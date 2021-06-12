
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TES.Module.Modules.CollisionMod.Reports.AnnualReport
{
    public class ChartArgument<T>
    {
        public int Order { get; set; }
        public T Value { get; set; }
        public override string ToString()
        {
            return Value.ToString();
        }
    }
}
