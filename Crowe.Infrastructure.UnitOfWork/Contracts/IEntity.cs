using System;
using System.Collections.Generic;
using System.Text;

namespace Crowe.Infrastructure.UnitOfWork.Contracts
{
    public interface IEntity
    {
        int ID { get; set; }
    }
}
