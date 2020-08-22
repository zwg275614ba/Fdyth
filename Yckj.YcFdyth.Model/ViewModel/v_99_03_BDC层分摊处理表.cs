namespace Yckj.YcFdyth.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class v_99_03_BDC层分摊处理表
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public long 标识码 { get; set; }

        [StringLength(20)]
        public string ZRZ号 { get; set; }

        [StringLength(20)]
        public string LJZ号 { get; set; }

        [StringLength(10)]
        public string 功能分类ID { get; set; }

        public decimal? 层分摊面积 { get; set; }

        public bool? 处理标志 { get; set; }

        [StringLength(50)]
        public string 功能分类 { get; set; }
    }
}
