
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