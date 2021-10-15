using Domain.Enums;
using System.Collections.Generic;

namespace Application.Clientes.DTO
{
    public class ClienteInputDTO
    {
        public long Id { get; set; }
        public string Identification { get; set; }
        public string FirstName { get; set; }
        public string SecondName { get; set; }
        public string Surname { get; set; }
        public string SecondSurname { get; set; }
    }
}
