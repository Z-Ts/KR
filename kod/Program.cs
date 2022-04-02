using static System.Console;
string [] arr = new string[] { "1", "sdfsd", "12", "2123авваив", "йц654", "0о"};
int f = arr.Length;
string [] tempArr = new string [f];
int j = 0;
 
foreach (string i in arr)       //проход по каждому элементу массива
{
    int length = i.Length;
    if (length <= 3) 
   { 
    tempArr [j] =i;
    j++;
    }
}
string [] arrFin = new string [j];
j=0;
foreach (string i in tempArr) 
{
    if (i != null)
    {
     arrFin[j] = i;
    WriteLine (arrFin[j]);
    j++;
    }
}