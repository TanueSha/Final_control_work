// Задача: 
// Написать программу, которая из имеющегося массива строк формирует новый массив из строк, 
// длина которых меньше, либо равна 3 символам. Первоначальный массив можно ввести с клавиатуры, 
// либо задать на старте выполнения алгоритма. При решении не рекомендуется пользоваться коллекциями, 
// лучше обойтись исключительно массивами.
// Примеры:
// [“Hello”, “2”, “world”, “:-)”] → [“2”, “:-)”]
// [“1234”, “1567”, “-2”, “computer science”] → [“-2”]
// [“Russia”, “Denmark”, “Kazan”] → []


string[] array = {"Hello" , "2" , "world" , ":-)"};
int lenArray = 0;

// считаем количество строк
for (int i = 0; i < array.Length; i++)
{
    if (array[i].Length <= 3)
    {
        lenArray++;
    }
    
}

// создаем новый массив нужного размера
string[]NewArray = new string[lenArray];
int index = 0;

// заполняем новый массив строками нужного размера

for (int i = 0; i < array.Length; i++)
{
    if (array[i].Length <= 3)
    {
        NewArray[index] = array[i];
        index++;
    }
}

// Console.WriteLine($"[{string.Join(", ", array)}] → [{string.Join(", ", NewArray)}]");
PrintArray(array);
Console.Write("→ ");
PrintArray(NewArray);

//  Функция вывода массива в терминал
void PrintArray(string[] array)
{
    Console.Write("[ ");
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write($"“{array[i]}”, ");
    }
    Console.Write("] ");
}
