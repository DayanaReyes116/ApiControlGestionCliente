using Application.Clientes.DTO;
using Domain.Clientes;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Application.Interfaces.Services
{
    public interface IGestionClienteService
    {
        Task<ClienteOutputDTO> GetClientByIdtAsync(long clientId);
        Task<ClienteOutputDTO> AddClientAsync(ClienteInputDTO clienteInput);
        Task<ClienteOutputDTO> UpdateClientAsync(long clientId, ClienteInputDTO clienteyInput);
        Task DeleteClientAsync(long id);

    }
}
