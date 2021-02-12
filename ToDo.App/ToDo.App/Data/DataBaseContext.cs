using SQLite;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using ToDo.App.Models;

namespace ToDo.App.Data
{
    public class DataBaseContext
    {
        public readonly SQLiteAsyncConnection Connection;
        public DataBaseContext(string path)
        {
            Connection = new SQLiteAsyncConnection(path);
            Connection.CreateTableAsync<ToDoItem>().Wait();
        }

        //Method Insert
        public async Task<int> InsertItemAsync(ToDoItem item)
        {
            return await Connection.InsertAsync(item);
        }

        //Method List View
        public async Task<List<ToDoItem>> GetItemsAsync()
        {
            return await Connection.Table<ToDoItem>().ToListAsync();
        }

        //Method delete
        public async Task<int> DeleteItemAzync(ToDoItem item)
        {
            return await Connection.DeleteAsync(item);
        }
    }
}
