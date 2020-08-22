namespace Yckj.YcFdyth.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("ZRZ")]
    public partial class ZRZ
    {
        [Key]
        public int OBJECTID { get; set; }

        [Column(TypeName = "image")]
        public byte[] SHAPE { get; set; }

        public int? BSM { get; set; }

        [StringLength(10)]
        public string YSDM { get; set; }

        [StringLength(28)]
        public string BDCDYH { get; set; }

        [StringLength(19)]
        public string ZDDM { get; set; }

        [StringLength(20)]
        public string ZRZH { get; set; }

        [StringLength(100)]
        public string XMMC { get; set; }

        [StringLength(100)]
        public string JZWMC { get; set; }

        public DateTime? JGRQ { get; set; }

        public double? JZWGD { get; set; }

        public double? ZZDMJ { get; set; }

        public double? ZYDMJ { get; set; }

        public double? YCJZMJ { get; set; }

        public double? SCJZMJ { get; set; }

        public int? ZCS { get; set; }

        public int? DSCS { get; set; }

        public int? DXCS { get; set; }

        public double? DXSD { get; set; }

        [StringLength(2)]
        public string GHYT { get; set; }

        [StringLength(2)]
        public string FWJG { get; set; }

        public int? ZTS { get; set; }

        [StringLength(200)]
        public string JZWJBYT { get; set; }

        public string BZ { get; set; }

        [StringLength(2)]
        public string ZT { get; set; }

        public double? SHAPE_Length { get; set; }

        public double? SHAPE_Area { get; set; }
    }
}
