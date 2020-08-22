using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterviewAgritask
{
   public class CornField : GrowerField
    {
        public CornField(string name, int length, int width) : base(name, length, width)
        {
        }

        public override double CalcFieldArea()
        {
            return this.Length * this.Width;
        }

        public override void GetTheShortestPath(double fieldArea, List<FieldPoint> points)
        {
            throw new NotImplementedException();
        }
    }
}
