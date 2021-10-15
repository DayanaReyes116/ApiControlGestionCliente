using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System.Threading.Tasks;
using System;
using Application.Interfaces.Services;
using Application.Clientes.DTO;
using System.Linq;
using Domain.Clientes;
using System.Collections.Generic;
using Api.Communication;

namespace Api.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class GestionController : Controller
    { 
        private readonly IGestionClienteService _gestionService;
        private readonly ILogger<GestionController> _logger;
       
        public GestionController(IGestionClienteService gestionService, ILogger<GestionController> logger)
        {
            _gestionService = gestionService;
            _logger = logger;
        }

        /// <summary>
        ///  Client
        /// </summary>
        /// <param name="clientId"></param>
        /// <returns></returns>
        [HttpPost("GetClient/{clientId}")]
        [ProducesResponseType(StatusCodes.Status403Forbidden)]
        [ProducesResponseType(StatusCodes.Status401Unauthorized)]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public async Task<ActionResult<IEnumerable<ClienteOutputDTO>>> GetClientAsync(long clientId)
        {
            _logger.LogInformation("Se inicia servicio: GetClient");
            try
            {
                var clientDTO = await _gestionService.GetClientByIdtAsync(clientId);

                if (clientDTO != null)
                {
                    return new OkObjectResult(new ResultResponse(clientDTO));
                }
                else
                {
                    return new NotFoundObjectResult(new ResultResponse(new Exception("The Client Not Found.")) { Message = "The Client Not Found." });
                }

            }
            catch (Exception ex)
            {
                return new NotFoundObjectResult(new Exception("The Client Not Found.", ex));
            };
        }

        /// <summary>
        /// Add cliente
        /// </summary>
        /// <param name="clientInputDto"></param>
        /// <returns></returns>
        [HttpPost("AddClient")]
        [ProducesResponseType(typeof(ClienteInputDTO), StatusCodes.Status403Forbidden)]
        [ProducesResponseType(typeof(ClienteInputDTO), StatusCodes.Status401Unauthorized)]
        [ProducesResponseType(typeof(ClienteInputDTO), StatusCodes.Status200OK)]
        [ProducesResponseType(typeof(ClienteInputDTO), StatusCodes.Status404NotFound)]
        public async Task<ActionResult<ClienteOutputDTO>> AddClientAsync([FromBody] ClienteInputDTO clientInput)
        {
            _logger.LogInformation("Se inicia servicio: AddClientAsync");
            try
            {
                var clientDTO = await _gestionService.AddClientAsync(clientInput);
               
                if (clientDTO != null)
                {
                    return new OkObjectResult(new ResultResponse(clientDTO) { Message = "The client has been added successfully." });
                }
                else
                {
                    return new NotFoundObjectResult(new ResultResponse(new Exception("The client has not added successfully.")) { Message = "The client has not added successfully." });
                }
            }
          
            catch (Exception ex)
            {
                return new NotFoundObjectResult(new Exception("The Client  has not added successfully.", ex));
            }
        }

        /// <summary>
        /// Put Api/ Update client
        /// </summary>
        /// <param name="id"></param>
        /// <param name="ClienteInputDTO"></param>
        /// <returns></returns>
        [HttpPut("UpdateClient/{id}")]
        [ProducesResponseType(typeof(ClienteInputDTO), StatusCodes.Status403Forbidden)]
        [ProducesResponseType(typeof(ClienteInputDTO), StatusCodes.Status401Unauthorized)]
        [ProducesResponseType(typeof(ClienteInputDTO), StatusCodes.Status200OK)]
        [ProducesResponseType(typeof(ClienteInputDTO), StatusCodes.Status404NotFound)]
        public async Task<ActionResult<ClienteOutputDTO>> UpdateUnionTemporary(long id, ClienteInputDTO clientInput)
        {
            _logger.LogInformation("Se inicia servicio: UpdateUnionTemporary");
            try
            {
                var ClienteDTO = await _gestionService.UpdateClientAsync(id, clientInput);
                if (ClienteDTO != null)
                {
                    return new OkObjectResult(new ResultResponse(ClienteDTO) { Message = "The Client has been update successfully." });
                }
                else
                {
                    return new NotFoundObjectResult(new ResultResponse(new Exception("The Client has not update successfully.")) { Message = "The Client has not update successfully." });
                }
            }
            catch (Exception ex)
            {
                return new NotFoundObjectResult(new ResultResponse(new Exception("The Client has not update successfully.", ex)) { Message = "The Clienty has not update successfully." });
            }
        }

        /// <summary>
        /// Delete Client
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        [HttpDelete("DeleteClient/{id}")]
        [ProducesResponseType(typeof(long), StatusCodes.Status403Forbidden)]
        [ProducesResponseType(typeof(long), StatusCodes.Status401Unauthorized)]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(typeof(long), StatusCodes.Status404NotFound)]
        public async Task<ActionResult> DeleteClientAsync(long id)
        {
            _logger.LogInformation("Se inicia servicio: DeleteClient");
            try
            {
                await _gestionService.DeleteClientAsync(id);

                return new OkObjectResult(new ResultResponse(id) { Message = "The client has been deleted successfully." });
            }
            catch (Exception ex)
            {
                return new NotFoundObjectResult(new Exception("The Client  has  not deleted successfully.", ex));
            }

        }
    }
}
