// Задача 2 Напишите программу, которая принимает на вход цифру обзначающую день недели, 
// и проверяет, является ли этот день выходным.
 int ReadInt(string message){
    System.Console.Write(message);
    int inputedValue = Convert.ToInt32(Console.ReadLine());
    return inputedValue;
}
bool IsWeekday(int number){
    if(number > 0 && number <= 7)
    {return true;}
    Console.WriteLine("Это не день недели");
    return false;
}
bool IsDayoff(int number){
    if(number > 5)
    {return true;}
    return false;
}
int weekday = ReadInt("Введите день недели: ");
if(IsWeekday(weekday)){
    if(IsDayoff(weekday)){
        Console.WriteLine("Выходной день");
    }
    else
    {
      Console.WriteLine("Рабочий день");  
    }
}