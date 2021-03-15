using System;
using System.Collections.Generic;
using System.IO;
using GR.Controller;
using log4net;
using Newtonsoft.Json;

namespace GR
{
    public class Program
    {
        private static readonly ILog log = LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);
        private static IBaseClass app;
        private static void Main(string[] args)
        {

            Console.WriteLine("Welcome");
            log.Info("Welcome to GR");
            
            
            try
            {
                //Read data from input folder
                var filename = "Input\\Input-ddmmyyyy.txt";
                var data = File.ReadAllText(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, filename));
                var Items = JsonConvert.DeserializeObject<List<Item>>(data);

                // Update Inventory
                app = new BaseClass(Items);
                var updatedList = app.UpdateInventory();

                // Save updated inventory to disk
                if (updatedList.Count != 0) { 
                    app.SaveDetails(updatedList);
                }

                Console.WriteLine("Inventory update complete");
                log.Info("Inventory update complete");
            }
            catch(Exception ex)
            {
                Console.WriteLine("Exception occured while inventory update. MainClass, Error - " + ex.Message);
                log.Error("Exception occured while inventory update. MainClass, Error - " + ex.Message);
            }

            Console.ReadKey();
        }

       
    }
}