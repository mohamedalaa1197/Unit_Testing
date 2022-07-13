using BankAccountNS;
using System;
using Xunit;

namespace BankTestingXUnit
{
    public class BankAccountTest
    {
        [Fact()]
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
            Assert.Equal(expected, bankAccount.Balance, 5);
        }

        [Fact]
        public void Debit_WithLessThanAmount_ThrowException()
        {
            double beginningBalance = 1000;
            double debitAmount = -100;

            BankAccount bankAccount = new BankAccount("Mohamed Alaa", beginningBalance);

            //Assert
            Assert.Throws<ArgumentOutOfRangeException>(
                                                    // Act
                                                    () => bankAccount.Debit(debitAmount));
        }

        [Fact]
        public void Debit_WithMoreThanBalanceAmount_ThrowException()
        {
            double beginningBalance = 1000;
            double debitAmount = 2000;

            BankAccount bankAccount = new BankAccount("Mohamed Alaa", beginningBalance);
            Assert.Throws<ArgumentOutOfRangeException>(
                                                    // Act
                                                    () => bankAccount.Debit(debitAmount));
        }


        [Fact]
        public void Debit_FromFrezzedAccount_ThrowException()
        {
            double beginningBalance = 1000;
            double debitAmount = 200;
            BankAccount bankAccount = new BankAccount("Mohamed Alaa", beginningBalance);
            bankAccount.FreezeAccount();
            Assert.Throws<Exception>(() => bankAccount.Debit(debitAmount));
        }
    }
}
