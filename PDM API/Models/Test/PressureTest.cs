using System;
using Newtonsoft.Json;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace PDM_API.Models
{
    [Table("PRESSURE_TEST", Schema = "PDM")]
    public class PressureTest
    {
        [JsonProperty("WELL_BORE_CODE")]
        public string WELL_BORE_CODE { get; set; }
        [JsonProperty("DATEPRD")]
        public DateTime? DATEPRD { get; set; }
        [JsonProperty("DURATION")]
        public double? DURATION { get; set; }
        [JsonProperty("SHUT_IN_PERIOD")]
        public double? SHUT_IN_PERIOD { get; set; }
        [JsonProperty("SHUT_IN_DHP")]
        public double? SHUT_IN_DHP { get; set; }
        [JsonProperty("SHUT_IN_DHP_TOP_PERF")]
        public double? SHUT_IN_DHP_TOP_PERF { get; set; }
        [JsonProperty("SHUT_IN_WHP")]
        public double? SHUT_IN_WHP { get; set; }
        [JsonProperty("ZONE_P_DAT_DEPTH")]
        public double? ZONE_P_DAT_DEPTH { get; set; }
        [JsonProperty("TEST_TYPE")]
        public string TEST_TYPE { get; set; }
        [JsonProperty("COMMENTS")]
        public string COMMENTS { get; set; }
    }
}