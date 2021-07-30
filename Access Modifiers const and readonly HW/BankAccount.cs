using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Access_Modifiers_const_and_readonly_HW
{
    class BankAccount
    {
        private double balance;
        private string bankName;
        private readonly long accountNumber;

        public BankAccount(double balance, string bankName, long accountNumber)
        {
            this.balance = balance;
            this.bankName = bankName;
            this.accountNumber = accountNumber;
        }

        public void WithdrawOrDeposit(double amount)
        {
            balance += amount;
        }

        public string GetAccountDetails()
        {
            return $"Account number: {accountNumber}, Bank name: {bankName}";
        }
    }
}
