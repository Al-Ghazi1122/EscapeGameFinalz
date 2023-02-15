using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EscapeGame
{
    internal class Item
    {
        protected string ItemName { get; set; }
        protected string ItemDescription { get; set; }

        public Item()
        {
            ItemName = "Item 1";
            ItemDescription = "description";
        }
        public Item(string name, string description)
        {
            ItemName = name;
            ItemDescription = description;
        }
        public string getItemDetails()
        {
            return ("This is a " + ItemName + ". " + ItemDescription);
        }
    }// End of Item Class

    class Key : Item
    {
        private string Colour { get; set; }

        public Key()
        {
            ItemName = "Key 1";
            ItemDescription = "This is a key that can be used to open a door";
            Colour = "blue";
        }
        public Key(string name, string description = "This is a key that can be used to open a door", string colour = "red")
        {
            ItemName = name;
            ItemDescription = description;
            Colour = colour;
        }
        public string getKeyDetails()
        {
            return ("This is a " + Colour + " " + ItemName + ". " + ItemDescription);
        }
    }//End of key Class
}
