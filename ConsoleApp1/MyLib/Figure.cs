namespace MyLib
{
    public abstract class Figure
    {
        public abstract double CalculateSquare();
    }

    public class Circle : Figure
    {
        private double radius;
        private const double pi = 3.14;

        public Circle(double radius)
        {
            this.radius = radius;
        }

        public override double CalculateSquare()
        {
            return this.radius * this.radius * pi;
        }
    }

    public class Triangle : Figure
    {
        private double a, b, c;

        public Triangle(double a, double b, double c)
        {
            this.a = a;
            this.b = b;
            this.c = c;
        }

        public bool isRightTriangle()
        {
            if(c > a && c > b)
            {
                if(c * c == a * a + b * b) return true;
                else return false;
            } else if(b > a && b > c)
            {
                if (b * b == a * a + c * c) return true;
                else return false;
            } else if(a > b && a > c)
            {
                if (a * a == c * c + b * b) return true;
                else return false;
            }
            return false;
        }

        public override double CalculateSquare()
        {
            double S, P;
            P = (this.a + this.b + this.c)/2;
            S = Math.Sqrt(P*(P - this.a) * (P - this.b) * (P - this.c));
            return S;
        }
    }
}