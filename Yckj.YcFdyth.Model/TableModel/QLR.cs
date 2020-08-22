namespace Yckj.YcFdyth.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("QLR")]
    public partial class QLR
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int OBJECTID { get; set; }

        [StringLength(10)]
        public string YSDM { get; set; }

        [StringLength(28)]
        public string BDCDYH { get; set; }

        public int? SXH { get; set; }

        [StringLength(100)]
        public string QLRMC { get; set; }

        [StringLength(50)]
        public string BDCQZH { get; set; }

        [StringLength(2)]
        public string ZJZL { get; set; }

        [StringLength(50)]
        public string ZJH { get; set; }

        [StringLength(200)]
        public string FZJG { get; set; }

        [StringLength(6)]
        public string SSHY { get; set; }

        [StringLength(6)]
        public string GJ { get; set; }

        [StringLength(6)]
        public string HJSZSS { get; set; }

        [StringLength(2)]
        public string XB { get; set; }

        [StringLength(50)]
        public string DH { get; set; }

        [StringLength(200)]
        public string DZ { get; set; }

        [StringLength(10)]
        public string YB { get; set; }

        [StringLength(100)]
        public string GZDW { get; set; }

        [StringLength(50)]
        public string DZYJ { get; set; }

        [StringLength(2)]
        public string QLRLX { get; set; }

        public double? QLMJ { get; set; }

        [StringLength(100)]
        public string QLBL { get; set; }

        [StringLength(2)]
        public string GYFS { get; set; }

        public string GYQK { get; set; }

        public string BZ { get; set; }
    }
}
