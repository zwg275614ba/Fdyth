namespace Yckj.YcFdyth.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class BDC附属建筑记录表
    {
        [Key]
        public int 标识码 { get; set; }

        [StringLength(20)]
        public string 附属建筑ID { get; set; }

        [StringLength(10)]
        public string 附属建筑类别ID { get; set; }

        public decimal? 附属建筑面积 { get; set; }

        [StringLength(10)]
        public string 分摊方式ID { get; set; }

        [StringLength(20)]
        public string ZRZ号 { get; set; }

        [StringLength(20)]
        public string C号 { get; set; }

        public int? 层数 { get; set; }

        public int? 个数 { get; set; }

        public string 备注 { get; set; }

        [StringLength(20)]
        public string LJZ号 { get; set; }
    }
}
