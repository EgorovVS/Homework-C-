
Console.WriteLine("Вас приветствует программа нахождения большего из двух чисел");

Console.WriteLine("Введите первое число");

int i = Convert.ToInt16(Console.ReadLine());

Console.WriteLine("Введите второе число ");

int j = Convert.ToInt16(Console.ReadLine());

if(i==j){
    Console.WriteLine("Числа равны");
}
else if(i>j){
    Console.WriteLine(i + " больше, чем " + j);
}
else {
    Console.WriteLine(j + " больше, чем " + i);
}
   
        
    
