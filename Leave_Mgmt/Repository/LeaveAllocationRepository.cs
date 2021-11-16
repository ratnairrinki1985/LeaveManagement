using System;
using System.Collections.Generic;
using System.Linq;
using Leave_Mgmt.Contracts;
using Leave_Mgmt.Data;
using leaveMangement.Data;

namespace Leave_Mgmt.Repository
{
    public class LeaveAllocationRepository : ILeaveAllocationRepository
    {
        private readonly ApplicationDbContext _db;

        public LeaveAllocationRepository(ApplicationDbContext db)
        {
            _db = db;
        }

        #region IRepositoryBaseImplementation

        public bool Create(LeaveAllocation entity)
        {
            _db.LeaveAllocations.Add(entity);
            //SAVE
            return Save(); throw new NotImplementedException();
        }

        public bool Delete(LeaveAllocation entity)
        {
            _db.LeaveAllocations.Remove(entity);
            //SAVE
            return Save();
        }

        public ICollection<LeaveAllocation> FindAll()
        {
            var leaveTypes = _db.LeaveAllocations.ToList();
            return leaveTypes;

        }

        public LeaveAllocation FindById(int id)
        {
            var leaveAllocation = _db.LeaveAllocations.Find(id);
            return leaveAllocation;
        }

        public bool Save()
        {
            return _db.SaveChanges() > 0;
        }

        public bool Update(LeaveAllocation entity)
        {
            _db.LeaveAllocations.Update(entity);
            return Save();
            //SAVE
        }

        #endregion
    }
}
