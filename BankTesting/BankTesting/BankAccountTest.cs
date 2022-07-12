using BankAccountNS;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace BankTesting
{
    [TestClass]
    public class BankAccountTest
    {
        [TestMethod()]
        public void Debit_WithValidAmount_UpdateBalance()
        {
            //Arrange
            double beginningBalance = 1000;
            double debitAmount = 700;
            double expected = 300;

            BankAccount bankAccount = new BankAccount("Mohamed Alaa", beginningBalance);
            //Act
            bankAccount.Debit(debitAmount);

            //Assert
            Assert.AreEqual(expected, bankAccount.Balance, 0.001, "Account not debited correctly");
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        public void Debit_WithLessThanAmount_ThrowException()
        {
            double beginningBalance = 1000;
            double debitAmount = -100;

            BankAccount bankAccount = new BankAccount("Mohamed Alaa", beginningBalance);
            //Act
            bankAccount.Debit(debitAmount);

            //Assert
            //Is handled by expection attribute

        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        public void Debit_WithMoreThanBalanceAmount_ThrowException()
        {
            double beginningBalance = 1000;
            double debitAmount = 2000;

            BankAccount bankAccount = new BankAccount("Mohamed Alaa", beginningBalance);
            //Act
            bankAccount.Debit(debitAmount);

            //Assert
            //Is handled by expection attribute
        }


        [TestMethod]
        [ExpectedException(typeof(Exception))]
        public void Debit_FromFrezzedAccount_ThrowException()
        {
            double beginningBalance = 1000;
            double debitAmount = 200;
            BankAccount bankAccount = new BankAccount("Mohamed Alaa", beginningBalance);
            bankAccount.FreezeAccount();
            //Act
            bankAccount.Debit(debitAmount);

            //Assert
            //Is handled by expection attribute
        }
    }
}
