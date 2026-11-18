public class Solution
{
    public bool IsValidSudoku(char[][] board)
    {
        var rows = new HashSet<char>[9];
        var cols = new HashSet<char>[9];
        var boxes = new HashSet<char>[9];

        for (var i = 0; i < 9; i++)
        {
            rows[i] = new HashSet<char>();
            cols[i] = new HashSet<char>();
            boxes[i] = new HashSet<char>();
        }

        for (var r = 0; r < 9; r++)
        {
            for (var c = 0; c < 9; c++)
            {
                var value = board[r][c];

                if (value == '.')
                    continue;

                var boxIndex = (r / 3) * 3 + c / 3;

                if (!rows[r].Add(value) ||
                    !cols[c].Add(value) ||
                    !boxes[boxIndex].Add(value))
                    return false;
            }
        }

        return true;
    }
}