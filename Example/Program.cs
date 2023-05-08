// Задача: Написать программу, которая из имеющегося массива строк 
//формирует новый массив из строк, длина которых меньше, либо равна 3 символам. 
//Первоначальный массив можно ввести с клавиатуры, либо задать на старте выполнения алгоритма. 
//При решении не рекомендуется пользоваться коллекциями, лучше обойтись исключительно массивами.


Console.Write("Введите размерность массива: ");
int m = Convert.ToInt32(Console.ReadLine());
string [] strArray = new string [m];

void FirstArray(string [] strArray)
{
  for (int i = 0; i < strArray.Length; i++)
  {
     Console.WriteLine($"Введите {i+1} элемент массива");
     strArray[i] = Console.ReadLine();
  }
}

void PrintFirstArray(string [] strArray)
{
    Console.Write("[");
        {
        for (int i = 0; i < strArray.Length; i++)
            {
            Console.Write($"{strArray[i]},");
            }
        }
    Console.Write("]");
}

void PrintNewArray(string [] strArray)
{
    Console.Write("[");
        {   
            int m = 3;
            if (strArray.Length > m)
                {
                    for (int i = 0; i < m; i++)                             
                        {
                        Console.Write($"{strArray[i]},");
                        }
                }
        }
    Console.Write("]");
}


FirstArray(strArray);
Console.WriteLine("Исходный массив: ");
PrintFirstArray(strArray);
Console.WriteLine();
Console.WriteLine("Новый массив: ");
PrintNewArray(strArray);

