public class Solution {
    public bool IsValidSudoku(char[][] board) {
        var cols = new Dictionary<int, HashSet<char>>();
        var rows = new Dictionary<int, HashSet<char>>();
        var squares = new Dictionary<(int,int), HashSet<char>>();

        for (var i = 0; i < board.Length; i++) {
            for (var j = 0; j < board.Length; j++) {
                if (board[i][j] == '.') {
                    continue;
                }
                if ((rows.ContainsKey(i) && rows[i].Contains(board[i][j])) ||
                    (cols.ContainsKey(j) && cols[j].Contains(board[i][j])) ||
                    (squares.ContainsKey((i/3, j/3)) && squares[(i/3,j/3)].Contains(board[i][j]))) 
                {
                        return false;
                }
                if (rows.ContainsKey(i))
                    rows[i].Add(board[i][j]);
                else
                    rows[i] = new HashSet<char>() {board[i][j]};

                if (cols.ContainsKey(j))
                    cols[j].Add(board[i][j]);
                else
                    cols[j] = new HashSet<char>() {board[i][j]};

                if (squares.ContainsKey((i/3,j/3)))
                    squares[(i/3,j/3)].Add(board[i][j]);
                else
                    squares[(i/3,j/3)] = new HashSet<char>() {board[i][j]};
            }
        }

        return true;
    }
}
