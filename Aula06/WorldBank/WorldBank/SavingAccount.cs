using System;
using System.Collections.Generic;
using System.Text;

namespace WorldBank
{
    class SavingAccount : Account
    {
        public SavingAccount(Persona holder, long accountNumber, int branchOffice, double balance, double withdrawalFee)
            : base(holder, accountNumber, branchOffice, balance, withdrawalFee)
        {
            Holder          = holder;
            AccountNumber   = accountNumber;
            BranchOffice    = branchOffice;
            Balance         = balance;
            WithdrawalFee   = withdrawalFee;
        }
    }
}