using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Clientes
{
    public interface IGestionClienteRepository
    {
        Task<List<Clients>> GetClientById(long id);
        Task<string> AddClient(Clients cliente);
        Task<string> UpdateClient(long id, Clients cliente);
        Task<string> DeleteClient(long id);
    }
}
