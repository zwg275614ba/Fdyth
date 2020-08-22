namespace Yckj.YcFdyth.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("ZDJBXX")]
    public partial class ZDJBXX
    {
        [Key]
        public int OBJECTID { get; set; }

        [Column(TypeName = "image")]
        public byte[] SHAPE { get; set; }

        public int? BSM { get; set; }

        [StringLength(10)]
        public string YSDM { get; set; }

        [StringLength(19)]
        public string ZDDM { get; set; }

        [StringLength(28)]
        public string BDCDYH { get; set; }

        [StringLength(2)]
        public string ZDTZM { get; set; }

        [StringLength(200)]
        public string ZL { get; set; }

        public double? ZDMJ { get; set; }

        [StringLength(2)]
        public string MJDW { get; set; }

        [StringLength(4)]
        public string YT { get; set; }

        [StringLength(2)]
        public string DJ { get; set; }

        public float? JG { get; set; }

        [StringLength(2)]
        public string QLLX { get; set; }

        [StringLength(4)]
        public string QLXZ { get; set; }

        [StringLength(2)]
        public string QLSDFS { get; set; }

        public float? RJL { get; set; }

        public float? JZMD { get; set; }

        public float? JZXG { get; set; }

        [StringLength(200)]
        public string ZDSZD { get; set; }

        [StringLength(200)]
        public string ZDSZN { get; set; }

        [StringLength(200)]
        public string ZDSZX { get; set; }

        [StringLength(200)]
        public string ZDSZB { get; set; }

        public string ZDT { get; set; }

        [StringLength(50)]
        public string TFH { get; set; }

        [StringLength(20)]
        public string DJH { get; set; }

        [StringLength(2)]
        public string ZT { get; set; }

        public double? SHAPE_Length { get; set; }

        public double? SHAPE_Area { get; set; }
    }
}
