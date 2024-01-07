public class Solution 
{
    public int MySqrt(int x) 
    {
        if(x > 0)
        {
           for (double i = 0; i * i <= x; i++)
                {
                    if ( (i*i) <= x && (i+1)*(i+1) > x)
                    {
                        return (int)i;
                    }
                }

             return 0; 
        }
        return 0;
    }
}