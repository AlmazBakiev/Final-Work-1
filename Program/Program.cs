Console.Clear();

string[] strArray = { "Hello", "2", "world", ":-)" };
string[] newStrArray = SearchWordsLargerFourChar(strArray);
PrintArray(newStrArray);


string[] SearchWordsLargerFourChar(string[] array)
{
    int counterForLength = 0;
    foreach (string el in array)
    {
        if (el.Length < 4) counterForLength++;
    }

    string[] result = new string[counterForLength];

    if (result.Length == 0) return result;

    for (int i = 0, j = 0; i < array.Length; i++)
    {
        if (array[i].Length < 4)
        {
            result[j] = array[i];
            j++;
        }
    }
    return result;
}

void PrintArray(string[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        if (i == array.Length - 1) Console.WriteLine(array[array.Length - 1]);
        else Console.Write(array[i] + ", ");
    }
}