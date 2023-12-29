public class Solution 
{
    public List<string> FizzBuzz(int n) 
    {
        List<string> answer = new List<string>(n);
        
        for( int i = 1; i <= n; i++)
        {
            bool divisibleBy3 = i % 3 == 0;
            bool divisibleBy5 = i % 5 == 0;
            if(divisibleBy3 && divisibleBy5){
                answer.Add("FizzBuzz");
            }
            else if(divisibleBy3){
                answer.Add("Fizz");
            }
            else if(divisibleBy5){
                answer.Add("Buzz");
            }
            else{
                answer.Add(i.ToString());
            }
        }
        
        return answer;
    }
}