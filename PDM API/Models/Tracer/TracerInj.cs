using System;
using Newtonsoft.Json;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace PDM_API.Models
{
    [Table("TRACER_INJ", Schema = "PDM")]
    public class TracerInj
    {
        [JsonProperty("WELL_BORE_CODE")]
        public string WELL_BORE_CODE { get; set; }
        [JsonProperty("DATEPRD")]
        public DateTime? DATEPRD { get; set; }
        [JsonProperty("COMMENTS")]
        public string COMMENTS { get; set; }
        [JsonProperty("INJECTION_METHOD")]
        public string INJECTION_METHOD { get; set; }
        [JsonProperty("AMIDOG")]
        public double? AMIDOG { get; set; }
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
        [JsonProperty("D_BUOH")]
        public double? D_BUOH { get; set; }
        [JsonProperty("D_C5_ACID")]
        public double? D_C5_ACID { get; set; }
        [JsonProperty("FLUORESCEIN")]
        public double? FLUORESCEIN { get; set; }
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
        [JsonProperty("IOD")]
        public double? IOD { get; set; }
        [JsonProperty("MIX_PDEC_1_3_5_PTMCH")]
        public double? MIX_PDEC_1_3_5_PTMCH { get; set; }
        [JsonProperty("MIX_PMCP_PMCH")]
        public double? MIX_PMCP_PMCH { get; set; }
        [JsonProperty("N_PPCH")]
        public double? N_PPCH { get; set; }
        [JsonProperty("OFT")]
        public double? OFT { get; set; }
        [JsonProperty("PDCH")]
        public double? PDCH { get; set; }
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
        [JsonProperty("PMIPCH")]
        public double? PMIPCH { get; set; }
        [JsonProperty("SCN")]
        public double? SCN { get; set; }
        [JsonProperty("SF6")]
        public double? SF6 { get; set; }
        [JsonProperty("SF6_OIL")]
        public double? SF6_OIL { get; set; }
        [JsonProperty("T_1_NS")]
        public double? T_1_NS { get; set; }
        [JsonProperty("T_12_PDMCH")]
        public double? T_12_PDMCH { get; set; }
        [JsonProperty("T_13_PDMCH")]
        public double? T_13_PDMCH { get; set; }
        [JsonProperty("T_135_PTMCH")]
        public double? T_135_PTMCH { get; set; }
        [JsonProperty("T_136_NTS")]
        public double? T_136_NTS { get; set; }
        [JsonProperty("T_14_PDMCH")]
        public double? T_14_PDMCH { get; set; }
        [JsonProperty("T_14C_BUOH")]
        public double? T_14C_BUOH { get; set; }
        [JsonProperty("T_14C_MEOH")]
        public double? T_14C_MEOH { get; set; }
        [JsonProperty("T_14C_SCN")]
        public double? T_14C_SCN { get; set; }
        [JsonProperty("T_15_NDS")]
        public double? T_15_NDS { get; set; }
        [JsonProperty("T_16_NDS")]
        public double? T_16_NDS { get; set; }
        [JsonProperty("T_2_FBA")]
        public double? T_2_FBA { get; set; }
        [JsonProperty("T_2_NS")]
        public double? T_2_NS { get; set; }
        [JsonProperty("T_2_TFMBA")]
        public double? T_2_TFMBA { get; set; }
        [JsonProperty("T_22_NA")]
        public double? T_22_NA { get; set; }
        [JsonProperty("T_234_TFBA")]
        public double? T_234_TFBA { get; set; }
        [JsonProperty("T_2345_TFBA")]
        public double? T_2345_TFBA { get; set; }
        [JsonProperty("T_24_DFBA")]
        public double? T_24_DFBA { get; set; }
        [JsonProperty("T_245_TFBA")]
        public double? T_245_TFBA { get; set; }
        [JsonProperty("T_25_DFBA")]
        public double? T_25_DFBA { get; set; }
        [JsonProperty("T_26_DFBA")]
        public double? T_26_DFBA { get; set; }
        [JsonProperty("T_26_NDS")]
        public double? T_26_NDS { get; set; }
        [JsonProperty("T_27_NDS")]
        public double? T_27_NDS { get; set; }
        [JsonProperty("T_3_FBA")]
        public double? T_3_FBA { get; set; }
        [JsonProperty("T_3_TFMBA")]
        public double? T_3_TFMBA { get; set; }
        [JsonProperty("T_34_DFBA")]
        public double? T_34_DFBA { get; set; }
        [JsonProperty("T_345_TFBA")]
        public double? T_345_TFBA { get; set; }
        [JsonProperty("T_35_BIS_TFM")]
        public double? T_35_BIS_TFM { get; set; }
        [JsonProperty("T_35_DFBA")]
        public double? T_35_DFBA { get; set; }
        [JsonProperty("T_36CL")]
        public double? T_36CL { get; set; }
        [JsonProperty("T_4_FBA")]
        public double? T_4_FBA { get; set; }
        [JsonProperty("T_4_NH2_1NS")]
        public double? T_4_NH2_1NS { get; set; }
        [JsonProperty("T_4_TFMBA")]
        public double? T_4_TFMBA { get; set; }
        [JsonProperty("T_5_NH2_2NS")]
        public double? T_5_NH2_2NS { get; set; }
        [JsonProperty("T_7_NH2_13_NDS")]
        public double? T_7_NH2_13_NDS { get; set; }
        [JsonProperty("T_BUOH")]
        public double? T_BUOH { get; set; }
        [JsonProperty("T_C18H38")]
        public double? T_C18H38 { get; set; }
        [JsonProperty("T_MEOH")]
        public double? T_MEOH { get; set; }
        [JsonProperty("T_MIX_PMCH_1_3_PDMCH")]
        public double? T_MIX_PMCH_1_3_PDMCH { get; set; }
        [JsonProperty("TEG")]
        public double? TEG { get; set; }
        [JsonProperty("THN")]
        public double? THN { get; set; }
        [JsonProperty("TMG")]
        public double? TMG { get; set; }
        [JsonProperty("CREATOR")]
        public string CREATOR { get; set; }
        [JsonProperty("CREATE_DATE")]
        public DateTime? CREATE_DATE { get; set; }
        [JsonProperty("UPDATOR")]
        public string UPDATOR { get; set; }
        [JsonProperty("UPDATE_DATE")]
        public DateTime? UPDATE_DATE { get; set; }
    }
}