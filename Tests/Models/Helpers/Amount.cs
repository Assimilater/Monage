using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Monage.Models;

namespace Tests.Models {
    [TestClass]
    public class Test_Amount {
        [TestMethod]
        [TestProperty("_Level", "0: One-time")]
        public void Amount_StringFormat() {
            Amount a = new Amount(10, 15);
            Assert.IsTrue(
                a.ToString().Equals("$10.00 [ $15.00 ]"),
                "Unexpected Result: " + a.ToString()
            );

            a = new Amount(-5, -4.3);
            Assert.IsTrue(
                a.ToString().Equals("($5.00) [ ($4.30) ]"),
                "Unexpected Result: " + a.ToString()
            );
        }
    }
}
