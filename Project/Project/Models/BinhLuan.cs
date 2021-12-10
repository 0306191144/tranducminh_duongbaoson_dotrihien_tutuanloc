using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Project.Models
{
    public class BinhLuan
    {
        public int BinhLuanId { get; set; }
        public int BaiVietId { get; set; }
        public BaiViet BaiViet { get; set; }
        public string NoiDungBinhLuan { get; set; }
        public DateTime date { get; set; }
        public int TaiKhoanId { get; set; }
        public TaiKhoan TaiKhoan { get; set; }
    }
}
