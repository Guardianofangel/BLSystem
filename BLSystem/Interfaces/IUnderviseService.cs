using BLSystem.Models;
using System.Collections.Generic;

namespace BLSystem.Interfaces
{
    public interface IUnderviseService
    {
        public IEnumerable<Underviser> GetUndervisers(string Filter);

        public IEnumerable<Underviser> GetUndervisers();

        void AddUnderviser(Underviser underviser);
        public void DeleteUnderviser(Underviser underviser);
        Underviser GetUnderviserId(int id);
        void DeleteUnderviser(int id);
    }
}
