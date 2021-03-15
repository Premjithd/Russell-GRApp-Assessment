namespace GR.BusinessObjects
{
    public static class LogicA
    {
        // logic for "Aged Brie"
        public static Item Process_A(Item item)
        {
            var modifiedItem = item;

            if (modifiedItem.Quality < 50)
            {
                modifiedItem.Quality = modifiedItem.Quality + 1;
            }

            if (modifiedItem.SellIn > 0)
            {
                modifiedItem.SellIn = modifiedItem.SellIn - 1;
            }

            return modifiedItem;
        }
    }
}
