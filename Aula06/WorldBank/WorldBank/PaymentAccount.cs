using System;
using System.Collections.Generic;
using System.Text;

namespace WorldBank
{
    class PaymentAccount : Account
    {
        public PaymentAccount(Persona holder, long accountNumber, int branchOffice, double balance, double withdrawalFee)
            : base(holder, accountNumber, branchOffice, balance, withdrawalFee)
        {
            Holder          = holder;
            AccountNumber   = accountNumber;
            BranchOffice    = branchOffice;
            Balance         = balance;
            WithdrawalFee   = 0;
        }
        public override void Transfer(Account account, double value) // CHECK HOW TO FIX THIS ERROR WITH TEACHER (abstract instead of virtual)
        {
            if (value > 0 || Holder == account.Holder)
            {
                if ((CheckBalance() - value) > 0)
                {
                    Balance -= value;
                    account.Deposit(value);
                }
            }
        }
        public override void Deposit(double value) { }              // HOW TO BLOCK INHERITED METHOD IMPLEMENTATION
    }
}
