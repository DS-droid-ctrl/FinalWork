string[] stringArray = new string[4] { "Hello", "2", "world", ":-)" };
string[] newArray = new string[stringArray.Length];
int j = 0;
int size = 3;
for (int i = 0; i<stringArray.Length; i++)
{
    if (stringArray[i].Length <=size)
    {
        newArray[j]=stringArray[i];  
        j++;   
    }
}
Console.Write($"[{String.Join(" ", stringArray)}] -> ");
Console.Write($"[{String.Join(" ", newArray)}]");