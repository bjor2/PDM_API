using Newtonsoft.Json;using System;
using System.ComponentModel.DataAnnotations.Schema;namespace PDM_API.Models{
    public class Error    {        [JsonProperty("message")]        public string Message { get; set; }

        [JsonProperty("code")]        public int Code { get; set; }    }}