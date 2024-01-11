using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccesse_Layer
{
    public interface ILocationRepository
    {
        public IEnumerable<Locations> GetLocation();
    }
}
