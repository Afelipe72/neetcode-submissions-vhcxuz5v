public class Solution {
    public bool IsValidSudoku(char[][] board) {

        // 3 memories
        HashSet<char>[] rows = new HashSet<char>[9];
        HashSet<char>[] cols = new HashSet<char>[9];
        HashSet<char>[] boxes = new HashSet<char>[9];

        // initialize all hashsets
        for (int i = 0; i < 9; i++) {
            rows[i] = new HashSet<char>();
            cols[i] = new HashSet<char>();
            boxes[i] = new HashSet<char>();
        }

        // go through every cell
        for (int i = 0; i < 9; i++) {
            for (int j = 0; j < 9; j++) {

                char value = board[i][j];

                if (value == '.') continue;

                int boxIdx = (i / 3) * 3 + (j / 3);

                // check duplicates
                if (rows[i].Contains(value) ||
                    cols[j].Contains(value) ||
                    boxes[boxIdx].Contains(value)) {
                    return false;
                }

                // remember the value
                rows[i].Add(value);
                cols[j].Add(value);
                boxes[boxIdx].Add(value);
            }
        }

        return true;
    }
}
