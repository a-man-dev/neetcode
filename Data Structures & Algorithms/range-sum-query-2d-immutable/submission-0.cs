public class NumMatrix {
    private int[][] _matrix;

    public NumMatrix(int[][] matrix) {
        _matrix = matrix;
    }
    
    public int SumRegion(int row1, int col1, int row2, int col2) {
        var count = 0;
        for (var i = row1; i < row2 + 1; i++) {
            for (var j = col1; j < col2 + 1; j++) {
                count += _matrix[i][j];
            }
        }
        return count;
    }
}

/**
 * Your NumMatrix object will be instantiated and called as such:
 * NumMatrix obj = new NumMatrix(matrix);
 * int param_1 = obj.SumRegion(row1,col1,row2,col2);
 */