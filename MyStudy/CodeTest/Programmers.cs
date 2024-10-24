
namespace MyStudy.CodeTest
{
    using System.Collections.Generic;

    public class Level0
    {
        public void Test2( string [] args )
        {
            Console.Clear();
            string [] s = Console.ReadLine().Split(' ');

            int a = int.Parse(s [0]);
            int b = int.Parse(s [1]);

            Console.WriteLine($"a = {a}");
            Console.WriteLine($"b = {b}");
        }

        public void Test( string [] args )
        {
            Console.Clear();
            string [] stringArray = Console.ReadLine().Split(' ');
            string s = stringArray [0];
            int n = int.Parse(stringArray [1]);
            for ( int i = 1; i <= n; i++ )
            {
                Console.Write(s);
            }
        }

        public void Test4( string [] args )
        {
            string str = Console.ReadLine();

            string result = ChangeCase(str);
            Console.WriteLine(result);


            Console.WriteLine("!@#$%^&*(\\'\"<>?:;");               // 특수문자

            static string ChangeCase( string str )
            {
                char [] chars = str.ToCharArray();

                for ( int i = 0; i < chars.Length; i++ )
                {
                    if ( char.IsUpper(chars [i]) )
                    {
                        chars [i] = char.ToLower(chars [i]);
                    }
                    else if ( char.IsLower(chars [i]) )
                    {
                        chars [i] = char.ToUpper(chars [i]);
                    }
                }
                return new string(chars);
            }
        }
        public void Test5( string [] args )
        {
            string [] s;

            Console.Clear();
            s = Console.ReadLine().Split(' ');

            int a = int.Parse(s [0]);
            int b = int.Parse(s [1]);
            int c = a + b;
            Console.WriteLine($"{a} + {b} = {c}");
        }

        public void Test6( string [] args )
        {
            string s;

            Console.Clear();
            s = Console.ReadLine();

            char [] chars = s.ToCharArray();
            for ( int i = 0; i < s.Length; i++ )
            {
                Console.WriteLine(chars [i]);
            }
        }

        public void Test7()
        {
            String s;

            Console.Clear();
            s = Console.ReadLine();

            int a = Int32.Parse(s);

            if ( a % 2 == 0 )
            {
                Console.WriteLine($"{a} is even");
            }
            else
            {
                Console.WriteLine($"{a} is odd");
            }
        }
        public string Test8( string my_string, string overwrite_string, int s )
        {
            char [] chars = my_string.ToCharArray();


            for ( int i = 0; i < overwrite_string.Length; i++ )
            {
                chars [s + i] = overwrite_string [i];
            }

            return new string(chars);
        }

        public string Test9( string str1, string str2 )
        {
            char [] chars = str1.ToCharArray();
            char [] chars2 = str2.ToCharArray();

            char [] resultChar = new char [chars.Length + chars2.Length];

            for ( int i = 0; i < chars.Length; i++ )
            {
                resultChar [2 * i] = chars [i];
            }
            for ( int i = 0; i < chars2.Length; i++ )
            {
                resultChar [2 * i + 1] = chars2 [i];
            }

            return new string(resultChar);
        }

        public string Test10( string [] arr )
        {
            string answer = String.Join("", arr);

            return answer;
        }
        public string Test11( string my_string, int k )
        {
            string answer = "";
            for ( int i = 0; i < k; i++ )
            {
                answer += my_string; // my_string을 answer에 이어 붙임
            }

            answer = String.Concat(Enumerable.Repeat(my_string, k));
            return answer;
        }
        public int Test12( int a, int b )
        {
            // a와 b를 문자열로 변환하여 결합
            string ab = $"{a}{b}"; // a ⊕ b
            string ba = $"{b}{a}"; // b ⊕ a

            // 두 문자열을 정수로 변환하여 비교
            int resultAb = int.Parse(ab);
            int resultBa = int.Parse(ba);

            // 더 큰 값을 반환, 같으면 ab를 반환
            return resultAb >= resultBa ? resultAb : resultBa;
        }
        public int Test13( int a, int b )
        {
            int answer = 0;
            string ab = $"{a}{b}";
            int abValue = int.Parse(ab);
            int cross = 2 * a * b;

            answer = abValue >= cross ? abValue : cross;
            if ( abValue == cross )
                answer = abValue;

            return answer;
        }
        public int Test14( string [] babbling )
        {
            string [] valid = { "aya", "ye", "woo", "ma" };
            int answer = 0;

            for ( int i = 0; i < babbling.Length; i++ )
            {
                string modified = babbling [i];
                foreach ( string word in valid )
                {
                    if ( modified.Contains(word) )
                    {
                        modified = modified.Replace(word, "");
                    }

                }
                modified.Replace(" ", "");
                if ( string.IsNullOrEmpty(modified) )
                {
                    answer++;
                }

            }
            return answer;


        }
        public int Test15( int n )
        {
            int answer = 0;
            for ( int i = 2; i < n; i++ )
            {
                if ( n % i == 1 )
                {
                    answer = i;
                    break;
                }
            }
            return answer;
        }
        public int Test16( int [] nums )
        {
            int answer = 0;
            bool IsPrime( int num )
            {
                if ( num < 2 ) return false;
                for ( int i = 2; i * i <= num; i++ )
                {
                    if ( num % i == 0 )
                        return false;
                }
                return true;
            }

            for ( int i = 0; i < nums.Length; i++ )
            {
                for ( int j = i + 1; j < nums.Length; j++ )
                { // j는 i+1부터
                    for ( int k = j + 1; k < nums.Length; k++ )
                    { // k는 j+1부터
                        int sum = nums [i] + nums [j] + nums [k];
                        if ( IsPrime(sum) )
                        {
                            answer++;
                        }
                    }
                }
            }


            return answer;
        }
        public long [] Test17( int x, int n )
        {
            long [] answer = new long [n];
            for ( int i = 0; i < n; i++ )
            {
                answer [i] = ( long )x * ( i + 1 ); // x에 (i + 1)을 곱해서 각 요소에 저장합니다.
            }

            return answer;
        }
        public int Test18( int n, int a, int b )
        {
            int answer = 0;

            int [] players = new int [n];

            double count = Math.Log(n, 2);

            int resultA = a;
            int resultB = b;

            for ( int i = 0; i < count; i++ )
            {
                resultA = ( resultA + 1 ) / 2;
                resultB = ( resultB + 1 ) / 2;
                answer++;
                if ( resultA == resultB )
                {
                    break;
                }

            }

            return answer;
        }

        public int Test19( int n, int [,] edge )
        {
            List<int> [] nodes = new List<int> [n + 1];
            for ( int i = 1; i < n + 1; i++ )
            {
                nodes [i] = new List<int>();
            }
            for ( int i = 0; i < edge.GetLength(0); i++ )
            {
                int a = edge [i, 0];
                int b = edge [i, 1];

                nodes [a].Add(b);
                nodes [b].Add(a);


            }

            Queue<int> queue = new Queue<int>();
            int [] distance = new int [n + 1];

            Array.Fill(distance, -1);

            queue.Enqueue(1);
            distance [1] = 0;

            while ( queue.Count > 0 )
            {
                int current = queue.Dequeue();

                foreach ( int neighbor in nodes [current] )
                {
                    if ( distance [neighbor] == -1 )
                    {
                        distance [neighbor] = distance [current] + 1;
                        queue.Enqueue(neighbor);
                    }
                }
            }

            int maxDis = 0;
            int count = 0;

            for ( int i = 1; i <= n; i++ )
            {
                if ( maxDis < distance [i] )
                {

                    maxDis = distance [i];
                    count = 1;
                }
                else if ( maxDis == distance [i] )
                    count++;

            }
            return count;

        }
        public struct Time
        {
            public int Minutes { get; set; }
            public int Seconds { get; set; }

            public Time( int minutes, int seconds )
            {
                Minutes = minutes;
                Seconds = seconds;
                Normalize();
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

            void Normalize()
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
                    int totalSeconds = ToSeconds();
                    Minutes = totalSeconds / 60; // 분 계산
                    Seconds = totalSeconds % 60; // 초 계산
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

        public string PCCP_1( string video_len, string pos, string op_start, string op_end, string [] commands )
        {
            string answer = "";
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
                            curTime.Seconds = 0;
                            curTime.Minutes = 0;
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

            answer = $"{curTime.Minutes} {curTime.Seconds}";



            return answer;
        }

        public int Ctrl_Z( string s )
        {
            int answer = 0;
            string [] array = s.Split(" ");

            for ( int i = 0; array.Length > i; i++ )
            {
                if ( array [i] == "Z" )
                {
                    array [i - 1] = "0";
                    array [i] = "0";
                }
            }
            foreach ( string element in array )
            {
                answer += int.Parse(element);
            }
            return answer;
        }
        public int Triangle_1( int [] sides )
        {
            int answer = 0;

            int bigger = sides [0] > sides [1] ? sides [0] : sides [1],
            smaller = sides [0] > sides [1] ? sides [1] : sides [0];

            for ( int i = bigger; i > bigger - smaller; i-- )
            {
                answer++;
            }

            for ( int i = bigger + 1; i < bigger + smaller; i++ )
            {
                answer++;
            }

            return answer;
        }
        public int [] WallPaper( string [] wallpaper )
        {

            List<int> xList = new List<int>();
            List<int> yList = new List<int>();

            int size = wallpaper.Length;



            for ( int i = 0; i < size; i++ )            //바탕화면 세로 사이즈 = wallPaperLength 가로사이즈 = wallpaper[i].Length
            {

                char [] chars = wallpaper [i].ToCharArray();
                for ( int j = 0; j < chars.Length; j++ )
                {
                    if ( chars [j] == '#' )
                    {
                        xList.Add(j);
                        yList.Add(i);
                    }
                }
            }

            xList = xList.OrderBy(x => x).ToList();
            yList = yList.OrderBy(y => y).ToList();

            int [] answer = new int [] { yList [0], xList [0], yList [yList.Count - 1 + 1], xList [xList.Count - 1] + 1 };


            return answer;
        }
        public int MonthlyCodeChallange( int left, int right )
        {
            bool isEven( int n )
            {
                if ( n % 2 == 0 )
                    return true;
                return false;
            }
            List<int> Divider( int n )
            {
                List<int> result = new List<int>();
                for ( int i = 1; i <= n; i++ )
                {
                    if ( n % i == 0 )
                        result.Add(i);
                }
                return result;
            }

            int answer = 0;

            for ( int i = left; i <= right; i++ )
            {
                answer += isEven(Divider(i).Count) ? i : -i;
            }
            return answer;
        }
        public string FoodFight( int [] food )
        {
            string answer = "";

            for ( int i = 1; i < food.Length; i++ )
            {
                for ( int j = 1; j <= food [i] / 2; j++ )
                {
                    answer += i;
                }
            }
            char [] chars = answer.ToCharArray();
            Array.Reverse(chars);
            string reverse = new string(chars);
            answer += $"0{reverse}";
            return answer;
        }
        public int [,] HanoiTower( int n )
        {
            List<string> Solution( int n )
            {
                List<string> moves = new List<string>();
                MoveDisks(n, 1, 3, 2, moves);
                return moves;
            }

            int [,] answer = new int [,] { { } };

            int numberOfDisks = 3; // 예시: 3개의 원판

            void MoveDisks( int n, int source, int destination, int auxiliary, List<string> moves )
            {
                if ( n == 1 )
                {
                    moves.Add($"{source} {destination}");
                    return;
                }

                MoveDisks(n - 1, source, auxiliary, destination, moves);

                moves.Add($"{source} {destination}");

                MoveDisks(n - 1, auxiliary, destination, source, moves);
            }
            List<string> result = Solution(numberOfDisks);


            foreach ( var move in result )
            {
                Console.WriteLine(move);
            }

            return answer;
        }
        public long GoldSilverConvey( int a, int b, int [] g, int [] s, int [] w, int [] t )
        {
            long answer = 4 * 10_000_000_000; // 충분히 큰 값으로 설정
            long start = 0;
            long end = 4 * 10_000_000_000; // 충분히 큰 값으로 설정

            while ( end >= start )
            {
                long mid = ( end + start ) / 2; // 주어진 시간
                long gold = 0; // 주어진 시간 내에 옮길 수 있는 금의 양
                long silver = 0; // 주어진 시간 내에 옮길 수 있는 은의 양
                long add = 0; // 주어진 시간 내에 옮길 수 있는 (금+은)의 양

                for ( int i = 0; i < t.Length; i++ )
                {
                    long now_g = g [i];
                    long now_s = s [i];
                    long now_w = w [i];
                    long now_t = t [i];

                    long move_cnt = mid / ( now_t * 2 ); // 왕복 가능 횟수
                    if ( mid % ( now_t * 2 ) >= now_t )
                    { // 추가적인 편도 운반 가능 여부
                        move_cnt += 1;
                    }

                    gold += Math.Min(now_g, move_cnt * now_w); // 금량
                    silver += Math.Min(now_s, move_cnt * now_w); // 은량
                    add += Math.Min(now_g + now_s, move_cnt * now_w); // 금과 은의 총량
                }

                // 필요 금과 은을 모두 옮길 수 있는지 확인
                if ( gold >= a && silver >= b && add >= a + b )
                {
                    end = mid - 1; // 시간을 줄이기
                    answer = Math.Min(mid, answer); // 최소값 갱신
                }
                else
                {
                    start = mid + 1; // 시간을 늘리기
                }
            }

            return answer;
        }
        public class Solution
        {
            // 시간 문자열을 초 단위로 변환하는 함수
            public int TimeParse( string time )
            {
                string [] timeArray = time.Split(':');
                int min = int.Parse(timeArray [0]);
                int sec = int.Parse(timeArray [1]);
                return min * 60 + sec;


            }

            // 초 단위를 다시 "MM:SS" 형식으로 변환하는 함수
            public string TimeFormat( int timeInSeconds )
            {
                int min = timeInSeconds / 60;
                int sec = timeInSeconds % 60;
                return $"{min:D2}:{sec:D2}";
            }
            public int SkipOpening( int opStart, int opEnd, int curTime )
            {
                if ( curTime >= opStart && curTime <= opEnd )
                {
                    return opEnd;
                }
                return curTime;
            }
            public string solution( string video_len, string pos, string op_start, string op_end, string [] commands )
            {
                // 각 시간을 초 단위로 변환
                int curTime = TimeParse(pos);
                int opStart = TimeParse(op_start);
                int opEnd = TimeParse(op_end);
                int videoTime = TimeParse(video_len);

                curTime = SkipOpening(opStart, opEnd, curTime);

                // 명령어 처리
                foreach ( string command in commands )
                {
                    if ( command == "prev" )
                    {
                        curTime -= 10;
                        if ( curTime < 0 ) curTime = 0; // 0초 이하로 가지 않게
                    }
                    else if ( command == "next" )
                    {
                        curTime += 10;
                        if ( curTime > videoTime ) curTime = videoTime; // 비디오 길이 초과 방지
                    }
                    curTime = SkipOpening(opStart, opEnd, curTime);
                }


                // 최종 시간을 "MM:SS" 형식으로 반환
                return TimeFormat(curTime);
            }
            ////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
            public struct NodeCost
            {
                public int Node { get; set; }
                public int Cost { get; set; }

                public NodeCost( int node, int cost )
                {
                    Node = node;
                    Cost = cost;
                }
            }

            // 우선순위 큐에서 사용할 구조체
            public struct PQEntry : IComparable<PQEntry>
            {
                public int Cost { get; set; }
                public int Node { get; set; }

                public PQEntry( int cost, int node )
                {
                    Cost = cost;
                    Node = node;
                }

                // 비용을 기준으로 우선순위를 비교
                public int CompareTo( PQEntry other )
                {
                    return Cost.CompareTo(other.Cost);
                }
            }
            public int TaxiFares( int n, int s, int a, int b, int [,] fares )
            {
                int answer = 0;

                var graph = new Dictionary<int, List<NodeCost>>();
                for ( int i = 1; i <= n; i++ )
                {
                    graph [i] = new List<NodeCost>();
                }

                for ( int i = 0; i < fares.GetLength(0); i++ )
                {
                    int start = fares [i, 0];
                    int end = fares [i, 1];
                    int fare = fares [i, 2];

                    graph [start].Add(new NodeCost(end, fare));
                    graph [end].Add(new NodeCost(start, fare));
                }
                var distFromS = Dijkstra(graph, s, n);
                var distFromA = Dijkstra(graph, a, n);
                var distFromB = Dijkstra(graph, b, n);

                for ( int i = 1; i <= n; i++ )
                {
                    int cost = distFromS [i] + distFromA [i] + distFromB [i];
                    answer = Math.Min(answer, cost);

                }
                return answer;


                int [] Dijkstra( Dictionary<int, List<NodeCost>> graph, int start, int n )
                {
                    // distance 배열을 int.MaxValue로 초기화 (아직까지는 각 노드까지의 거리를 모름)
                    var distance = Enumerable.Repeat(int.MaxValue, n + 1).ToArray();
                    distance [start] = 0;  // 시작 노드의 거리는 0

                    // 우선순위 큐를 사용하여 비용이 가장 적은 경로를 먼저 탐색
                    var priorityQueue = new SortedSet<PQEntry>()
    {
        new PQEntry(0, start)  // 시작 노드를 우선순위 큐에 삽입 (비용 0)
    };

                    while ( priorityQueue.Count > 0 )
                    {
                        // 비용이 가장 적은 노드 꺼내기
                        var current = priorityQueue.Min;
                        priorityQueue.Remove(current);

                        int currentCost = current.Cost;
                        int currentNode = current.Node;

                        // 현재 노드의 인접 노드들 탐색
                        foreach ( var neighbor in graph [currentNode] )
                        {
                            int newCost = currentCost + neighbor.Cost;

                            // 만약 새로운 경로가 더 짧다면 거리 갱신
                            if ( newCost < distance [neighbor.Node] )
                            {
                                distance [neighbor.Node] = newCost;
                                priorityQueue.Add(new PQEntry(newCost, neighbor.Node));
                            }
                        }
                    }

                    // 시작 노드로부터 각 노드까지의 최단 거리 배열 반환
                    return distance;
                }
            }
            ////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////

            bool CheckArray( int [,] arr, int x, int y, int size )
            {
                for ( int i = 0; i < size; i++ )
                {
                    for ( int j = 0; j < size; j++ )
                    {
                        if ( arr [x + i, y + j] != arr [x, y] )
                        {
                            return false;
                        }
                    }
                }
                return true;
            }
            void BuildLeaf( int [,] arr, int x, int y, int size, ref int [] answer )
            {
                int newSize = size / 2;
                if ( size == 1 || CheckArray(arr, x, y, size) )
                {
                    if ( arr [x, y] == 0 )
                        answer [0]++;
                    else
                        answer [1]++;
                }
                else
                {
                    BuildLeaf(arr, x, y, newSize, ref answer);
                    BuildLeaf(arr, x + newSize, y, newSize, ref answer);
                    BuildLeaf(arr, x, y + newSize, newSize, ref answer);
                    BuildLeaf(arr, x + newSize, y + newSize, newSize, ref answer);
                }
            }


            public int [] QuadTree( int [,] arr )
            {
                int [] answer = new int [2];
                BuildLeaf(arr, 0, 0, arr.GetLength(0), ref answer);
                return answer;
            }


            //    source :  https://school.programmers.co.kr/learn/challenges
        }
    }
}

