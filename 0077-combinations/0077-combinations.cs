public class Solution {
    public IList<IList<int>> Combine(int n, int k) {
        var result = new List<IList<int>>();
        Backtrack(1, n, k, new List<int>(), result);
        return result;
    }

    private void Backtrack(int start, int n, int k, List<int> current, List<IList<int>> result) {

        if (current.Count == k) {
            result.Add(new List<int>(current));
            return;
        }

        for (int i = start; i <= n; i++) {
            current.Add(i);
            Backtrack(i + 1, n, k, current, result);
            current.RemoveAt(current.Count - 1);
        }
    }
}