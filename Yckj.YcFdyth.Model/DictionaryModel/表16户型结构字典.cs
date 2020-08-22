namespace Yckj.YcFdyth.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class 表16户型结构字典
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public short OBJECTID { get; set; }

        [StringLength(255)]
        public string HXJG { get; set; }

        [StringLength(255)]
        public string 户型结构 { get; set; }
    }
}
