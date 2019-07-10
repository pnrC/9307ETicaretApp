using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Eticaret.Common; //Eticaret.Repository> referance> Add referance > common'ı ekledik

namespace ETicaret.Repository
{
    public abstract class DataRepository<T, M>
    {
        //Burda temel CRUD işlemerini temsil edecek metotlarım var
        public abstract Result<int> Insert(T item);

        public abstract Result<int> Update(T item);

        public abstract Result<int> Delete(M id);

        public abstract Result<List<T>> List();

        public abstract Result<T> GetObjByID(M ID);
    }
}
