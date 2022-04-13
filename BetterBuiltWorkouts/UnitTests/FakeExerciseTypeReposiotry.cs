using BetterBuiltWorkouts.Data;
using BetterBuiltWorkouts.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BetterBuiltWorkoutsTest
{
    public class FakeExerciseTypeReposiotry : IRepository<ExerciseType>
    {
        public void Delete(ExerciseType entity)
        {
            throw new NotImplementedException();
        }

        public ExerciseType GetOne(QueryOptions<ExerciseType> options)
        {
            throw new NotImplementedException();
        }

        public void Insert(ExerciseType entity)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<ExerciseType> List(QueryOptions<ExerciseType> options)
        {
            throw new NotImplementedException();
        }

        public void SaveChanges()
        {
            return;
        }

        public void Update(ExerciseType entity)
        {
            throw new NotImplementedException();
        }

        void IRepository<ExerciseType>.Delete(ExerciseType entity)
        {
            throw new NotImplementedException();
        }

        ExerciseType IRepository<ExerciseType>.Get(int id)
        {
            throw new NotImplementedException();
        }

        ExerciseType IRepository<ExerciseType>.Get(string id)
        {
            throw new NotImplementedException();
        }

        ExerciseType IRepository<ExerciseType>.Get(QueryOptions<ExerciseType> options)
        {
            throw new NotImplementedException();
        }

        void IRepository<ExerciseType>.Insert(ExerciseType entity)
        {
            throw new NotImplementedException();
        }

        IEnumerable<ExerciseType> IRepository<ExerciseType>.List(QueryOptions<ExerciseType> options)
        {
            throw new NotImplementedException();
        }

        void IRepository<ExerciseType>.Update(ExerciseType entity)
        {
            throw new NotImplementedException();
        }
    }
}
