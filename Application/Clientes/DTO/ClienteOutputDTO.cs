using AutoMapper;
using Domain.Clientes;

namespace Application.Clientes.DTO
{
    [AutoMap(typeof(Clients), ReverseMap = true)]
    public class ClienteOutputDTO
    {   
        public long Id { get; set; }
        public string Identification { get; set; }
        public string FirstName { get; set; }
        public string SecondName { get; set; }
        public string Surname { get; set; }
        public string SecondSurname { get; set; }
    }
}
