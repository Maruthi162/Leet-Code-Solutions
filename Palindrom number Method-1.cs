public class Solution {
    public bool IsPalindrome(int x) {
        string num=Convert.ToString(x);
        string rev=string.Join("",num.Reverse());
        if(rev==num){
            return true;
        }
        return false;
    }
}