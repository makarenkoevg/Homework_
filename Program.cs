using System;
using static System.Console;

Clear();


Write("Введите массив данных через ',': ");
string str = ReadLine();
string[] array = str.Split(",");
int len=3;

WriteLine($"[{string.Join(",", array)}]=>[{string.Join(",", newArray(array,len))}]");

string[] newArray(string[] arr, int len){

    string[] outArr = new string[0];
    int j=0;

    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i].Length <= len)
        {
            j+=1;
            Array.Resize(ref outArr, j);
            outArr[j-1] = arr[i];
        }

    }
    return outArr;
}
