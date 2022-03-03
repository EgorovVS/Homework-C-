
Console.WriteLine("Программа для нахождения максимума из трех чисел");

Console.WriteLine("Введите первое число");
int i = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите второе число");
int j = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите третье число");
int k = Convert.ToInt32(Console.ReadLine());

int max = i;
if(j>i){
    max = j;
}
if(k>j){
    max = k;
}
Console.WriteLine("Максимальное число - "+ max);