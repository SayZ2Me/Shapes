namespace Shapes
{
    public class Shape
    {
        public virtual double Area { get; set; }
        public virtual void calculate_area () { }
    }

    public class Circle : Shape
    {
        public Circle()
            : this(0)
        { }

        public Circle(double radius)
        {
            if (radius >= 0)
            {
                Radius = radius;
                calculate_area();
            }
            else 
            {
                Radius = 0;
            }
        }
        public double Radius { get; set; }
        public override void calculate_area ()
        {
            Area = Radius * Radius * Math.PI;
        }
    }

    public class Triangle : Shape
    {
        public Triangle()
            : this(1,1,1)
        { }

        public Triangle(double a, double b, double c)
        {
            if (a > 0 & b > 0 & c > 0)
            {
                Sides[0] = a;
                Sides[1] = b;
                Sides[2] = c;
                calculate_area();
            }
            else
            {
                Sides[0] = 1;
                Sides[1] = 1;
                Sides[2] = 1;
                calculate_area();
            }
        }
        double[] Sides = new double[3];
        public override void calculate_area ()
        {
            double Perimetr = (Sides[0] + Sides[1] + Sides[2]) / 2;
            Area = Math.Sqrt(Perimetr * (Perimetr - Sides[0]) * (Perimetr - Sides[1]) * (Perimetr - Sides[2]));
        }
        public string IsRectangular()
        {
            Array.Sort(Sides);
            if (Sides[2] * Sides[2] == Sides[1] * Sides[1] + Sides[0] * Sides[0])
            {
                return "rectangular";
            }
            else
            {
                return "not rectangular";
            }
        }
    }
}
