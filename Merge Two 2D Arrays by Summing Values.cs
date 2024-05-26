public class Solution {
    public int[][] MergeArrays(int[][] nums1, int[][] nums2) {
        Dictionary<int,int> IdValues=new Dictionary<int,int>();
        
        for(int r=0;r<nums1.Length;r++){
            if(IdValues.ContainsKey(nums1[r][0])){
                IdValues[nums1[r][0]]+=nums1[r][1];
            }
            else{
                IdValues.Add(nums1[r][0],nums1[r][1]);
            }
        }
        for(int r=0;r<nums2.Length;r++){
            if(IdValues.ContainsKey(nums2[r][0])){
                IdValues[nums2[r][0]]+=nums2[r][1];
            }
            else{
                IdValues.Add(nums2[r][0],nums2[r][1]);
            }
        }
        var sortedDic= IdValues.OrderBy(a=>a.Key).ToList();
        int row=IdValues.Count;
        int[][] res=new int [row][];

        for (int i = 0; i < row; i++) 
        {
            res[i] = new int[2];
        }
        int index=0;

        foreach(var pair in sortedDic){

            res[index][0]=pair.Key;
            res[index][1]=pair.Value;    
            index++; 
        }
        return res;
        
    }
}
