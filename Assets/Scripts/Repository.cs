using System.Collections.Generic;
using System.Threading.Tasks;
using UnityEngine;

namespace RepositoryPattern
{
    // Repository class that contains a DataContext object
    // And methods for getting all items, getting price of an item, adding an item, deleting an item, and saving data
    public class Repository : MonoBehaviour {
        public DataContext context;
    
        private List<Item> Entities => context.Set();

        public async Task<List<Item>> GetAllItems() {
            await context.Load();
            return Entities;  
        }

        public float GetPrice(int id) {
            var i = Entities.Find(x => x.ID == id);
            return i.Price;
        }
    
        public void Add(Item item) {
            Entities.Add(item);
        }
    
        public void Delete(int id) {
            var item = Entities.Find(x => x.ID == id);
            if (item != null) {
                Entities.Remove(item);
            }
        }

        public async Task Save() {
            await context.Save();
        }
    }
}