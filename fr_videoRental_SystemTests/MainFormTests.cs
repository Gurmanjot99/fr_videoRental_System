using Microsoft.VisualStudio.TestTools.UnitTesting;
using fr_videoRental_System.Folder;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using fr_videoRental_System.Task;

namespace fr_videoRental_System.Tests
{
    [TestClass()]
    public class MainFormTests
    {
        [TestMethod()]
        public void MainFormTest()
        {
            fr_videoRental_System.Task.operations obj = new fr_videoRental_System.Task.operations();
            int z = obj.findcost(2019);
            if (z == 5)
            {
                Assert.IsTrue(true);
            }
            else {
                Assert.IsTrue(false);
            }
        }

        [TestMethod()]
        public void CostTest()
        {
            fr_videoRental_System.Task.operations obj = new fr_videoRental_System.Task.operations();
            
            if (obj.getCost(1)>0)
            {
                Assert.IsTrue(true);
            }
            else
            {
                Assert.IsTrue(false);
            }
        }


    }
}