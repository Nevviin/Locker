using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankLockers.Models
{
    public interface ILockerRepository
    {
        List<Locker> GetLockerList();
    }
}
