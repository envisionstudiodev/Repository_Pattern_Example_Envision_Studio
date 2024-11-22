using System.Collections.Generic;
using System.Threading.Tasks;
using UnityEngine;

namespace RepositoryPattern
{
    // DataContext class that contains a GameData object
    // And abstract methods for loading and saving data
    public abstract class DataContext : MonoBehaviour {
        public GameData data = new GameData(); // public List<Item> Items;

        public abstract Task Load();
        public abstract Task Save();
    
        public List<Item> Set() {
            // if (data != null) {
            //     Debug.Log("return data.Items as List<Item>;");
            // }
            // else {
            //     Debug.Log("Cannot set data as List<Item>;");
            // }
        
            return data.Items;
        }
    }
}