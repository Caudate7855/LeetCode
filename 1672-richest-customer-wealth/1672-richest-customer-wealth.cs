public class Solution 
    {
        public int MaximumWealth(int[][] accounts) 
        {
            int maxWealthSoFar = 0;

            foreach (int[] customer in accounts)
            {
                int currentCustomerWealth = 0;
            
                foreach( int bank in  customer)
                {
                    currentCustomerWealth += bank;
                }
                
                maxWealthSoFar = Math.Max(maxWealthSoFar, currentCustomerWealth);
            }
        
            return maxWealthSoFar;
        }
    }