using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelProject.BusinessLayer.Abstract
{
    public interface IGenericService<T> where T : class
    {
        void TInsert(T insert);
        void TUpdate(T update);
        void TDelete(T delete);
        List<T> TGetList();
        T TGetByID(int id);
    }
}

