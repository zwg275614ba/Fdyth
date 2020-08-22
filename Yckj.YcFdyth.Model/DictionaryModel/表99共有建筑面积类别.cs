namespace Yckj.YcFdyth.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class 表99共有建筑面积类别
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int BSM { get; set; }

        [StringLength(4)]
        public string GYJZMJDM { get; set; }

        [StringLength(255)]
        public string GYJZMJLX { get; set; }

        [StringLength(255)]
        public string GYJZMJMC { get; set; }
    }
}
