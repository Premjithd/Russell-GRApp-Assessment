using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GR.BusinessObjects
{
    public static class LogicD
    {
        // Default case
        public static Item Process_D(Item item)
        {
            var modifiedItem = item;

            if (modifiedItem.SellIn > 0)
            {
                modifiedItem.SellIn = modifiedItem.SellIn - 1;

                if (modifiedItem.Quality > 0)
                {
                    modifiedItem.Quality = modifiedItem.Quality - 1;
                }
            }
            else if (modifiedItem.SellIn == 0)                           // if sellby date has passed
            {
                if (modifiedItem.Quality > 1)
                {
                    modifiedItem.Quality = modifiedItem.Quality - 2;   // reduce twice as fast
                }
                else
                {
                    modifiedItem.Quality = 0;                           // set to 0
                }
            }

            return modifiedItem;
        }
    }
}
