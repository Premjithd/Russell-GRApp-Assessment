namespace GR.BusinessObjects
{
    public static class LogicC
    {
        // logic for "Conjured Mana Cake"
        public static Item Process_C(Item item)
        {
            var modifiedItem = item;

            if (modifiedItem.SellIn > 0)                              // if sellby date has NOT passed
            {
                modifiedItem.SellIn = modifiedItem.SellIn - 1;

                if (modifiedItem.Quality > 1)
                {
                    modifiedItem.Quality = modifiedItem.Quality - 2;   //Degrade twice as fast as normal item
                }
                else
                {
                    modifiedItem.Quality = 0;                          // set to 0
                }
            }
            else if (modifiedItem.SellIn == 0)                          // if sellby date has passed
            {
                if (modifiedItem.Quality > 3)
                {
                    modifiedItem.Quality = modifiedItem.Quality - 4;   //Degrade twice as fast as normal item
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
