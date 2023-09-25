using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelProject.DataAccessLayer.Abstract
{
    public interface IGenericDal<T> where T : class
    {
        void Insert(T insert);
        void Update(T update);
        void Delete(T delete);
        List<T> GetList();
        T GetByID(int id);
    }
}
