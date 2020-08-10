using System;
using System.Collections.Generic;
using System.Text;

namespace MicroRabbit.Banking.Domain.Dtos
{
    public class AccountTransfer
    {
        public int FromAccount { get; set; }
        public int ToAccount { get; set; }
        public decimal TransferAmount { get; set; }
    }
}
