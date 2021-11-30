using System;
using System.Collections.Generic;
using System.Linq;
using Leave_Mgmt.Contracts;
using Leave_Mgmt.Data;
using leaveMangement.Data;

namespace Leave_Mgmt.Repository
{
    public class LeaveHistoryRepository : ILeaveHistoryRepository
    {
        private readonly ApplicationDbContext _db;
        public LeaveHistoryRepository(ApplicationDbContext db)
        {
            _db = db;
        }
        #region IRepositoryBaseImplementation

        public bool Create(LeaveHistory entity)
        {
            _db.LeaveHistories.Add(entity);
            //SAVE
            return Save(); throw new NotImplementedException();
        }

        public bool Delete(LeaveHistory entity)
        {
            _db.LeaveHistories.Remove(entity);
            //SAVE
            return Save();
        }

        public ICollection<LeaveHistory> FindAll()
        {
            var leaveTypes = _db.LeaveHistories.ToList();
            return leaveTypes;
        }

        public LeaveHistory FindById(int id)
        {
            var leaveHistory = _db.LeaveHistories.Find(id);
            return leaveHistory;
        }

        public bool isExists(int id)
        {
            var exists = _db.LeaveHistories.Any(q => q.Id == id);
            return exists;
        }

        public bool Save()
        {
            return _db.SaveChanges() > 0;
        }

        public bool Update(LeaveHistory entity)
        {
            _db.LeaveHistories.Update(entity);
            return Save();
            //SAVE
        }
        #endregion
    }
}
