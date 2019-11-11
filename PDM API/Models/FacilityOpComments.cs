using System;
using Newtonsoft.Json;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace PDM_API.Models
{
    [Table("FACILITY_OP_COMMENTS", Schema = "PDM")]
    public class FacilityOpComments
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
        [JsonProperty("NPD_FCTY_CODE")]
        public string NPD_FCTY_CODE { get; set; }
        [JsonProperty("NPD_FCTY_NAME")]
        public string NPD_FCTY_NAME { get; set; }
        [JsonProperty("COMMENT_DAY")]
        public DateTime? COMMENT_DAY { get; set; }
        [JsonProperty("COMMENT_DAYTIME")]
        public DateTime? COMMENT_DAYTIME { get; set; }
        [JsonProperty("COMMENT_ID")]
        public double? COMMENT_ID { get; set; }
        [JsonProperty("COMMENT_TYPE")]
        public string COMMENT_TYPE { get; set; }
        [JsonProperty("COMMENTS")]
        public string COMMENTS { get; set; }
        [JsonProperty("REPORT_INTERNAL")]
        public string REPORT_INTERNAL { get; set; }
        [JsonProperty("REPORT_EXTERNAL")]
        public string REPORT_EXTERNAL { get; set; }
        [JsonProperty("FACILITY_LAT")]
        public double? FACILITY_LAT { get; set; }
        [JsonProperty("FACILITY_LON")]
        public double? FACILITY_LON { get; set; }
        [JsonProperty("FCTY_START_DATE")]
        public DateTime? FCTY_START_DATE { get; set; }
        [JsonProperty("FCTY_END_DATE")]
        public DateTime? FCTY_END_DATE { get; set; }
        [JsonProperty("LAST_CHANGED")]
        public DateTime? LAST_CHANGED { get; set; }
        [JsonProperty("DBSOURCE")]
        public string DBSOURCE { get; set; }
        [JsonProperty("DBSOURCE_ID")]
        public string DBSOURCE_ID { get; set; }
    }
}