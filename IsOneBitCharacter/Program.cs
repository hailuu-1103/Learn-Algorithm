bool IsOneBitCharacter(int[] nums)
{
    var i = 0;
    while (i < nums.Length - 1)
    {
        if (nums[i] == 0)
        {
            i++;
        }
        if (nums[i] == 1)
        {
            i += 2;
        }
    }
    return i == nums.Length - 1;
}