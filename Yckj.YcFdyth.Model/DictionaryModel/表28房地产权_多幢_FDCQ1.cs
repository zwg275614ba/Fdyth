namespace Yckj.YcFdyth.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("表28房地产权（多幢）FDCQ1")]
    public partial class 表28房地产权_多幢_FDCQ1
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int OBJECTID { get; set; }

        [StringLength(28)]
        public string BDCDYH { get; set; }

        [StringLength(10)]
        public string YSDM { get; set; }

        [StringLength(200)]
        public string XMMC { get; set; }

        [StringLength(20)]
        public string YWH { get; set; }

        [StringLength(200)]
        public string ZH { get; set; }

        [StringLength(4)]
        public string ZCS { get; set; }

        [StringLength(2)]
        public string GHYT { get; set; }

        [StringLength(2)]
        public string FWJG { get; set; }

        public double? JZMJ { get; set; }

        public DateTime? JGSJ { get; set; }

        public int? ZTS { get; set; }
    }
}
