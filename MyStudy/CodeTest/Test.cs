class Result
{

    /*
     * Complete the 'calcMissing' function below.
     *
     * The function accepts STRING_ARRAY readings as parameter.
     */

    public static void calcMissing( List<string> readings )
    {
        List<float?> levels = new List<float?>();
        foreach ( var item in readings )
        {
            var parts = item.Split(new [] { ' ', '\t' }, StringSplitOptions.RemoveEmptyEntries);
            string lastPart = parts [2];

            if ( lastPart.StartsWith("Missing") )
            {
                levels.Add(null);
            }
            else
            {
                levels.Add(float.Parse(lastPart));
            }
        }
        for ( int i = 0; i < levels.Count; i++ )
        {
            if ( levels [i] == null )
            {
                int prev = i - 1;
                int next = i + 1;
                while ( prev >= 0 && levels [prev] == null )
                {
                    prev--;
                }
                while ( next < levels.Count && levels [next] == null )
                {
                    next++;
                }

                if ( prev >= 0 && next < levels.Count )
                {
                    float preValue = levels [prev].Value;
                    float nextValue = levels [next].Value;

                    float predictValue = preValue + ( nextValue - preValue ) * ( i - prev ) / ( next - prev );      //선형보간

                    levels [i] = predictValue;
                }
                else if ( prev >= 0 )
                {     // 마지막 레벨값이 레벨카운트에 없을때 전값으로 할당
                    levels [i] = levels [prev];
                }
                else if ( next < levels.Count )
                {      //이전값이 더이상 없을때 다음값으로 할당
                    levels [i] = levels [next];
                }
            }
        }

        for ( int i = 0; i < readings.Count; i++ )
        {
            if ( readings [i].Contains("Missing") )
            {
                Console.WriteLine($"{levels [i]:F2}");
            }
        }
    }

}

class Solution
{
    public static void Main2( string [] args )
    {
        int readingsCount = Convert.ToInt32(Console.ReadLine().Trim());

        List<string> readings = new List<string>();

        for ( int i = 0; i < readingsCount; i++ )
        {
            string readingsItem = Console.ReadLine();
            readings.Add(readingsItem);
        }

        Result.calcMissing(readings);
    }

    public static List<int> twoSum( List<int> nums, int target )
    {
        Dictionary<int, int> numIndices = new Dictionary<int, int>();
        for ( int i = 0; i < nums.Count; i++ )
        {
            int comple = target - nums [i];

            if ( numIndices.ContainsKey(comple) )
            {

                return new List<int> { numIndices [comple], i };
            }

            if ( !numIndices.ContainsKey(nums [i]) )
            {
                numIndices [nums [i]] = i;
            }
        }
        return null;
    }

}
class NQueen
{

    public static void chess_puzzle( int n )
    {
        int [] queens = new int [n];
        SolveNQueens(0, queens, n);
    }
    static bool SolveNQueens( int row, int [] queens, int n )
    {
        if ( row == n )
        {
            Answer(queens, n);
            return true;
        }
        for ( int col = 0; col < n; col++ )
        {

            if ( IsValid(row, col, queens) )
            {
                queens [row] = col;
                if ( SolveNQueens(row + 1, queens, n) )
                    return true;
            }
        }
        return false;
    }
    static bool IsValid( int row, int col, int [] queens )
    {
        for ( int i = 0; i < row; i++ )
        {
            int qCol = queens [i];

            if ( qCol == col || Math.Abs(qCol - col) == Math.Abs(i - row) )
                return false;
        }
        return true;
    }

    static void Answer( int [] queens, int n )
    {
        for ( int i = 0; i < n; i++ )
        {
            Console.WriteLine(i + " " + queens [i]);
        }
    }


}
public class Solution2
{
    public struct Time
    {
        public int Minutes { get; set; }
        public int Seconds { get; set; }

        public Time( int minutes, int seconds )
        {
            Minutes = minutes;
            Seconds = seconds;
            Normalize(); // Normalize 호출
        }

        public static Time operator +( Time t1, Time t2 )
        {
            return new Time(t1.Minutes + t2.Minutes, t1.Seconds + t2.Seconds);
        }

        public static Time operator -( Time t1, Time t2 )
        {
            return new Time(t1.Minutes - t2.Minutes, t1.Seconds - t2.Seconds);
        }

        public static bool operator <( Time t1, Time t2 )
        {
            return t1.ToSeconds() < t2.ToSeconds();
        }

        public static bool operator >( Time t1, Time t2 )
        {
            return t1.ToSeconds() > t2.ToSeconds();
        }

        private void Normalize()
        {
            if ( Seconds >= 60 )
            {
                Minutes += Seconds / 60;
                Seconds %= 60;
            }
            else if ( Seconds < 0 )
            {
                int extraMin = ( Math.Abs(Seconds) / 60 ) + 1;
                Seconds += extraMin * 60;
                Minutes -= extraMin;
            }

            if ( Minutes < 0 )
            {
                Minutes = 0; // 필요에 따라 수정
                Seconds = 0; // 필요에 따라 수정
            }
        }

        public int ToSeconds()
        {
            return Minutes * 60 + Seconds;
        }

        public override string ToString()
        {
            return $"{Minutes:D2}:{Seconds:D2}";
        }
    }
    public static void Main(
        string [] args )
    {
        Console.WriteLine(Solution2.WireTest(9, new int [,] { { 1, 3 }, { 2, 3 }, { 3, 4 }, { 4, 5 }, { 4, 6 }, { 4, 7 }, { 7, 8 }, { 7, 9 } }));
    }
    public static string solution( string video_len, string pos, string op_start, string op_end, string [] commands )
    {
        Time TimeParse( string time )
        {
            string [] timeArray = time.Split(":");
            int min = int.Parse(timeArray [0]);
            int sec = int.Parse(timeArray [1]);

            return new Time(min, sec);
        }

        Time curTime = TimeParse(pos);
        Time opStart = TimeParse(op_start);
        Time opEnd = TimeParse(op_end);
        Time videoTime = TimeParse(video_len);

        for ( int i = 0; i < commands.Length; i++ )
        {
            switch ( commands [i] )
            {
                case "prev":
                    curTime -= new Time(0, 10);
                    if ( curTime < new Time(0, 0) )
                    {
                        curTime = new Time(0, 0); // 0으로 설정
                    }
                    break;
                case "next":
                    curTime += new Time(0, 10);
                    if ( curTime > videoTime )
                    {
                        curTime = videoTime;
                    }
                    break;
            }
        }

        if ( curTime > opStart && curTime < opEnd )
        {
            curTime = opEnd;
        }

        return curTime.ToString();
    }

    public static int WireTest( int n, int [,] wires )
    {
        Dictionary<int, List<int>> graph = new Dictionary<int, List<int>>();



        for ( int i = 0; i < wires.GetLength(0); i++ )
        {
            int tower1 = wires [i, 0];
            int tower2 = wires [i, 1];

            if ( !graph.ContainsKey(tower1) )
            {
                graph [tower1] = new List<int>();
            }
            if ( !graph.ContainsKey(tower2) )
            {
                graph [tower2] = new List<int>();
            }

            graph [tower1].Add(tower2);
            graph [tower2].Add(tower1);
        }
        int [,] select = new int [1, 2];



        int min = int.MaxValue;
        foreach ( var higherNode in graph.Keys )
        {
            for ( int i = 0; i < graph [higherNode].Count; i++ )
            {
                HashSet<int> nodeList = new HashSet<int>();
                Dictionary<int, List<int>> tempGraph = graph.ToDictionary(
                    entry => entry.Key,
                    entry => entry.Value.ToList());
                //  List<int> temp = new List<int>(graph [select [0, 0]]);
                int reverse = tempGraph [higherNode] [i];
                tempGraph [higherNode].RemoveAt(i);
                tempGraph [reverse].Remove(higherNode);


                Console.WriteLine($"{i}번 간선 제거");

                int index = 0;
                int [] compare = new int [2];
                HashSet<int> countSet = new HashSet<int>();
                for ( int j = 1; j <= n; j++ )
                {
                    if ( nodeList.Count != 0 && countSet.Contains(j) )
                    {
                        continue;
                    }

                    //   nodeList.Clear();
                    nodeList = BFS(j, tempGraph);
                    countSet.UnionWith(nodeList);
                    foreach ( var node in nodeList )
                    {
                        Console.WriteLine($"방문한 노드 {node})");
                    }
                    Console.WriteLine($"{index}번째 BFS종료\n\n");
                    compare [index] = nodeList.Count;

                    index++;
                }
                min = Math.Min(Math.Abs(compare [0] - compare [1]), min);
                Console.WriteLine($"노드리스트 A({compare [0]})개와 노드리스트 B({compare [1]})을 비교 \n 결과값 : {Math.Abs(compare [0] - compare [1])}\n\n" +
                    $"현재 최소 노드 갯수 차이 {min}\n\n");
            }

        }

        return min;
    }

    static HashSet<int> BFS( int n, Dictionary<int, List<int>> graphList )
    {
        Queue<int> queue = new Queue<int>();
        HashSet<int> visited = new HashSet<int>();

        queue.Enqueue(n);
        visited.Add(n);
        while ( queue.Count > 0 )
        {
            int node = queue.Dequeue();
            foreach ( var i in graphList [node] )
            {
                if ( !visited.Contains(i) )
                {
                    Console.WriteLine($"{node} => {i} 방문");
                    queue.Enqueue(i);
                    visited.Add(i);
                }

            }

        }
        return visited;
    }
}




/*
 * Complete the 'chess_puzzle' function below.
 *
 * The function accepts INTEGER n as parameter.
 */

