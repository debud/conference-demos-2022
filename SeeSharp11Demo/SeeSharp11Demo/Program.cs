using SeeSharp11Demo;

Console.WriteLine("Hello World!");

Foo foo = new();

foo.ExamineNameSize();
foo.CheckList();

Literals literals = new();

public class Foo
{
    [OldGeneric(typeof(int))]
    public string Title { get; set; }

    [NewGeneric<Foo>]
    public string Name { get; set; } = "Deni";

    public void CheckList()
    {
        int[] list = { 1, 2, 3, 4 };

        Console.WriteLine(list is [1, 2, 3, 4]);
        Console.WriteLine(list is [1, _, 3, 4]);
        Console.WriteLine(list is [1, .., 4]);
    }

    public void ExamineNameSize()
    {
        string result = $"Your name is {Name.Length switch
        {
            < 3 => " short",
            > 15 => " long",
            _ => " just right",
        }}";

        switch (Name.Length)
        {
            case < 3:
                result += " short";
                break;
            case < 15:
                result += " long";
                break;
            default:
                result += " just right";
                break;
        }

        Console.WriteLine(result);
    }
}