namespace Yckj.YcFdyth.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class 表38省市字典
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public short OBJECTID { get; set; }

        [StringLength(255)]
        public string SS { get; set; }

        [StringLength(255)]
        public string 省市 { get; set; }
    }
}
