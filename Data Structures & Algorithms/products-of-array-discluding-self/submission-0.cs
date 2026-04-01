public class Solution {
    public int[] ProductExceptSelf(int[] nums) {
        List<int> prefix = new List<int>();
        List<int> sufix = new List<int>();

        int[] solution = new int[nums.Length];
        int product = 1;
        // store product prefix left to right 
        for(int i = 0;i < nums.Length; i++ )
        {
            
            if( i != 0)
                product *= nums[i - 1]; 
            else
                product = 1;

            prefix.Add(product);

        }
        
        for(int i = nums.Length - 1; i >= 0; i-- )
        {
            
            if( i != nums.Length - 1)
                product *= nums[i + 1]; 
            else
                product = 1;

            sufix.Insert(0, product);
        }

        for(int i = 0; i < prefix.Count; i++ ){
            solution[i] = prefix[i] * sufix[i];
           
        }

        return solution;

    }
}

// int[] destination = new int[3];
// Array.Copy(numbers, 1, destination, 0, 3); // Copies 3 elements starting from index 1 of 'numbers'
// destination is now { 40, 30, 25 }