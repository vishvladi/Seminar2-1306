// Задача 2 Напишите программу, которая выводит третью цифру заданного числа, 
//или сообщает что третьей цифры нет
 int ReadInt(string message){
    System.Console.Write(message);
    int inputedValue = Convert.ToInt32(Console.ReadLine());
    return inputedValue;
}

int CountThirdDigit(int num){
    while (num > 999){
        num /= 10;
    }
    return num % 10;
}
bool ValidateNumber(int number){
    { if (number > 100)
    
        return true;
    }
    return false;
     
}
int number = ReadInt("Введите число : ");
if (ValidateNumber(number))
{
    Console.WriteLine(CountThirdDigit(number));
}
else{
    Console.WriteLine($"В числе {number} нет третей цифры");
}
