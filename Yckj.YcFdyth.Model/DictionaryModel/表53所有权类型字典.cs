namespace Yckj.YcFdyth.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class 表53所有权类型字典
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public short OBJECTID { get; set; }

        [StringLength(255)]
        public string SYQLX { get; set; }

        [StringLength(255)]
        public string 所有权类型 { get; set; }
    }
}
