﻿using System;
using NEventStoreExample.Infrastructure;

namespace NEventStoreExample.Command
{
    // A command doesn't need to carry state if you don't want it to... Here, we're just telling it the account id to close.
    public class CloseAccountCommand : ICommand
    {
        public CloseAccountCommand(Guid accountId)
        {
            AccountId = accountId;
        }

        public Guid AccountId { get; private set; }
    }
}