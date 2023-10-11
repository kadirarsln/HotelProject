using HotelProject.EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelProject.DataAccessLayer.Abstract
{
    public interface IBookingDal:IGenericDal<Booking>
    {
        void BookingStatusChangeApproved(Booking status);
        void BookingStatusChangeApproved2(int id);
    }
}
