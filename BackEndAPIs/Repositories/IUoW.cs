using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Asp.NetCoreMVCCRUD.project.Repository
{
    public interface IUoW
    {
        IGeneralRepository employeeRepository { get; }
        void Commit();
        void Rollback();
    }
}
