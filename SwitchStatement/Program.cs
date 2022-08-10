Console.WriteLine("What is your favorite school subject?");
var subject = Console.ReadLine().ToLower();

switch (subject)
{
    case "science":
        Console.WriteLine("You know I'm somewhat of a scientist myself.");
        break;
    case "math":
        Console.WriteLine("Not my favorite but you do you.");
        break;
    case "music":
        Console.WriteLine("Party on Wayne!");
        break;
    case "sports":
        Console.WriteLine("If you're not first you're last!");
        break;
    default:
        Console.WriteLine("Interesting....");
        break;
}
