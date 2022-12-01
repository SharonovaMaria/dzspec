
// string[] array = Ask();
// string[] result = NewArray(array, 3);
// Console.WriteLine($"[{string.Join(", ", array)}] -> [{string.Join(", ", result)}]");

// string[] NewArray(string[] array, int n){
//     string[] newArray = new string[Count(array,n)];
//     for (int i = 0,j=0; i < array.Length; i++)
//     {
//         if(array[i].Length<=n){
//             newArray[j]=array[i];
//             j++;
//         }
//     }
//     return newArray;
// }

// int Count(string [] array, int n){
//     int count = 0;
//     for (int j = 0; j < array.Length; j++)
//     {
//         if(array[j].Length <= n){
//             count++;
//         }
//     }
//     return count;
// }

// string[] Ask(){
//     Console.WriteLine("vvedite dannie v massiv cherez probel");
//     return Console.ReadLine().Split(" ");
// }

Console.WriteLine("skolko elementov?");
int size = Convert.ToInt32(Console.ReadLine());

string[] array = new string[size];
for (int i = 0; i < size; i++)
{
    Console.WriteLine($"vvedite {i+1} element");
    string element = Convert.ToString(Console.ReadLine());
    array[i]=element;
}


string[] changeArray = new string[size];
int temp =3;
int count = 0;
for (int j = 0; j < size; j++)
{
    if(array[j].Length<=3){
        changeArray[count]= array[j];
        count++;
    }
    
}

Console.WriteLine();
PrintArray(changeArray);

void PrintArray(string [] array){
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write(array[i]+"  ");
    }
    Console.WriteLine();
}
















