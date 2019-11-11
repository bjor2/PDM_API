using System;
using Newtonsoft.Json;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace PDM_API.Models
{
    [Table("FIELD_MASTER", Schema = "PDM")]
    public class FieldMaster
    {
        [JsonProperty("FIELD_GUID")]
        public double? FIELD_GUID { get; set; }
        [JsonProperty("COUNTRY")]
        public string COUNTRY { get; set; }
        [JsonProperty("COUNTRY_NAME")]
        public string COUNTRY_NAME { get; set; }
        [JsonProperty("BA_CODE")]
        public string BA_CODE { get; set; }
        [JsonProperty("RA_CODE")]
        public string RA_CODE { get; set; }
        [JsonProperty("BU_CODE")]
        public string BU_CODE { get; set; }
        [JsonProperty("PC_CODE")]
        public string PC_CODE { get; set; }
        [JsonProperty("FIELD_ID_EC")]
        public string FIELD_ID_EC { get; set; }
        [JsonProperty("FIELD_CODE")]
        public string FIELD_CODE { get; set; }
        [JsonProperty("FIELD_NAME")]
        public string FIELD_NAME { get; set; }
        [JsonProperty("OFM_FIELD_NAME")]
        public string OFM_FIELD_NAME { get; set; }
        [JsonProperty("GOV_FIELD_CODE")]
        public string GOV_FIELD_CODE { get; set; }
        [JsonProperty("GOV_FIELD_NAME")]
        public string GOV_FIELD_NAME { get; set; }
        [JsonProperty("SMDA_FIELD_CODE")]
        public string SMDA_FIELD_CODE { get; set; }
        [JsonProperty("SMDA_FIELD_NAME")]
        public string SMDA_FIELD_NAME { get; set; }
        [JsonProperty("CURRENT_STATUS")]
        public string CURRENT_STATUS { get; set; }
        [JsonProperty("CURRENT_OPERATOR")]
        public string CURRENT_OPERATOR { get; set; }
        [JsonProperty("CURRENT_RESP_ORG")]
        public string CURRENT_RESP_ORG { get; set; }
        [JsonProperty("OWNER_IDENTIFIER")]
        public string OWNER_IDENTIFIER { get; set; }
        [JsonProperty("OWNERS_TYPE")]
        public string OWNERS_TYPE { get; set; }
        [JsonProperty("PARENT")]
        public string PARENT_FIELD { get; set; }
        [JsonProperty("PARTNER_STATUS")]
        public string PARTNER_STATUS { get; set; }
        [JsonProperty("MAIN_HYDROCARBON_TYPE")]
        public string MAIN_HYDROCARBON_TYPE { get; set; }
        [JsonProperty("FIELD_START_DATE")]
        public DateTime? FIELD_START_DATE { get; set; }
        [JsonProperty("FIELD_END_DATE")]
        public DateTime? FIELD_END_DATE { get; set; }
        [JsonProperty("FIELD_V_START_DATE")]
        public DateTime? FIELD_V_START_DATE { get; set; }
        [JsonProperty("FIELD_V_END_DATE")]
        public DateTime? FIELD_V_END_DATE { get; set; }
        [JsonProperty("LAST_CHANGED")]
        public DateTime? LAST_CHANGED { get; set; }
        [JsonProperty("DBSOURCE")]
        public string DBSOURCE { get; set; }
        [JsonProperty("DBSOURCE_ID")]
        public string DBSOURCE_ID { get; set; }
    }
}