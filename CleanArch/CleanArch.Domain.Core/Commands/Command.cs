using System;
using System.Collections.Generic;
using System.Text;
using CleanArch.Domain.Core.Events;

namespace CleanArch.Domain.Core.Commands
{
    public abstract class Command : Message
    {
        protected Command()
        {
            TimeStamp = DateTime.Now;
        }
        public DateTime TimeStamp { get;  protected  set; }
    }
}
