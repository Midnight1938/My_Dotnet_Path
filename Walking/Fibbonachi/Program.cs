int numbers = 17;
int result = Fibbonachi(numbers);
//Console.Write($"The numbers are {result}");
Console.Write($"The Sum of the first {numbers} numbers is: {result}");

static int Fibbonachi(int n)
{
/*
    int num1 = 0;
    int num2 = 1;
    int sum = 0;
*/
    if (n < 2)
    {
        return n;
    }
    else{
        return Fibbonachi(n-1)+ Fibbonachi(n-2);
    }
/*
    for (int i = 2; i <= n; i++)
    {
        sum = num1 + num2;
        num1 = num2;
        num2 = sum;
    }

    return n == 0 ? num1 : num2;
*/
}
