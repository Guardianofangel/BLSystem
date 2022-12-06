using BLSystem.Models;
using Newtonsoft.Json.Bson;
using System.Collections.Generic;

namespace BLSystem.Interfaces

{
    public interface IFagService
    {
        public IEnumerable<Fag> GetFags();

        void CreateFag(Fag fag);
        void DeleteFag(int id);
        Fag GetFagById(int id);

        void UpdateFag(Fag fag);

        void DeleteFag(Fag fag);
    }
}
