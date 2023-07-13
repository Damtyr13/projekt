using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListaZakupów
{

    class ItemManager
    {
        private List<ShoppingItem> itemList;

        public int Count {

            get
            {
                return itemList.Count;
            }
        }

        public ItemManager()
        {
            itemList = new List<ShoppingItem>();

        }

        public ShoppingItem GetItem(int index)
        {
            if (!CheckIndex(index))
                return null;

            return itemList[index];
        }

        public bool AddItem(ShoppingItem itemIn)
        {
            bool ok = false;

            if(itemIn != null)
            {
                itemList.Add(itemIn);
                ok = true;
            }

            return ok;
        } 
        private bool CheckIndex(int index)
        {
            bool ok = false;

            if((index >= 0) && index < Count)
            {
                ok = true;
            }

            return ok;
        } 
        public bool ChangeItem(ShoppingItem itemIn, int index)
        {
            bool ok = false;
            if(CheckIndex(index))
            {
                itemList[index].Description = itemIn.Description;
                itemList[index].Amount = itemIn.Amount;
				itemList[index].Price = itemIn.Price;
				itemList[index].Unit = itemIn.Unit;
                ok = true;
            }

            return ok;
        } 

        public bool DeleteItem(int index)
        {
            bool ok = false;

            if(CheckIndex(index))
            {
                itemList.RemoveAt(index);
                ok = true;
            }

            return ok;
        }

        public string[] GetItemsInfoString()
        {
            string[] stringInfoStrings = new string[itemList.Count];

            int i = 0;

            foreach (ShoppingItem item in itemList)
            {
                stringInfoStrings[i++] = item.ToString();
            }

            return stringInfoStrings;
        } 

    } 
}
