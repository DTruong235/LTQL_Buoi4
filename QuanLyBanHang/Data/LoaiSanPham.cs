using Microsoft.EntityFrameworkCore.ChangeTracking;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyBanHang.Data
{
    public class LoaiSanPham
    {
        public int Id { get; set; }
        public string TenLoai { get; set; }

        public virtual ObservableCollectionListSource<SanPham> SanPham { get; } = new();
    }
}
