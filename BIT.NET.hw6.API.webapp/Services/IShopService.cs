using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BIT.NET.hw6.API.webapp.Services
{
    public interface IShopService<T>
    {
        List<T> GetAllItems();

        T GetItem(int id);

        void CreateItem(T item);

        void UpdateItem(T item);

        void DeleteItem(int id);

        int Save();

        Task<int> SaveAsync();
    }
}
