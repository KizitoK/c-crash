namespace Giraffe
{
    public class Concatenation
    {
        public int[] GetConcatenation(int[] nums)
        {
            int[] ans = nums;

            var concatenation = ans.Concat(nums).ToArray();
            return concatenation;
        }
    }
}