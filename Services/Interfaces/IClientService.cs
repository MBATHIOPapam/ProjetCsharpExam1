using System.Collections.Generic;
using ProjetCsharpExamMbathio.Models.Entities;

namespace ProjetCsharpExamMbathio.Services.Interfaces
{
    public interface IClientService
    {
        void CreateClient(Client client);
        Client GetClientById(int id);
        IEnumerable<Client> GetAllClients();
        void UpdateClient(Client client);
        void DeleteClient(int id);
    }
}

