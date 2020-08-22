namespace Yckj.YcFdyth.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class 表11不动产单元状态字典
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public short OBJECTID { get; set; }

        [StringLength(255)]
        public string ZT { get; set; }

        [StringLength(255)]
        public string 不动产单元状态 { get; set; }
    }
}
