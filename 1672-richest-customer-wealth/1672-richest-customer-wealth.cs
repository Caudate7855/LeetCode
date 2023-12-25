public class Solution 
    {
        public int MaximumWealth(int[][] accounts) 
        {
            int maximumWealth = 0;

            foreach (int[] customer in accounts)
            {
                int currentCustomerWealth = 0;
            
                foreach( int bank in  customer)
                {
                    currentCustomerWealth += bank;
                }
                
                maximumWealth = Math.Max(maximumWealth, currentCustomerWealth);
            }
        
            return maximumWealth;
        }
    }