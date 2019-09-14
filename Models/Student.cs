using System.ComponentModel.DataAnnotations;

namespace CourseAPp.Models
{
    public class Student
    {   
        [Required(ErrorMessage="İsminizi Giriniz")]
        public string Name { get; set; }
        [Required(ErrorMessage="Emailinizi Giriniz")]
        [EmailAddress(ErrorMessage="Email adresi yanlış")]
        public string Email { get; set; }
        [Required(ErrorMessage="Telefon numaranızı Giriniz")]
        public string Phone { get; set; }
        [Required(ErrorMessage="Katılım durumunuzu Giriniz")]
        public bool? Confirm { get; set; } //true false, null
    }
}