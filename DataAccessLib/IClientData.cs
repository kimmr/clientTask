using System.Collections.Generic;
using System.Threading.Tasks;
using DataAccessLib.Models;

namespace DataAccessLib
{
    public interface IClientData
    {
        Task<List<ClientModel>> GetClient();
        Task InsertClient(ClientModel client);
    }
}