using System.ComponentModel.DataAnnotations;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebTruyen.Models
{
    public class Truyen
    {
        [Key]
        [Required]
        public int TruyenId { get; set; }
        [Required(ErrorMessage ="thiếu tên truyện")]
        public string TenTruyen { get; set; }
        [Required(ErrorMessage ="thiếu chú thích")]
        public string ChuThich { get; set; }
        [Required(ErrorMessage ="thiếu trạng thái")]
        public string TrangThai { get; set; }
        [Required(ErrorMessage ="thiếu thể loại")]
        public string TheLoai { get; set; }
        [Required(ErrorMessage ="thiếu số chương")]
        public int SoChuong { get; set; }
        public string ImageUrl { get; set; }
    }
}
