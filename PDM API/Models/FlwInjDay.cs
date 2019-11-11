using System;
using Newtonsoft.Json;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace PDM_API.Models
{
    [Table("FLW_INJ_DAY", Schema = "PDM")]
    public class FlwInjDay
    {
        [JsonProperty("PROD_MONTH")]
        public DateTime? PROD_MONTH { get; set; }
        [JsonProperty("PROD_DAY")]
        public DateTime? PROD_DAY { get; set; }
        [JsonProperty("COUNTRY")]
        public string COUNTRY { get; set; }
        [JsonProperty("BA_CODE")]
        public string BA_CODE { get; set; }
        [JsonProperty("RA_CODE")]
        public string RA_CODE { get; set; }
        [JsonProperty("RU_CODE")]
        public string RU_CODE { get; set; }
        [JsonProperty("FCTY_CODE")]
        public string FCTY_CODE { get; set; }
        [JsonProperty("GOV_FCTY_CODE")]
        public string GOV_FCTY_CODE { get; set; }
        [JsonProperty("GOV_FCTY_NAME")]
        public string GOV_FCTY_NAME { get; set; }
        [JsonProperty("GOV_FIELD_CODE")]
        public string GOV_FIELD_CODE { get; set; }
        [JsonProperty("GOV_FIELD_NAME")]
        public string GOV_FIELD_NAME { get; set; }
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
        [JsonProperty("CALC_GI_METHOD")]
        public string CALC_GI_METHOD { get; set; }
        [JsonProperty("CALC_WI_METHOD")]
        public string CALC_WI_METHOD { get; set; }
        [JsonProperty("ON_STREAM_HRS")]
        public double? ON_STREAM_HRS { get; set; }
        [JsonProperty("CHOKE_CODE")]
        public string CHOKE_CODE { get; set; }
        [JsonProperty("CHOKE_OPENING")]
        public double? CHOKE_OPENING { get; set; }
        [JsonProperty("CHOKE_UOM")]
        public string CHOKE_UOM { get; set; }
        [JsonProperty("CHOKE_MM")]
        public double? CHOKE_MM { get; set; }
        [JsonProperty("FLWL_PRESS_BARG")]
        public double? FLWL_PRESS_BARG { get; set; }
        [JsonProperty("FLWL_TEMP_C")]
        public double? FLWL_TEMP_C { get; set; }
        [JsonProperty("FLWL_DSC_PRESS")]
        public double? FLWL_DSC_PRESS { get; set; }
        [JsonProperty("FLWL_DSC_TEMP")]
        public double? FLWL_DSC_TEMP { get; set; }
        [JsonProperty("SS_PRESS_BARG")]
        public double? SS_PRESS_BARG { get; set; }
        [JsonProperty("SS_TEMP_C")]
        public double? SS_TEMP_C { get; set; }
        [JsonProperty("GAS_INJ_VOL_SM3")]
        public double? GAS_INJ_VOL_SM3 { get; set; }
        [JsonProperty("WATER_INJ_VOL_M3")]
        public double? WATER_INJ_VOL_M3 { get; set; }
        [JsonProperty("THEOR_WATER_INJ_VOL_M3")]
        public double? THEOR_WATER_INJ_VOL_M3 { get; set; }
        [JsonProperty("WELLS_ON_FLOWLINE")]
        public string WELLS_ON_FLOWLINE { get; set; }
        [JsonProperty("COMMENTS")]
        public string COMMENTS { get; set; }
        [JsonProperty("FACILITY_LAT")]
        public double? FACILITY_LAT { get; set; }
        [JsonProperty("FACILITY_LON")]
        public double? FACILITY_LON { get; set; }
        [JsonProperty("FLW_START_DATE")]
        public DateTime? FLW_START_DATE { get; set; }
        [JsonProperty("FLW_END_DATE")]
        public DateTime? FLW_END_DATE { get; set; }
        [JsonProperty("LAST_CHANGED")]
        public DateTime? LAST_CHANGED { get; set; }
        [JsonProperty("DBSOURCE")]
        public string DBSOURCE { get; set; }
        [JsonProperty("DBSOURCE_ID")]
        public string DBSOURCE_ID { get; set; }
    }
}