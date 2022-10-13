// // Вид 1 (тот что ничего не принимает и ничего не возвращает)
// // void Method1() //void - ключевое слово (означает не возвращаемый метод)
// // {
// //     Console.WriteLine("Автор...");
// // }
// //Method1();//вызывается обращением к имени метода и пустыми скобочками
// //Method1; // !!! это ошибочное написание










// // Вид 2 (тот что ничего не возвращают, но принимают какие-либо аргументы)
// // void Method2(string a)
// // {
// //     Console.WriteLine(a);
// // }
// // Method2("Текст сообщения");

// // void Method21(string a, int count)
// // {
// //     int i = 0;
// //     while (i < count)
// //     {
// //         Console.WriteLine(a);
// //         i++;
// //     }
// // }
// //Method21("Text", 4); //вариант первый метода 2.1
// //Method21(count: 4, a: "New text"); // явное указание







// // Вид 3 (что-то возвращают, но ничего не принимают)

// int Method3()
// {
//     return DateTime.Now.Year;
// }
// int a = Method3();
// //Console.WriteLine(a);











// // Вид 4 (что-то принимают и что-то возвращают)

// // string Method4(int count, string text)
// // {
// //     int i = 0;
// //     string result = String.Empty;
// //     while (i < count)
// //     {
// //         result = result + text;
// //         i++;
// //     }
// //     return result;
// // }

// string Method4(int count, string text)
// {
//     string result = String.Empty;
//     for (int i = 0; i < count; i++)
//     {
//         result = result + text;
//     }
//     return result;
// }

// string res = Method4(1, "Хвала Аллаху, Господу миров! ");
// //Console.WriteLine(res);

// //Таблица умножения до 10
// // for (int i = 2; i <= 10; i++)
// // {
// //     for (int j = 2; j <= 10; j++)
// //     {
// //         Console.WriteLine($"{i} x {j} = {i * j}");
// //     }
// //     Console.WriteLine();
// // }

// //===== Работа с текстом
// // Дан текст. В тексте нужно все пробелы заменить черточками,
// // маленькие буквы "к" заменить большими "К",
// // а большие "С" заменить маленькими "с".

// //Ясна ли задача?

// string text = "- Я думаю, - Сказал князь, улыбаясь, - что, "
//             + "ежели бы вас послали вместо нашего милого Винценгероде,"
//             + "вы бы взяли приступом согласие прусского короля. "
//             + "Вы так красноречивы. Вы дадите мне чаю?";


// string Replace(string text, char oldValue, char newValue)
// {
//     string result = String.Empty; //инициализация пустой строки

//     int length = text.Length;
//     for (int i = 0; i < length; i++)
//     {
//         if (text[i] == oldValue) result = result + $"{newValue}";
//         else result = result + $"{text[i]}";
//     }

//     return result;
// }

// string newText = Replace(text, ' ', '|');
// Console.WriteLine(newText);
// Console.WriteLine();

// newText = Replace(text, 'к', 'К');
// Console.WriteLine(newText);
// Console.WriteLine();

// newText = Replace(text, 'С', 'с');
// Console.WriteLine(newText);
// Console.WriteLine();

//Задача на выстраивание элементов массива от меньшего к большему

﻿int[] arr = { 1, 5, 4, 3, 2, 6, 7, 1, 1 };

void PrintArray(int[] array)
{
    int count = array.Length;

    for (int i = 0; i < count; i++)
    {
        Console.Write($"{array[i]} ");
    }
    Console.WriteLine();
}

void SelectionSort(int[] array) // выводит на консоль перечень данных массива
{
    for (int i = 0; i < array.Length - 1; i++)
    {
        int minPosition = i;

        for (int j = i + 1; j < array.Length; j++)
        {
            if (array[j] < array[minPosition]) minPosition = j;



        }

        int temporary = array[i];
        array[i] = array[minPosition];
        array[minPosition] = temporary;
    }
}

PrintArray(arr);
SelectionSort(arr);

PrintArray(arr);


