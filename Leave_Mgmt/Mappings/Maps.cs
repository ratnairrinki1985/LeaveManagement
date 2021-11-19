using AutoMapper;
using Leave_Mgmt.ViewModels;
using leaveMangement.Data;
using System;
namespace Leave_Mgmt.Mappings
{
    public class Maps:Profile
    {
        public Maps()
        {
            //<DataClass,View Model Class>
            CreateMap<LeaveType, LeaveTypeVM>().ReverseMap();

            CreateMap<LeaveHistory, LeaveHistoryVM>().ReverseMap();

            CreateMap<LeaveAllocation, LeaveAllocationVM>().ReverseMap();

            CreateMap<Employee, EmployeeVM>().ReverseMap();
        }
    }
}
