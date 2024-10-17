using Microsoft.VisualStudio.TestTools.UnitTesting;
using LoansProject.Business;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LoansProject.Business.Tests
{
    [TestClass()]
    public class GraduatedAmortizationTests
    {
        [TestMethod()]
        public void calcuatePeriodInterestRateTest()
        {
            var amortization = new GraduatedAmortization();
            var result = amortization.calcuatePeriodInterestRate(12, 0.06m);
            Assert.AreEqual(0.005m, result);
        }

        [TestMethod()]
        public void calculatePaymentTest()
        {
            var amortization = new GraduatedAmortization();
            var result = amortization.calculatePayment(new Models.Loan(200000, 0.06m, 2, Models.PaymentPeriods.monthly));
            Assert.AreEqual(8864.12m, result, delta: 0.01m);
        }
    }
}