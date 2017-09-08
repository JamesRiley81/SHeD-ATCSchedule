using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using SHeDSchedule.Models;

namespace SHeDSchedule.Repository
{
    public interface IStaffRepository
    {
        IEnumerable<Staff> Students();
        Monday MondaySchedule(Staff s);
        Tuesday TuesdaySchedule(Staff s);
        Wednesday WednesdaySchedule(Staff s);
        Thursday ThursdaySchedule(Staff s);
        Friday FridaySchedule(Staff s);
        void AddMonday(Staff s);
        void AddTuesday(Staff s);
        void AddWednesday(Staff s);
        void AddThursday(Staff s);
        void AddFriday(Staff s);
        //void EditMonday(Monday m);
        //void EditTuesday(Tuesday t);
        //void EditWednesday(Wednesday w);
        //void EditThursday(Thursday th);
        //void EditFriday(Friday f);
        void CreateStaff(Staff s);
        void DeleteStaff(Staff s);
        Staff Student(int id);
    }
}
