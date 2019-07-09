using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ETicaret.Entity; //EntityCommona referans sag tık add entity yi refere ettik

namespace Eticaret.Common
{
    public class Tool
    {
        public static ECommerceEntities db = null;

        public static ECommerceEntities GetConnection()
        {
            if(db is null)
            {
                db = new ECommerceEntities();
            }
            return db;
        }       
    }
}
