using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BIT.NET.hw6.API.webapp.Data;
using Microsoft.EntityFrameworkCore;

namespace BIT.NET.hw6.API.webapp.Services
{
    public class ShopService<T> : IShopService<T> where T : Item
    {
        private Context _context;
        public ShopService(Context context)
        {
            _context = context;
        }
        public void CreateItem(T item)
        {           
            _context.Add(item);
        }

        public void DeleteItem(int id)
        {
            var item = GetItem(id);

            if (item != null)
            {
                _context.Remove(item);
            }
        }

        public List<T> GetAllItems()
        {
            return _context.Set<T>().ToList<T>();
        }

        public T GetItem(int id)
        {
            return GetAllItems().SingleOrDefault(e => e.Id == id);
        }

        public int Save()
        {
            return _context.SaveChanges();
        }

        public Task<int> SaveAsync()
        {
            return _context.SaveChangesAsync();
        }

        public void UpdateItem(T item)
        {            
            _context.Set<T>().Attach(item);
            _context.Entry(item).State = EntityState.Modified;
        }
    }
}
