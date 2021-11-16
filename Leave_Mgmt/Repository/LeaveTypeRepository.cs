using System;
using System.Collections.Generic;
using System.Linq;
using Leave_Mgmt.Contracts;
using Leave_Mgmt.Data;
using leaveMangement.Data;

namespace Leave_Mgmt.Repository
{
    public class LeaveTypeRepository : ILeaveTypeRepository
    {
        private readonly ApplicationDbContext _db;
        
        public LeaveTypeRepository(ApplicationDbContext db)
        {
            _db = db;
        }

        public ICollection<LeaveType> GetEmplpoyeesByLeaveType(int id)
        {
            throw new NotImplementedException();
        }

        #region IRepositoryBaseImplementation

        public bool Create(LeaveType entity)
        {
            _db.LeaveTypes.Add(entity);
            //SAVE
            return Save();
        }

        public bool Delete(LeaveType entity)
        {
            _db.LeaveTypes.Remove(entity);
            //SAVE
            return Save();
        }

        public ICollection<LeaveType> FindAll()
        {
            var leaveTypes = _db.LeaveTypes.ToList();
            return leaveTypes;
        }

        public LeaveType FindById(int id)
        {

            var leaveType = _db.LeaveTypes.Find(id);
            return leaveType;
        }

        public bool Save()
        {
              
            return _db.SaveChanges() > 0;
        }

        public bool Update(LeaveType entity)
        {
            _db.LeaveTypes.Update(entity);
            return Save();
            //SAVE
        }
        #endregion
    }
}
