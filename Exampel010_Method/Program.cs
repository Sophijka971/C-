int [] array = {1,12,553,41,41,61,47,861,79}; 

int n = array.Length;
int find = 41;

int index = 0;

while (index < n)
{
    if(array[index] == find)
    {
        Console.WriteLine(index);
        break;
    }
    
    index++;
}