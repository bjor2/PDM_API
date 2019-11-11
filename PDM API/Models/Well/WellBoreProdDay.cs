using System;
using Newtonsoft.Json;
using System.ComponentModel.DataAnnotations.Schema;

namespace PDM_API.Models
{
    [Table("WB_PROD_DAY", Schema = "PDM")]
    public class WellBoreProdDay
    {
        [JsonProperty("PROD_MONTH")]
        public DateTime? PROD_MONTH { get; set; }
        [JsonProperty("PROD_MONTH_SHORT")]
        public string PROD_MONTH_SHORT { get { return PROD_MONTH != null ? ((DateTime)PROD_MONTH).ToString("yyyy-MM-dd") : null; } }

        [JsonProperty("PROD_DAY")]
        public DateTime PROD_DAY { get; set; }
        [JsonProperty("PROD_DAY_SHORT")]
        public string PROD_DAY_SHORT { get { return PROD_DAY.ToString("yyyy-MM-dd"); } }

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
        [JsonProperty("FCTY_CODE")]
        public string FCTY_CODE { get; set; }
        [JsonProperty("GOV_FCTY_CODE")]
        public string GOV_FCTY_CODE { get; set; }
        [JsonProperty("GOV_FCTY_NAME")]
        public string GOV_FCTY_NAME { get; set; }
        [JsonProperty("WELL_OFFICIAL_NAME")]
        public string WELL_OFFICIAL_NAME { get; set; }
        [JsonProperty("WELL_NAME")]
        public string WELL_NAME { get; set; }
        [JsonProperty("WELL_UWI")]
        public string WELL_UWI { get; set; }
        [JsonProperty("WELL_BORE_CODE")]
        public string WELL_BORE_CODE { get; set; }
        [JsonProperty("UNIQUE_WB_ID")]
        public string UNIQUE_WB_ID { get; set; }
        [JsonProperty("GOV_WB_CODE")]
        public string GOV_WB_CODE { get; set; }
        [JsonProperty("GOV_WB_NAME")]
        public string GOV_WB_NAME { get; set; }
        [JsonProperty("OPERATOR")]
        public string OPERATOR { get; set; }
        [JsonProperty("WBI_CODE")]
        public string WBI_CODE { get; set; }
        [JsonProperty("PERF_CODE")]
        public string PERF_CODE { get; set; }
        [JsonProperty("SEGMENT")]
        public string SEGMENT { get; set; }
        [JsonProperty("FORMATION")]
        public string FORMATION { get; set; }
        [JsonProperty("WB_OIL_VOL_SM3")]
        public double? WB_OIL_VOL_SM3 { get; set; }
        [JsonProperty("WBI_OIL_VOL_SM3")]
        public double? WBI_OIL_VOL_SM3 { get; set; }
        [JsonProperty("PERF_OIL_VOL_SM3")]
        public double? PERF_OIL_VOL_SM3 { get; set; }
        [JsonProperty("WB_COND_VOL_SM3")]
        public double? WB_COND_VOL_SM3 { get; set; }
        [JsonProperty("WBI_COND_VOL_SM3")]
        public double? WBI_COND_VOL_SM3 { get; set; }
        [JsonProperty("PERF_COND_VOL_SM3")]
        public double? PERF_COND_VOL_SM3 { get; set; }
        [JsonProperty("WB_GAS_VOL_SM3")]
        public double? WB_GAS_VOL_SM3 { get; set; }
        [JsonProperty("WBI_GAS_VOL_SM3")]
        public double? WBI_GAS_VOL_SM3 { get; set; }
        [JsonProperty("PERF_GAS_VOL_SM3")]
        public double? PERF_GAS_VOL_SM3 { get; set; }
        [JsonProperty("WB_WAT_VOL_SM3")]
        public double? WB_WAT_VOL_SM3 { get; set; }
        [JsonProperty("WBI_WAT_VOL_SM3")]
        public double? WBI_WAT_VOL_SM3 { get; set; }
        [JsonProperty("PERF_WAT_VOL_SM3")]
        public double? PERF_WAT_VOL_SM3 { get; set; }
        [JsonProperty("WBI_TUBING_PRESS_BARG")]
        public double? WBI_TUBING_PRESS_BARG { get; set; }
        [JsonProperty("WBI_TUBING_TEMP_C")]
        public double? WBI_TUBING_TEMP_C { get; set; }
        [JsonProperty("WBI_ANNULUS_PRESS_BARG")]
        public double? WBI_ANNULUS_PRESS_BARG { get; set; }
        [JsonProperty("WBI_ANNULUS_TEMP_C")]
        public double? WBI_ANNULUS_TEMP_C { get; set; }
        [JsonProperty("DP_SLEEVE_BARA")]
        public double? DP_SLEEVE_BARA { get; set; }
        [JsonProperty("WBI_CHOKE_OPENING")]
        public double? WBI_CHOKE_OPENING { get; set; }
        [JsonProperty("WELL_LAT")]
        public double? WELL_LAT { get; set; }
        [JsonProperty("WELL_LON")]
        public double? WELL_LON { get; set; }
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