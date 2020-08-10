using MicroRabbit.Banking.Data.Context;
using MicroRabbit.Domain.Core.ContextFactory;
using System;
using System.Collections.Generic;
using System.Text;

namespace MicroRabbit.Banking.Data.Domain
{
    public class BankingDesignTimeDbContextFactory : GenericDesignTimeDbContextFactory<BankingDbContext>
    {
    }
}
