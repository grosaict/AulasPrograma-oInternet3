using System;
using System.Collections.Generic;
using System.Text;

namespace WorldBank
{
    abstract class Account : IDeposit
    {
        public Persona Holder { get; set; }
        public long AccountNumber { get; set; }
        public int BranchOffice { get; set; }
        public double Balance { get; set; }
        public double WithdrawalFee { get; set; }

        public Account(Persona holder, long accountNumber, int branchOffice, double balance, double withdrawalFee)
        {
            Holder          = holder;
            AccountNumber   = accountNumber;
            BranchOffice    = branchOffice;
            Balance         = balance;
            WithdrawalFee   = withdrawalFee;
        }

        public virtual void Withdrawal(double value)
        {
            if (value > 0)
            {
                double charge = value * (1 + WithdrawalFee);
                if ((CheckBalance() - charge) > 0)
                {
                    Balance -= charge;
                }
            }
        }
        public virtual double CheckBalance()                        // CHECK HOW TO FIX THIS ERROR WITH TEACHER (abstract instead of virtual)
        {
            return Balance;
        }
        public virtual void Transfer(Account account, double value) // CHECK HOW TO FIX THIS ERROR WITH TEACHER (abstract instead of virtual)
        {
            if (value > 0)
            {
                if ((CheckBalance() - value) > 0)
                {
                    Balance -= value;
                    account.Deposit(value);
                }
            }
        }
        public virtual void Deposit(double value)                   // WHAT THE DIFFERENCE TO USE INTERFACE INSTEAD OF DECLARE HERE?
        {                                                           // IS IT JUST TO FORCE IMPLEMENTATION?
            Balance += value;
        }
    }
}
