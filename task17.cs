
namespace task17
{
    public class Geometricfigure
    {
        private int coordScenter; // поля
       
        public int CoordScenter { get; set; } //свойство

        public Geometricfigure(int coordScente) //конструктор
        {
            CoordScenter = coordScente;
        }
    }

    class Sqaure : Geometricfigure // класс наследник 1
    {
        public double  SmeStor1 { get; set; } //  знач. смещения стороны
        public double SmeStor2 { get; set; } //  знач. смещения стороны
        public double SmeStor3 { get; set; } //  знач. смещения стороны
        public double SmeStor4 { get; set; } //  знач. смещения стороны

        public Sqaure(int coordScente, double smeStor1, double smeStor2, double smeStor3, double smeStor4) : base(coordScente)
        {
            SmeStor1 = smeStor1;
            SmeStor1 = smeStor2;
            SmeStor1 = smeStor3;
            SmeStor1 = smeStor4;

        }
        public void draw1()
        {
            //используя координату центра и значение смещения от неё четырех других сторон "строим" квадрат
        }

    }

    class Circle : Geometricfigure // класс наследник 2
    {
        public double Radius { get; set; } // радиус

        public Circle(int coordScente, double radius) : base(coordScente)
        {
            Radius = radius;
        }

        public void draw2()
        {
            //используя центр и радиус "чертим" круг
        }
    }

    class task17
    {
        static void Main(string[] args)
        {
            Sqaure S1 = new Sqaure(6, 12, 12, 12, 12); // создаем объект квадрат и задаем координаты центра и радиус
            S1.draw1(); // "рисуем" круг
            Circle C1 = new Circle(6, 10);
            // создаем объект круг и задаем координаты задаем координаты центра и радиус
            C1.draw2(); // "рисуем" треугольник
        }
    }
}