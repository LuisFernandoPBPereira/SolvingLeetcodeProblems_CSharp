public class Solution {
    /*
        U: UP
        D: DOWN
        L: LEFT
        R: RIGHT
    */
    public bool JudgeCircle(string moves) 
    {
        int xLine=0, yLine=0;

        for(int i=0; i<moves.Length; i++)
        {
            if(moves[i].ToString() == "U") yLine++;
            if(moves[i].ToString() == "D") yLine--;
            if(moves[i].ToString() == "L") xLine--;
            if(moves[i].ToString() == "R") xLine++;
        }

        return xLine == 0 && yLine == 0;
    }
}