﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Model
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class CSDL_CNPMEntities : DbContext
    {
        public CSDL_CNPMEntities()
            : base("name=CSDL_CNPMEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<GiaoVien> GiaoViens { get; set; }
        public virtual DbSet<HocKy> HocKies { get; set; }
        public virtual DbSet<HocSinh> HocSinhs { get; set; }
        public virtual DbSet<Khoi> Khois { get; set; }
        public virtual DbSet<LoaiDiem> LoaiDiems { get; set; }
        public virtual DbSet<Lop> Lops { get; set; }
        public virtual DbSet<LopHoc> LopHocs { get; set; }
        public virtual DbSet<MonHoc> MonHocs { get; set; }
        public virtual DbSet<PhanCongGiangDay> PhanCongGiangDays { get; set; }
        public virtual DbSet<PhuHuynh> PhuHuynhs { get; set; }
        public virtual DbSet<sysdiagram> sysdiagrams { get; set; }
        public virtual DbSet<TienHoc> TienHocs { get; set; }
        public virtual DbSet<TrinhDoHocVan> TrinhDoHocVans { get; set; }
        public virtual DbSet<XepLoai> XepLoais { get; set; }
        public virtual DbSet<XepLoaiHocSinh> XepLoaiHocSinhs { get; set; }
        public virtual DbSet<Diem> Diems { get; set; }
    }
}
