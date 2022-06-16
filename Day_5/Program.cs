int Heads = 0;
int Tails = 0;
double Hp = 0;
double Tp = 0;

Random hd = new Random();
int Flip = hd.Next(0,2);
int i = 0;
while ( i < 10)
{


    if (Flip < 0.5)
    {
        Console.WriteLine("Its Tails");
        Tails++;
         i++;
    }
    else
    {
        Console.WriteLine("Its Heads");
        Heads++;
        i++;
    }
}
Hp = Heads / .1;
Tp = Tails / .1;
Console.WriteLine("Heads percentage :" + Hp);
Console.WriteLine("Tails percentage :" + Tp);


      