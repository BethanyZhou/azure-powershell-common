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
    /// Active Directory user information.
    /// </summary>
    public partial class User : DirectoryObject
    {
        /// <summary>
        /// Initializes a new instance of the User class.
        /// </summary>
        public User()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the User class.
        /// </summary>
        /// <param name="additionalProperties">Unmatched properties from the
        /// message are deserialized this collection</param>
        /// <param name="objectId">The object ID.</param>
        /// <param name="deletionTimestamp">The time at which the directory
        /// object was deleted.</param>
        /// <param name="immutableId">This must be specified if you are using a
        /// federated domain for the user's userPrincipalName (UPN) property
        /// when creating a new user account. It is used to associate an
        /// on-premises Active Directory user account with their Azure AD user
        /// object.</param>
        /// <param name="usageLocation">A two letter country code (ISO standard
        /// 3166). Required for users that will be assigned licenses due to
        /// legal requirement to check for availability of services in
        /// countries. Examples include: "US", "JP", and "GB".</param>
        /// <param name="givenName">The given name for the user.</param>
        /// <param name="surname">The user's surname (family name or last
        /// name).</param>
        /// <param name="userType">A string value that can be used to classify
        /// user types in your directory, such as 'Member' and 'Guest'.
        /// Possible values include: 'Member', 'Guest'</param>
        /// <param name="accountEnabled">Whether the account is
        /// enabled.</param>
        /// <param name="displayName">The display name of the user.</param>
        /// <param name="userPrincipalName">The principal name of the
        /// user.</param>
        /// <param name="mailNickname">The mail alias for the user.</param>
        /// <param name="mail">The primary email address of the user.</param>
        /// <param name="signInNames">The sign-in names of the user.</param>
        public User(IDictionary<string, object> additionalProperties = default(IDictionary<string, object>), string objectId = default(string), System.DateTime? deletionTimestamp = default(System.DateTime?), string immutableId = default(string), string usageLocation = default(string), string givenName = default(string), string surname = default(string), string userType = default(string), bool? accountEnabled = default(bool?), string displayName = default(string), string userPrincipalName = default(string), string mailNickname = default(string), string mail = default(string), IList<SignInName> signInNames = default(IList<SignInName>))
            : base(additionalProperties, objectId, deletionTimestamp)
        {
            ImmutableId = immutableId;
            UsageLocation = usageLocation;
            GivenName = givenName;
            Surname = surname;
            UserType = userType;
            AccountEnabled = accountEnabled;
            DisplayName = displayName;
            UserPrincipalName = userPrincipalName;
            MailNickname = mailNickname;
            Mail = mail;
            SignInNames = signInNames;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets this must be specified if you are using a federated
        /// domain for the user's userPrincipalName (UPN) property when
        /// creating a new user account. It is used to associate an on-premises
        /// Active Directory user account with their Azure AD user object.
        /// </summary>
        [JsonProperty(PropertyName = "immutableId")]
        public string ImmutableId { get; set; }

        /// <summary>
        /// Gets or sets a two letter country code (ISO standard 3166).
        /// Required for users that will be assigned licenses due to legal
        /// requirement to check for availability of services in countries.
        /// Examples include: "US", "JP", and "GB".
        /// </summary>
        [JsonProperty(PropertyName = "usageLocation")]
        public string UsageLocation { get; set; }

        /// <summary>
        /// Gets or sets the given name for the user.
        /// </summary>
        [JsonProperty(PropertyName = "givenName")]
        public string GivenName { get; set; }

        /// <summary>
        /// Gets or sets the user's surname (family name or last name).
        /// </summary>
        [JsonProperty(PropertyName = "surname")]
        public string Surname { get; set; }

        /// <summary>
        /// Gets or sets a string value that can be used to classify user types
        /// in your directory, such as 'Member' and 'Guest'. Possible values
        /// include: 'Member', 'Guest'
        /// </summary>
        [JsonProperty(PropertyName = "userType")]
        public string UserType { get; set; }

        /// <summary>
        /// Gets or sets whether the account is enabled.
        /// </summary>
        [JsonProperty(PropertyName = "accountEnabled")]
        public bool? AccountEnabled { get; set; }

        /// <summary>
        /// Gets or sets the display name of the user.
        /// </summary>
        [JsonProperty(PropertyName = "displayName")]
        public string DisplayName { get; set; }

        /// <summary>
        /// Gets or sets the principal name of the user.
        /// </summary>
        [JsonProperty(PropertyName = "userPrincipalName")]
        public string UserPrincipalName { get; set; }

        /// <summary>
        /// Gets or sets the mail alias for the user.
        /// </summary>
        [JsonProperty(PropertyName = "mailNickname")]
        public string MailNickname { get; set; }

        /// <summary>
        /// Gets or sets the primary email address of the user.
        /// </summary>
        [JsonProperty(PropertyName = "mail")]
        public string Mail { get; set; }

        /// <summary>
        /// Gets or sets the sign-in names of the user.
        /// </summary>
        [JsonProperty(PropertyName = "signInNames")]
        public IList<SignInName> SignInNames { get; set; }

    }
}
