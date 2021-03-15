namespace GR.BusinessObjects
{
    public static class LogicB
    {
        //logic for "Backstage passes "
        public static Item Process_B(Item item)
        {
            var modifiedItem = item;

            if (modifiedItem.SellIn > 0 && modifiedItem.SellIn <= 5)
            {
                modifiedItem.SellIn = modifiedItem.SellIn - 1;

                if (modifiedItem.Quality < 48)
                {
                    modifiedItem.Quality = modifiedItem.Quality + 3;  // increase by 3
                }
                else
                {
                    modifiedItem.Quality = 50;  // set to 50
                }
            }
            else if (modifiedItem.SellIn > 5 && modifiedItem.SellIn <= 10)
            {
                modifiedItem.SellIn = modifiedItem.SellIn - 1;

                if (modifiedItem.Quality < 49)
                {
                    modifiedItem.Quality = modifiedItem.Quality + 2;  // increase by 2
                }
                else
                {
                    modifiedItem.Quality = 50;  // set to 50
                }

            }
            else if (modifiedItem.SellIn > 10)
            {
                modifiedItem.SellIn = modifiedItem.SellIn - 1;

                if (modifiedItem.Quality < 50)
                {
                    modifiedItem.Quality = modifiedItem.Quality + 1;  // increase by 1
                }
            }
            else if (modifiedItem.SellIn == 0)
            {
                modifiedItem.Quality = 0;    // Drops to 0 after concert
            }

            return modifiedItem;
        }
    }
}
