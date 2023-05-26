//Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа. Обязательна проверка на ввод чисел больше/меньше 3-х знаков
/*Console.WriteLine("Введите трёхзначное число: ");
int number = int.Parse(Console.ReadLine()!); 
int result = (number/10)%10;
if (number>99) {
Console.WriteLine($"{number} -> {result}"); 
} 
else {
   Console.WriteLine($"Вы ввели не трёхзначное число");  
} */

//Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет. Берем числа до 100000
/*Console.WriteLine("Введите число до 100000: ");
int number1 = int.Parse(Console.ReadLine()!); 
int result1 = number1%10;
int result2 = (number1/10)%10;
int result3 = (number1/100)%10;
    if (number1>99&number1<1000){
Console.WriteLine($"{number1} -> {result1}"); 
} 
else {
  Console.WriteLine($"Третьей цифры нет");  
}
if (number1>999&number1<10000) {
Console.WriteLine($"{number1} -> {result2}"); 
} 
if (number1>9999&number1<100000) {
Console.WriteLine($"{number1} -> {result3}"); 
} 
*/


//Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным. Обязательна проверка на ввод числа <1 и >7
/*Console.WriteLine("Введите номер дня недели:");
int num = int.Parse(Console.ReadLine()!);
if (num<6){
    Console.WriteLine($"Нет"); 
}
if (num>5&num<8){
    Console.WriteLine($"Выходной"); 
}
if (num<1){
    Console.WriteLine($"Неверное число"); 
}
if (num>7){
    Console.WriteLine($"Неверное число"); 
} 
*/

