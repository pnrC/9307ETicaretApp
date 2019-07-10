using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Eticaret.Common; //biz ekledik
using ETicaret.Entity; //biz ekledik

namespace ETicaret.Repository
{
    class CategoryRepository : DataRepository<Category, Guid>
    {
        static ECommerceEntities db = Tool.GetConnection();
        ResultProcess<Category> result = new ResultProcess<Category>();

        public override Result<int> Delete(Guid id)
        {
            Category c = db.Categories.SingleOrDefault(x => x.CategoryID == id);
            db.Categories.Remove(c);
            return result.GetResult(db);
        }

        public override Result<Category> GetObjByID(Guid ID)
        {
            Category c = db.Categories.SingleOrDefault(x => x.CategoryID == ID);
            return result.GetT(c);
        }

        public override Result<int> Insert(Category item)
        {
            Category yeni = db.Categories.Create();
            yeni.CategoryName = item.CategoryName;
            yeni.CreatedDate = DateTime.Now;
            yeni.Description = item.Description;
            //burda sadece saf property'lerini işliyorum.
            db.Categories.Add(yeni);

            return result.GetResult(db); //çunku sadece GetResult içinde db.savechanges var ve benim lu an db.savechanges yapmam alzım.
        }

        public override Result<List<Category>> List()
        {
            List<Category> CatList = db.Categories.ToList();
            return result.GetListResult(CatList);
        }

        public override Result<int> Update(Category item)
        {
            Category dbdeki = db.Categories.SingleOrDefault(x => x.CategoryID == item.CategoryID);
            dbdeki.CategoryName = item.CategoryName;
            dbdeki.Description = item.Description;
            //dbdeki.CreatedDate= bunu da guncelleyemeyiz updateDate diye bir şey yaratmadım,ilk yarattıgımda date i de yaratıldı zaten
            return result.GetResult(db);
        }
    }
}
