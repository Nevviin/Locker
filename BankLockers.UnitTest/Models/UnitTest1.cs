using Microsoft.VisualStudio.TestTools.UnitTesting;
using BankLockers.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace BankLockers.Models.Tests
{
    [TestClass()]
    public class UnitTest1
    {
        [TestMethod()]
        public void GetLockerListTest()
        {
            var lockerRepo = new LockerRepository();
            var lockerList =  lockerRepo.GetLockerList();
            Assert.AreEqual(lockerList.GetType(), new List<Locker>().GetType());
        }
    }
}