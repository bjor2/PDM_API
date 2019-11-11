using Newtonsoft.Json;
using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace PDM_API.Models
{
    [Table("STREAM_ANALYSIS_COMP", Schema = "PDM")]
    public class StreamAnalysisComp
    {
        [JsonProperty("PROD_DAY")]
        public DateTime? PROD_DAY { get; set; }
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
        [JsonProperty("VALID_FROM_DATE")]
        public DateTime? VALID_FROM_DATE { get; set; }
        [JsonProperty("FACILITY_CODE")]
        public string FACILITY_CODE { get; set; }
        [JsonProperty("GOV_FACILITY_CODE")]
        public string GOV_FACILITY_CODE { get; set; }
        [JsonProperty("GOV_FACILITY_NAME")]
        public string GOV_FACILITY_NAME { get; set; }
        [JsonProperty("COMMERCIAL_ENTITY")]
        public string COMMERCIAL_ENTITY { get; set; }
        [JsonProperty("STREAM_CODE")]
        public string STREAM_CODE { get; set; }
        [JsonProperty("STREAM_NAME")]
        public string STREAM_NAME { get; set; }
        [JsonProperty("STREAM_CAT")]
        public string STREAM_CAT { get; set; }
        [JsonProperty("FLOW_KIND")]
        public string FLOW_KIND { get; set; }
        [JsonProperty("QUALIFIER")]
        public string QUALIFIER { get; set; }
        [JsonProperty("PRODUCT")]
        public string PRODUCT { get; set; }
        [JsonProperty("CODE")]
        public string CODE { get; set; }
        [JsonProperty("PHASE")]
        public string PHASE { get; set; }
        [JsonProperty("ANALYSIS_TYPE")]
        public string ANALYSIS_TYPE { get; set; }
        [JsonProperty("SAMPLING_METHOD")]
        public string SAMPLING_METHOD { get; set; }
        [JsonProperty("ANALYSIS_STATUS")]
        public string ANALYSIS_STATUS { get; set; }
        [JsonProperty("COMPONENT_SET")]
        public string COMPONENT_SET { get; set; }
        [JsonProperty("DENSITY_KGPERSM3")]
        public double? DENSITY_KGPERSM3 { get; set; }
        [JsonProperty("REL_DENSITY")]
        public double? REL_DENSITY { get; set; }
        [JsonProperty("GCV_MJPERSM3")]
        public double? GCV_MJPERSM3 { get; set; }
        [JsonProperty("WOBBE_INDEX_MJPERSM3")]
        public double? WOBBE_INDEX_MJPERSM3 { get; set; }
        [JsonProperty("MOL_WT_GPERMOL")]
        public double? MOL_WT_GPERMOL { get; set; }
        [JsonProperty("CNPL_MOL_WT_GPERMOL")]
        public double? CNPL_MOL_WT_GPERMOL { get; set; }
        [JsonProperty("H2S_PPM")]
        public double? H2S_PPM { get; set; }
        [JsonProperty("C2_MOL_PCT")]
        public double? C2_MOL_PCT { get; set; }
        [JsonProperty("N2_MOL_PCT")]
        public double? N2_MOL_PCT { get; set; }
        [JsonProperty("N2_WT_PCT")]
        public double? N2_WT_PCT { get; set; }
        [JsonProperty("CO2_MOL_PCT")]
        public double? CO2_MOL_PCT { get; set; }
        [JsonProperty("CO2_WT_PCT")]
        public double? CO2_WT_PCT { get; set; }
        [JsonProperty("C1_MOL_PCT")]
        public double? C1_MOL_PCT { get; set; }
        [JsonProperty("C1_WT_PCT")]
        public double? C1_WT_PCT { get; set; }
        [JsonProperty("C2_WT_PCT")]
        public double? C2_WT_PCT { get; set; }
        [JsonProperty("C3_MOL_PCT")]
        public double? C3_MOL_PCT { get; set; }
        [JsonProperty("C3_WT_PCT")]
        public double? C3_WT_PCT { get; set; }
        [JsonProperty("IC4_MOL_PCT")]
        public double? IC4_MOL_PCT { get; set; }
        [JsonProperty("IC4_WT_PCT")]
        public double? IC4_WT_PCT { get; set; }
        [JsonProperty("NC4_MOL_PCT")]
        public double? NC4_MOL_PCT { get; set; }
        [JsonProperty("NC4_WT_PCT")]
        public double? NC4_WT_PCT { get; set; }
        [JsonProperty("IC5_MOL_PCT")]
        public double? IC5_MOL_PCT { get; set; }
        [JsonProperty("IC5_WT_PCT")]
        public double? IC5_WT_PCT { get; set; }
        [JsonProperty("NC5_MOL_PCT")]
        public double? NC5_MOL_PCT { get; set; }
        [JsonProperty("NC5_WT_PCT")]
        public double? NC5_WT_PCT { get; set; }
        [JsonProperty("C6_MOL_PCT")]
        public double? C6_MOL_PCT { get; set; }
        [JsonProperty("C6_WT_PCT")]
        public double? C6_WT_PCT { get; set; }
        [JsonProperty("C6_PLUS_MOL_PCT")]
        public double? C6_PLUS_MOL_PCT { get; set; }
        [JsonProperty("C6_PLUS_WT_PCT")]
        public double? C6_PLUS_WT_PCT { get; set; }
        [JsonProperty("C7_MOL_PCT")]
        public double? C7_MOL_PCT { get; set; }
        [JsonProperty("C7_WT_PCT")]
        public double? C7_WT_PCT { get; set; }
        [JsonProperty("C8_MOL_PCT")]
        public double? C8_MOL_PCT { get; set; }
        [JsonProperty("C8_WT_PCT")]
        public double? C8_WT_PCT { get; set; }
        [JsonProperty("C9_MOL_PCT")]
        public double? C9_MOL_PCT { get; set; }
        [JsonProperty("C9_WT_PCT")]
        public double? C9_WT_PCT { get; set; }
        [JsonProperty("C10_PLUS_MOL_PCT")]
        public double? C10_PLUS_MOL_PCT { get; set; }
        [JsonProperty("C10_PLUS_WT_PCT")]
        public double? C10_PLUS_WT_PCT { get; set; }
        [JsonProperty("COMMENTS")]
        public string COMMENTS { get; set; }
        [JsonProperty("FACILITY_LAT")]
        public double? FACILITY_LAT { get; set; }
        [JsonProperty("FACILITY_LON")]
        public double? FACILITY_LON { get; set; }
        [JsonProperty("LAST_CHANGED")]
        public DateTime? LAST_CHANGED { get; set; }
        [JsonProperty("STREAM_START_DATE")]
        public DateTime? STREAM_START_DATE { get; set; }
        [JsonProperty("STREAM_END_DATE")]
        public DateTime? STREAM_END_DATE { get; set; }
        [JsonProperty("DBSOURCE")]
        public string DBSOURCE { get; set; }
        [JsonProperty("DBSOURCE_ID")]
        public string DBSOURCE_ID { get; set; }
    }
}