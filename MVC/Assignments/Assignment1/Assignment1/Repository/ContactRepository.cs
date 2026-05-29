using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;
using System.Threading.Tasks;
using Assignment1.Models;

namespace Assignment1.Repository
{
    public class ContactRepository : IRepository<Contact>
    {
        ContactContext db;
        DbSet<Contact> dbset;

        public ContactRepository()
        {
            db = new ContactContext();
            dbset = db.Set<Contact>();
        }

        public async Task<List<Contact>> GetAllAsync()
        {
            return await dbset.ToListAsync();
        }

        public async Task<Contact> GetByIdAsync(object id)
        {
            return await dbset.FindAsync(id);
        }

        public async Task InsertAsync(Contact obj)
        {
            dbset.Add(obj);
            await SaveAsync();
        }

        public async Task DeleteAsync(object id)
        {
            Contact c = await dbset.FindAsync(id);

            if (c != null)
            {
                dbset.Remove(c);
                await SaveAsync();
            }
        }

        public async Task SaveAsync()
        {
            await db.SaveChangesAsync();
        }
    }
}