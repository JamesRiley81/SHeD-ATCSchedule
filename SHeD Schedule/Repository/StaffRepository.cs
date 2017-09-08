using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using SHeDSchedule.Models;

namespace SHeDSchedule.Repository
{
    public class StaffRepository:IStaffRepository
    {
        AppDbContext cntx;
        public StaffRepository(AppDbContext ctx)
        {
            cntx = ctx;
        }
        public Staff Student(int id)
        {
            return cntx.Staff.Where(st => st.staffId == id).SingleOrDefault();
        }
        public void AddMonday(Staff s)
        {
            Monday m = new Monday();
            m.staffId = s.staffId;
            try
            {
                cntx.Monday.Add(m);
                cntx.SaveChanges();
            }
            catch (Exception)
            {
                throw new ArgumentException("Error in adding " + s.initials + " to Monday schedule.");
            }
        }
        public void DeleteStaff(Staff s)
        {
            try
            {
                cntx.Staff.Remove(s);
                cntx.SaveChanges();
            }
            catch (Exception)
            {
                throw new ArgumentException("Could not remove user from system, please try again.");
            }
        }
        public void AddTuesday(Staff s)
        {
            Tuesday t = new Tuesday();
            t.staffId = s.staffId;
            try
            {
                cntx.Tuesday.Add(t);
                cntx.SaveChanges();
            }
            catch (Exception)
            {
                throw new ArgumentException("Error in addming " + s.initials + " to Tuesday schedule.");
            }
        }
        public void AddWednesday(Staff s)
        {
            Wednesday t = new Wednesday();
            t.staffId = s.staffId;
            try
            {
                cntx.Wednesday.Add(t);
                cntx.SaveChanges();
            }
            catch (Exception)
            {
                throw new ArgumentException("Error in addming " + s.initials + " to Wednesday schedule.");
            }
        }
        public void AddThursday(Staff s)
        {
            Thursday t = new Thursday();
            t.staffId = s.staffId;
            try
            {
                cntx.Thursday.Add(t);
                cntx.SaveChanges();
            }
            catch (Exception)
            {
                throw new ArgumentException("Error in addming " + s.initials + " to Thursday schedule.");
            }
        }
        public void AddFriday(Staff s)
        {
            Friday t = new Friday();
            t.staffId = s.staffId;
            try
            {
                cntx.Friday.Add(t);
                cntx.SaveChanges();
            }
            catch (Exception)
            {
                throw new ArgumentException("Error in addming " + s.initials + " to Friday schedule.");
            }
        }
        public IEnumerable<Staff> Students()
        {
            try
            {
                return cntx.Staff.ToList();
            }
            catch (Exception)
            {
                throw new ArgumentException("Could not retrieve student list.");
            }
        }
        public void CreateStaff(Staff s)
        {
            try
            {
                cntx.Add(s);
                cntx.SaveChanges();
                AddMonday(s);
                AddTuesday(s);
                AddWednesday(s);
                AddThursday(s);
                AddFriday(s);
            }
            catch (Exception)
            {
                throw new ArgumentException("Error in adding user.");
            }
        }
        public Monday MondaySchedule(Staff s)
        {
            try
            {
                return cntx.Monday.Where(st => st.staffId == s.staffId).SingleOrDefault();
            }
            catch (Exception)
            {
                throw new ArgumentException("Could not retrieve Monday schedule for " + s.initials);
            }
        }
        public Tuesday TuesdaySchedule(Staff s)
        {
            try
            {
                return cntx.Tuesday.Where(st => st.staffId == s.staffId).SingleOrDefault();
            }
            catch (Exception)
            {
                throw new ArgumentException("Could not retrieve Tuesday schedule for " + s.initials);
            }
        }
        public Wednesday WednesdaySchedule(Staff s)
        {
            try
            {
                return cntx.Wednesday.Where(st => st.staffId == s.staffId).SingleOrDefault();
            }
            catch (Exception)
            {
                throw new ArgumentException("Could not retrieve Wednesday schedule for " + s.initials);
            }
        }
        public Thursday ThursdaySchedule(Staff s)
        {
            try
            {
                return cntx.Thursday.Where(st => st.staffId == s.staffId).SingleOrDefault();
            }
            catch (Exception)
            {
                throw new ArgumentException("Could not retrieve Thurdsay schedule for " + s.initials);
            }
        }
        public Friday FridaySchedule(Staff s)
        {
            try
            {
                return cntx.Friday.Where(st => st.staffId == s.staffId).SingleOrDefault();
            }
            catch (Exception)
            {
                throw new ArgumentException("Could not retrieve Friday schedule for " + s.initials);
            }
        }
    }
}
