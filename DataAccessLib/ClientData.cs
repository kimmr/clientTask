using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using DataAccessLib.Models;

namespace DataAccessLib
{
    public class ClientData : IClientData
    {
        private readonly ISqlDataAccess db;

        public ClientData(ISqlDataAccess db)
        {
            this.db = db;
        }

        public Task<List<ClientModel>> GetClient()
        {
            string sql = "select * from dbo.Client";

            return db.LoadData<ClientModel, dynamic>(sql, new { });
        }

        public Task InsertClient(ClientModel client)
        {
            string sql = @"insert into dbo.Client (FirstName, LastName, Email, PhoneNumber)
                            values (@FirstName, @LastName, @Email, @PhoneNumber);";

            return db.SaveData(sql, client);
        }
    }
}
