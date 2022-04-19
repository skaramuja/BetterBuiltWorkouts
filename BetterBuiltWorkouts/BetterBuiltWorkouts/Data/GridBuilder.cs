using BetterBuiltWorkouts.Extensions;
using BetterBuiltWorkouts.Models;
using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BetterBuiltWorkouts.Data
{
    public class GridBuilder
    {
        private const string RouteKey = "currentroute";

        protected RouteDictonary routes { get; set; }
        private ISession session { get; set; }

        public GridBuilder(ISession sess)
        {
            session = sess;
            routes = session.GetObject<RouteDictonary>(RouteKey) ?? new RouteDictonary();
        }

        public GridBuilder(ISession sess, GridDTO values, string defaultSortField)
        {
            session = sess;
            routes = new RouteDictonary();
            routes.PageNumber = values.PageNumber;
            routes.PageSize = values.PageSize;
            routes.FilterBy = values.FilterBy;
            //routes.SortField = values.SortField;
            //routes.SortDirection = values.SortDirection;

            SaveRouteSegments();
        }

        public void SaveRouteSegments() =>
            session.SetObject<RouteDictonary>(RouteKey, routes);

        public int GetTotalPages(int count)
        {
            int size = routes.PageSize;
            return (count + size - 1) / size;
        }

        public RouteDictonary CurrentRoute => routes;
    }

}
