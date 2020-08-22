namespace Yckj.YcFdyth.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class H
    {
        [Key]
        public int OBJECTID { get; set; }

        [StringLength(28)]
        public string BDCDYH { get; set; }

        [StringLength(26)]
        public string FWBM { get; set; }

        [StringLength(10)]
        public string YSDM { get; set; }

        [StringLength(20)]
        public string ZRZH { get; set; }

        [StringLength(20)]
        public string LJZH { get; set; }

        [StringLength(20)]
        public string CH { get; set; }

        [StringLength(100)]
        public string ZL { get; set; }

        [StringLength(2)]
        public string MJDW { get; set; }

        public float? SJCS { get; set; }

        public int? HH { get; set; }

        [StringLength(20)]
        public string SHBW { get; set; }

        [StringLength(2)]
        public string HX { get; set; }

        [StringLength(2)]
        public string HXJG { get; set; }

        [StringLength(2)]
        public string FWYT1 { get; set; }

        [StringLength(2)]
        public string FWYT2 { get; set; }

        [StringLength(2)]
        public string FWYT3 { get; set; }

        public double? YCJZMJ { get; set; }

        public double? YCTNJZMJ { get; set; }

        public double? YCFTJZMJ { get; set; }

        public double? YCDXBFJZMJ { get; set; }

        public double? YCQTJZMJ { get; set; }

        public double? YCFTXS { get; set; }

        public double? SCJZMJ { get; set; }

        public double? SCTNJZMJ { get; set; }

        public double? SCFTJZMJ { get; set; }

        public double? SCDXBFJZMJ { get; set; }

        public double? SCQTJZMJ { get; set; }

        public double? SCFTXS { get; set; }

        public double? GYTDMJ { get; set; }

        public double? FTTDMJ { get; set; }

        public double? DYTDMJ { get; set; }

        [StringLength(2)]
        public string FWLX { get; set; }

        [StringLength(2)]
        public string FWXZ { get; set; }

        public string FCFHT { get; set; }

        [StringLength(2)]
        public string ZT { get; set; }

        [StringLength(6)]
        public string H型ID { get; set; }
    }
}
