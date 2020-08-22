namespace Yckj.YcFdyth.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("LJZ")]
    public partial class LJZ
    {
        [Key]
        public int OBJECTID { get; set; }

        [StringLength(20)]
        public string LJZH { get; set; }

        [StringLength(20)]
        public string ZRZH { get; set; }

        [StringLength(10)]
        public string YSDM { get; set; }

        [StringLength(50)]
        public string MPH { get; set; }

        public double? YCJZMJ { get; set; }

        public double? YCDXMJ { get; set; }

        public double? YCQTMJ { get; set; }

        public double? SCJZMJ { get; set; }

        public double? SCDXMJ { get; set; }

        public double? SCQTMJ { get; set; }

        public DateTime? JGRQ { get; set; }

        [StringLength(4)]
        public string FWJG1 { get; set; }

        [StringLength(4)]
        public string FWJG2 { get; set; }

        [StringLength(4)]
        public string FWJG3 { get; set; }

        [StringLength(4)]
        public string JZWZT { get; set; }

        [StringLength(4)]
        public string FWYT1 { get; set; }

        [StringLength(4)]
        public string FWYT2 { get; set; }

        [StringLength(4)]
        public string FWYT3 { get; set; }

        public int? ZCS { get; set; }

        public int? DSCS { get; set; }

        public int? DXCS { get; set; }

        public string BZ { get; set; }
    }
}
