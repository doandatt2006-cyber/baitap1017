
using System;

namespace baitap1710
{
    public class PhieuMuon
    {
        public string MaPhieu { get; set; }
        public string MaSV { get; set; }
        public string HoTen { get; set; }
        public string ThietBi { get; set; }
        public int SoLuong { get; set; }

        public DateTime NgayMuon { get; set; }
        public DateTime HanTra { get; set; }

        public DateTime? NgayTraThucTe { get; set; }

        public string TrangThai
        {
            get
            {
                if (NgayTraThucTe.HasValue)
                    return "Đã trả";

                if (HanTra.Date < DateTime.Today)
                    return "Quá hạn";

                return "Đang mượn";
            }
        }
    }
}
