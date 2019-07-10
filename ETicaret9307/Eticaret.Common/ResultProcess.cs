using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ETicaret.Entity;

namespace Eticaret.Common
{
    public class ResultProcess<T> //Generic class: içinde T tag'i var ve kullanırken ne atarsam o oalcak.
    {
        public Result<int> GetResult(ECommerceEntities db) //Bu metot: db'ye kayıt yapmak için kullanacağımız yardımcı metot.
        {
            Result<int> result = new Result<int>();

            int sonuc = db.SaveChanges();

            if (sonuc > 0)
            {
                result.UserMessage = "Basarili";
                result.IsSucceeded = true;
                result.ProcessResult = sonuc;
            }
            else
            {
                result.UserMessage = "Basarisiz";
                result.IsSucceeded = false;
                result.ProcessResult = sonuc;
            }

            return result;
        }

        public Result<List<T>> GetListResult(List<T> data) //Bu metot: db'den Liste tipinde data çekerken, datanın olup olmadıgını kontrol eden metot
        {
            Result<List<T>> result = new Result<List<T>>();

            if(data != null)
            {
                result.UserMessage = "Işlem başarılı";
                result.IsSucceeded = true;
                result.ProcessResult = data;
            }
            else
            {
                result.UserMessage = "Işlem başarısız data yok";
                result.IsSucceeded = true;
                result.ProcessResult = data;
            }
            return result;
        }

        public Result<T> GetT(T data) //Bu metot: db'den tek bir item çekmek için- tek bir özellik
        {
            Result<T> result = new Result<T>();

            if(data != null)
            {
                result.IsSucceeded = true;
                result.UserMessage = "Basarili";
                result.ProcessResult = data;
            }
            else
            {
                result.IsSucceeded = false;
                result.UserMessage = "Basarisiz";
                result.ProcessResult = data;
            }
            return result;
        }
    }
}
