
Console.WriteLine("Программа отображения четных чисел. При вводе N выводит все четные числа от 1 до N");

Console.WriteLine("Введите число");

int N = Convert.ToInt32(Console.ReadLine());
int i = 2;
for(i = 2; i<N; i+=2){
Console.WriteLine(i);
}