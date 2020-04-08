using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace CDPortfolio.Models
{
    public static class AddedCDs
    {
        private static List<CD> addCDresponses = new List<CD>();

        public static IEnumerable<CD> AddCDresponses
        {
            get
            {
                return addCDresponses;
            }
        }

        public static void AddCD(CD userAddedCD)
        {
            userAddedCD.Id = Interlocked.Increment(ref CD.nextId);
            addCDresponses.Add(userAddedCD);
        }
    }
}
