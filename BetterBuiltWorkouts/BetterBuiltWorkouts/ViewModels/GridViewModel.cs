using BetterBuiltWorkouts.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BetterBuiltWorkouts.Models
{
    public class GridViewModel<T>
    {
        public IEnumerable<T> Items { get; set; }
        public RouteDictonary CurrentRoute { get; set; }
        public int TotalPages { get; set; }
    }
}
