using System;
using System.Collections.Generic;
using System.Data.Entity.Spatial;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hackdecode.SQLSpatial
{
    class Program
    {
        static void Main(string[] args)
        {
        }

        /// <summary>
        /// Create Point using a helper method 
        /// </summary>
        /// <param name="latitude"></param>
        /// <param name="longitude"></param>
        /// <returns></returns>
        public static DbGeography CreatePoint(double latitude, double longitude)
        {
            // 4326 is most common used coordinate system used in Maps
            return DbGeography.FromText($"POINT({latitude} {longitude})", 4326);
        }
    }
}
