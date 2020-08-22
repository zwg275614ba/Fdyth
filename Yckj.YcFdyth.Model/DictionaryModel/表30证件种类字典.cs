namespace Yckj.YcFdyth.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class 表30证件种类字典
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public short OBJECTID { get; set; }

        public int? ZJZL { get; set; }

        [StringLength(255)]
        public string 证件种类 { get; set; }
    }
}
