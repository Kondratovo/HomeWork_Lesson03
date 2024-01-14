Console.WriteLine("Ведите натуральное число от 1 до 100000");
int inputNumber = Convert.ToInt32(Console.ReadLine());
//Проверка введенного числа
if (inputNumber <= 100000 && inputNumber >= 1)
{
    //Подсчет количества цифр
    int i = inputNumber;
    int countDigits = 0;
    while (i > 0) 
    {
        i /= 10;
        countDigits++;
    }
    //Запись числа по цифрам в массив
    int[] arrayFromInputNumber = new int[countDigits];
    for (i = countDigits-1; i >= 0; i--)
    {
        arrayFromInputNumber[i] = inputNumber % 10;
        inputNumber /= 10;
    }
    //Вывод массива на экран для проверки правильности заполнения масива
    for (i = 0; i < countDigits; i++)
    {
        Console.Write($"{arrayFromInputNumber[i]} ");
    } 
}

else 
{
    Console.WriteLine("Ведено некорректное число");
}