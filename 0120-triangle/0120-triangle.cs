public class Solution {
    public int MinimumTotal(IList<IList<int>> triangle) {

        for (int row = triangle.Count - 2; row >= 0; row--) {
            for (int i = 0; i < triangle[row].Count; i++) {
                triangle[row][i] += Math.Min(triangle[row + 1][i], triangle[row + 1][i + 1]);
            }
        }
        
        return triangle[0][0];
    }
}