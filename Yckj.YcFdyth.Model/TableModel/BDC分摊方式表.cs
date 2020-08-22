namespace Yckj.YcFdyth.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class BDC分摊方式表
    {
        [Key]
        public int 标识码 { get; set; }

        [StringLength(10)]
        public string 分摊方式ID { get; set; }

        [StringLength(50)]
        public string 分摊方式 { get; set; }

        public string 备注 { get; set; }
    }
}
