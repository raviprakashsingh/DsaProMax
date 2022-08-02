// Find a given number is prime or not.

private static bool IsPrimeNumber(int num) 
{
    int count = 0;
    for(int i  = 1; (i * i) <= num; i++) 
    {
        if(num%i == 0) 
        {
            count++;
            if(num != 1 && num%i != i) 
            {
                count++;
            }
        }
    }
    if(count == 2) 
    {
        return true;
    }
    return false;
}
