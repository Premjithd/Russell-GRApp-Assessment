using GR.BusinessObjects;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using log4net;

namespace GR.Controller
{
    public class BaseClass : IBaseClass
    {
        private  List<Item> _items;
        private static readonly ILog log = LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);
        public BaseClass(List<Item> items)
        {
            _items = items;
        }

        public List<Item> UpdateInventory()
        {
            Console.WriteLine("Updating inventory");
            log.Info("Updating inventory");

            List<Item> updatedItems = _items;

            try
            {
                for (int i=0;i<_items.Count;i++)
                {
                    Console.WriteLine(" - Item: {0}" , _items[i].Name);
                    log.Info(" - Item: " + _items[i].Name);

                    var name = _items[i].Name.Substring(0, 9);
                    switch (name)
                    {
                        case "Aged Brie":
                            updatedItems[i] = LogicA.Process_A(_items[i]);
                            break;
                        case "Sulfuras,":                                           // Do nothing
                            break;
                        case "Backstage":
                            updatedItems[i] = LogicB.Process_B(_items[i]);
                            break;
                        case "Conjured ":
                            updatedItems[i] = LogicC.Process_C(_items[i]);
                            break;
                        default:
                            updatedItems[i] = LogicD.Process_D(_items[i]);
                            break;
                    }

                }

                return updatedItems;
            }
            catch (Exception ex)
            {
                Console.WriteLine("Exception occured while inventory update. BaseClass, Error - " + ex.Message);
                log.Error("Exception occured while inventory update. BaseClass, Error - " + ex.Message);
            }

            return new List<Item>();
        }

        public void SaveDetails(List<Item> Items)
        {
            try
            {
                var filename = $"inventory_{DateTime.Now:yyyyddMM-HHmmss}.txt";
                var inventoryOutput = JsonConvert.SerializeObject(Items, Formatting.Indented);
                File.WriteAllText(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, filename), inventoryOutput);
            }
            catch (Exception ex)
            {
                Console.WriteLine("Exception While writing output, Error - " + ex.Message);
                log.Error("Exception While writing output, Error - " + ex.Message);
            }
        }
    }
}
