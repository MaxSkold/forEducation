using getset;

UsualMethods obj = new("Max", 19);

string name = obj.GetName();
int age = obj.GetAge();

Console.WriteLine($"Name: {name} | Age: {age}\n");

//-----------------------------------------------

GetSet obj2 = new();
obj2.Name = "Dima";
obj2.Age = 18;

Console.WriteLine($"Name: {obj2.Name} | Age: {obj2.Age}\n");

//-----------------------------------------------

GetSetALT obj3 = new()
{
    Name = name,
    Age = age
};

Console.WriteLine($"Name: {obj3.Name} | Age: {obj3.Age}\n");

