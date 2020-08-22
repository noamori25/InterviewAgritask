using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterviewAgritask
{
   public abstract class GrowerField
    {
        public FieldPoint[,] FieldPlanning;
        public int Id;
        public string Name;
        public int Length;
        public int Width;
        List<FieldPoint> FieldPoints;
        

        public GrowerField (string name, int length, int width)
        {
            this.Name = name;
            this.Length = length;
            this.Width = width;
            FieldPoints = new List<FieldPoint>();
            FieldPlanning = new FieldPoint[Width, Length];
        }

        //the path changing in each field by the field's area and the amount of the points.
        //the function will calculate according to the distance of the points in the field the shortest way.
        //to each type of field will be differently implement, acccording field's structure.
        abstract public void GetTheShortestPath(double fieldArea, List<FieldPoint> points);

        //the area calculate could change to each type of field
        abstract public double CalcFieldArea();

        //creating and adding a new point if succeeded return true, else return false
        public bool AddPoint(DateTime timeStamp, int location, double plantHieght, double avgLeafLength, int totalNumberOfIndescts)
        {
            return true;
        }
        //delete point by location
        public bool DeletePoint(int location)
        {
            return true;
        }
        //update point by location
        public bool UpdateField(int location)
        {
            return true;
        }

    }
}
