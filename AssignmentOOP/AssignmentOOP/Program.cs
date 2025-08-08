// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");

using AssignmentOOP;
using AssignmentOOP.Services;

int[] numbers = ReverseArray.GenerateArray(10);
ReverseArray.Reverse(numbers);
ReverseArray.PrintNumbers(numbers);

Console.WriteLine(Fibonacci.FibonacciSeries(3));
Console.WriteLine(Fibonacci.FibonacciSeries(8));

Dictionary<string, string> coursesTaken = new Dictionary<string, string>();
coursesTaken.Add("Database", "A");
coursesTaken.Add("Data Mining", "A");
coursesTaken.Add("Graphics", "B");
List<string> address = new List<string>();
address.Add("4313 rV, 22030");
StudentService studentService = new StudentService();
DateTime bday = new DateTime(2001, 06, 12);
studentService.add("Shruthi", coursesTaken, bday, address);
studentService.display();
Console.WriteLine("Grade: " + studentService.CalculateGPA(coursesTaken));
Console.WriteLine("Age: " + studentService.CalculateAge("Shruthi"));
List<string> stuAddress = studentService.GetAllAddress("Shruthi");
foreach(string a in stuAddress)
{
   Console.WriteLine(a);
}



//Ball pop
Color color1 = new Color(221, 233, 244);
Color color2 = new Color(56, 67, 67);
Ball ball1 = new Ball(3, color1);
Ball ball2 = new Ball(5, color2);
Ball ball3 = new Ball(2, color1);

ball1.Throw();
ball1.Pop();
ball1.Throw();
ball1.Throw();

ball2.Throw();
ball2.Throw();
ball2.Pop();
ball2.Throw();

ball3.Throw();
ball3.Pop();
ball3.Throw();
ball3.Throw();

Console.WriteLine("Ball 1: " + ball1.GetTimeThrown());
Console.WriteLine("Ball 2: " + ball2.GetTimeThrown());
Console.WriteLine("Ball 3: " + ball3.GetTimeThrown());