using MicroRabbit.Transfer.Data.Context;
using MicroRabbit.Domain.Core.ContextFactory;
using System;
using System.Collections.Generic;
using System.Text;

namespace MicroRabbit.Transfer.Data.Domain
{
    public class TransferDesignTimeDbContextFactory : GenericDesignTimeDbContextFactory<TransferDbContext>
    {
        public TransferDesignTimeDbContextFactory() : base("TransferDbConnection")
        {
        }
    }
}
