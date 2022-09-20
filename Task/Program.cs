// Написать программу, которая из имеющегося массива строк формирует новый массив из строк, 
// длина которых меньше, либо равна 3 символам. 
// Первоначальный массив можно ввести с клавиатуры, либо задать на старте выполнения алгоритма.
// При решении не рекомендуется пользоваться коллекциями, лучше обойтись исключительно массивами.

// Примеры:
// ["Hello", "2", "world", ":-)"] → ["2", ":-)"]
// ["1234", "1567", "-2", "computer science"] → ["-2"]
// ["Russia", "Denmark", "Kazan"] → []

string[] arrayA = {"Hello", "2", "world", ":-)", "152", "md"};
string[] arrayB = new string[arrayA.Length]; 
int count = 0;

void SecondArray(string[] arrayA, string[] arrayB)
{
for (int i = 0; i < arrayA.Length; i++)
    {  
        if (arrayA[i].Length <= 3)
        {
            arrayB[count] = arrayA[i];
            count++;
        }
    }
}


void PrintArray(string[] array)
{
    for (int i = 0; i < array.Length; i++)
     {
        Console.Write(array[i] + " ");
     }
}
SecondArray(arrayA, arrayB);
PrintArray(arrayB);