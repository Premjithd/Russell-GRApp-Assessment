using System.Collections.Generic;

namespace GR.Controller
{
    public interface IBaseClass
    {
        List<Item> UpdateInventory();
        void SaveDetails(List<Item> Items);
    }
}
