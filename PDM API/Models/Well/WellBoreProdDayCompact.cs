using System;
using Newtonsoft.Json;
using System.ComponentModel.DataAnnotations.Schema;
using System.Collections.Generic;
using System.Linq;

namespace PDM_API.Models
{
    [Table("WB_PROD_DAY", Schema = "PDM")]
    public class WellBoreProdDayCompact
    {
        [JsonProperty("PROD_MONTH")]
        public IEnumerable<DateTime?> PROD_MONTH { get; set; }
        [JsonProperty("PROD_MONTH_SHORT")]
        public IEnumerable<string> PROD_MONTH_SHORT { get { return PROD_MONTH != null ? ((IEnumerable<DateTime>)PROD_MONTH).ToList().Select(e => e.ToString("yyyy-MM-dd")) : null; } }

        [JsonProperty("PROD_DAY")]
        public IEnumerable<DateTime> PROD_DAY { get; set; }
        [JsonProperty("PROD_DAY_SHORT")]
        public IEnumerable<string> PROD_DAY_SHORT { get { return PROD_DAY.ToList().Select(e => e.ToString("yyyy-MM-dd")); } }

        [JsonProperty("COUNTRY")]
        public IEnumerable<string> COUNTRY { get; set; }
        [JsonProperty("COUNTRY_NAME")]
        public IEnumerable<string> COUNTRY_NAME { get; set; }
        [JsonProperty("BA_CODE")]
        public IEnumerable<string> BA_CODE { get; set; }
        [JsonProperty("RA_CODE")]
        public IEnumerable<string> RA_CODE { get; set; }
        [JsonProperty("BU_CODE")]
        public IEnumerable<string> BU_CODE { get; set; }
        [JsonProperty("PC_CODE")]
        public IEnumerable<string> PC_CODE { get; set; }
        [JsonProperty("PLAN_ENTITY")]
        public IEnumerable<string> PLAN_ENTITY { get; set; }
        [JsonProperty("GOV_FIELD_CODE")]
        public IEnumerable<string> GOV_FIELD_CODE { get; set; }
        [JsonProperty("GOV_FIELD_NAME")]
        public IEnumerable<string> GOV_FIELD_NAME { get; set; }
        [JsonProperty("FCTY_CODE")]
        public IEnumerable<string> FCTY_CODE { get; set; }
        [JsonProperty("GOV_FCTY_CODE")]
        public IEnumerable<string> GOV_FCTY_CODE { get; set; }
        [JsonProperty("GOV_FCTY_NAME")]
        public IEnumerable<string> GOV_FCTY_NAME { get; set; }
        [JsonProperty("WELL_OFFICIAL_NAME")]
        public IEnumerable<string> WELL_OFFICIAL_NAME { get; set; }
        [JsonProperty("WELL_NAME")]
        public IEnumerable<string> WELL_NAME { get; set; }
        [JsonProperty("WELL_UWI")]
        public IEnumerable<string> WELL_UWI { get; set; }
        [JsonProperty("WELL_BORE_CODE")]
        public IEnumerable<string> WELL_BORE_CODE { get; set; }
        [JsonProperty("UNIQUE_WB_ID")]
        public IEnumerable<string> UNIQUE_WB_ID { get; set; }
        [JsonProperty("GOV_WB_CODE")]
        public IEnumerable<string> GOV_WB_CODE { get; set; }
        [JsonProperty("GOV_WB_NAME")]
        public IEnumerable<string> GOV_WB_NAME { get; set; }
        [JsonProperty("OPERATOR")]
        public IEnumerable<string> OPERATOR { get; set; }
        [JsonProperty("WBI_CODE")]
        public IEnumerable<string> WBI_CODE { get; set; }
        [JsonProperty("PERF_CODE")]
        public IEnumerable<string> PERF_CODE { get; set; }
        [JsonProperty("SEGMENT")]
        public IEnumerable<string> SEGMENT { get; set; }
        [JsonProperty("FORMATION")]
        public IEnumerable<string> FORMATION { get; set; }
        [JsonProperty("WB_OIL_VOL_SM3")]
        public IEnumerable<double?> WB_OIL_VOL_SM3 { get; set; }
        [JsonProperty("WBI_OIL_VOL_SM3")]
        public IEnumerable<double?> WBI_OIL_VOL_SM3 { get; set; }
        [JsonProperty("PERF_OIL_VOL_SM3")]
        public IEnumerable<double?> PERF_OIL_VOL_SM3 { get; set; }
        [JsonProperty("WB_COND_VOL_SM3")]
        public IEnumerable<double?> WB_COND_VOL_SM3 { get; set; }
        [JsonProperty("WBI_COND_VOL_SM3")]
        public IEnumerable<double?> WBI_COND_VOL_SM3 { get; set; }
        [JsonProperty("PERF_COND_VOL_SM3")]
        public IEnumerable<double?> PERF_COND_VOL_SM3 { get; set; }
        [JsonProperty("WB_GAS_VOL_SM3")]
        public IEnumerable<double?> WB_GAS_VOL_SM3 { get; set; }
        [JsonProperty("WBI_GAS_VOL_SM3")]
        public IEnumerable<double?> WBI_GAS_VOL_SM3 { get; set; }
        [JsonProperty("PERF_GAS_VOL_SM3")]
        public IEnumerable<double?> PERF_GAS_VOL_SM3 { get; set; }
        [JsonProperty("WB_WAT_VOL_SM3")]
        public IEnumerable<double?> WB_WAT_VOL_SM3 { get; set; }
        [JsonProperty("WBI_WAT_VOL_SM3")]
        public IEnumerable<double?> WBI_WAT_VOL_SM3 { get; set; }
        [JsonProperty("PERF_WAT_VOL_SM3")]
        public IEnumerable<double?> PERF_WAT_VOL_SM3 { get; set; }
        [JsonProperty("WBI_TUBING_PRESS_BARG")]
        public IEnumerable<double?> WBI_TUBING_PRESS_BARG { get; set; }
        [JsonProperty("WBI_TUBING_TEMP_C")]
        public IEnumerable<double?> WBI_TUBING_TEMP_C { get; set; }
        [JsonProperty("WBI_ANNULUS_PRESS_BARG")]
        public IEnumerable<double?> WBI_ANNULUS_PRESS_BARG { get; set; }
        [JsonProperty("WBI_ANNULUS_TEMP_C")]
        public IEnumerable<double?> WBI_ANNULUS_TEMP_C { get; set; }
        [JsonProperty("DP_SLEEVE_BARA")]
        public IEnumerable<double?> DP_SLEEVE_BARA { get; set; }
        [JsonProperty("WBI_CHOKE_OPENING")]
        public IEnumerable<double?> WBI_CHOKE_OPENING { get; set; }
        [JsonProperty("WELL_LAT")]
        public IEnumerable<double?> WELL_LAT { get; set; }
        [JsonProperty("WELL_LON")]
        public IEnumerable<double?> WELL_LON { get; set; }
        [JsonProperty("WB_START_DATE")]
        public IEnumerable<DateTime?> WB_START_DATE { get; set; }
        [JsonProperty("WB_END_DATE")]
        public IEnumerable<DateTime?> WB_END_DATE { get; set; }
        [JsonProperty("WB_V_START_DATE")]
        public IEnumerable<DateTime?> WB_V_START_DATE { get; set; }
        [JsonProperty("WB_V_END_DATE")]
        public IEnumerable<DateTime?> WB_V_END_DATE { get; set; }
        [JsonProperty("LAST_CHANGED")]
        public IEnumerable<DateTime?> LAST_CHANGED { get; set; }
        [JsonProperty("DBSOURCE")]
        public IEnumerable<string> DBSOURCE { get; set; }
        [JsonProperty("DBSOURCE_ID")]
        public IEnumerable<string> DBSOURCE_ID { get; set; }
    }
}