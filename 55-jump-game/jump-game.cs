public class Solution {
        public bool CanJump(int[] nums)
        {
            int power = 0;
            for (int i = 0; i < nums.Length; i++)
            {
                if (i > power) return false;

                power = Math.Max(power, i + nums[i]);

                if (power >= nums.Length - 1) return true;
            }
            return false;
        }
}