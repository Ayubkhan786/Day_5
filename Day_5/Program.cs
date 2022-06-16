int firstNum = 100;
int secNum = 50;

firstNum *=secNum; 
secNum = firstNum / secNum; 
firstNum /= secNum; 

Console.WriteLine("SwapValue of firstNum :" + firstNum);
Console.WriteLine("SwapValue of secNum:" + secNum);