using eCommerce.Api.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace eCommerce.Api.Repositories.Interfaces
{
    public interface IUserRepository
    {
        public Task<List<Usuario>> Get();
        public Task<Usuario> Get(int id);
        public Task<Usuario> GetMultiple(int id);
        public Task<Usuario> Insert(Usuario user);
        public Task<Usuario> Update(Usuario user);
        public Task<bool> Delete(int id);
    }
}
