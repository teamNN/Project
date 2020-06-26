using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Ungdungdoctintuc.CustomViewModel
{
    public class Regist
    {
        [Display(Name ="Tên người dùng")]
        [Required(ErrorMessage = "Yêu cầu nhập tên người dùng")]
        public string DisplayName { get; set; }

        [Display(Name = "Tên đăng nhập")]
        [Required(ErrorMessage ="Yêu cầu nhập họ tên")]
        public string UserName { get; set; }

        [Display(Name = "Mật khẩu")]
        [StringLength(20,MinimumLength =6,ErrorMessage ="Độ dài ít nhất 6 kí tự")]
        [Required(ErrorMessage = "Yêu cầu nhập mật khẩu")]
        public string Password { get; set; }

        [Display(Name = "Nhập lại mật khẩu")]
        [Compare("Password",ErrorMessage ="Mật khẩu xác nhận sai")]
        [Required(ErrorMessage = "Yêu cầu nhập lại mật khẩu")]
        public string rePassword { get; set; }
    }
}