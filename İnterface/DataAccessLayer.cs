using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace İnterface
{
    public class DataAccessLayer
    {
        string appDirectory = AppDomain.CurrentDomain.BaseDirectory;
        
        public List<EntityLayer> GetAll()
        {
            string filePath = Path.Combine(appDirectory, "Itmes.json");

            if (File.Exists(filePath) == false)
            {
           
                Console.WriteLine(filePath);

                Console.WriteLine("the path is incorrect");

                Console.ReadLine();
            }

            var json = File.ReadAllText(filePath);

            List<EntityLayer>? items = JsonConvert.DeserializeObject<List<EntityLayer>>(json);

            return items;
        }

        public void Save(List<EntityLayer> entityLayers)
        {


            string filePath = Path.Combine(appDirectory, "Itmes.json");

            var json = JsonConvert.SerializeObject(entityLayers, Formatting.Indented);

            if (File.Exists(filePath))
            {
                File.Delete(filePath);
            }

            File.WriteAllText(filePath, json);


        }
    }
}
