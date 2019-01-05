using System;
using System.Collections.Generic;
using System.Text;

namespace XamarinRpg.Model
{
    public class Inventory
    {
        #region private data
        private List<Item> ItemList;
        private int Capacity;
        #endregion region

        #region Contructor
        public Inventory() {
            ItemList = new List<Item>();
            Capacity = 12;
        }
        #endregion
    }
}
