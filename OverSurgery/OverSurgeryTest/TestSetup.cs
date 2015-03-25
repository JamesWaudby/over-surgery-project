using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OverSurgery;

namespace OverSurgeryTest
{
    [TestClass]
    public class TestSetup
    {
        [TestInitialize()]
        public void Initialize()
        {
            Database.Instance().Restore();
        }

        //[TestMethod]
        //public void TestBackup()
        //{
        //    //Arrange
        //    Database.Instance().Backup();
        //}
    }
}
