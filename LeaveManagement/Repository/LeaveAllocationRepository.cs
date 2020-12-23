using LeaveManagement.Contracts;
using LeaveManagement.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LeaveManagement.Repository
{
    public class LeaveAllocationRepository : ILeaveAllocationRepository
    {
        private readonly ApplicationDbContext _db;
        public LeaveAllocationRepository(ApplicationDbContext db)
        {
            _db = db;
        }
        public bool Create(LeaveAllocation entity)
        {
            _db.LeaveAllocations.Add(entity);
            return Save();
        }

        public bool Delete(LeaveAllocation entity)
        {
            _db.LeaveAllocations.Remove(entity);
            return Save();
        }

        public ICollection<LeaveAllocation> FindAll()
        {
            var leaveAllocations = _db.LeaveAllocations.ToList();

            return leaveAllocations;
        }

        public LeaveAllocation FindById(int id)
        {
            var leaveAllocationsId = _db.LeaveAllocations.Find(id);

            return leaveAllocationsId;
        }

        public bool isExists(int id)
        {
            var exists = _db.LeaveAllocations.Any(x => x.Id == id);
            return exists;
        }

        public bool Save()
        {
            var changes = _db.SaveChanges();
            if (changes > 0)
            {
                return true;
            }
            return false;
        }

        public bool Update(LeaveAllocation entity)
        {
            _db.LeaveAllocations.Update(entity);
            return Save();
        }
    }
}
