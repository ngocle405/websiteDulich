using Microsoft.AspNetCore.Http;
using System;
using System.ComponentModel.DataAnnotations;

namespace WebApp_01.Areas.Admin.Models.Tour
{
    public class TourUpdateRequest
    {
        public long Id { get; set; }
        [Required(ErrorMessage = "Bạn phải nhập mã")]
        public string Code { get; set; }

        [Required(ErrorMessage = "Bạn phải nhập tên sản phẩm")]
        [StringLength(500, ErrorMessage = "tên sản phẩm không quá 500 ký tự")]
        public string Name { get; set; }

        [Required(ErrorMessage = "Bạn phải chọn danh mục")]
        public long? CategoryId { get; set; }
        [Required(ErrorMessage = "Bạn phải chọn địa điểm")]
        public long? PlaceId { get; set; }
        public string Logo { get; set; }

        [Required(ErrorMessage = "Bạn phải nhập mô tả sản phẩm")]
        public string Description { get; set; }

      

        [Required(ErrorMessage = "Bạn phải nhập giá bán")]
        public decimal? Price { get; set; }
        public decimal? PriceDiscount { get; set; }
        public bool? IsNew { get; set; }
        public DateTime? CreateDate { get; set; }
        public DateTime? EditDate { get; set; }

        [Required(ErrorMessage = "Bạn phải nhập URL")]
        public string Url { get; set; }
        public int? DisplayOrder { get; set; }

       
        public int? Status { get; set; }
        public bool IsNewInput
        {
            get => this.IsNew.GetValueOrDefault();
            set { this.IsNew = value; }
        }
        public IFormFile FileUpload { get; set; }
        [Required(ErrorMessage = "Bạn phải nhập điểm đến")]
        public string Destination { get; set; }//điểm đến
        [Required(ErrorMessage = "Bạn phải nhập điểm xuất phát")]
        public string DeparturePoint { get; set; }//điểm đi
        [Required(ErrorMessage = "Bạn phải nhập ngày xuất phát")]
        [DisplayFormat(DataFormatString = "{0:dd/MM/yyyy}", ApplyFormatInEditMode = true)]
        public DateTime Start { get; set; }// bắt đầu từ ngày nào
        [Required(ErrorMessage = "Bạn phải nhập phương tiện")]
        public string Vehicle { get; set; } //phương tiện

        public string PlaceName { get; set; }
        [Required(ErrorMessage = "Bạn phải nhập thời gian đi trong bao lâu")]
        public string Time { get; set; }
    }
}
