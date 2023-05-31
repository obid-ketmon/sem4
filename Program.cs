// Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16

/*
        Console.WriteLine("Введите число A:");
        int A = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Введите степень B:");
        int B = Convert.ToInt32(Console.ReadLine());

        int result = 1;

        for (int i = 1; i <= B; i++)
        {
            result *= A;
        }

        Console.WriteLine("Результат: " + result);*/


// Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
// 452 -> 11
// 82 -> 10
// 9012 -> 12

    /*    Console.WriteLine("Введите число:");
        int number = Convert.ToInt32(Console.ReadLine());

        int sum = 0;
        int temp = number;

        while (temp != 0)
        {
            int digit = temp % 10;
            sum += digit;
            temp /= 10;
        }

        Console.WriteLine("Сумма цифр числа: " + sum);*/



// Задача 29: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.
// 1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
// 6, 1, 33 -> [6, 1, 33]
/*
  int[] array = new int[8]; // Создание массива из 8 элементов

        // Заполнение массива значениями
        for (int i = 0; i < array.Length; i++)
        {
            Console.WriteLine("Введите элемент массива #" + (i + 1) + ":");
            array[i] = Convert.ToInt32(Console.ReadLine());
        }

        // Вывод элементов массива на экран
        Console.WriteLine("Элементы массива:");
    
        {
            Console.WriteLine ($"Массив: [ {String.Join("; ",array)} ]");
        }



 
/*