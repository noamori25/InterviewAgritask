using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace InterviewAgritask
{
   public class FieldPoint
    {
        public DateTime TimeStamp;
        public Point Location;
        public double PlantHeight;
        public double AvgLeafLength;
        public int TotalNumberOfInsects;

        public FieldPoint(DateTime timeStamp, double plantHieght, double avgLeafLength, int totalNumberOfIndescts, int RowNumber, int ColumnNumber)
        {
            this.TimeStamp = timeStamp;
            this.PlantHeight = plantHieght;
            this.AvgLeafLength = avgLeafLength;
            this.TotalNumberOfInsects = totalNumberOfIndescts;
            Location = new Point(Convert.ToDouble(RowNumber), Convert.ToDouble(ColumnNumber));
        }

      
    }
}
