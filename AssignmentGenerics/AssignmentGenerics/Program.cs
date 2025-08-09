// See https://aka.ms/new-console-template for more information
using AssignmentGenerics;
using AssignmentGenerics.DataModels;

Console.WriteLine("Hello, World!");

MyStack<int> stack = new MyStack<int>();
stack.Push(1);
stack.Push(2);
stack.Push(3);
stack.Push(63);
Console.WriteLine("Stack");
Console.WriteLine("Count: " + stack.Count());
Console.WriteLine("Pop Element: " + stack.Pop());
Console.WriteLine("Pop Element: " + stack.Pop());
Console.WriteLine("Count: " + stack.Count());

Console.WriteLine();
Console.WriteLine("List");
MyList<string> list = new MyList<string>();
list.Add("C#");
list.Add("Java");
list.Add("Python");
list.Add("C");
list.Add("Go");
Console.WriteLine("Remove Index - 1 : " + list.Remove(1));

Console.WriteLine("Contains Java: "+ list.Contains("Java"));
list.Find(1);
list.DeleteAt(1);
list.Clear();

GenericRepository<Customer> gc = new GenericRepository<Customer>();
gc.Add(new Customer { Id = 1, Name = "Rob", Age = 43 });
gc.Add(new Customer { Id = 2, Name = "John", Age = 43 });
var co = gc.GetById(1);
Console.WriteLine(co.Name);
var allGc = gc.GetAll();
Console.WriteLine("Customer Names: ");
foreach(var customer in allGc)
{
    Console.WriteLine(customer.Name);

}
gc.Remove(co);
allGc = gc.GetAll();
Console.WriteLine("Customer Names after removal: ");
foreach (var customer in allGc)
{
    Console.WriteLine(customer.Name);

}







