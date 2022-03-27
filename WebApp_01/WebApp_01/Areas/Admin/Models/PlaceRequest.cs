using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace WebApp_01.Areas.Admin.Models
{
    public class PlaceRequest
    {
        public long Id { get; set; }
        [Required(ErrorMessage = "Bạn phải nhập tên địa điểm")]
        public string PlaceName { get; set; }
        public string Description { get; set; }
        [Required(ErrorMessage = "Bạn phải chọn trạng thái")]
        public int Status { get; set; }
        public bool ShowHomeInput
        {
            get => this.ShowHome.GetValueOrDefault();
            set { this.ShowHome = value; }
        }
        public bool? ShowHome { get; set; }
    }
}
