using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Text;

namespace BankTesting
{
    [TestClass]
    public class DataDrivenTest
    {
        private TestContext _context;
        public TestContext Context
        {
            get { return _context; }
            set { _context = value; }
        }

        [TestMethod]
        [DataSource("System.Data.OleDb",
            "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=D:\\Courses\\Unit testing\\Unit Testing\\Day02\\Unit Testing Code - Smart 2020 - Day 2\\sample.mdb",
            "Table1",
            DataAccessMethod.Sequential)]
        public void DebitTest()
        {
           //_context.DataRow ==> is not supportrd in .Net core
        }

    }
}
