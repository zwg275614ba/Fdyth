namespace Yckj.YcFdyth.Model
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class YcFdythModel : DbContext
    {
        public YcFdythModel()
            : base("name=YcFdythModel")
        {
        }

        public virtual DbSet<BDC分摊方式表> BDC分摊方式表 { get; set; }
        public virtual DbSet<BDC附属建筑记录表> BDC附属建筑记录表 { get; set; }
        public virtual DbSet<BDC附属建筑类别表> BDC附属建筑类别表 { get; set; }
        public virtual DbSet<BDC功能分类表> BDC功能分类表 { get; set; }
        public virtual DbSet<BDC户型表> BDC户型表 { get; set; }
        public virtual DbSet<BDC户型分摊关联表> BDC户型分摊关联表 { get; set; }
        public virtual DbSet<C> C { get; set; }
        public virtual DbSet<FDCQ2> FDCQ2 { get; set; }
        public virtual DbSet<files_文件目录> files_文件目录 { get; set; } 
        public virtual DbSet<H> H { get; set; }
        public virtual DbSet<LJZ> LJZ { get; set; }
        public virtual DbSet<prjs_项目类别> prjs_项目类别 { get; set; }
        public virtual DbSet<ZDJBXX> ZDJBXX { get; set; }
        public virtual DbSet<ZRZ> ZRZ { get; set; }
        public virtual DbSet<安置点表> 安置点表 { get; set; }
        public virtual DbSet<安置点关联表> 安置点关联表 { get; set; }
        public virtual DbSet<用户表> 用户表 { get; set; }
        public virtual DbSet<资料上传记录> 资料上传记录 { get; set; }
        public virtual DbSet<BDC层分摊处理表> BDC层分摊处理表 { get; set; }
        public virtual DbSet<QLR> QLR { get; set; }
        public virtual DbSet<表11不动产单元状态字典> 表11不动产单元状态字典 { get; set; }
        public virtual DbSet<表15户型字典> 表15户型字典 { get; set; }
        public virtual DbSet<表16户型结构字典> 表16户型结构字典 { get; set; }
        public virtual DbSet<表17房屋用途字典> 表17房屋用途字典 { get; set; }
        public virtual DbSet<表18房屋类型字典> 表18房屋类型字典 { get; set; }
        public virtual DbSet<表19房屋性质字典> 表19房屋性质字典 { get; set; }
        public virtual DbSet<表20区县字典> 表20区县字典 { get; set; }
        public virtual DbSet<表22权属状态字典> 表22权属状态字典 { get; set; }
        public virtual DbSet<表26建设用地使用权JSYDSYQ> 表26建设用地使用权JSYDSYQ { get; set; }
        public virtual DbSet<表27房地产权_多幢_FDCQ1> 表27房地产权_多幢_FDCQ1 { get; set; }
        public virtual DbSet<表28房地产权_多幢_FDCQ1> 表28房地产权_多幢_FDCQ1 { get; set; }
        public virtual DbSet<表30证件种类字典> 表30证件种类字典 { get; set; }
        public virtual DbSet<表34共有方式字典> 表34共有方式字典 { get; set; }
        public virtual DbSet<表35国家和地区字典> 表35国家和地区字典 { get; set; }
        public virtual DbSet<表36权利人类型字典> 表36权利人类型字典 { get; set; }
        public virtual DbSet<表38省市字典> 表38省市字典 { get; set; }
        public virtual DbSet<表41所属行业字典> 表41所属行业字典 { get; set; }
        public virtual DbSet<表43性别字典> 表43性别字典 { get; set; }
        public virtual DbSet<表44宗地宗海特征码字典> 表44宗地宗海特征码字典 { get; set; }
        public virtual DbSet<表46房屋结构字典> 表46房屋结构字典 { get; set; }
        public virtual DbSet<表47建筑物状态字典> 表47建筑物状态字典 { get; set; }
        public virtual DbSet<表53所有权类型字典> 表53所有权类型字典 { get; set; }
        public virtual DbSet<表54定着物物特征码字典> 表54定着物物特征码字典 { get; set; }
        public virtual DbSet<表59土地用途代码> 表59土地用途代码 { get; set; }
        public virtual DbSet<表7面积单位字典> 表7面积单位字典 { get; set; }
        public virtual DbSet<表99扶贫搬迁点> 表99扶贫搬迁点 { get; set; }
        public virtual DbSet<表99共有建筑面积类别> 表99共有建筑面积类别 { get; set; }
        public virtual DbSet<表99建筑面积计算比例> 表99建筑面积计算比例 { get; set; }
        public virtual DbSet<v_01_01_套内主体面积统计表> v_01_01_套内主体面积统计表 { get; set; }
        public virtual DbSet<v_01_02_套内附属建筑面积详表统计> v_01_02_套内附属建筑面积详表统计 { get; set; }
        public virtual DbSet<v_01_03_套内主体附属面积统计表> v_01_03_套内主体附属面积统计表 { get; set; }
        public virtual DbSet<v_01_04_户型分摊系数> v_01_04_户型分摊系数 { get; set; }
        public virtual DbSet<v_02_01_01_附属建筑共用分摊统计> v_02_01_01_附属建筑共用分摊统计 { get; set; }
        public virtual DbSet<v_02_01_共用附属建筑分摊面积统计表> v_02_01_共用附属建筑分摊面积统计表 { get; set; }
        public virtual DbSet<v_500_01_BDC户型表> v_500_01_BDC户型表 { get; set; }
        public virtual DbSet<v_500_02_BDC附属建筑记录表> v_500_02_BDC附属建筑记录表 { get; set; }
        public virtual DbSet<v_500_03_BDC户型分摊关联表> v_500_03_BDC户型分摊关联表 { get; set; }
        public virtual DbSet<v_99_00_BDC户型表> v_99_00_BDC户型表 { get; set; }
        public virtual DbSet<v_99_01_BDC户型分摊关联表> v_99_01_BDC户型分摊关联表 { get; set; }
        public virtual DbSet<v_99_02_BDC附属建筑记录表> v_99_02_BDC附属建筑记录表 { get; set; }
        public virtual DbSet<v_99_03_BDC层分摊处理表> v_99_03_BDC层分摊处理表 { get; set; }
        public virtual DbSet<v_files_文件目录> v_files_文件目录 { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<BDC分摊方式表>()
                .Property(e => e.分摊方式ID)
                .IsUnicode(false);

            modelBuilder.Entity<BDC附属建筑记录表>()
                .Property(e => e.附属建筑ID)
                .IsUnicode(false);

            modelBuilder.Entity<BDC附属建筑记录表>()
                .Property(e => e.附属建筑类别ID)
                .IsUnicode(false);

            modelBuilder.Entity<BDC附属建筑记录表>()
                .Property(e => e.附属建筑面积)
                .HasPrecision(18, 4);

            modelBuilder.Entity<BDC附属建筑记录表>()
                .Property(e => e.分摊方式ID)
                .IsUnicode(false);

            modelBuilder.Entity<BDC附属建筑记录表>()
                .Property(e => e.ZRZ号)
                .IsUnicode(false);

            modelBuilder.Entity<BDC附属建筑记录表>()
                .Property(e => e.C号)
                .IsUnicode(false);

            modelBuilder.Entity<BDC附属建筑记录表>()
                .Property(e => e.LJZ号)
                .IsUnicode(false);

            modelBuilder.Entity<BDC附属建筑类别表>()
                .Property(e => e.附属建筑类别ID)
                .IsUnicode(false);

            modelBuilder.Entity<BDC附属建筑类别表>()
                .Property(e => e.计算比例)
                .HasPrecision(4, 2);

            modelBuilder.Entity<BDC功能分类表>()
                .Property(e => e.功能分类ID)
                .IsUnicode(false);

            modelBuilder.Entity<BDC户型表>()
                .Property(e => e.H型ID)
                .IsUnicode(false);

            modelBuilder.Entity<BDC户型表>()
                .Property(e => e.ZRZ号)
                .IsUnicode(false);

            modelBuilder.Entity<BDC户型表>()
                .Property(e => e.LJZ号)
                .IsUnicode(false);

            modelBuilder.Entity<BDC户型表>()
                .Property(e => e.C号)
                .IsUnicode(false);

            modelBuilder.Entity<BDC户型表>()
                .Property(e => e.套内面积)
                .HasPrecision(18, 4);

            modelBuilder.Entity<BDC户型表>()
                .Property(e => e.功能分类ID)
                .IsUnicode(false);

            modelBuilder.Entity<BDC户型分摊关联表>()
                .Property(e => e.分摊ID)
                .IsUnicode(false);

            modelBuilder.Entity<BDC户型分摊关联表>()
                .Property(e => e.ZRZ号)
                .IsUnicode(false);

            modelBuilder.Entity<BDC户型分摊关联表>()
                .Property(e => e.C号)
                .IsUnicode(false);

            modelBuilder.Entity<BDC户型分摊关联表>()
                .Property(e => e.H型ID)
                .IsUnicode(false);

            modelBuilder.Entity<BDC户型分摊关联表>()
                .Property(e => e.附属建筑ID)
                .IsUnicode(false);

            modelBuilder.Entity<files_文件目录>()
                .Property(e => e.项目类别)
                .IsUnicode(false);

            modelBuilder.Entity<prjs_项目类别>()
                .Property(e => e.项目类别ID)
                .IsUnicode(false);

            modelBuilder.Entity<prjs_项目类别>()
                .Property(e => e.行业类别ID)
                .IsUnicode(false);

            modelBuilder.Entity<BDC层分摊处理表>()
                .Property(e => e.ZRZ号)
                .IsUnicode(false);

            modelBuilder.Entity<BDC层分摊处理表>()
                .Property(e => e.LJZ号)
                .IsUnicode(false);

            modelBuilder.Entity<BDC层分摊处理表>()
                .Property(e => e.功能分类ID)
                .IsUnicode(false);

            modelBuilder.Entity<BDC层分摊处理表>()
                .Property(e => e.层分摊面积)
                .HasPrecision(18, 4);

            modelBuilder.Entity<v_01_01_套内主体面积统计表>()
                .Property(e => e.ZRZ号)
                .IsUnicode(false);

            modelBuilder.Entity<v_01_01_套内主体面积统计表>()
                .Property(e => e.LJZ号)
                .IsUnicode(false);

            modelBuilder.Entity<v_01_01_套内主体面积统计表>()
                .Property(e => e.C号)
                .IsUnicode(false);

            modelBuilder.Entity<v_01_01_套内主体面积统计表>()
                .Property(e => e.H型ID)
                .IsUnicode(false);

            modelBuilder.Entity<v_01_01_套内主体面积统计表>()
                .Property(e => e.功能分类ID)
                .IsUnicode(false);

            modelBuilder.Entity<v_01_01_套内主体面积统计表>()
                .Property(e => e.套内面积)
                .HasPrecision(18, 4);

            modelBuilder.Entity<v_01_01_套内主体面积统计表>()
                .Property(e => e.主体面积合计)
                .HasPrecision(18, 3);

            modelBuilder.Entity<v_01_02_套内附属建筑面积详表统计>()
                .Property(e => e.ZRZ号)
                .IsUnicode(false);

            modelBuilder.Entity<v_01_02_套内附属建筑面积详表统计>()
                .Property(e => e.LJZ号)
                .IsUnicode(false);

            modelBuilder.Entity<v_01_02_套内附属建筑面积详表统计>()
                .Property(e => e.C号)
                .IsUnicode(false);

            modelBuilder.Entity<v_01_02_套内附属建筑面积详表统计>()
                .Property(e => e.H型ID)
                .IsUnicode(false);

            modelBuilder.Entity<v_01_02_套内附属建筑面积详表统计>()
                .Property(e => e.附属建筑面积)
                .HasPrecision(18, 4);

            modelBuilder.Entity<v_01_02_套内附属建筑面积详表统计>()
                .Property(e => e.计算比例)
                .HasPrecision(4, 2);

            modelBuilder.Entity<v_01_02_套内附属建筑面积详表统计>()
                .Property(e => e.套内附属面积合计)
                .HasPrecision(18, 3);

            modelBuilder.Entity<v_01_03_套内主体附属面积统计表>()
                .Property(e => e.ZRZ号)
                .IsUnicode(false);

            modelBuilder.Entity<v_01_03_套内主体附属面积统计表>()
                .Property(e => e.LJZ号)
                .IsUnicode(false);

            modelBuilder.Entity<v_01_03_套内主体附属面积统计表>()
                .Property(e => e.C号)
                .IsUnicode(false);

            modelBuilder.Entity<v_01_03_套内主体附属面积统计表>()
                .Property(e => e.H型ID)
                .IsUnicode(false);

            modelBuilder.Entity<v_01_03_套内主体附属面积统计表>()
                .Property(e => e.功能分类ID)
                .IsUnicode(false);

            modelBuilder.Entity<v_01_03_套内主体附属面积统计表>()
                .Property(e => e.套内面积)
                .HasPrecision(18, 4);

            modelBuilder.Entity<v_01_03_套内主体附属面积统计表>()
                .Property(e => e.套内主体面积)
                .HasPrecision(18, 3);

            modelBuilder.Entity<v_01_03_套内主体附属面积统计表>()
                .Property(e => e.附属建筑面积)
                .HasPrecision(18, 3);

            modelBuilder.Entity<v_01_03_套内主体附属面积统计表>()
                .Property(e => e.套内附属面积合计)
                .HasPrecision(20, 4);

            modelBuilder.Entity<v_01_03_套内主体附属面积统计表>()
                .Property(e => e.套内面积合计)
                .HasPrecision(30, 3);

            modelBuilder.Entity<v_01_04_户型分摊系数>()
                .Property(e => e.ZRZ号)
                .IsUnicode(false);

            modelBuilder.Entity<v_01_04_户型分摊系数>()
                .Property(e => e.LJZ号)
                .IsUnicode(false);

            modelBuilder.Entity<v_01_04_户型分摊系数>()
                .Property(e => e.H型ID)
                .IsUnicode(false);

            modelBuilder.Entity<v_01_04_户型分摊系数>()
                .Property(e => e.套内面积)
                .HasPrecision(18, 4);

            modelBuilder.Entity<v_01_04_户型分摊系数>()
                .Property(e => e.附属建筑面积)
                .HasPrecision(18, 3);

            modelBuilder.Entity<v_01_04_户型分摊系数>()
                .Property(e => e.套内附属面积合计)
                .HasPrecision(20, 4);

            modelBuilder.Entity<v_01_04_户型分摊系数>()
                .Property(e => e.分摊系数)
                .HasPrecision(18, 6);

            modelBuilder.Entity<v_01_04_户型分摊系数>()
                .Property(e => e.老分摊系数)
                .HasPrecision(18, 6);

            modelBuilder.Entity<v_01_04_户型分摊系数>()
                .Property(e => e.分摊面积)
                .HasPrecision(18, 3);

            modelBuilder.Entity<v_01_04_户型分摊系数>()
                .Property(e => e.建筑面积)
                .HasPrecision(21, 4);

            modelBuilder.Entity<v_02_01_01_附属建筑共用分摊统计>()
                .Property(e => e.计算比例)
                .HasPrecision(4, 2);

            modelBuilder.Entity<v_02_01_01_附属建筑共用分摊统计>()
                .Property(e => e.共用附属建筑面积)
                .HasPrecision(18, 4);

            modelBuilder.Entity<v_02_01_01_附属建筑共用分摊统计>()
                .Property(e => e.共用附属建筑面积合计)
                .HasPrecision(18, 3);

            modelBuilder.Entity<v_02_01_01_附属建筑共用分摊统计>()
                .Property(e => e.ZRZ号)
                .IsUnicode(false);

            modelBuilder.Entity<v_02_01_01_附属建筑共用分摊统计>()
                .Property(e => e.LJZ号)
                .IsUnicode(false);

            modelBuilder.Entity<v_02_01_01_附属建筑共用分摊统计>()
                .Property(e => e.C号)
                .IsUnicode(false);

            modelBuilder.Entity<v_02_01_共用附属建筑分摊面积统计表>()
                .Property(e => e.ZRZ号)
                .IsUnicode(false);

            modelBuilder.Entity<v_02_01_共用附属建筑分摊面积统计表>()
                .Property(e => e.LJZ号)
                .IsUnicode(false);

            modelBuilder.Entity<v_02_01_共用附属建筑分摊面积统计表>()
                .Property(e => e.C号)
                .IsUnicode(false);

            modelBuilder.Entity<v_02_01_共用附属建筑分摊面积统计表>()
                .Property(e => e.分摊方式ID)
                .IsUnicode(false);

            modelBuilder.Entity<v_02_01_共用附属建筑分摊面积统计表>()
                .Property(e => e.附属建筑面积)
                .HasPrecision(18, 4);

            modelBuilder.Entity<v_02_01_共用附属建筑分摊面积统计表>()
                .Property(e => e.计算比例)
                .HasPrecision(4, 2);

            modelBuilder.Entity<v_02_01_共用附属建筑分摊面积统计表>()
                .Property(e => e.附属建筑共用面积)
                .HasPrecision(18, 3);

            modelBuilder.Entity<v_500_01_BDC户型表>()
                .Property(e => e.自然幢号)
                .IsUnicode(false);

            modelBuilder.Entity<v_500_01_BDC户型表>()
                .Property(e => e.逻辑幢号)
                .IsUnicode(false);

            modelBuilder.Entity<v_500_01_BDC户型表>()
                .Property(e => e.层号)
                .IsUnicode(false);

            modelBuilder.Entity<v_500_01_BDC户型表>()
                .Property(e => e.户型)
                .IsUnicode(false);

            modelBuilder.Entity<v_500_01_BDC户型表>()
                .Property(e => e.功能)
                .IsUnicode(false);

            modelBuilder.Entity<v_500_01_BDC户型表>()
                .Property(e => e.套内面积)
                .HasPrecision(18, 4);

            modelBuilder.Entity<v_500_01_BDC户型表>()
                .Property(e => e.主体面积合计)
                .HasPrecision(18, 3);

            modelBuilder.Entity<v_500_02_BDC附属建筑记录表>()
                .Property(e => e.自然幢号)
                .IsUnicode(false);

            modelBuilder.Entity<v_500_02_BDC附属建筑记录表>()
                .Property(e => e.逻辑幢号)
                .IsUnicode(false);

            modelBuilder.Entity<v_500_02_BDC附属建筑记录表>()
                .Property(e => e.层号)
                .IsUnicode(false);

            modelBuilder.Entity<v_500_02_BDC附属建筑记录表>()
                .Property(e => e.附属建筑类别)
                .IsUnicode(false);

            modelBuilder.Entity<v_500_02_BDC附属建筑记录表>()
                .Property(e => e.分摊方式)
                .IsUnicode(false);

            modelBuilder.Entity<v_500_02_BDC附属建筑记录表>()
                .Property(e => e.附属建筑面积)
                .HasPrecision(18, 4);

            modelBuilder.Entity<v_500_02_BDC附属建筑记录表>()
                .Property(e => e.计算比例)
                .HasPrecision(4, 2);

            modelBuilder.Entity<v_500_02_BDC附属建筑记录表>()
                .Property(e => e.附属建筑面积合计)
                .HasPrecision(18, 3);

            modelBuilder.Entity<v_500_02_BDC附属建筑记录表>()
                .Property(e => e.附属建筑ID)
                .IsUnicode(false);

            modelBuilder.Entity<v_500_03_BDC户型分摊关联表>()
                .Property(e => e.自然幢号)
                .IsUnicode(false);

            modelBuilder.Entity<v_500_03_BDC户型分摊关联表>()
                .Property(e => e.逻辑幢号)
                .IsUnicode(false);

            modelBuilder.Entity<v_500_03_BDC户型分摊关联表>()
                .Property(e => e.层号)
                .IsUnicode(false);

            modelBuilder.Entity<v_500_03_BDC户型分摊关联表>()
                .Property(e => e.户型)
                .IsUnicode(false);

            modelBuilder.Entity<v_500_03_BDC户型分摊关联表>()
                .Property(e => e.功能)
                .IsUnicode(false);

            modelBuilder.Entity<v_500_03_BDC户型分摊关联表>()
                .Property(e => e.套内面积)
                .HasPrecision(18, 4);

            modelBuilder.Entity<v_500_03_BDC户型分摊关联表>()
                .Property(e => e.主体面积合计)
                .HasPrecision(18, 3);

            modelBuilder.Entity<v_500_03_BDC户型分摊关联表>()
                .Property(e => e.附属建筑类别)
                .IsUnicode(false);

            modelBuilder.Entity<v_500_03_BDC户型分摊关联表>()
                .Property(e => e.分摊方式)
                .IsUnicode(false);

            modelBuilder.Entity<v_500_03_BDC户型分摊关联表>()
                .Property(e => e.附属建筑面积)
                .HasPrecision(18, 4);

            modelBuilder.Entity<v_500_03_BDC户型分摊关联表>()
                .Property(e => e.计算比例)
                .HasPrecision(4, 2);

            modelBuilder.Entity<v_500_03_BDC户型分摊关联表>()
                .Property(e => e.附属建筑面积合计)
                .HasPrecision(18, 3);

            modelBuilder.Entity<v_500_03_BDC户型分摊关联表>()
                .Property(e => e.附属建筑ID)
                .IsUnicode(false);

            modelBuilder.Entity<v_99_00_BDC户型表>()
                .Property(e => e.ZRZ号)
                .IsUnicode(false);

            modelBuilder.Entity<v_99_00_BDC户型表>()
                .Property(e => e.LJZ号)
                .IsUnicode(false);

            modelBuilder.Entity<v_99_00_BDC户型表>()
                .Property(e => e.C号)
                .IsUnicode(false);

            modelBuilder.Entity<v_99_00_BDC户型表>()
                .Property(e => e.H型ID)
                .IsUnicode(false);

            modelBuilder.Entity<v_99_00_BDC户型表>()
                .Property(e => e.功能分类ID)
                .IsUnicode(false);

            modelBuilder.Entity<v_99_00_BDC户型表>()
                .Property(e => e.户型面积)
                .HasPrecision(18, 4);

            modelBuilder.Entity<v_99_00_BDC户型表>()
                .Property(e => e.户型面积合计)
                .HasPrecision(38, 4);

            modelBuilder.Entity<v_99_01_BDC户型分摊关联表>()
                .Property(e => e.分摊ID)
                .IsUnicode(false);

            modelBuilder.Entity<v_99_01_BDC户型分摊关联表>()
                .Property(e => e.ZRZ号)
                .IsUnicode(false);

            modelBuilder.Entity<v_99_01_BDC户型分摊关联表>()
                .Property(e => e.LJZ号)
                .IsUnicode(false);

            modelBuilder.Entity<v_99_01_BDC户型分摊关联表>()
                .Property(e => e.C号)
                .IsUnicode(false);

            modelBuilder.Entity<v_99_01_BDC户型分摊关联表>()
                .Property(e => e.H型ID)
                .IsUnicode(false);

            modelBuilder.Entity<v_99_01_BDC户型分摊关联表>()
                .Property(e => e.功能分类ID)
                .IsUnicode(false);

            modelBuilder.Entity<v_99_01_BDC户型分摊关联表>()
                .Property(e => e.套内面积)
                .HasPrecision(18, 4);

            modelBuilder.Entity<v_99_01_BDC户型分摊关联表>()
                .Property(e => e.附属建筑ID)
                .IsUnicode(false);

            modelBuilder.Entity<v_99_01_BDC户型分摊关联表>()
                .Property(e => e.分摊方式ID)
                .IsUnicode(false);

            modelBuilder.Entity<v_99_01_BDC户型分摊关联表>()
                .Property(e => e.附属建筑类别ID)
                .IsUnicode(false);

            modelBuilder.Entity<v_99_01_BDC户型分摊关联表>()
                .Property(e => e.附属建筑面积)
                .HasPrecision(18, 4);

            modelBuilder.Entity<v_99_01_BDC户型分摊关联表>()
                .Property(e => e.计算比例)
                .HasPrecision(4, 2);

            modelBuilder.Entity<v_99_02_BDC附属建筑记录表>()
                .Property(e => e.ZRZ号)
                .IsUnicode(false);

            modelBuilder.Entity<v_99_02_BDC附属建筑记录表>()
                .Property(e => e.LJZ号)
                .IsUnicode(false);

            modelBuilder.Entity<v_99_02_BDC附属建筑记录表>()
                .Property(e => e.C号)
                .IsUnicode(false);

            modelBuilder.Entity<v_99_02_BDC附属建筑记录表>()
                .Property(e => e.附属建筑ID)
                .IsUnicode(false);

            modelBuilder.Entity<v_99_02_BDC附属建筑记录表>()
                .Property(e => e.附属建筑类别ID)
                .IsUnicode(false);

            modelBuilder.Entity<v_99_02_BDC附属建筑记录表>()
                .Property(e => e.分摊方式ID)
                .IsUnicode(false);

            modelBuilder.Entity<v_99_02_BDC附属建筑记录表>()
                .Property(e => e.附属建筑面积)
                .HasPrecision(18, 4);

            modelBuilder.Entity<v_99_02_BDC附属建筑记录表>()
                .Property(e => e.计算比例)
                .HasPrecision(4, 2);

            modelBuilder.Entity<v_99_02_BDC附属建筑记录表>()
                .Property(e => e.附属建筑面积合计)
                .HasPrecision(18, 4);

            modelBuilder.Entity<v_99_03_BDC层分摊处理表>()
                .Property(e => e.ZRZ号)
                .IsUnicode(false);

            modelBuilder.Entity<v_99_03_BDC层分摊处理表>()
                .Property(e => e.LJZ号)
                .IsUnicode(false);

            modelBuilder.Entity<v_99_03_BDC层分摊处理表>()
                .Property(e => e.功能分类ID)
                .IsUnicode(false);

            modelBuilder.Entity<v_99_03_BDC层分摊处理表>()
                .Property(e => e.层分摊面积)
                .HasPrecision(18, 4);

            modelBuilder.Entity<v_files_文件目录>()
                .Property(e => e.项目类别)
                .IsUnicode(false);
        }
    }
}
