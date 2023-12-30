public class Solution 
{
    public int RomanToInt(string s) 
    {
       var counter = 0;

        var dictionary = new Dictionary<char,int> {
	    { 'I', 1 },
	    { 'V', 5 },
	    { 'X', 10 },
	    { 'L', 50 },
	    { 'C', 100 },
	    { 'D', 500 },
	    { 'M', 1000 }
    };

        for (var i = 0; i < s.Length; i++) 
        {
            
	        if (i == 0) 
            {
		        counter += dictionary[s[i]];
		        continue;
	        }
            
	if (dictionary[s[i-1]] >= dictionary[s[i]]) 
    {
		counter += dictionary[s[i]];
	}
	else 
    {
		counter = counter + dictionary[s[i]] - (2 * dictionary[s[i-1]]);
	}
}

return counter;  
    }
}