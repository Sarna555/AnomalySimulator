using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnomaliePaliw
{
    public class Anomaly
    {
        int Id;
        AnomalyType type;
        Equation value;
        DateTime Start;
        DateTime End;

        public List<Anomaly> FakeData()
        {
            return new List<Anomaly>();
        }
        
    }
}
