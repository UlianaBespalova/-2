using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Лаба2
{
    class Program
    {
        static void Main(string[] args)
        {
            Rectangle rect = new Rectangle(3, 4);  //создали объект класса Прямоугольник размером 3на4, блабла
            Square sq = new Square(8);
            Circle circle = new Circle(5);

            rect.Print(); //вывели ответ
            sq.Print();
            circle.Print();


            Console.ReadLine();
        }
    }


    abstract class Figure //геометрическая фигура
    {
        string _Type;
        public string Type  //свойство
        {
            get
            {
                return this._Type;
            }

            protected set
            {
                this._Type = value;
            }
        }

        public virtual double Area() { return 0; } //заготовка для площади

        public override string ToString() //вывод ответа
        {
            return ("Площадь " + this.Type + "а = " + this.Area().ToString());
        }

        interface IPrint //заготовка для интерфейса
        {
            void Print();
        }
    }


    class Rectangle : Figure
    {
        double A, B; //длина и высота

        public Rectangle(double a, double b)//конструктор. 
        {
            this.A = a;
            this.B = b;
            this.Type = "Прямоугольник";
        }

        public override double Area()
        {
            return this.A * this.B;
        }

        public void Print()
        {
            Console.WriteLine(this.ToString());
        }
    }


    class Square : Rectangle
    {
        public Square(double size) //присвоили значения сторонам с использованием базового конструктора
            : base(size, size)
        {
            this.Type = "Квадрат";
        }
    }



    class Circle : Figure
    {
        double r;

        public Circle(double R)
        {
            this.r = R;
            this.Type = "Круг";
        }

        public override double Area()
        {
            return Math.PI * this.r * this.r;
        }

        public void Print()
        {
            Console.WriteLine(this.ToString());
        }

    }

}