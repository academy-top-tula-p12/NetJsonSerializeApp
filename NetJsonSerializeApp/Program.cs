using System.IO;
using System.Text;
using System.Text.Json;
using NetJsonSerializeApp;


List<Employee> employees = new()
{
    new(){ Name = "Joe", Age = 26 },
    new(){ Name = "Ben", Age = 18},
    new(){ Name = "Sam", Age = 35 },
    new(){ Name = "Leo", Age = 28 },
};

Employee employee = new()
{
    Name = "Bill",
    Age = 33,
    Company = new Company() { Title = "Yandex", City = "Moscow" }
};

JsonSerializerOptions options = new JsonSerializerOptions()
{
    AllowTrailingCommas = true,
    WriteIndented = true,
};


// serialize non generic
//string json = JsonSerializer.Serialize(employee, options);
//Console.WriteLine(json);

//Employee employeeRestore = (Employee)JsonSerializer.Deserialize(json, typeof(Employee));
//Console.WriteLine($"{employeeRestore.Name} {employeeRestore.Age}");


// serialize generic
string employeeJson = JsonSerializer.Serialize<Employee>(employee, options);
//string employeesJson = JsonSerializer.Serialize<List<Employee>>(employees, options);

Console.WriteLine(employeeJson);
//Console.WriteLine();
//Console.WriteLine(employeesJson);

//Employee? empl = JsonSerializer.Deserialize<Employee>(employeeJson);
//List<Employee>? empls = JsonSerializer.Deserialize<List<Employee>>(employeesJson);

//Console.WriteLine(empl);
//Console.WriteLine();
//foreach (var e in empls)
//    Console.WriteLine(e);



//file serialize
//using (FileStream stream = new FileStream("user.json", FileMode.Create))
//{
//    await JsonSerializer.SerializeAsync<Employee>(stream, employee);
//    stream.Write(Encoding.UTF8.GetBytes("\n"));
//    Console.WriteLine("data write to file");
//}

//using (FileStream stream = new FileStream("user.json", FileMode.Append))
//{
//    await JsonSerializer.SerializeAsync<List<Employee>>(stream, employees);
//    Console.WriteLine("datas write to file");
//}


//using (FileStream stream = new FileStream("user.json", FileMode.Open))
//using (StreamReader reader = File.OpenText("user.json"))
//{
//    string? emplStr = reader.ReadLine();
//    Stream s = new MemoryStream(Encoding.UTF8.GetBytes(emplStr));

//    Employee? employeeRestore = JsonSerializer.Deserialize<Employee>(s, options);
//    Console.WriteLine(employeeRestore);

//    emplStr = reader.ReadToEnd();
//    s = new MemoryStream(Encoding.UTF8.GetBytes(emplStr));
//    List<Employee>? employeesRestore = JsonSerializer.Deserialize<List<Employee>>(s, options);
//    foreach (var e in employeesRestore)
//        Console.WriteLine(e);

//}

//using (FileStream stream = new FileStream("user.json", FileMode.Open))
//{
//    List<Employee>? employeesRestore = JsonSerializer.Deserialize<List<Employee>>(stream);
//    foreach(var e in employeesRestore)
//        Console.WriteLine(e);
//}


