namespace Yckj.YcFdyth.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class BDC功能分类表
    {
        [Key]
        public int 标识码 { get; set; }

        [StringLength(10)]
        public string 功能分类ID { get; set; }

        [StringLength(50)]
        public string 功能分类 { get; set; }

        public string 备注 { get; set; }
    }
}
