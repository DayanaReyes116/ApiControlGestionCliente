using Domain.Enums;
using Domain.Utils;
using System.ComponentModel.DataAnnotations;

namespace Domain.Clientes
{
    public class Clients 
    {
        [Key]
        public long Id { get; set; }

        [Required(ErrorMessage = "Identification is required.")]
        [MaxLength(LengthFieldConstants.LengthIDNumber, ErrorMessage = "Identification. The MaxLength is 20 characteres.")]
        public string Identification { get; set; }

        [Required(ErrorMessage = "FirstName is required.")]
        [MaxLength(LengthFieldConstants.LengthName, ErrorMessage = "FirstName. The MaxLength is 100 characteres.")]
        public string FirstName { get; set; }

        [Required(ErrorMessage = "SecondName is required.")]
        [MaxLength(LengthFieldConstants.LengthName, ErrorMessage = "SecondName. The MaxLength is 100 characteres.")]
        public string SecondName { get; set; }

        [Required(ErrorMessage = "Surname is required.")]
        [MaxLength(LengthFieldConstants.LengthName, ErrorMessage = "Surname. The MaxLength is 100 characteres.")]
        public string Surname { get; set; }

        [MaxLength(LengthFieldConstants.LengthName, ErrorMessage = "SecondSurname. The MaxLength is 100 characteres.")]
        public string SecondSurname { get; set; }
    }
}
