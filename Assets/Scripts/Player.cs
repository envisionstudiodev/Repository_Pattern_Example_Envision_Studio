using System.Collections.Generic;

namespace RepositoryPattern
{
    public class Player
    {
        public string Name;
        public float Money;
        public List<Item> Inventory;

        public Player(string name, int money) {
            Name = name;
            Money = money;
        }
    }
}
