//using MicroRabbit.Transfer.Domain.Dtos;
//using MicroRabbit.Transfer.Domain.Models;
using MicroRabbit.Transfer.Domain.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace MicroRabbit.Transfer.Application.Interfaces
{
    public interface ITransferService
    {
        IEnumerable<TransferLog> GetTransferLogs();
        //void Transfer(AccountTransfer accountTransfer);
    }
}
