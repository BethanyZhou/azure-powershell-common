// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Graph.RBAC.Version1_6_20190326.Models
{
    using Newtonsoft.Json;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;

    /// <summary>
    /// Active Directory service principal common properties shared among GET,
    /// POST and PATCH
    /// </summary>
    public partial class ServicePrincipalBase
    {
        /// <summary>
        /// Initializes a new instance of the ServicePrincipalBase class.
        /// </summary>
        public ServicePrincipalBase()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the ServicePrincipalBase class.
        /// </summary>
        /// <param name="accountEnabled">whether or not the service principal
        /// account is enabled</param>
        /// <param name="appRoleAssignmentRequired">Specifies whether an
        /// AppRoleAssignment to a user or group is required before Azure AD
        /// will issue a user or access token to the application.</param>
        /// <param name="keyCredentials">The collection of key credentials
        /// associated with the service principal.</param>
        /// <param name="passwordCredentials">The collection of password
        /// credentials associated with the service principal.</param>
        /// <param name="servicePrincipalType">the type of the service
        /// principal</param>
        /// <param name="tags">Optional list of tags that you can apply to your
        /// service principals. Not nullable.</param>
        public ServicePrincipalBase(string accountEnabled = default(string), bool? appRoleAssignmentRequired = default(bool?), IList<KeyCredential> keyCredentials = default(IList<KeyCredential>), IList<PasswordCredential> passwordCredentials = default(IList<PasswordCredential>), string servicePrincipalType = default(string), IList<string> tags = default(IList<string>))
        {
            AccountEnabled = accountEnabled;
            AppRoleAssignmentRequired = appRoleAssignmentRequired;
            KeyCredentials = keyCredentials;
            PasswordCredentials = passwordCredentials;
            ServicePrincipalType = servicePrincipalType;
            Tags = tags;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets whether or not the service principal account is
        /// enabled
        /// </summary>
        [JsonProperty(PropertyName = "accountEnabled")]
        public string AccountEnabled { get; set; }

        /// <summary>
        /// Gets or sets specifies whether an AppRoleAssignment to a user or
        /// group is required before Azure AD will issue a user or access token
        /// to the application.
        /// </summary>
        [JsonProperty(PropertyName = "appRoleAssignmentRequired")]
        public bool? AppRoleAssignmentRequired { get; set; }

        /// <summary>
        /// Gets or sets the collection of key credentials associated with the
        /// service principal.
        /// </summary>
        [JsonProperty(PropertyName = "keyCredentials")]
        public IList<KeyCredential> KeyCredentials { get; set; }

        /// <summary>
        /// Gets or sets the collection of password credentials associated with
        /// the service principal.
        /// </summary>
        [JsonProperty(PropertyName = "passwordCredentials")]
        public IList<PasswordCredential> PasswordCredentials { get; set; }

        /// <summary>
        /// Gets or sets the type of the service principal
        /// </summary>
        [JsonProperty(PropertyName = "servicePrincipalType")]
        public string ServicePrincipalType { get; set; }

        /// <summary>
        /// Gets or sets optional list of tags that you can apply to your
        /// service principals. Not nullable.
        /// </summary>
        [JsonProperty(PropertyName = "tags")]
        public IList<string> Tags { get; set; }

    }
}
