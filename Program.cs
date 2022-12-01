
string[] array = Ask();
string[] result = NewArray(array, 3);
Console.WriteLine($"[{string.Join(", ", array)}] -> [{string.Join(", ", result)}]");

string[] NewArray(string[] array, int n){
    string[] newArray = new string[Count(array,n)];
    for (int i = 0,j=0; i < array.Length; i++)
    {
        if(array[i].Length<=n){
            newArray[j]=array[i];
            j++;
        }
    }
    return newArray;
}

int Count(string [] array, int n){
    int count = 0;
    for (int j = 0; j < array.Length; j++)
    {
        if(array[j].Length <= n){
            count++;
        }
    }
    return count;
}

string[] Ask(){
    Console.WriteLine("vvedite dannie v massiv cherez probel");
    return Console.ReadLine().Split(" ");
}