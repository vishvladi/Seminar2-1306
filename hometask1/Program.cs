// Напиши программу, которая принимает на вход трехзначное число и на выходе показывает 
//вторую цифру этого числа.
int ReadInt(string message){
    System.Console.Write(message);
    int inputedValue = Convert.ToInt32(Console.ReadLine());
    return inputedValue;
}
bool Validate3sign(int number)
{ if (number > 100 && number < 1000)
     {return true;
     }
System.Console.WriteLine($"Число {number}  не трехзначное");
return false;
}
int num = ReadInt("Введите число: ");
if (Validate3sign(num))
 {int secondDigital = num / 10 % 10;
 System.Console.WriteLine($"Вторая цифра в числе {num} равна {secondDigital}");

 }




