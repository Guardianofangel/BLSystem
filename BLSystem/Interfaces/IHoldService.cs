using BLSystem.Models;
using System.Collections.Generic;

namespace BLSystem.Interfaces
{
    public interface IHoldService
    {
       

        //public IEnumerable<Hold> GetHolds(string Filter);
        public IEnumerable<Hold> GetHolds();
        void AddHold(Hold hold);
        void DeleteHold(int id);
        void DeleteHold(Hold hold);
        Hold GetHoldById(int id);
    }
}
