string[] firstArray = new string[6] { "12345", "23", "GeekBrains", "computer science", "world", "-45" };
string[] secondArray = new string[firstArray.Length];

FillSecondArray(firstArray, econdArray);
PrintArray(secondArray);

void FillSecondArray(string[] array1, string[] array2)
{
    int count = 0;
    for (int i = 0; i < array1.Length; i++)
    {
        if (array1[i].Length <= 3)
        {
            array2[count] = array1[i];
            count++;
        }
    }
}

