string[] array = { "Russia", "Denmark", "UK", "Finland", "USA", "India", "Peru" };
int count = 0;
CountShortLines(array);
string[] resultArray = new string[10];
FillArrayWithShortLines(array);
PrintArray(resultArray);

void CountShortLines(string[] arr1)
{
    count = 0;
    for (int i = 0; i < arr1.Length; i++)
    {
        if (arr1[i].Length <= 3) count++;
    }
}

void FillArrayWithShortLines(string[] arr)
{
    int j = 0;
    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i].Length <= 3)
        {
            resultArray[j] = arr[i];
            j++;
        }
    }
}

void PrintArray(string[] matr)
{
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        Console.Write($"{matr[i]} ");
    }
}