using System;
using System.ComponentModel.DataAnnotations;

namespace lab10.Models
{
    public class Consultation
    {
        [Required(ErrorMessage = "Будь ласка, введіть ваше ім'я та прізвище.")]
        public string FullName { get; set; }

        [Required(ErrorMessage = "Будь ласка, введіть ваш Email.")]
        [EmailAddress(ErrorMessage = "Неправильний формат Email.")]
        public string Email { get; set; }

        [Required(ErrorMessage = "Будь ласка, виберіть дату консультації.")]
        [DataType(DataType.Date)]
        [FutureDate(ErrorMessage = "Дата повинна бути в майбутньому.")]
        public DateTime ConsultationDate { get; set; }

        [Required(ErrorMessage = "Будь ласка, виберіть продукт.")]
        public string Product { get; set; }
    }
}
