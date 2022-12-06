using BLSystem.Interfaces;
using BLSystem.Models;
using BLSystem.Pages.BogPage;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;

namespace BLSystem.Services
{
    public class BogServices : IBogService
    {
        BLSystemContext context;

        public BogServices(BLSystemContext service) 
        {
            context = service;
        }
        public IEnumerable<Bog> GetBogs(string Filter)
        {

            if(Filter == null)
            {
                return context.Bøger;
            }
            return context.Set<Bog>().Where(b => b.Title.StartsWith(Filter));
        }

        public IEnumerable<Bog> GetBogs() {
            return context.Bøger;
        }

        public void AddBog(Bog bog) {
            context.Bøger.Add(bog);
            context.SaveChanges();
        }

      
        public Bog GetBogById(int id) {
            return context.Bøger.Find(id);
        }

        public void DeleteBog(int id) {

            Bog Bog = GetBogById(id);
            context.Bøger.Remove(Bog);
            context.SaveChanges(true);
        }


        public void DeleteBog(Bog bog) {

            context.Bøger.Remove(bog);
           context.SaveChanges(true);
        }
        public IEnumerable<Bog> GetBogs(string Filter, string FilterForfatter, double ISBNFilter) {
            IEnumerable<Bog> resulat = context.Bøger;

            if (Filter != null)
            {
                resulat = resulat.Where(r => r.Title.StartsWith(Filter));
            }

            if (FilterForfatter != null)
            {
                resulat = resulat.Where(r => r.Forfatter.StartsWith(FilterForfatter));
            }

            if (ISBNFilter !> 0)
            {
                resulat = resulat.Where(r => r.ISBN == ISBNFilter);
            }
            return resulat;
        }

        public void UpdateBog(Bog bog)
        {
            context.Bøger.Update(bog);
            context.SaveChanges();
        }
    }
}
