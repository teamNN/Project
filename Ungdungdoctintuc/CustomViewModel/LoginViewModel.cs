using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Ungdungdoctintuc.CustomViewModel
{
    public class LoginViewModel
    {
        [Display(Name ="Tên đăng nhập")]
        [Required(ErrorMessage ="Phải nhập tên đăng nhập")]
        public string UserName { get; set; }

        [Display(Name = "Mật khẩu")]
        [Required(ErrorMessage = "Phải nhập mật khẩu")]
        public string passWord { get; set; }
    }
}