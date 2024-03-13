## Learn the Fundamentals

### Syntax CSharp

#### Comment:
```C#
Đơn: // This is a single-line comment
Đa: /* This is a multi-line comment */
```

#### Data Types:
```C#
Dữ liệu nguyên thủy: int, float, double, char, bool, ...
Dữ liệu tham chiếu: string, object, ...
```
#### Variables:

```CSharp
Khai báo: <kieudulieu> <tenbien>;
Khởi tạo: <tenbien> = <giatri>;
Khai báo và khởi tạo: <kieudulieu> <tenbien> = <giatri>;
Hằng số: const <kieudulieu> <tenbien> = <giatri>;
```

#### Operators:
```C#
Đại số: +, -, *, /, %
So sánh: ==, !=, <, >, <=, >=
Logic: &&, ||, !
```


### Variables and Data Types

```C#
string s = "string";
int a = 100;
float x= 100.2f;
decimal  d = 10.3m;
bool b = false;
double d = 10.3982; 
var k = 100;
```



### Conditionals
```C#
if(<dieukien>)
{
    // khoi lenh
}


if(<dieukien>)
{
    // khoi lenh
}
else
{
    // khoi lenh
}



if(<dieukien1>)
{
    // khoi lenh
}
else if(<dieukien2>)
{
    // khoi lenh
}
else
{
    // khoi lenh
}


switch(<dieukiensosánh>)
{
    case <giatrisosanh1>:
        // khoi lenh
        break;
    default:
        // khoi lenh
        break;
}
```

### Methods

```C#
private void Start()
{
        <goiham>
        Methods(<truyenthamso>);
}

public <kieudulieu>  Methods(<thamsotruyenvao> <kieudulieu> <tenbien>)
{
    // khoi lenh
    <cothecogiatritrave>
}

```

### Collections
```C#
List
List<kieudulieu> <tenbien> = new List<kieudulieu>();

Dictionary
Dictionary<kieudulieu> <tenbien> = new Dictionary<kieudulieu>();

Array
<kieudulieu> [] <tenbien>;
```


### Loops

```C#
for(<kieudulieu> <tenbien> = <giatribandau>; <tenbien> <bieuthucdieukien> <giatricuoi>; <buocnhay> )
{
    // khoi lenh
}
```

### Namespace

```C#
namespace <tenbien>
{
     
}
```


### String Interpolation

```C#
Console.WriteLine(<giatriinra>);
```

### 'Using' directives

```C#
using <tenthuvien>;
```


## Object-Oriented Programming

### Encapsulation
```C#
Example:
public class Perion
{
    // co the cho nguoi ta biet duoc 
    public int _name { get; set; }

    // khong cho nguoi ta biet duoc, chi truy cap qua phan tu thu 2
    private string _idBank { get; set; }
    public string IDBank
    {
        set => _idBank = value;
        get => _idBank;
    }
}



Classes
<mucdotruycap> class <tenclass>  
{
}

Structs
<mucdotruycap> struct <tenstruct>
{
    // khai bao
}

Records
<mucdotruycap> record <tendoituong>(<kieudulieu> tendulieu);

Primary Constructors
<mucdotruycap>  class <tenclass>  (<kieudulieu> <tendulieu>)
{
        <mucdotruycap> <kieudulieu> <tenbien> => <tendulieu>;
}
```


### Access Modifiers
```C#
Public
Internal
Protected
Private
```


### Inheritance
```C#
Interfaces
public interface IAnimal
{
    public void Call();
}
 
public interface IFly{
    public bool Fly();
}

public class Dog : IAnimal, IFly
{
    public void Call()
    {
        Debug.Log("Gau gau");
    }

    public bool Fly()
    {
       return false;
    }
}

public class Chicken : IAnimal, IFly
{
    public void Call()
    {
        Debug.Log("Meo meo");
    }
    public bool Fly()
    {
        return true;
    }
}

Abstract Classes

public abstract class IAnimal
{
    public abstract void Call();
}

public class Dog : IAnimal
{
    public override void Call()
    {
        Debug.Log("Gau gau");
    }
}

public class Chicken : IAnimal
{
    public override void Call()
    {
        Debug.Log("Meo meo");
    }
}
```


### Polymorphism

```C#

Virtual
public class Animal
{
    public virtual bool Fly()
    {
        return true;
    }
}

Override
public class Dog : Animal
{
    public override bool Fly()
    {
        return false;
    }
}

public class Bird : Animal
{

}

Using Base Classes
public class NewAnimal
{
    public void CreateAnimal()
    {
        Animal animal = new Animal();
        animal.Fly();
    }
}
```

## Going Deeper
### Enums
```C#
public enum EnumStateGame{
    none, start, play, pause, end 
}
public EnumStateGame stateGame;

public void SetStateGameWhenEndGame()
{
    stateGame = EnumStateGame.end;
}
```

### Object and Collection Initializers
```C#
public class NewPerson 
{
    Person person = new Person
    {
        FirstName = "John",
        LastName = "Doe"
    };
}

 public class Person
{
    public string FirstName { get; set; }
    public string LastName { get; set; }
}
```
### Lambdas

Arrow Functions
"=>" Operator
```C#

using System;

public class Bird : MonoBehaviour
{
    public void Lambda() => Debug.Log("Test Lambda");

    public void Show()
    {
        Func<int, int, int> lambda = (a, b) => a+b;
        Debug.Log(lambda(100, 200)); // 300
    }
    
}
```

### Asynchronous Programming
Tasks
Async
Await
Threads
 
```C#
using System;
using System.Threading.Tasks;

public class AsyncExample
{
    public async Task Main()
    {
        // Tạo một Task
        Task<int> task = Task.Run(() => Sum(3, 5));

        // Thực hiện các công việc khác trong khi Task đang chạy

        // Chờ đợi và lấy kết quả từ Task
        int result = await task;

        // In kết quả
        Console.WriteLine(result); // Kết quả là 8
    }

    public int Sum(int a, int b)
    {
        return a + b;
    }
}
```

### LINQ

```C#
using System;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

public class LinqInUnity
{
    private void Find()
    {
        IEnumerable<int> rsl = new List<int> { 1, 3, 4, 5, 6 }.Where(i => i % 2 == 0);
        foreach (var item in rsl)
        {
            Debug.Log(item);
        }
    }
}
```

### Generics

```C#
using UnityEngine;


public class GenericUnityCSharp
{
    public class Animal<T>
    {
        public T animal;
    }


    public class Dog
    {
        private string _name = "Dog";
        public string GetName()
        {
            return _name;
        }
        public void SetName(string _n)
        {
            _name = _n;
        }
    }


    public void Generic()
    {
        Animal<Dog> a = new Animal<Dog>();
        Debug.Log(a.animal.GetName());
        a.animal.SetName("Con cho");

        Animal<int> s = new Animal<int>();
        s.animal = 100;
        Debug.Log(s.animal);
    }
}
```

### Exception Handling
```C#
try
{
    // Code that might throw an exception
    int result = Divide(10, 0); // Division by zero will throw an exception
    Console.WriteLine(result);
}
catch (DivideByZeroException ex)
{
    // Handle specific exception types
    Console.WriteLine($"Error: {ex.Message}");
}
catch (Exception ex)
{
    // Handle other exceptions
    Console.WriteLine($"Unexpected error: {ex.Message}");
}
finally
{
    // Code that will be executed whether an exception occurs or not
    Console.WriteLine("This code always runs.");
}

int Divide(int a, int b)
{
    if (b == 0)
        throw new DivideByZeroException("Cannot divide by zero.");

    return a / b;
}
```
### Static

```C#
public class Dog
{
    public static string _name = "Dog";
}

public class Animal
{
    public void NameDog()
    {
        Debug.Log(Dog._name);
    }
}
```
### `Serialization`

```C#
using System;
using System.Text.Json;

public class Person
{
    public string FirstName { get; set; }
    public string LastName { get; set; }
}

public class SerializationExample
{
    public static void Main()
    {
        // Create a Person object
        Person person = new Person { FirstName = "John", LastName = "Doe" };

        // Serialize the object to JSON
        string jsonData = SerializeObjectToJson(person);
        Console.WriteLine("Serialized Data:\n" + jsonData);

        // Deserialize the JSON back to a Person object
        Person deserializedPerson = DeserializeObjectFromJson<Person>(jsonData);

        // Display the deserialized object
        Console.WriteLine("\nDeserialized Object:\n" +
                          $"FirstName: {deserializedPerson.FirstName}, LastName: {deserializedPerson.LastName}");
    }

    // Serialize an object to JSON
    private static string SerializeObjectToJson<T>(T obj)
    {
        return JsonSerializer.Serialize(obj);
    }

    // Deserialize an object from JSON
    private static T DeserializeObjectFromJson<T>(string jsonData)
    {
        return JsonSerializer.Deserialize<T>(jsonData);
    }
}

```

### Raw String Literals

```C#
string rawString = @"This is a raw string literal.It can span multiple lines.
No need to escape \ characters or special characters like \n, \t, etc.
It's great for writing regular expressions, file paths, JSON, XML, etc.";
```

### `Extension Methods`
```C#
using UnityEngine;

public static class Name
{    public static void GetName(this IAnimal _animal)
    {
        Debug.Log(_animal._name);
    }
}
public interface IAnimal
{
    public string _name { get; }
}
public class Extension
{
    public class Dog : IAnimal
    {
        public string _name
        {
            get => "Dog";
        }
    }
    public void Controller()
    {
        Dog dog = new Dog();
        dog.GetName();
    }
}
```
### Member Modifiers
```C#
Required
public class Person
{
    [Required]
    public string Name { get; set; }
}


Init
public class Example
{
    public int ReadOnlyProperty { get; init; }
}


Readonly
public class Example
{
    public readonly int ReadOnlyField;

    public Example(int value)
    {
        ReadOnlyField = value;
    }
}


Const
public class Example
{
    public const int ConstantValue = 42;
}
```
