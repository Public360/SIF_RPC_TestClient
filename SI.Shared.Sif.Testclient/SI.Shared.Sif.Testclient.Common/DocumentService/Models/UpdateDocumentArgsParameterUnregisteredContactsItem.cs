﻿// Code generated by Microsoft (R) AutoRest Code Generator 0.16.0.0
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.

namespace SI.Shared.Sif.Testclient.Common.Models
{
    using System;
    using System.Linq;
    using System.Collections.Generic;
    using Newtonsoft.Json;
    using Microsoft.Rest;
    using Microsoft.Rest.Serialization;

    public partial class UpdateDocumentArgsParameterUnregisteredContactsItem
    {
        /// <summary>
        /// Initializes a new instance of the
        /// UpdateDocumentArgsParameterUnregisteredContactsItem class.
        /// </summary>
        public UpdateDocumentArgsParameterUnregisteredContactsItem() { }

        /// <summary>
        /// Initializes a new instance of the
        /// UpdateDocumentArgsParameterUnregisteredContactsItem class.
        /// </summary>
        public UpdateDocumentArgsParameterUnregisteredContactsItem(string role = default(string), bool? isUnofficial = default(bool?), string contactName = default(string), string contactCompanyName = default(string), string referenceNumber = default(string), string address = default(string), string country = default(string), string mobilePhone = default(string), string phone = default(string), string fax = default(string), string email = default(string), string state = default(string), string zipCode = default(string), string zipPlace = default(string), string dispatchChannel = default(string))
        {
            Role = role;
            IsUnofficial = isUnofficial;
            ContactName = contactName;
            ContactCompanyName = contactCompanyName;
            ReferenceNumber = referenceNumber;
            Address = address;
            Country = country;
            MobilePhone = mobilePhone;
            Phone = phone;
            Fax = fax;
            Email = email;
            State = state;
            ZipCode = zipCode;
            ZipPlace = zipPlace;
            DispatchChannel = dispatchChannel;
        }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "Role")]
        public string Role { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "IsUnofficial")]
        public bool? IsUnofficial { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "ContactName")]
        public string ContactName { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "ContactCompanyName")]
        public string ContactCompanyName { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "ReferenceNumber")]
        public string ReferenceNumber { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "Address")]
        public string Address { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "Country")]
        public string Country { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "MobilePhone")]
        public string MobilePhone { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "Phone")]
        public string Phone { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "Fax")]
        public string Fax { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "Email")]
        public string Email { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "State")]
        public string State { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "ZipCode")]
        public string ZipCode { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "ZipPlace")]
        public string ZipPlace { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "DispatchChannel")]
        public string DispatchChannel { get; set; }

    }
}