using MicroRabbit.Transfer.Application.Interfaces;
using MicroRabbit.Transfer.Domain.Interfaces;
using MicroRabbit.Transfer.Domain.Models;
using MicroRabbit.Domain.Core.Bus;
using System;
using System.Collections.Generic;
using System.Text;

namespace MicroRabbit.Transfer.Application.Services
{
    public class TransferService : ITransferService
    {
        private readonly ITransferRepository _transferRepository;
        private readonly IEventBus _bus;

        public TransferService(ITransferRepository transferRepository, IEventBus bus)
        {
            this._transferRepository = transferRepository;
            this._bus = bus;
        }
        public IEnumerable<TransferLog> GetTransferLogs()
        {
            return _transferRepository.GetTransferLogs();
        }

        //public void Transfer(AccountTransfer accountTransfer)
        //{
        //    var createTransferCommand = new CreateTransferCommand(
        //        from : accountTransfer.FromAccount,
        //        to : accountTransfer.ToAccount,
        //        amount : accountTransfer.TransferAmount
        //        );

        //    _bus.SendCommand(createTransferCommand);
        //}
    }
}
