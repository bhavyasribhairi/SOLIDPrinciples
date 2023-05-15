// See https://aka.ms/new-console-template for more information
using LiskovSubstitution;

Console.WriteLine("Liskov Substitution principle");
Rectangle rectangle= new Rectangle { Width = 4, Height = 5 };
Square square= new Square { Side=5};

var Shapes= new Shape[] { square, rectangle };
var calculator = new AreaCalculator();
calculator.CalculateTotalArea(Shapes);

