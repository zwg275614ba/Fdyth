namespace Yckj.YcFdyth.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class BDC附属建筑类别表
    {
        [Key]
        public int 标识码 { get; set; }

        [StringLength(10)]
        public string 附属建筑类别ID { get; set; }

        [StringLength(50)]
        public string 附属建筑类别 { get; set; }

        public decimal? 计算比例 { get; set; }

        public string 备注 { get; set; }
    }
}
