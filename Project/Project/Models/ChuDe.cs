using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Project.Models
{
    public class ChuDe
    {
        public int ChudeId { get; set; }
        public string TenChuDe { get; set; }
        public string Motachude { get; set; }
        public List<BaiViet> BaiViets { get; set; }


    }
}
