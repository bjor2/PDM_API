using System;
using Newtonsoft.Json;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace PDM_API.Models
{
    [Table("WELL_EVENT", Schema = "PDM")]
    public class WellEvent
    {
        [JsonProperty("WELL_CODE")]
        public string WELL_CODE { get; set; }
        [JsonProperty("WDATE")]
        public DateTime? WDATE { get; set; }
        [JsonProperty("CODE_TEXT")]
        public string CODE_TEXT { get; set; }
        [JsonProperty("CHANGED_BY")]
        public string CHANGED_BY { get; set; }
        [JsonProperty("CHANGED_DATE")]
        public DateTime? CHANGED_DATE { get; set; }
        [JsonProperty("CODE")]
        public string CODE { get; set; }
        [JsonProperty("CREATED_BY")]
        public string CREATED_BY { get; set; }
        [JsonProperty("CREATED_DATE")]
        public DateTime? CREATED_DATE { get; set; }
        [JsonProperty("END_TIME")]
        public DateTime? END_TIME { get; set; }
        [JsonProperty("ROW_CNT")]
        public double? ROW_CNT { get; set; }
        [JsonProperty("STRUCTURE")]
        public string STRUCTURE { get; set; }
        [JsonProperty("TEST_ID")]
        public double? TEST_ID { get; set; }
        [JsonProperty("WORK_DESCRIPTION")]
        public string WORK_DESCRIPTION { get; set; }
        [JsonProperty("WELL_BORE_CODE")]
        public string WELL_BORE_CODE { get; set; }
    }
}