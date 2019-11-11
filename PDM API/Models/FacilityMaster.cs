using System;
using Newtonsoft.Json;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace PDM_API.Models
{
    [Table("FACILITY_MASTER", Schema = "PDM")]
    public class FacilityMaster
    {
        [JsonProperty("FCTY_GUID")]
        public double? FCTY_GUID { get; set; }
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
        [JsonProperty("FCTY_ID_EC")]
        public string FCTY_ID_EC { get; set; }
        [JsonProperty("FCTY_CODE")]
        public string FCTY_CODE { get; set; }
        [JsonProperty("FCTY_NAME")]
        public string FCTY_NAME { get; set; }
        [JsonProperty("GOV_FCTY_CODE")]
        public string GOV_FCTY_CODE { get; set; }
        [JsonProperty("GOV_FCTY_NAME")]
        public string GOV_FCTY_NAME { get; set; }
        [JsonProperty("FCTY_TYPE")]
        public string FCTY_TYPE { get; set; }
        [JsonProperty("OPERATOR")]
        public string OPERATOR { get; set; }
        [JsonProperty("SMDA_FCTY_NAME")]
        public string SMDA_FCTY_NAME { get; set; }
        [JsonProperty("SMDA_FCTY_TYPE")]
        public string SMDA_FCTY_TYPE { get; set; }
        [JsonProperty("SAP_PLANT_ID")]
        public string SAP_PLANT_ID { get; set; }
        [JsonProperty("STID_CODE")]
        public string STID_CODE { get; set; }
        [JsonProperty("BLOCK")]
        public string BLOCK { get; set; }
        [JsonProperty("TOTAL_BEDS")]
        public double? TOTAL_BEDS { get; set; }
        [JsonProperty("XY_SYSTEM")]
        public string XY_SYSTEM { get; set; }
        [JsonProperty("FACILITY_LAT")]
        public double? FACILITY_LAT { get; set; }
        [JsonProperty("FACILITY_LON")]
        public double? FACILITY_LON { get; set; }
        [JsonProperty("FCTY_START_DATE")]
        public DateTime? FCTY_START_DATE { get; set; }
        [JsonProperty("FCTY_END_DATE")]
        public DateTime? FCTY_END_DATE { get; set; }
        [JsonProperty("FCTY_V_START_DATE")]
        public DateTime? FCTY_V_START_DATE { get; set; }
        [JsonProperty("FCTY_V_END_DATE")]
        public DateTime? FCTY_V_END_DATE { get; set; }
        [JsonProperty("DESCRIPTION")]
        public string DESCRIPTION { get; set; }
        [JsonProperty("LAST_CHANGED")]
        public DateTime? LAST_CHANGED { get; set; }
        [JsonProperty("DBSOURCE")]
        public string DBSOURCE { get; set; }
        [JsonProperty("DBSOURCE_ID")]
        public string DBSOURCE_ID { get; set; }
    }
}