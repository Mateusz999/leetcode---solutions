public class Solution {
    public bool IsValidSudoku(char[][] board) {
        var rowCheck = new Dictionary<int, int>[9];
        var colCheck = new Dictionary<int, int>[9];
        var blockCheck = new Dictionary<int, int>[9];

        for (int i = 0; i < 9; i++) {
            rowCheck[i] = new Dictionary<int, int>();
            colCheck[i] = new Dictionary<int, int>();
            blockCheck[i] = new Dictionary<int, int>();
        }

        for (int i = 0; i < 9; i++) {
            for (int j = 0; j < 9; j++) {
                char num = board[i][j];
                if (num == '.') continue; 

                if (rowCheck[i].ContainsKey(num)) {
                    return false;
                } else {
                    rowCheck[i].Add(num, 1);
                }

                if (colCheck[j].ContainsKey(num)) {
                    return false;
                } else {
                    colCheck[j].Add(num, 1);
                }

                int blockIndex = (i / 3) * 3 + j / 3;
                if (blockCheck[blockIndex].ContainsKey(num)) {
                    return false;
                } else {
                    blockCheck[blockIndex].Add(num, 1);
                }
            }
        }

        return true;
    }
}