UserC user1 = new UserC() { Name = "Bob" };
UserC user2 = new UserC() { Name = "Bob" };

Console.WriteLine(user1.Equals(user2));

user1 = user2;
user2.Name = "Tom";
Console.WriteLine(user1);


UserS user3 = new UserS() { Name = "Bob" };
UserS user4 = new UserS() { Name = "Bob" };

Console.WriteLine(user3.Equals(user4));

user3 = user4;
user4.Name = "Tom";
Console.WriteLine(user3);





UserR user5 = new UserR() { Name = "Bob" };
UserR user6 = new UserR() { Name = "Bob" };

Console.WriteLine(user5.Equals(user6));

user5 = user6;
user6.Name = "Tom";
Console.WriteLine(user5);


UserRP tom = new("Tom", 45);
Console.WriteLine(tom);
tom.Name = "Tommy";


void AnonimObjects()
{
    var persons = new[]
{
    new
    {
        Name = "Leo",
        Status = true,
        Member = "admin",
        Age = 32
    },
    new
    {
        Name = "Tom",
        Status = false,
        Member = "member",
        Age = 35
    }
};

    var user = new
    {
        Name = "Leo",
        Status = true,
        Member = "admin",
        Age = 32
    };


    var tom = new
    {
        Name = "Tom",
        Status = false,
        Member = "member",
        Age = 35
    };



    Console.WriteLine(user.GetType().Name);
    Console.WriteLine(tom.GetType().Name);

    string answer = (user.Status) ? "yes" : "no";


    foreach (var p in persons)
        Console.WriteLine($"Name: {p.Name}, " +
            $"Age: {p.Age}, " +
            $"Member: {p.Member}");
}

void TupleExample()
{
    var tuple = (100, 200, "Hello");
    Console.WriteLine(tuple.Item1);
    Console.WriteLine(tuple.Item2);
    Console.WriteLine(tuple.Item3);

    int a = 20;
    int b = 30;
    Console.WriteLine($"{a} {b}");
    (b, a) = (a, b);
    Console.WriteLine($"{a} {b}");
}


class UserC
{
    public string Name { get; set; }
}

struct UserS
{
    public string Name { get; set; }
}

record UserR
{
    public string Name { get; set; }
}

readonly record struct UserRP(string Name, int Age);


