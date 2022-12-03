/*Задача 41: Пользователь вводит с клавиатуры M чисел.
 Посчитайте, сколько чисел больше 0 ввёл пользователь.
0, 7, 8, -2, -2 -> 2
1, -7, 567, 89, 223-> 3*/

Console.Write("Введите числа через запятую: ");
string a =ReadDigitsFromConsole();
int count=0;
int j=0;
int[] arr=new int[IndexComa(a)];
char c=',';
string s = "";

for (int i=0; i<a.Length;i++)
{
    if (a[i]==c)
    {arr[j++]=Convert.ToInt32(s);
    s="";}
    else {s+=a[i];}
}
if (arr[j]!=c)
 {arr[j]=Convert.ToInt32(s);}
 PrintArray(arr);  

 for (int i=0; i<arr.Length; i++) 
 {
    if (arr[i]<0)
    {count++;}
 }
 Console.Write(" -> " + count);   
if (count==0) {Console.Write(" , Все числа положительные");}

int IndexComa(string s)
{   int countsymbol=1;
    for (int i=0; i<s.Length;i++)
    if(s[i]==',')
    {
      countsymbol++;  
    }
    return countsymbol;
}

string ReadDigitsFromConsole()
        {
            string result = "";
            while (true)
            {
                ConsoleKeyInfo key = Console.ReadKey(true);
                switch (key.Key)
                {
                    case ConsoleKey.Backspace:
                        if (result.Length > 0)
                        {
                            result = result.Remove(result.Length - 1, 1);
                            Console.Write(key.KeyChar + " " + key.KeyChar);
                        }
                        break;

                    case ConsoleKey.Enter:
                        Console.WriteLine();
                        return result;

                    case ConsoleKey.OemComma:

                        if (result[result.Length-1] == ',')
                        {Console.Write("\b"+ key.KeyChar);}
                        else {Console.Write(key.KeyChar);
                        result += key.KeyChar;}
                        break;
                    case ConsoleKey.OemMinus:

                        if (result.Length>0 && (result[result.Length-1] == '-' || char.IsDigit(result[result.Length-1])))
                        {Console.Write("\b"+result[result.Length-1]);}
                        else {Console.Write(key.KeyChar);
                        result += key.KeyChar;}
                        break;

                    default:
                        if (char.IsDigit(key.KeyChar) || key.KeyChar == '-' || key.KeyChar == ',')
                        {
                            {Console.Write(key.KeyChar);
                            result += key.KeyChar;
                            }
                        }
                        break;
                }
            }
        }

void PrintArray(int[] array)
{
    int count = array.Length;
    for (int i=0;i<count;i++)
    {
        Console.Write(array[i] + "|");
    }
}
