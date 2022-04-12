using BetterBuiltWorkouts.Data;
using BetterBuiltWorkouts.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BetterBuiltWorkoutsTest
{
    public class FakePlanRepository : IRepository<Plan>
    {
        public void Delete(Plan entity)
        {
            return;
        }

        public Plan GetOne(QueryOptions<Plan> options)
        {
            return new Plan();
        }

        public void Insert(Plan entity)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Plan> List(QueryOptions<Plan> options)
        {
            return new List<Plan>();
        }

        public void SaveChanges()
        {
            return;
        }

        public void Update(Plan entity)
        {
            throw new NotImplementedException();
        }

        void IRepository<Plan>.Delete(Plan entity)
        {
            throw new NotImplementedException();
        }

        Plan IRepository<Plan>.Get(int id)
        {
            throw new NotImplementedException();
        }

        Plan IRepository<Plan>.Get(string id)
        {
            throw new NotImplementedException();
        }

        Plan IRepository<Plan>.Get(QueryOptions<Plan> options)
        {
            throw new NotImplementedException();
        }

        void IRepository<Plan>.Insert(Plan entity)
        {
            throw new NotImplementedException();
        }

        IEnumerable<Plan> IRepository<Plan>.List(QueryOptions<Plan> options)
        {
            throw new NotImplementedException();
        }

        void IRepository<Plan>.Update(Plan entity)
        {
            throw new NotImplementedException();
        }
    }
}
        