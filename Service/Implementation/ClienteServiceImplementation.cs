using AppVendasBlazor.Data.Context;
using AppVendasBlazor.Model;
using Microsoft.EntityFrameworkCore;

namespace AppVendasBlazor.Service.Implementation
{
    public class ClienteServiceImplementation:IClienteService
    {
        private readonly SQLServerContext _context;

        public ClienteServiceImplementation(SQLServerContext context )
        {
            _context = context;
        }


        public async Task<Cliente> ObterPorIdAsync(int id)
        {
            return await _context.Clientes.FindAsync(id);
        }

        public async Task<IEnumerable<Cliente>> ObterTodosAsync()
        {
            return await _context.Clientes.ToListAsync();
        }
        public async Task AdicionarAsync(Cliente cliente)
        {
            await _context.Clientes.AddAsync(cliente);
            await _context.SaveChangesAsync();
        }

        public async Task AlterarAsync(Cliente cliente)
        {
            _context.Clientes.Update(cliente);
            await _context.SaveChangesAsync();
        }

        public async Task ExcluirAsync(int Id)
        {
            var cliente = await _context.Clientes.FindAsync(Id);
            if (cliente != null)
            {
                _context.Clientes.Remove(cliente);
                await _context.SaveChangesAsync();
            }
          
            
        }

       
    }
}
