namespace Yckj.YcFdyth.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class BDC户型分摊关联表
    {
        [Key]
        public int 标识码 { get; set; }

        public int? 户型标识码 { get; set; }

        public int? 附属建筑标识码 { get; set; }

        [StringLength(20)]
        public string 分摊ID { get; set; }

        public int? 附属个数 { get; set; }

        public string 备注 { get; set; }

        [StringLength(20)]
        public string ZRZ号 { get; set; }

        [StringLength(20)]
        public string C号 { get; set; }

        [StringLength(10)]
        public string H型ID { get; set; }

        [StringLength(20)]
        public string 附属建筑ID { get; set; }
    }
}
