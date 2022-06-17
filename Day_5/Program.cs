
Console.WriteLine("Write a Number");
int P = Convert.ToInt32(Console.ReadLine());
int N;

for ( N=1;(N*N <= P);N++ )
{
    if((P % N ==0))
    
    Console.WriteLine(N+ "is PrimeFactor ");
   
}
