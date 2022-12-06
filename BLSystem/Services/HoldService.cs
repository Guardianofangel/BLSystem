using BLSystem.Interfaces;
using BLSystem.Models;
using System.Collections.Generic;
using System.Linq;

namespace BLSystem.Services
{
    public class HoldService : IHoldService
    {
        BLSystemContext context;
        public HoldService(BLSystemContext service) {
            context= service;
        }

        //public IEnumerable<Hold> GetHolds(string Filter) {
        //    if(Filter == null)
        //    {
        //        return context.Holds;
        //    }
        //    return context.S
        //}
        public void AddHold(Hold hold) {
            context.Holds.Add(hold);
            context.SaveChanges();
        }

        public void DeleteHold(int id) {
            Hold hold = GetHoldById(id);
            context.Holds.Remove(hold);
            context.SaveChanges();
           
        }

        public void DeleteHold(Hold hold) {
            context.Holds.Remove(hold);
            context.SaveChanges();
        }

        public Hold GetHoldById(int id) {
            return context.Holds.Find(id);
        }

        public IEnumerable<Hold> GetHolds() {
            return context.Holds;
        }

    }
}
