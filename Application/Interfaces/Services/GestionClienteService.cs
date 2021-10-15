using Application.Clientes.DTO;
using AutoMapper;
using Domain.Clientes;
using Domain.Exceptions;
using System.Linq;
using System.Threading.Tasks;

namespace Application.Interfaces.Services
{
    public class GestionClienteService : IGestionClienteService
    {
        private readonly IMapper _mapper;
        private readonly IGestionClienteRepository _gestionClienteRepository;

        /// <summary>
        /// Método constructor de los servicios.
        /// </summary>
        /// <param name="mapper">Inyección del objeto para mapear objetos</param>
        public GestionClienteService(IGestionClienteRepository gestionClienteRepository, IMapper mapper)
        {
            _gestionClienteRepository = gestionClienteRepository;
            _mapper = mapper;
        }

        public async Task<ClienteOutputDTO> GetClientByIdtAsync(long clientId)
        {
            var clientesDB = await _gestionClienteRepository.GetClientById(clientId);
            if (clientesDB != null)
            {
                var client = _mapper.Map<ClienteOutputDTO>(clientesDB);
                return client;
               
            }
            else
                throw new GestionClienteException("Client Not Found.");
        }

        public async Task<ClienteOutputDTO> AddClientAsync(ClienteInputDTO clienteInput)
        {
            var exist = await _gestionClienteRepository.GetClientById(clienteInput.Id);

            if (exist != null)
            {
                var client = _mapper.Map<Clients>(clienteInput);
                var res = await _gestionClienteRepository.AddClient(client);

                return await GetClientByIdtAsync(clienteInput.Id);
            }
            else
                throw new GestionClienteException("The client is already registered..");
        }
        public async Task<ClienteOutputDTO> UpdateClientAsync(long clientId,ClienteInputDTO clienteInput)
        {
            var objFind = _gestionClienteRepository.GetClientById(clientId);

            if (objFind == null)
            {
                throw new HttpResponseException
                {
                    Status = 404,
                    Value = $"The Client with the ID {clientId} was not found."
                };
            }
            var client = _mapper.Map<Clients>(clienteInput);
            var objUpdate = await _gestionClienteRepository.UpdateClient(clientId, client);
            return _mapper.Map<ClienteOutputDTO>(objUpdate);
        }

        public async Task DeleteClientAsync(long id)
        {
            var exist = await _gestionClienteRepository.GetClientById(id);

            if (exist != null)
            {
                await _gestionClienteRepository.DeleteClient(id);
            }
            else
                throw new GestionClienteException("Client Not Found.");
        }

    }
}
