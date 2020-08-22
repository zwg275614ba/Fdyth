namespace Yckj.YcFdyth.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class 表59土地用途代码
    {
        [Key]
        [StringLength(255)]
        public string 地类代码 { get; set; }

        [StringLength(255)]
        public string 地类名称 { get; set; }

        [StringLength(255)]
        public string 一级分类 { get; set; }
    }
}
