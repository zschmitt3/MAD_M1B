using ConsoleApp1;

public class main
{
    private static StreamWriter sw = new StreamWriter("animals.txt");
    private static StreamReader sr = new StreamReader("animals.txt");

    public static void Main(String[] args) {
        List<Talkable> zoo = new List<Talkable>();

        // Lines to Replace Begin Here
        zoo.Add(new Dog(true, "Bean"));
        zoo.Add(new Cat(9, "Charlie"));
        zoo.Add(new Teacher(44, "Stacy Read"));
        // End Lines to Replace

        foreach (Talkable thing in zoo) {
            PrintOut(thing);
        }
        sw.Close();
        sr.Read();
        sr.Close();

        StreamReader inData = new StreamReader("animals.txt");
        String line;
        while ((line = inData.ReadLine()) != null) {
            Console.WriteLine(line);
        }
    }

    public static void PrintOut(Talkable p) {
        Console.WriteLine(p.getName() + " says=" + p.talk());
        sw.Write(p.getName() + " | " + p.talk());
    }
}