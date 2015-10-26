public abstract class Polygon
    {
        public Polygon()
        {
            NumberOfSides = 1;
            LengthOfSide = 1;
            NameOfShape = "Random Polygon";
        }
        public int NumberOfSides;
        public int LengthOfSide;
        public string NameOfShape;

        public abstract double GetArea();

        public string GetShapeName()
        {
            return NameOfShape;
        }

    }

    public class Square : Polygon
    {

        public string ColorOfTheSquare;

        public Square()
        {
            ColorOfTheSquare = "Red";
            NameOfShape = "Square";
            NumberOfSides = 4;
        }

        public override double GetArea()
        {
            return NumberOfSides * LengthOfSide;
        }
    }

    public class Triangle : Polygon
    {
        public Triangle()
        {
            NameOfShape = "Triangle";
            NumberOfSides = 3;
        }

        public override double GetArea()
        {
            return (.5 * LengthOfSide * LengthOfSide);
        }
    }


    public interface IStoppable
    {
        void Brake();
    }

    public interface ISteerable
    {

    }
    public abstract class Car : ISteerable
    {
        public string Make { get; set; }
        public string Model { get; set; }
        public int Year { get; set; }
        public string Color { get; set; }

        public int CurrentSpeed { get; set; }

        public void Drive(int speed)
        {
            CurrentSpeed = speed;
        }

    }

    public abstract class Truck : Car
    {
        public int LengthOfBed;
        public bool IsDiesel;
    }

    public class HondaAccord : Car, IStoppable
    {
        public HondaAccord()
        {

        }

        public void Brake()
        {
            CurrentSpeed = 0;
        }
    }

    public class Ford150 : Truck
    {

    }

    public class ChevySilverado : Truck, IStoppable
    {
        public void Brake()
        {
            CurrentSpeed = 1; //1 mph
        }
    }


    class Program
    {
        static void Main(string[] args)
        {
            HondaAccord danielsCar = new HondaAccord();
            ChevySilverado casonsdreamCar = new ChevySilverado();
            Ford150 tomsCar = new Ford150();

            Car[] cars = new Car[3];
            cars[0] = danielsCar;
            cars[1] = casonsdreamCar;
            cars[2] = tomsCar;

            IStoppable[] vehicles = new IStoppable[3];
            vehicles[0] = danielsCar;
            vehicles[1] = casonsdreamCar;
            //vehicles[2] = tomsCar;
            foreach (var v in vehicles)
            {
                v.Brake();
            }


            Square s = new Square();

            s.LengthOfSide = 10;

            Triangle t = new Triangle();
            t.LengthOfSide = 5;

            //Polygon p = new Polygon();
            //p.NumberOfSides = 6;
            //p.LengthOfSide = 10;

            var areaOfP = s.GetArea();
            Console.WriteLine($"The area is {areaOfP} for this {s.GetShapeName()}. # of sides: {s.NumberOfSides}. Length of Sides: {s.LengthOfSide}");

            var areaOfP2 = t.GetArea();
            Console.WriteLine($"The area is {areaOfP2} for this {t.GetShapeName()}. # of sides: {t.NumberOfSides}. Length of Sides: {t.LengthOfSide}");


            Console.ReadLine();
        }
    }
