public class Solution {
    private readonly Dictionary<char, string> phoneMap = new Dictionary<char, string>() {
        {'2', "abc"},
        {'3', "def"},
        {'4', "ghi"},
        {'5', "jkl"},
        {'6', "mno"},
        {'7', "pqrs"},
        {'8', "tuv"},
        {'9', "wxyz"}
    };

    public IList<string> LetterCombinations(string digits) {
        var result = new List<string>();
        if (string.IsNullOrEmpty(digits)) {
            return result;
        }

        Backtrack(0, digits, new System.Text.StringBuilder(), result);
        return result;
    }

    private void Backtrack(int index, string digits, System.Text.StringBuilder current, List<string> result) {

        if (index == digits.Length) {
            result.Add(current.ToString());
            return;
        }

        char digit = digits[index];
        string letters = phoneMap[digit];

        foreach (char letter in letters) {
            current.Append(letter);
            Backtrack(index + 1, digits, current, result); 
            current.Length--;               
        }
    }
}