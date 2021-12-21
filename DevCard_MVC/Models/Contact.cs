using System.ComponentModel.DataAnnotations;

namespace DevCard_MVC.Models
{
    public class Contact
    {
        [Required(ErrorMessage = "این فیلد اجباریست")]
        [DataType(DataType.Text)]
        [MinLength(3)]
        [MaxLength(50)]
        [Display(Name = "نام")]
        public string Name { get; set; }

        [Required(ErrorMessage = "این فیلد اجباریست")]
        [EmailAddress(ErrorMessage = "لطفا آدرس ایمیل صحیحی وارد کنید")]
        [MaxLength(70)]
        [Display(Name = "آدرس ایمیل")]
        public string Email { get; set; }

        [Required(ErrorMessage = "این فیلد اجباریست")]
        [DataType(DataType.Text)]
        [MaxLength(1000)]
        [Display(Name = "پیام")]
        public string Message { get; set; }

        [Required(ErrorMessage = "این فیلد اجباریست")]
        public string Service { get; set; }
    }
}
