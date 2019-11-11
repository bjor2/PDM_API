using System;
using Newtonsoft.Json;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace PDM_API.Models
{
    [Table("TRACER_PROD_COMB", Schema = "PDM")]
    public class TracerProdComb
    {
        [JsonProperty("WELL_BORE_CODE")]
        public string WELL_BORE_CODE { get; set; }
        [JsonProperty("DATEPRD")]
        public DateTime? DATEPRD { get; set; }
        [JsonProperty("SAMPLE_TYPE")]
        public string SAMPLE_TYPE { get; set; }
        [JsonProperty("SLEEVE_NO")]
        public double? SLEEVE_NO { get; set; }
        [JsonProperty("SAMPLE_POINT")]
        public string SAMPLE_POINT { get; set; }
        [JsonProperty("WELL_CODE")]
        public string WELL_CODE { get; set; }
        [JsonProperty("WELLBORE_INTERVAL_CODE")]
        public string WELLBORE_INTERVAL_CODE { get; set; }
        [JsonProperty("FACILITY")]
        public string FACILITY { get; set; }
        [JsonProperty("COMMENTS")]
        public string COMMENTS { get; set; }
        [JsonProperty("PTYPE")]
        public string PTYPE { get; set; }
        [JsonProperty("FIELD")]
        public string FIELD { get; set; }
        [JsonProperty("PROSTY")]
        public string PROSTY { get; set; }
        [JsonProperty("INITIAL_WELL_ID")]
        public string INITIAL_WELL_ID { get; set; }
        [JsonProperty("WELL_S")]
        public string WELL_S { get; set; }
        [JsonProperty("WELL_SORTNAME")]
        public string WELL_SORTNAME { get; set; }
        [JsonProperty("WELLBORE_PART_S")]
        public string WELLBORE_PART_S { get; set; }
        [JsonProperty("WELLBORE_PART_SORT")]
        public string WELLBORE_PART_SORT { get; set; }
        [JsonProperty("WELLBORE_S")]
        public string WELLBORE_S { get; set; }
        [JsonProperty("WELLBORE_T")]
        public string WELLBORE_T { get; set; }
        [JsonProperty("BUOH_OIL")]
        public double? BUOH_OIL { get; set; }
        [JsonProperty("C2H5T")]
        public double? C2H5T { get; set; }
        [JsonProperty("C4H9T")]
        public double? C4H9T { get; set; }
        [JsonProperty("CH3T")]
        public double? CH3T { get; set; }
        [JsonProperty("COCN6")]
        public double? COCN6 { get; set; }
        [JsonProperty("D_C5_ACID")]
        public double? D_C5_ACID { get; set; }
        [JsonProperty("GGT_1")]
        public double? GGT_1 { get; set; }
        [JsonProperty("HTO")]
        public double? HTO { get; set; }
        [JsonProperty("I_PPCH")]
        public double? I_PPCH { get; set; }
        [JsonProperty("IFE_GT_1")]
        public double? IFE_GT_1 { get; set; }
        [JsonProperty("IFE_GT_2")]
        public double? IFE_GT_2 { get; set; }
        [JsonProperty("IFE_GT_3")]
        public double? IFE_GT_3 { get; set; }
        [JsonProperty("IFE_GT_4")]
        public double? IFE_GT_4 { get; set; }
        [JsonProperty("IFE_GT_5")]
        public double? IFE_GT_5 { get; set; }
        [JsonProperty("IFE_GT_6")]
        public double? IFE_GT_6 { get; set; }
        [JsonProperty("IFE_GT_7")]
        public double? IFE_GT_7 { get; set; }
        [JsonProperty("IFE_WT_1")]
        public double? IFE_WT_1 { get; set; }
        [JsonProperty("IFE_WT_10")]
        public double? IFE_WT_10 { get; set; }
        [JsonProperty("IFE_WT_11")]
        public double? IFE_WT_11 { get; set; }
        [JsonProperty("IFE_WT_12")]
        public double? IFE_WT_12 { get; set; }
        [JsonProperty("IFE_WT_13")]
        public double? IFE_WT_13 { get; set; }
        [JsonProperty("IFE_WT_14")]
        public double? IFE_WT_14 { get; set; }
        [JsonProperty("IFE_WT_15")]
        public double? IFE_WT_15 { get; set; }
        [JsonProperty("IFE_WT_16")]
        public double? IFE_WT_16 { get; set; }
        [JsonProperty("IFE_WT_2")]
        public double? IFE_WT_2 { get; set; }
        [JsonProperty("IFE_WT_3")]
        public double? IFE_WT_3 { get; set; }
        [JsonProperty("IFE_WT_4")]
        public double? IFE_WT_4 { get; set; }
        [JsonProperty("IFE_WT_40")]
        public double? IFE_WT_40 { get; set; }
        [JsonProperty("IFE_WT_41")]
        public double? IFE_WT_41 { get; set; }
        [JsonProperty("IFE_WT_42")]
        public double? IFE_WT_42 { get; set; }
        [JsonProperty("IFE_WT_43")]
        public double? IFE_WT_43 { get; set; }
        [JsonProperty("IFE_WT_5")]
        public double? IFE_WT_5 { get; set; }
        [JsonProperty("IFE_WT_6")]
        public double? IFE_WT_6 { get; set; }
        [JsonProperty("IFE_WT_60")]
        public double? IFE_WT_60 { get; set; }
        [JsonProperty("IFE_WT_61")]
        public double? IFE_WT_61 { get; set; }
        [JsonProperty("IFE_WT_62")]
        public double? IFE_WT_62 { get; set; }
        [JsonProperty("IFE_WT_7")]
        public double? IFE_WT_7 { get; set; }
        [JsonProperty("IFE_WT_8")]
        public double? IFE_WT_8 { get; set; }
        [JsonProperty("IFE_WT_9")]
        public double? IFE_WT_9 { get; set; }
        [JsonProperty("IFE_WTP_1")]
        public double? IFE_WTP_1 { get; set; }
        [JsonProperty("IFE_WTP_2")]
        public double? IFE_WTP_2 { get; set; }
        [JsonProperty("N_PPCH")]
        public double? N_PPCH { get; set; }
        [JsonProperty("OFT")]
        public double? OFT { get; set; }
        [JsonProperty("PDEC")]
        public double? PDEC { get; set; }
        [JsonProperty("PDMCB")]
        public double? PDMCB { get; set; }
        [JsonProperty("PDMCB_OIL")]
        public double? PDMCB_OIL { get; set; }
        [JsonProperty("PDMCH")]
        public double? PDMCH { get; set; }
        [JsonProperty("PDMCH_OIL")]
        public double? PDMCH_OIL { get; set; }
        [JsonProperty("PECH")]
        public double? PECH { get; set; }
        [JsonProperty("PFD")]
        public double? PFD { get; set; }
        [JsonProperty("PMCH")]
        public double? PMCH { get; set; }
        [JsonProperty("PMCH_OIL")]
        public double? PMCH_OIL { get; set; }
        [JsonProperty("PMCP")]
        public double? PMCP { get; set; }
        [JsonProperty("PMCP_OIL")]
        public double? PMCP_OIL { get; set; }
        [JsonProperty("PMDEC")]
        public double? PMDEC { get; set; }
        [JsonProperty("SCN")]
        public double? SCN { get; set; }
        [JsonProperty("SF6")]
        public double? SF6 { get; set; }
        [JsonProperty("SF6_OIL")]
        public double? SF6_OIL { get; set; }
        [JsonProperty("T_12_PDMCH")]
        public double? T_12_PDMCH { get; set; }
        [JsonProperty("T_13_PDMCH")]
        public double? T_13_PDMCH { get; set; }
        [JsonProperty("T_135_PTMCH")]
        public double? T_135_PTMCH { get; set; }
        [JsonProperty("T_14_PDMCH")]
        public double? T_14_PDMCH { get; set; }
        [JsonProperty("T_14C_BUOH")]
        public double? T_14C_BUOH { get; set; }
        [JsonProperty("T_14C_MEOH")]
        public double? T_14C_MEOH { get; set; }
        [JsonProperty("T_14C_SCN")]
        public double? T_14C_SCN { get; set; }
        [JsonProperty("T_2_FBA")]
        public double? T_2_FBA { get; set; }
        [JsonProperty("T_234_TFBA")]
        public double? T_234_TFBA { get; set; }
        [JsonProperty("T_24_DFBA")]
        public double? T_24_DFBA { get; set; }
        [JsonProperty("T_245_TFBA")]
        public double? T_245_TFBA { get; set; }
        [JsonProperty("T_25_DFBA")]
        public double? T_25_DFBA { get; set; }
        [JsonProperty("T_26_DFBA")]
        public double? T_26_DFBA { get; set; }
        [JsonProperty("T_34_DFBA")]
        public double? T_34_DFBA { get; set; }
        [JsonProperty("T_35_DFBA")]
        public double? T_35_DFBA { get; set; }
        [JsonProperty("T_36CL")]
        public double? T_36CL { get; set; }
        [JsonProperty("T_4_FBA")]
        public double? T_4_FBA { get; set; }
        [JsonProperty("T_BUOH")]
        public double? T_BUOH { get; set; }
        [JsonProperty("T_MEOH")]
        public double? T_MEOH { get; set; }
        [JsonProperty("THN")]
        public double? THN { get; set; }
        [JsonProperty("ROW_CREATOR")]
        public string ROW_CREATOR { get; set; }
        [JsonProperty("ROW_CREATE_DATE")]
        public DateTime? ROW_CREATE_DATE { get; set; }
        [JsonProperty("UPDATOR")]
        public string UPDATOR { get; set; }
        [JsonProperty("UPDATE_DATE")]
        public DateTime? UPDATE_DATE { get; set; }
    }
}