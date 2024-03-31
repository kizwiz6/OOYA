namespace OOYA
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Profile sam = new Profile("Sam Drakkila", 30);
            sam.SetHobbies(new string[] {
        "Running",
        "reading",
        "gaming",
        "painting"
        });
            Console.WriteLine(sam.ViewProfile());
        }
    }
}
