﻿using BetterBuiltWorkouts.Data;
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
            return new ExerciseType();
        }

        public void Insert(ExerciseType entity)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<ExerciseType> List(QueryOptions<ExerciseType> options)
        {
            return new List<ExerciseType>();
        }

        public void SaveChanges()
        {
            return;
        }

        public void Update(ExerciseType entity)
        {
            throw new NotImplementedException();
        }
    }
}
