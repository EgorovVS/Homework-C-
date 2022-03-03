
Console.WriteLine("Программа для определения четности числа");  

Console.WriteLine("Введите число");

int i = Convert.ToInt32(Console.ReadLine());

if(i%2==0){
    Console.WriteLine("Число "+ i + "четное");
} 
else {
    Console.WriteLine("Число "+ i + " нечетное");
}
