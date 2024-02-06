namespace Giraffe
{
    public class Solution
    {
        public bool ContainsDuplicate(int[] nums)
        {
            HashSet<int> set = new HashSet<int>(nums);
            // a set automatically removes duplicate
            // compare if equals to the original array
            if (set.Count < nums.Length)
            {
                return true;
            }
            return false;
        }
    }
}

