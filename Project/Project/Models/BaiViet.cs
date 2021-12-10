using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Project.Models
{
    public class BaiViet
    {
        public int BaiVietId { get; set; }
        public int TaiKhoanId { get; set; }
        public TaiKhoan TaiKhoan { get; set; }
        public int ChuDeId { get; set; }
        public ChuDe ChuDe { get; set; }

        public string TenBaiViet { get; set; }
        public string NoiDungBaiViet { get; set; }
        public DateTime date { get; set; }
        public List<BinhLuan> BinhLuans { get; set; }


    }
}
