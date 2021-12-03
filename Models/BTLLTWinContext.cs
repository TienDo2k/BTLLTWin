using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

#nullable disable

namespace BTLLTWin.Models
{
    public partial class BTLLTWinContext : DbContext
    {
        public BTLLTWinContext()
        {
        }

        public BTLLTWinContext(DbContextOptions<BTLLTWinContext> options)
            : base(options)
        {
        }

        public virtual DbSet<BaoTri> BaoTris { get; set; }
        public virtual DbSet<CthddichVu> CthddichVus { get; set; }
        public virtual DbSet<DatDichVu> DatDichVus { get; set; }
        public virtual DbSet<DatPhong> DatPhongs { get; set; }
        public virtual DbSet<DichVuKhachHang> DichVuKhachHangs { get; set; }
        public virtual DbSet<HddichVu> HddichVus { get; set; }
        public virtual DbSet<HoaDon> HoaDons { get; set; }
        public virtual DbSet<KhachHang> KhachHangs { get; set; }
        public virtual DbSet<LichSuChuyenDo> LichSuChuyenDos { get; set; }
        public virtual DbSet<MenuDichVu> MenuDichVus { get; set; }
        public virtual DbSet<NhaCc> NhaCcs { get; set; }
        public virtual DbSet<NhanVien> NhanViens { get; set; }
        public virtual DbSet<Phong> Phongs { get; set; }
        public virtual DbSet<TaiKhoan> TaiKhoans { get; set; }
        public virtual DbSet<ThietBiVatTu> ThietBiVatTus { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
                optionsBuilder.UseSqlServer("Data Source=DESKTOP-3DSH6JF\\SQLEXPRESS;Initial Catalog=BTLLTWin;Integrated Security=True");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasAnnotation("Relational:Collation", "Vietnamese_CI_AS");

            modelBuilder.Entity<BaoTri>(entity =>
            {
                entity.HasKey(e => e.MaBaoTri)
                    .HasName("PK__BaoTri__51A9CA511B461C93");

                entity.ToTable("BaoTri");

                entity.Property(e => e.MaBaoTri)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.MaPhong)
                    .IsRequired()
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.MaVatTu)
                    .IsRequired()
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.NgayBaoTri).HasColumnType("datetime");

                entity.Property(e => e.NgayBaoTriKeTiep).HasColumnType("datetime");

                entity.Property(e => e.NoiDung).HasMaxLength(200);

                entity.Property(e => e.TenVatTu)
                    .IsRequired()
                    .HasMaxLength(500);

                entity.HasOne(d => d.IdNavigation)
                    .WithMany(p => p.BaoTris)
                    .HasForeignKey(d => d.Id)
                    .HasConstraintName("Fk_BaoTri_vattu");
            });

            modelBuilder.Entity<CthddichVu>(entity =>
            {
                entity.HasKey(e => new { e.MaHd, e.Stt })
                    .HasName("PK__CTHDDich__BB868667F25EB56D");

                entity.ToTable("CTHDDichVu");

                entity.Property(e => e.MaHd)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("MaHD");

                entity.Property(e => e.MaDichVu)
                    .IsRequired()
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.HasOne(d => d.MaDichVuNavigation)
                    .WithMany(p => p.CthddichVus)
                    .HasForeignKey(d => d.MaDichVu)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("Fk_CTHDDichVu_MenuDichVu");

                entity.HasOne(d => d.MaHdNavigation)
                    .WithMany(p => p.CthddichVus)
                    .HasForeignKey(d => d.MaHd)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("Fk_CTHDDichVu_HDDichVu");
            });

            modelBuilder.Entity<DatDichVu>(entity =>
            {
                entity.HasKey(e => new { e.MaDatDv, e.MaDichVu })
                    .HasName("PK__DatDichV__86384A9EB8A6D917");

                entity.ToTable("DatDichVu");

                entity.Property(e => e.MaDatDv)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("MaDatDV");

                entity.Property(e => e.MaDichVu)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.MaNcc)
                    .IsRequired()
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("MaNCC");

                entity.Property(e => e.NgayDatDv)
                    .HasColumnType("date")
                    .HasColumnName("NgayDatDV");

                entity.Property(e => e.Sld).HasColumnName("SLD");

                entity.Property(e => e.TrangThai)
                    .IsRequired()
                    .HasMaxLength(8);

                entity.HasOne(d => d.MaDichVuNavigation)
                    .WithMany(p => p.DatDichVus)
                    .HasForeignKey(d => d.MaDichVu)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("Fk_DatDichVu_MenuDichVu");

                entity.HasOne(d => d.MaNccNavigation)
                    .WithMany(p => p.DatDichVus)
                    .HasForeignKey(d => d.MaNcc)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("Fk_DatDichVu_NhaCC");
            });

            modelBuilder.Entity<DatPhong>(entity =>
            {
                entity.ToTable("DatPhong");

                entity.Property(e => e.Id)
                    .ValueGeneratedNever()
                    .HasColumnName("ID");

                entity.Property(e => e.HoTen)
                    .IsRequired()
                    .HasMaxLength(100);

                entity.Property(e => e.MaPhong)
                    .IsRequired()
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.NgayDatPhong).HasColumnType("date");

                entity.Property(e => e.NgayDi).HasColumnType("date");

                entity.Property(e => e.Sdt)
                    .IsRequired()
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("SDT")
                    .IsFixedLength(true);

                entity.Property(e => e.SoCmnd)
                    .IsRequired()
                    .HasMaxLength(12)
                    .IsUnicode(false)
                    .HasColumnName("SoCMND");

                entity.HasOne(d => d.MaPhongNavigation)
                    .WithMany(p => p.DatPhongs)
                    .HasForeignKey(d => d.MaPhong)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("Fk_DatPhong_Phong");
            });

            modelBuilder.Entity<DichVuKhachHang>(entity =>
            {
                entity.ToTable("DichVuKhachHang");

                entity.Property(e => e.Id)
                    .ValueGeneratedNever()
                    .HasColumnName("ID");

                entity.Property(e => e.MaDichVu)
                    .IsRequired()
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.MaKh)
                    .IsRequired()
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("MaKH");

                entity.Property(e => e.NgaySuDung).HasColumnType("date");

                entity.Property(e => e.TinhTrang)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.HasOne(d => d.MaDichVuNavigation)
                    .WithMany(p => p.DichVuKhachHangs)
                    .HasForeignKey(d => d.MaDichVu)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("Fk_DichVuKhachHang_MenuDichVu");

                entity.HasOne(d => d.MaKhNavigation)
                    .WithMany(p => p.DichVuKhachHangs)
                    .HasForeignKey(d => d.MaKh)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("Fk_DichVuKhachHang_KhachHang");
            });

            modelBuilder.Entity<HddichVu>(entity =>
            {
                entity.HasKey(e => e.MaHd)
                    .HasName("PK__HDDichVu__2725A6E003DAFC80");

                entity.ToTable("HDDichVu");

                entity.Property(e => e.MaHd)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("MaHD");

                entity.Property(e => e.NgayLap).HasColumnType("date");

                entity.Property(e => e.TenHd)
                    .IsRequired()
                    .HasMaxLength(100)
                    .HasColumnName("TenHD");
            });

            modelBuilder.Entity<HoaDon>(entity =>
            {
                entity.HasKey(e => e.MaHd)
                    .HasName("PK__HoaDon__2725A6E06F8F025F");

                entity.ToTable("HoaDon");

                entity.Property(e => e.MaHd)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("MaHD");

                entity.Property(e => e.MaKh)
                    .IsRequired()
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("MaKH");

                entity.Property(e => e.MaPhong)
                    .IsRequired()
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.NgayDen).HasColumnType("datetime");

                entity.Property(e => e.NgayDi).HasColumnType("datetime");

                entity.Property(e => e.TtthanhToan)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasColumnName("TTThanhToan");

                entity.HasOne(d => d.MaKhNavigation)
                    .WithMany(p => p.HoaDons)
                    .HasForeignKey(d => d.MaKh)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("Fk_HoaDon_KhachHang");

                entity.HasOne(d => d.MaPhongNavigation)
                    .WithMany(p => p.HoaDons)
                    .HasForeignKey(d => d.MaPhong)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("Fk_HoaDon_Phong");
            });

            modelBuilder.Entity<KhachHang>(entity =>
            {
                entity.HasKey(e => e.MaKh)
                    .HasName("PK__KhachHan__2725CF1E281068FF");

                entity.ToTable("KhachHang");

                entity.Property(e => e.MaKh)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("MaKH");

                entity.Property(e => e.DiaChi)
                    .IsRequired()
                    .HasMaxLength(500);

                entity.Property(e => e.Sdt)
                    .IsRequired()
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("SDT")
                    .IsFixedLength(true);

                entity.Property(e => e.SoCmnd)
                    .HasMaxLength(12)
                    .IsUnicode(false)
                    .HasColumnName("SoCMND");

                entity.Property(e => e.TenKh)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasColumnName("TenKH");
            });

            modelBuilder.Entity<LichSuChuyenDo>(entity =>
            {
                entity.HasKey(e => e.MaLichSu)
                    .HasName("PK__LichSuCh__C443222AF238E1E0");

                entity.ToTable("LichSuChuyenDo");

                entity.Property(e => e.MaLichSu).ValueGeneratedNever();

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.MaPhong)
                    .IsRequired()
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.MaVatTu)
                    .IsRequired()
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.NgayChuyenDi).HasColumnType("datetime");

                entity.Property(e => e.NgayChuyenVao).HasColumnType("datetime");

                entity.Property(e => e.Sl).HasColumnName("SL");

                entity.Property(e => e.TenVatTu)
                    .IsRequired()
                    .HasMaxLength(500);

                entity.Property(e => e.TinhTrang)
                    .IsRequired()
                    .HasMaxLength(20);

                entity.HasOne(d => d.IdNavigation)
                    .WithMany(p => p.LichSuChuyenDos)
                    .HasForeignKey(d => d.Id)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("Fk_LichSuChuyenDo_vattu");
            });

            modelBuilder.Entity<MenuDichVu>(entity =>
            {
                entity.HasKey(e => e.MaDichVu)
                    .HasName("PK__MenuDich__C0E6DE8F94772A34");

                entity.ToTable("MenuDichVu");

                entity.Property(e => e.MaDichVu)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.Slc).HasColumnName("SLC");

                entity.Property(e => e.TenDichVu)
                    .IsRequired()
                    .HasMaxLength(200);
            });

            modelBuilder.Entity<NhaCc>(entity =>
            {
                entity.HasKey(e => e.MaNcc)
                    .HasName("PK__NhaCC__3A185DEBD6710537");

                entity.ToTable("NhaCC");

                entity.Property(e => e.MaNcc)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("MaNCC");

                entity.Property(e => e.DiaChi)
                    .IsRequired()
                    .HasMaxLength(500);

                entity.Property(e => e.TenNcc)
                    .IsRequired()
                    .HasMaxLength(500)
                    .HasColumnName("TenNCC");
            });

            modelBuilder.Entity<NhanVien>(entity =>
            {
                entity.HasKey(e => e.MaNv)
                    .HasName("PK__NhanVien__2725D70A1A7237A2");

                entity.ToTable("NhanVien");

                entity.Property(e => e.MaNv)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("MaNV");

                entity.Property(e => e.ChucVu).HasMaxLength(50);

                entity.Property(e => e.DiaChi).HasMaxLength(500);

                entity.Property(e => e.DienThoai)
                    .HasMaxLength(10)
                    .IsFixedLength(true);

                entity.Property(e => e.Email).HasMaxLength(50);

                entity.Property(e => e.GioiTinh).HasMaxLength(5);

                entity.Property(e => e.TenNv)
                    .HasMaxLength(50)
                    .HasColumnName("TenNV");
            });

            modelBuilder.Entity<Phong>(entity =>
            {
                entity.HasKey(e => e.MaPhong)
                    .HasName("PK__Phong__20BD5E5BE82FE9A0");

                entity.ToTable("Phong");

                entity.Property(e => e.MaPhong)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.LoaiPhong)
                    .IsRequired()
                    .HasMaxLength(20);

                entity.Property(e => e.TenPhong)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.TinhTrang)
                    .IsRequired()
                    .HasMaxLength(20);
            });

            modelBuilder.Entity<TaiKhoan>(entity =>
            {
                entity.HasKey(e => e.MaNv)
                    .HasName("PK__TaiKhoan__2725D70A88B4438B");

                entity.ToTable("TaiKhoan");

                entity.Property(e => e.MaNv)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("MaNV");

                entity.Property(e => e.MatKhau)
                    .IsRequired()
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.HasOne(d => d.MaNvNavigation)
                    .WithOne(p => p.TaiKhoan)
                    .HasForeignKey<TaiKhoan>(d => d.MaNv)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("Fk_TaiKhoan_NhanVien");
            });

            modelBuilder.Entity<ThietBiVatTu>(entity =>
            {
                entity.ToTable("ThietBiVatTu");

                entity.Property(e => e.Id)
                    .ValueGeneratedNever()
                    .HasColumnName("ID");

                entity.Property(e => e.MaPhong)
                    .IsRequired()
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.MaVatTu)
                    .IsRequired()
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.NgayChuyenVao).HasColumnType("datetime");

                entity.Property(e => e.Sl).HasColumnName("SL");

                entity.Property(e => e.TenVatTu)
                    .IsRequired()
                    .HasMaxLength(500);

                entity.Property(e => e.TinhTrang)
                    .IsRequired()
                    .HasMaxLength(20);

                entity.HasOne(d => d.MaPhongNavigation)
                    .WithMany(p => p.ThietBiVatTus)
                    .HasForeignKey(d => d.MaPhong)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("Fk_ThietBiVatTu_Phong");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
