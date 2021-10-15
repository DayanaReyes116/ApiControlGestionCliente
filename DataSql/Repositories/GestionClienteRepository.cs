using Dapper;
using Domain.Clientes;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Threading.Tasks;

namespace DataSql.Repositories
{
    public class GestionClienteRepository : IGestionClienteRepository
    {
        private readonly string _connectionStrings;
        private readonly IConfiguration _configuration;

        //inyectar serviio de configuracion en el constructor 
        public GestionClienteRepository(IConfiguration configuration)
        {
            _configuration = configuration;
            _connectionStrings = _configuration.GetSection("ConnectionStrings:connectionDb").Value;
        }
        
        public async Task<List<Clients>> GetClientById(long clientId)
        {
            await using (var connection = new SqlConnection(_connectionStrings))
            {
                connection.Open();
                using (var transaction = connection.BeginTransaction())
                {
                    try
                    {
                        var clientes = (await connection.QueryAsync<Clients>(
                           @"select c.*
                                    FROM Client c 
                                    WHERE c.Id = @Id"
                                , new { @Id = clientId }
                                , transaction
                            )).AsList();

                        transaction.Commit();
                        return clientes;
                    }
                    catch (Exception ex)
                    {
                        transaction.Rollback();

                        throw;
                    }
                }
            }
        }

        public Task<string> UpdateClient(long id, Clients cliente)
        {
            throw new NotImplementedException();
        }

        public Task<string> AddClient(Clients cliente)
        {
            throw new NotImplementedException();
        }

        public Task<string> DeleteClient(long id)
        {
            throw new NotImplementedException();
        }
    }
}
