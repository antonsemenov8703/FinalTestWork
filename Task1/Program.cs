//Console.WriteLine("Введите массив строк:");
string [] array = {"Russia", "Denmark", "USA"};
string [] resultArray = new string[10];
for (int i=0; i<array.Length;i++)
{
    if (array[i].Length<=3)
    {
        Console.WriteLine($"{array[i]}");
        resultArray[] = array[i];
    }
}
