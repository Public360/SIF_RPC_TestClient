using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace SI.Shared.Sif.Testclient.Common.Entities
{
    [JsonObject("DocumentInfo")]
    public class DocumentInfo
    {
        [JsonProperty("File_Path")]
        public string File_Path { get; set; }

        [JsonProperty("File_Title")]
        public string File_Title { get; set; }

        [JsonProperty("File_Format")]
        public string File_Format { get; set; }

        [JsonProperty("CaseNumber")]
        public string CaseNumber { get; set; }

        [JsonProperty("Title")]
        public string Title { get; set; }

        [JsonProperty("UnofficialTitle")]
        public string UnofficialTitle { get; set; }

        private DateTime documentDate;
        private DateTime journalDate;
        private DateTime dispatchedDate;

        [JsonProperty("DocumentDate")]
        public DateTime DocumentDate 
        { 
            get 
            {
                return documentDate;
            }
            set 
            { 
                documentDate = DateTimeHelper.ConvertToSafeDate(value);
            } 
        }

        [JsonProperty("JournalDate")]
        public DateTime JournalDate
        {
            get
            {
                return journalDate;
            }
            set
            {
                journalDate = DateTimeHelper.ConvertToSafeDate(value);
            }
        }

        [JsonProperty("DispatchedDate")]
        public DateTime DispatchedDate
        {
            get
            {
                return dispatchedDate;
            }
            set
            {
                dispatchedDate = DateTimeHelper.ConvertToSafeDate(value);
            }
        }

        [JsonProperty("Category")]
        public string Category { get; set; }

        [JsonProperty("Status")]
        public string Status { get; set; }

        [JsonProperty("StreamFile")]
        public bool StreamFile { get; set; }

        [JsonProperty("CreateCase")]
        public bool CreateCase { get; set; }

        [JsonProperty("AdContextUser")]
        public string AdContextUser { get; set; }
        
        [JsonProperty("User")]
        public string User { get; set; }

        [JsonProperty("TemplateId")]
        public string TemplateId { get; set; }

        [JsonProperty("TemplateTitle")]
        public string TemplateTitle { get; set; }

        public static DocumentInfo CreateSample()
        {
            return new DocumentInfo()
            {
                File_Path = @"C:\Users\360admin\Downloads\testfil.pdf",
                File_Title = "Test",
                File_Format = "PDF",
                CaseNumber = "20/00001",
                Title = "testTieto",
                UnofficialTitle = "testTieto",
                DocumentDate = DateTime.Now,
                JournalDate = DateTime.Now,
                DispatchedDate = DateTime.Now,
                Category = "110",
                Status = "Reg",
            };
        }
    }
}
