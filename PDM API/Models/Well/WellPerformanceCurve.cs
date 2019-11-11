using System;
using Newtonsoft.Json;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace PDM_API.Models
{
    [Table("WELL_PERFORMANCE_CURVE", Schema = "PDM")]
    public class WellPerformanceCurve
    {
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
        [JsonProperty("WELL_NAME")]
        public string WELL_NAME { get; set; }
        [JsonProperty("WELL_UWI")]
        public string WELL_UWI { get; set; }
        [JsonProperty("WELL_OFFICIAL_NAME")]
        public string WELL_OFFICIAL_NAME { get; set; }
        [JsonProperty("WELL_HOOKUP")]
        public string WELL_HOOKUP { get; set; }
        [JsonProperty("VALID_FROM_DATE")]
        public DateTime? VALID_FROM_DATE { get; set; }
        [JsonProperty("PERF_CURVE_ID")]
        public double? PERF_CURVE_ID { get; set; }
        [JsonProperty("SEQ")]
        public double? SEQ { get; set; }
        [JsonProperty("CURVE_PURPOSE")]
        public string CURVE_PURPOSE { get; set; }
        [JsonProperty("PHASE")]
        public string PHASE { get; set; }
        [JsonProperty("FORMULA_TYPE")]
        public string FORMULA_TYPE { get; set; }
        [JsonProperty("CURVE_PARAM_CODE")]
        public string CURVE_PARAM_CODE { get; set; }
        [JsonProperty("GOR")]
        public double? GOR { get; set; }
        [JsonProperty("WATERCUT_PCT")]
        public double? WATERCUT_PCT { get; set; }
        [JsonProperty("CGR")]
        public double? CGR { get; set; }
        [JsonProperty("WGR")]
        public double? WGR { get; set; }
        [JsonProperty("X_VALUE")]
        public double? X_VALUE { get; set; }
        [JsonProperty("Y_VALUE")]
        public double? Y_VALUE { get; set; }
        [JsonProperty("PLANE_INTERSECT_CODE")]
        public string PLANE_INTERSECT_CODE { get; set; }
        [JsonProperty("POTEN_2ND_VALUE")]
        public double? POTEN_2ND_VALUE { get; set; }
        [JsonProperty("POTEN_3RD_VALUE")]
        public double? POTEN_3RD_VALUE { get; set; }
        [JsonProperty("MIN_ALLOW_WH_PRESS_BARG")]
        public double? MIN_ALLOW_WH_PRESS_BARG { get; set; }
        [JsonProperty("MAX_ALLOW_WH_PRESS_BARG")]
        public double? MAX_ALLOW_WH_PRESS_BARG { get; set; }
        [JsonProperty("COMMENTS")]
        public string COMMENTS { get; set; }
        [JsonProperty("LAST_CHANGED")]
        public DateTime? LAST_CHANGED { get; set; }
        [JsonProperty("DBSOURCE")]
        public string DBSOURCE { get; set; }
        [JsonProperty("DBSOURCE_ID")]
        public string DBSOURCE_ID { get; set; }
    }
}