namespace Yckj.YcFdyth.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class 资料上传记录
    {
        [Key]
        public int OBJECTID { get; set; }

        [StringLength(50)]
        public string LocalIp { get; set; }

        [StringLength(50)]
        public string LocalPcName { get; set; }

        public string SourcePath { get; set; }

        public string TargetPath { get; set; }

        public DateTime? CreateTime { get; set; }
    }
}
