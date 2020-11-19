using JS_basic4.Models;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;

namespace JS_basic4.DataAccess
{
    public class DataAccessLayer
    {
        public Blogs LoadData()
        {
            try
            {
                var data = File.ReadAllText(@"C:\Users\Hieu Bui\source\repos\Digidinos_test\Javascript\JS_basic4\JS_basic4\Data\db.json");
                var obj = JsonConvert.DeserializeObject<Blogs>(data);

                return obj;
            }
            catch (Exception)
            {
                throw;
            }
        }
    }
}