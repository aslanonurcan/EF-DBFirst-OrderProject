using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EF_DBFirst_OrderProject
{
    public class DbSingleTone
    {
        private static NorthwindEntitiesConnectionString db;//databasei korumak için private yazdık. Db'yi silmeyi vs engelledik.
        //Normalde dbContextin instancesini alırdık. Burda bunu yaptık
        public static NorthwindEntitiesConnectionString GetInstance()//yukarıdakine dışardan ulaşmak için publi metot oluşturduk
        {
            if (db==null)
            {
                db = new NorthwindEntitiesConnectionString();
            }
            return db;
        }
    }
}
