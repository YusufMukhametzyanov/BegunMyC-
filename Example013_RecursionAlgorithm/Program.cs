// string[,] table = new string[2, 5];
//для того чтобы нам обратиться к нужному элементу двумерного массива мы указываем наименование массива
//и далее в квадратных скобках сначала индекс строки, затем индекс столбца
// table[1, 2] = "слово";
// for (int rows = 0; rows < 2; rows++)
// {
//     for (int columns = 0; columns < 5; columns++)
//     {
//         Console.WriteLine($"-{table[rows, columns]}-");
//     }
// }


// void PrintArray(int[,] matr)
// {
//     for (int i = 0; i < matr.GetLength(0); i++) //вместо аргумента matrix.GetLength(0) можно прописать цифру 3, т.е. обратиться к размеру строк
//     {
//         for (int j = 0; j < matr.GetLength(1); j++) //вместо аргумента matrix.GetLength(1) можно прописать цифру 4, т.е. обратиться к размеру столбцов
//         {
//             Console.Write($"{matr[i, j]} ");
//         }
//         Console.WriteLine();
//     }
// }

// void FillArray(int[,] matr)
// {
//     for (int i = 0; i < matr.GetLength(0); i++)
//     {
//         for (int j = 0; j < matr.GetLength(1); j++)
//         {
//             matr[i,j] = new Random().Next(1,10);
//         }
//     }
// }

// int[,] matrix = new int[20, 80];

// PrintArray(matrix);
// Console.WriteLine();
// FillArray(matrix);
// PrintArray(matrix);

// Вычисление факториала

// int Factorial(int n)
// {   //1! = 1
//     //0! = 1
//     if (n == 1) return 1;
//     else return n * Factorial(n - 1);
// }

// Console.WriteLine(Factorial(5)); //1*2*3=6

// f(1) = 1
// f(2) = 1
// f(n) = f(n-1) + f(n-2)

double Fibonacci(int n)
{
    if (n == 1 || n == 2) return 1;
    else return Fibonacci(n - 1) + Fibonacci(n - 2);
}

for (int i = 1; i < 40; i++)
{
    Console.WriteLine($"f({i}) = {Fibonacci(i)}");
}