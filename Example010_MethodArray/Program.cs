int[] array = { 4, 12, 65, 12, 8, 3, 84, 14 };

int n=array.Length;
int find=12;
int index=0;

while(index<n)
{
    if(array[index]==find)
    {
        Console.WriteLine(index);
        break;//остановить проверку при первом совпадении
    }

    index++;
}