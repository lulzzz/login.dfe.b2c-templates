﻿using Microsoft.IdentityModel.Clients.ActiveDirectory;
using System;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace B2CAzureFunc.Helpers
{
    /// <summary>
    /// B2C Graph Client
    /// </summary>
    public class B2CGraphClient
    {
        private string clientId { get; set; }
        private string clientSecret { get; set; }
        private string tenant { get; set; }

        private AuthenticationContext authContext;
        private ClientCredential credential;

        public B2CGraphClient(string clientId, string clientSecret, string tenant)
        {
            this.clientId = clientId;
            this.clientSecret = clientSecret;
            this.tenant = tenant;

            this.authContext = new AuthenticationContext("https://login.microsoftonline.com/" + tenant);
            this.credential = new ClientCredential(clientId, clientSecret);
        }

        public async Task<string> GetAllUsersAsync(string query)
        {
            return await SendGraphGetRequest("/users", query);
        }

        public async Task<bool> UpdateUser(string objectId, string json)
        {
            return await SendGraphPatchRequest("/users/" + objectId, json);
        }

        public async Task<string> SendGraphGetRequest(string api, string query)
        {
            AuthenticationResult result = await authContext.AcquireTokenAsync("https://graph.windows.net", credential);

            // For B2C user managment, be sure to use the 1.6 Graph API version.
            HttpClient http = new HttpClient();
            string url = "https://graph.windows.net/" + tenant + api + "?" + Globals.aadGraphVersion;
            if (!string.IsNullOrEmpty(query))
            {
                url += "&" + query;
            }

            // Append the access token for the Graph API to the Authorization header of the request, using the Bearer scheme.
            HttpRequestMessage request = new HttpRequestMessage(HttpMethod.Get, url);
            request.Headers.Authorization = new AuthenticationHeaderValue("Bearer", result.AccessToken);
            HttpResponseMessage response = await http.SendAsync(request);

            if (!response.IsSuccessStatusCode)
            {
                return null;
            }
            var result1 = await response.Content.ReadAsStringAsync();
            return result1;
        }

        private async Task<bool> SendGraphPatchRequest(string api, string json)
        {
            // NOTE: This client uses ADAL v2, not ADAL v4
            AuthenticationResult result = await authContext.AcquireTokenAsync(Globals.aadGraphResourceId, credential);
            HttpClient http = new HttpClient();
            string url = Globals.aadGraphEndpoint + tenant + api + "?" + Globals.aadGraphVersion;

            HttpRequestMessage request = new HttpRequestMessage(new HttpMethod("PATCH"), url);
            request.Headers.Authorization = new AuthenticationHeaderValue("Bearer", result.AccessToken);
            request.Content = new StringContent(json, Encoding.UTF8, "application/json");
            HttpResponseMessage response = await http.SendAsync(request);

            if (!response.IsSuccessStatusCode)
            {
                throw new Exception(await response.Content.ReadAsStringAsync() + response.ReasonPhrase);
            }
            return response.IsSuccessStatusCode;
        }
    }
}