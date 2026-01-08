Console.WriteLine("Student Report");
int score;
string name;

Console.WriteLine("Student's Name; ");
name =  Console.ReadLine();

Console.Write("Score :");
score = int.Parse(Console.ReadLine());

if (score >= 80) Console.WriteLine("You Pass");
else Console.WriteLine("You fail!");