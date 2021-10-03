using Microsoft.VisualStudio.TestTools.UnitTesting;
using ATMClassLibrary;

namespace ATMTestProject
{
    [TestClass]
    public class ATMUnitTestDeposit
    {
        [TestMethod]
        // test deposit with positive number input will pass
        public void TestDeposit_WithPositiveNumber_WillPass()
        {
            // tripple A, (1) Arrange or Assemble, (2) Act, and (3) Assert
            // 1. Arrange
            // 1.1 create ATMClass's object
            ATMClass atmClass = new ATMClass();
            int depositAmount = 100;
            // 1.2 create expected_result
            bool expectedResult = true;

            // 2. Act
            // 2.1 evaluate actual_result from object's operation
            bool actualResult = atmClass.Deposit(depositAmount);

            // 3. Assert 
            // 3.1 Compare expected and actual result
            Assert.AreEqual(expectedResult, actualResult);
        }

        [TestMethod]
        public void TestDeposit_WithZeroNumber_WillFail()
        {
            ATMClass atmClass = new ATMClass();
            int depositAmount = 0;
            bool expectedResult = false;

            bool actualResult = atmClass.Deposit(depositAmount);

            Assert.AreEqual(expectedResult, actualResult);
        }

        [TestMethod]
        public void TestDeposit_WithNegativeNumber_WillFail()
        {
            ATMClass atmClass = new ATMClass();
            int depositAmount = -100;
            bool expectedResult = false;

            bool actualResult = atmClass.Deposit(depositAmount);

            Assert.AreEqual(expectedResult, actualResult);
        }

    }

    [TestClass]
    public class ATMUnitTestWithdraw
    {
        [TestMethod]
        public void TestWithdraw_WithAmountLessThanBalance_WillPass()
        {
            ATMClass atmClass = new ATMClass();
            int withdrawAmount = 100;
            atmClass.Balance = 1000;
            bool expectedResult = true;

            bool actualResult = atmClass.Withdraw(withdrawAmount);

            Assert.AreEqual(expectedResult, actualResult);
        }

        [TestMethod]
        public void TestWithdraw_WithAmountEqualtoZero_WillFail()
        {
            ATMClass atmClass = new ATMClass();
            int withdrawAmount = 0;
            atmClass.Balance = 1000;
            bool expectedResult = false;

            bool actualResult = atmClass.Withdraw(withdrawAmount);

            Assert.AreEqual(expectedResult, actualResult);
        }

        [TestMethod]
        public void TestWithdraw_WithAmountNegativeNumber_WillFail()
        {
            ATMClass atmClass = new ATMClass();
            int withdrawAmount = -100;
            atmClass.Balance = 1000;
            bool expectedResult = false;

            bool actualResult = atmClass.Withdraw(withdrawAmount);

            Assert.AreEqual(expectedResult, actualResult);
        }

        [TestMethod]
        public void TestWithdraw_WithAmountExceedBalance_WillFail()
        {
            ATMClass atmClass = new ATMClass();
            int withdrawAmount = 1100;
            atmClass.Balance = 1000;
            bool expectedResult = false;

            bool actualResult = atmClass.Withdraw(withdrawAmount);

            Assert.AreEqual(expectedResult, actualResult);
        }


    }
}
