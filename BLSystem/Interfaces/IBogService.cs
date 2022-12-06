using BLSystem.Models;
using System.Collections.Generic;

namespace BLSystem.Interfaces
{
    public interface IBogService
    {
        public IEnumerable<Bog> GetBogs(string Filter);
        public IEnumerable<Bog> GetBogs( string Filter, string FilterForfatter, double ISBNFilter);

        IEnumerable<Bog> GetBogs();
        
        void AddBog(Bog bog);
        Bog GetBogById(int id);
        void DeleteBog(Bog bog);
        void DeleteBog(int id);
        void UpdateBog(Bog bog);

    }
}
