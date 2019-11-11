using System;
using Newtonsoft.Json;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace PDM_API.Models
{
    [Table("FLOWLINE_MASTER", Schema = "PDM")]
    public class FlowlineMaster
    {
        [JsonProperty("FLOWLINE_ID")]
        public double? FLOWLINE_ID { get; set; }
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
        [JsonProperty("FCTY_CODE")]
        public string FCTY_CODE { get; set; }
        [JsonProperty("GOV_FCTY_CODE")]
        public string GOV_FCTY_CODE { get; set; }
        [JsonProperty("GOV_FCTY_NAME")]
        public string GOV_FCTY_NAME { get; set; }
        [JsonProperty("FLW_ID_EC")]
        public string FLW_ID_EC { get; set; }
        [JsonProperty("FLW_NAME")]
        public string FLW_NAME { get; set; }
        [JsonProperty("FLW_CODE")]
        public string FLW_CODE { get; set; }
        [JsonProperty("FLW_TYPE")]
        public string FLW_TYPE { get; set; }
        [JsonProperty("FLW_SIZE_M")]
        public double? FLW_SIZE_M { get; set; }
        [JsonProperty("SS_TEMPLATE")]
        public string SS_TEMPLATE { get; set; }
        [JsonProperty("TM")]
        public string TM { get; set; }
        [JsonProperty("PM1")]
        public string PM1 { get; set; }
        [JsonProperty("PM2")]
        public string PM2 { get; set; }
        [JsonProperty("CALC_OIL_METHOD")]
        public string CALC_OIL_METHOD { get; set; }
        [JsonProperty("CALC_COND_METHOD")]
        public string CALC_COND_METHOD { get; set; }
        [JsonProperty("CALC_GAS_METHOD")]
        public string CALC_GAS_METHOD { get; set; }
        [JsonProperty("CALC_WATER_METHOD")]
        public string CALC_WATER_METHOD { get; set; }
        [JsonProperty("CALC_GAS_LIFT_MTD")]
        public string CALC_GAS_LIFT_MTD { get; set; }
        [JsonProperty("CHOKE_CODE")]
        public string CHOKE_CODE { get; set; }
        [JsonProperty("FLW_START_DATE")]
        public DateTime? FLW_START_DATE { get; set; }
        [JsonProperty("FLW_END_DATE")]
        public DateTime? FLW_END_DATE { get; set; }
        [JsonProperty("FLW_V_START_DATE")]
        public DateTime? FLW_V_START_DATE { get; set; }
        [JsonProperty("FLW_V_END_DATE")]
        public DateTime? FLW_V_END_DATE { get; set; }
        [JsonProperty("FACILITY_LAT")]
        public double? FACILITY_LAT { get; set; }
        [JsonProperty("FACILITY_LON")]
        public double? FACILITY_LON { get; set; }
        [JsonProperty("LAST_CHANGED")]
        public DateTime? LAST_CHANGED { get; set; }
        [JsonProperty("DBSOURCE")]
        public string DBSOURCE { get; set; }
        [JsonProperty("DBSOURCE_ID")]
        public string DBSOURCE_ID { get; set; }
    }
}