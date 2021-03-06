﻿using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace B2CAzureFunc.Models
{
    /// <summary>
    /// AppSettings
    /// </summary>
    public class AppSettings
    {
        /// <summary>
        /// B2CTenant
        /// </summary>
        [JsonProperty("B2CTenant")]
        public string B2CTenant { get; set; }
        /// <summary>
        /// B2CSignUpPolicy
        /// </summary>
        [JsonProperty("B2CSignUpPolicy")]
        public string B2CSignUpPolicy { get; set; }
        /// <summary>
        /// B2CSignupConfirmPolicy
        /// </summary>
        [JsonProperty("B2CSignupConfirmPolicy")]
        public string B2CSignupConfirmPolicy { get; set; }
        /// <summary>
        /// B2CPasswordResetConfirmPolicy
        /// </summary>
        [JsonProperty("B2CPasswordResetConfirmPolicy")]
        public string B2CPasswordResetConfirmPolicy { get; set; }
        /// <summary>
        /// RelyingPartyAppClientId
        /// </summary>
        [JsonProperty("RelyingPartyAppClientId")]
        public Guid RelyingPartyAppClientId { get; set; }
        /// <summary>
        /// B2CRedirectUri
        /// </summary>
        [JsonProperty("B2CRedirectUri")]
        public Uri B2CRedirectUri { get; set; }
        /// <summary>
        /// B2CAuthorizationUrl
        /// </summary>
        [JsonProperty("B2CAuthorizationUrl")]
        public string B2CAuthorizationUrl { get; set; }
        /// <summary>
        /// ClientSigningKey
        /// </summary>
        [JsonProperty("ClientSigningKey")]
        public string ClientSigningKey { get; set; }
        /// <summary>
        /// LinkExpiresAfterMinutes
        /// </summary>
        [JsonProperty("LinkExpiresAfterMinutes")]
        public long LinkExpiresAfterMinutes { get; set; }
        /// <summary>
        /// SmtpServer
        /// </summary>
        [JsonProperty("SMTPServer")]
        public string SmtpServer { get; set; }
        /// <summary>
        /// SMTPPort
        /// </summary>
        [JsonProperty("SMTPPort")]
        public long SmtpPort { get; set; }
        /// <summary>
        /// SMTPUsername
        /// </summary>
        [JsonProperty("SMTPUsername")]
        public string SmtpUsername { get; set; }
        /// <summary>
        /// SmtpPassword
        /// </summary>
        [JsonProperty("SMTPPassword")]
        public string SmtpPassword { get; set; }
        /// <summary>
        /// SmtpUseSsl
        /// </summary>
        [JsonProperty("SMTPUseSSL")]
        public bool SmtpUseSsl { get; set; }
        /// <summary>
        /// SmtpFromAddress
        /// </summary>
        [JsonProperty("SMTPFromAddress")]
        public string SmtpFromAddress { get; set; }
        /// <summary>
        /// SmtpSubject
        /// </summary>
        [JsonProperty("SMTPSubject")]
        public string SmtpSubject { get; set; }
        /// <summary>
        /// SignupEmailSubject
        /// </summary>
        [JsonProperty("SignupEmailSubject")]
        public string SignupEmailSubject { get; set; }
        /// <summary>
        /// SignupConfirmationEmailSubject
        /// </summary>
        [JsonProperty("SignupConfirmationEmailSubject")]
        public string SignupConfirmationEmailSubject { get; set; }
        /// <summary>
        /// PasswordResetConfirmationEmailSubject
        /// </summary>
        [JsonProperty("PasswordResetConfirmationEmailSubject")]
        public string PasswordResetConfirmationEmailSubject { get; set; }
        /// <summary>
        /// AccountActivationEmailExpiryInSeconds
        /// </summary>
        [JsonProperty("AccountActivationEmailExpiryInSeconds")]
        public long AccountActivationEmailExpiryInSeconds { get; set; }
        /// <summary>
        /// NcsDssSearchApiUrl
        /// </summary>
        [JsonProperty("ncsdsssearchapiurl")]
        public Uri NcsDssSearchApiUrl { get; set; }
        /// <summary>
        /// NcsDssApiKey
        /// </summary>
        [JsonProperty("ncsdssapikey")]
        public string NcsDssApiKey { get; set; }
        /// <summary>
        /// OcpApimSubscriptionKey
        /// </summary>
        [JsonProperty("OcpApimSubscriptionKey")]
        public string OcpApimSubscriptionKey { get; set; }
        /// <summary>
        /// NcsDssSearchApiVersion
        /// </summary>
        [JsonProperty("ncsdsssearchapiversion")]
        public string NcsDssSearchApiVersion { get; set; }
        /// <summary>
        /// ResendSignupEmail
        /// </summary>
        [JsonProperty("resendSignupEmail")]
        public string ResendSignupEmail { get; set; }
        /// <summary>
        /// NcsDssCreateCustomerApiUrl
        /// </summary>
        [JsonProperty("ncsdsscreatecustomerapiurl")]
        public Uri NcsDssCreateCustomerApiUrl { get; set; }
        /// <summary>
        /// NcsDssCreateContactApiUrl
        /// </summary>
        [JsonProperty("ncsdsscreatecontactapiurl")]
        public string NcsDssCreateContactApiUrl { get; set; }
        /// <summary>
        /// NcsDssCreateIdentityApiUrl
        /// </summary>
        [JsonProperty("ncsdsscreateidentityapiurl")]
        public Uri NcsDssCreateIdentityApiUrl { get; set; }
        /// <summary>
        /// TouchpointId
        /// </summary>
        [JsonProperty("TouchpointId")]
        public long TouchpointId { get; set; }
        /// <summary>
        /// B2CTenant
        /// </summary>
        [JsonProperty("B2CTenantId")]
        public string B2CTenantId { get; set; }
        /// <summary>
        /// B2CGraphAccessClientId
        /// </summary>
        [JsonProperty("B2CGraphAccessClientId")]
        public Guid B2CGraphAccessClientId { get; set; }
        /// <summary>
        /// B2CGraphAccessClientSecret
        /// </summary>
        [JsonProperty("B2CGraphAccessClientSecret")]
        public string B2CGraphAccessClientSecret { get; set; }
        /// <summary>
        /// EmailChangeConfirmationEmailSubjectNewEmail
        /// </summary>
        [JsonProperty("EmailChangeConfirmationEmailSubjectNewEmail")]
        public string EmailChangeConfirmationEmailSubjectNewEmail { get; set; }
        /// <summary>
        /// EmailChangeConfirmationEmailSubjectOldEmail
        /// </summary>
        [JsonProperty("EmailChangeConfirmationEmailSubjectOldEmail")]
        public string EmailChangeConfirmationEmailSubjectOldEmail { get; set; }
        /// <summary>
        /// B2CChangeEmailPolicy
        /// </summary>
        [JsonProperty("B2CChangeEmailPolicy")]
        public string B2CChangeEmailPolicy { get; set; }
        /// <summary>
        /// ExtensionAppId
        /// </summary>
        [JsonProperty("ExtensionAppId")]
        public string ExtensionAppId { get; set; }
        /// <summary>
        /// FromDisplayName
        /// </summary>
        [JsonProperty("FromDisplayName")]
        public string FromDisplayName { get; set; }
        /// <summary>
        /// NotifyAPIKey
        /// </summary>
        [JsonProperty("NotifyAPIKey")]
        public string NotifyApiKey { get; set; }
        /// <summary>
        /// NotifyAidedSignupEmailTemplateId
        /// </summary>
        [JsonProperty("NotifyAidedSignupEmailTemplateId")]
        public string NotifyAidedSignupEmailTemplateId { get; set; }
        /// <summary>
        /// NotifySelfSignupEmailTemplateId
        /// </summary>
        [JsonProperty("NotifySelfSignupEmailTemplateId")]
        public string NotifySelfSignupEmailTemplateId { get; set; }
        /// <summary>
        /// NotifyPasswordResetConfirmationEmailTemplateId
        /// </summary>
        [JsonProperty("NotifyPasswordResetConfirmationEmailTemplateId")]
        public string NotifyPasswordResetConfirmationEmailTemplateId { get; set; }
        /// <summary>
        /// NotifyEmailChangeConfirmationEmailNewEmailTemplateId
        /// </summary>
        [JsonProperty("NotifyEmailChangeConfirmationEmailNewEmailTemplateId")]
        public string NotifyEmailChangeConfirmationEmailNewEmailTemplateId { get; set; }
        /// <summary>
        /// NotifyEmailChangeConfirmationEmailOldEmailTemplateId
        /// </summary>
        [JsonProperty("NotifyEmailChangeConfirmationEmailOldEmailTemplateId")]
        public string NotifyEmailChangeConfirmationEmailOldEmailTemplateId { get; set; }
        /// <summary>
        /// ncsdssgetcustomerapiurl
        /// </summary>
        [JsonProperty("ncsdssgetcustomerapiurl")]
        public string NcsDssGetCustomerApiUrl { get; set; }
        /// <summary>
        /// ncsdsspatchdigitalidentityapiurl
        /// </summary>
        [JsonProperty("ncsdsspatchdigitalidentityapiurl")]
        public string NcsDssPatchDigitalidentityApiUrl { get; set; }
        /// <summary>
        /// TncFileName
        /// </summary>
        [JsonProperty("TncFileName")]
        public string TncFileName { get; set; }
        /// <summary>
        /// TncContainerName
        /// </summary>
        [JsonProperty("TncContainerName")]
        public string TncContainerName { get; set; }
        /// <summary>
        /// StorageAccountConnectionString
        /// </summary>
        [JsonProperty("StorageAccountConnectionString")]
        public string StorageAccountConnectionString { get; set; }
    }
}