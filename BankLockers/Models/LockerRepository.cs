using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BankLockers.Models
{
    public class LockerRepository: ILockerRepository
    {

        public List<Locker> GetLockerList()
        {
            var lockerList = new List<Locker>();

            var locations = new List<string> { "Sydney", "Melbourne", "Adelaide", "Brisbane", "Perth" };


            foreach (string location in locations)
            {

                for (int i = 1; i <=5; i++)
                {
                    var locker =
                        new Locker
                        {
                            BankName = string.Concat(location.Substring(0, 3), i.ToString()),
                            Location = location,
                            NoOfLockers = i
                        };
                    lockerList.Add(locker);
                }


            }





            return lockerList;

        }


        public List<string> GetLocations()
        {
            var locations = new List<string> { "Sydney", "Melbourne", "Adelaide", "Brisbane", "Perth" };
            return locations;
        }



    }
}