using System;
using Newtonsoft.Json;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace PDM_API.Models
{
    [Table("WELLBORE_MASTER", Schema = "PDM")]
    public class WellBoreMaster
    {
        [JsonProperty("WB_GUID")]
        public double? WB_GUID { get; set; }
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
        [JsonProperty("PLAN_ENTITY")]
        public string PLAN_ENTITY { get; set; }
        [JsonProperty("GOV_FIELD_CODE")]
        public string GOV_FIELD_CODE { get; set; }
        [JsonProperty("GOV_FIELD_NAME")]
        public string GOV_FIELD_NAME { get; set; }
        [JsonProperty("GOV_FCTY_CODE")]
        public string GOV_FCTY_CODE { get; set; }
        [JsonProperty("GOV_FCTY_NAME")]
        public string GOV_FCTY_NAME { get; set; }
        [JsonProperty("WELL_OFFICIAL_NAME")]
        public string WELL_OFFICIAL_NAME { get; set; }
        [JsonProperty("WELL_UWI")]
        public string WELL_UWI { get; set; }
        [JsonProperty("WB_NAME")]
        public string WB_NAME { get; set; }
        [JsonProperty("WB_CODE")]
        public string WB_CODE { get; set; }
        [JsonProperty("WB_UWBI")]
        public string WB_UWBI { get; set; }
        [JsonProperty("GOV_WB_NAME")]
        public string GOV_WB_NAME { get; set; }
        [JsonProperty("GOV_WB_CODE")]
        public string GOV_WB_CODE { get; set; }
        [JsonProperty("GOVERN_AREA_ID")]
        public string GOVERN_AREA_ID { get; set; }
        [JsonProperty("DRILLING_FACILITY_ID")]
        public string DRILLING_FACILITY_ID { get; set; }
        [JsonProperty("PURPOSE")]
        public string PURPOSE { get; set; }
        [JsonProperty("STATUS")]
        public string STATUS { get; set; }
        [JsonProperty("CONTENT")]
        public string CONTENT { get; set; }
        [JsonProperty("DRILL_START_DATE")]
        public string DRILL_START_DATE { get; set; }
        [JsonProperty("DRILL_END_DATE")]
        public string DRILL_END_DATE { get; set; }
        [JsonProperty("PARENT_WELLBORE")]
        public string PARENT_WELLBORE { get; set; }
        [JsonProperty("OPERATOR")]
        public string OPERATOR { get; set; }
        [JsonProperty("WB_START_DATE")]
        public DateTime? WB_START_DATE { get; set; }
        [JsonProperty("WB_END_DATE")]
        public DateTime? WB_END_DATE { get; set; }
        [JsonProperty("WB_V_START_DATE")]
        public DateTime? WB_V_START_DATE { get; set; }
        [JsonProperty("WB_V_END_DATE")]
        public DateTime? WB_V_END_DATE { get; set; }
        [JsonProperty("LAST_CHANGED")]
        public DateTime? LAST_CHANGED { get; set; }
        [JsonProperty("DBSOURCE")]
        public string DBSOURCE { get; set; }
        [JsonProperty("DBSOURCE_ID")]
        public string DBSOURCE_ID { get; set; }
    }
}