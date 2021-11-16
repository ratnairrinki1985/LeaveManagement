using System;
using System.Collections.Generic;
using leaveMangement.Data;

namespace Leave_Mgmt.Contracts
{
    public interface ILeaveTypeRepository: IRepositoryBase<LeaveType>
    {

        ICollection<LeaveType> GetEmplpoyeesByLeaveType(int id);
    }
}
