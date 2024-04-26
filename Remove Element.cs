public class Solution {
    public int RemoveElement(int[] nums, int val) {
        int index=0;
        foreach(var n in nums){
            if(n!=val){
                nums[index]=n;
                index++;
            }

        }
        return index;

    }
}