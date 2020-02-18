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

    public partial class GetPrivatePersonsOKResponsePrivatePersonsItem
    {
        /// <summary>
        /// Initializes a new instance of the
        /// GetPrivatePersonsOKResponsePrivatePersonsItem class.
        /// </summary>
        public GetPrivatePersonsOKResponsePrivatePersonsItem() { }

        /// <summary>
        /// Initializes a new instance of the
        /// GetPrivatePersonsOKResponsePrivatePersonsItem class.
        /// </summary>
        public GetPrivatePersonsOKResponsePrivatePersonsItem(int? recno = default(int?), string firstName = default(string), string middleName = default(string), string lastName = default(string), string personalIdNumber = default(string), string externalID = default(string), string phoneNumber = default(string), string mobilePhone = default(string), string email = default(string), GetPrivatePersonsOKResponsePrivatePersonsItemPrivateAddress privateAddress = default(GetPrivatePersonsOKResponsePrivatePersonsItemPrivateAddress), GetPrivatePersonsOKResponsePrivatePersonsItemPostAddress postAddress = default(GetPrivatePersonsOKResponsePrivatePersonsItemPostAddress), GetPrivatePersonsOKResponsePrivatePersonsItemWorkAddress workAddress = default(GetPrivatePersonsOKResponsePrivatePersonsItemWorkAddress), string gender = default(string), IList<string> categories = default(IList<string>), string customNo1 = default(string), string customNo2 = default(string), string customNo3 = default(string), bool? active = default(bool?), DateTime? createdDate = default(DateTime?), DateTime? modifiedDate = default(DateTime?), string title = default(string), string accessGroup = default(string), object additionalFields = default(object), string alternativeEmail = default(string))
        {
            Recno = recno;
            FirstName = firstName;
            MiddleName = middleName;
            LastName = lastName;
            PersonalIdNumber = personalIdNumber;
            ExternalID = externalID;
            PhoneNumber = phoneNumber;
            MobilePhone = mobilePhone;
            Email = email;
            PrivateAddress = privateAddress;
            PostAddress = postAddress;
            WorkAddress = workAddress;
            Gender = gender;
            Categories = categories;
            CustomNo1 = customNo1;
            CustomNo2 = customNo2;
            CustomNo3 = customNo3;
            Active = active;
            CreatedDate = createdDate;
            ModifiedDate = modifiedDate;
            Title = title;
            AccessGroup = accessGroup;
            AdditionalFields = additionalFields;
            AlternativeEmail = alternativeEmail;
        }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "Recno")]
        public int? Recno { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "FirstName")]
        public string FirstName { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "MiddleName")]
        public string MiddleName { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "LastName")]
        public string LastName { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "PersonalIdNumber")]
        public string PersonalIdNumber { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "ExternalID")]
        public string ExternalID { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "PhoneNumber")]
        public string PhoneNumber { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "MobilePhone")]
        public string MobilePhone { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "Email")]
        public string Email { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "PrivateAddress")]
        public GetPrivatePersonsOKResponsePrivatePersonsItemPrivateAddress PrivateAddress { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "PostAddress")]
        public GetPrivatePersonsOKResponsePrivatePersonsItemPostAddress PostAddress { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "WorkAddress")]
        public GetPrivatePersonsOKResponsePrivatePersonsItemWorkAddress WorkAddress { get; set; }

        /// <summary>
        /// Possible values include: 'Female', 'Male'
        /// </summary>
        [JsonProperty(PropertyName = "Gender")]
        public string Gender { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "Categories")]
        public IList<string> Categories { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "CustomNo1")]
        public string CustomNo1 { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "CustomNo2")]
        public string CustomNo2 { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "CustomNo3")]
        public string CustomNo3 { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "Active")]
        public bool? Active { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "CreatedDate")]
        public DateTime? CreatedDate { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "ModifiedDate")]
        public DateTime? ModifiedDate { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "Title")]
        public string Title { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "AccessGroup")]
        public string AccessGroup { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "AdditionalFields")]
        public object AdditionalFields { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "AlternativeEmail")]
        public string AlternativeEmail { get; set; }

    }
}