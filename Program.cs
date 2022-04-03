using static System.Console;

string[] Find3symb(string[] arr)
{
    int j = 0;
     for (int i = 0; i < arr.Length; i++)
    {
        if(arr[i].Length < 4) j++;
    }
    string[] res = new string[j];
    j = 0;
    for (int i = 0; i < arr.Length; i++)
    {
        if(arr[i].Length < 4) 
        {
            res[j] = arr[i];
            j++;
        }
    }
    return res;
}

WriteLine(String.Join(", ", Find3symb(new string[] {"hello", "2", "world", ":-)"})));
WriteLine(String.Join(", ", Find3symb(new string[] {"1234", "1567", "-2", "computer science"})));
WriteLine(String.Join(", ", Find3symb(new string[] {"Russia", "Denmark", "Kazan"})));