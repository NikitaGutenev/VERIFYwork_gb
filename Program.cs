String[] arr = {"hello","bye","Steve","Mia",":("};
int count = 0;
String[] array = new string[arr.Length];
for (int i = 0; i<arr.Length; i++)
{
    if (arr[i].Length <= 3) 
    {
        array[count] = arr[i];
        count++;
    }
}
for (int i = 0; i<array.Length; i++)
{
    Console.Write(array[i] + " ");
}