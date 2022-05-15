using Microsoft.AspNetCore.Http;
using System;
using System.ComponentModel.DataAnnotations;

namespace WebAppDulich.Areas.Admin.Models.Tour
{
    public class TourCreateRequest
    {
        [Required(ErrorMessage = "Bạn phải nhập tên sản phẩm")]
        [StringLength(500, ErrorMessage = "tiêu đề tin tức không quá 500 ký tự")]
        public string Name { get; set; }

        [Required(ErrorMessage = "Bạn phải chọn danh mục")]
        public long? CategoryId { get; set; }
        [Required(ErrorMessage = "Bạn phải chọn địa điểm")]
        public long? PlaceId { get; set; }
        public string Logo { get; set; }

        [Required(ErrorMessage = "Bạn phải nhập mô tả sản phẩm")]
        [StringLength(500, ErrorMessage = "tiêu đề tin tức không quá 500 ký tự")]
        public string Description { get; set; }

        [Required(ErrorMessage = "Bạn phải nhập chi tiết sản phẩm")]
        public string Detail { get; set; }

        [Required(ErrorMessage = "Bạn phải nhập giá bán")]
        public decimal? Price { get; set; }
        public decimal? PriceDiscount { get; set; }
        public bool? IsNew { get; set; }
        public DateTime? CreateDate { get; set; }
        public DateTime? EditDate { get; set; }

        [Required(ErrorMessage = "Bạn phải nhập URL")]
        public string Url { get; set; }
        public int? DisplayOrder { get; set; }

        [Required(ErrorMessage = "Bạn phải chọn trạng thái")]
        public int? Status { get; set; }

        public bool IsNewInput
        {
            get => this.IsNew.GetValueOrDefault();
            set { this.IsNew = value; }
        }

        [Required(ErrorMessage = "Chọn một file")]
        [Display(Name = "Chọn file upload")]
        public IFormFile FileUpload { get; set; }

        public string Destination { get; set; }//điểm đến
        public string DeparturePoint { get; set; }//điểm đi
        public string Start { get; set; }//điểm bắt đầu
        public string Vehicle { get; set; } //phương tiện
        public string PlaceName { get; set; }
        public string Time { get; set; }
    }
}
