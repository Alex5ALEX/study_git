

static int sum(int a,int b, out int temp)
{
    temp =  a + b;
    return temp;
}


int temp = 0;

sum(10, 12,out temp);


Console.WriteLine(temp);
