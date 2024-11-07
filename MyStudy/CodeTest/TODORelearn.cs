using System;

namespace MyStudy.CodeTest
{
    internal class Class1
    {
        public class Solution
        {
            // (x, y) 좌표를 1차원 배열의 인덱스로 변환하는 함수
            // 이 함수는 삼각형 배열에서 각 행이 시작되는 위치와 열 위치를 고려하여 인덱스를 계산합니다.
            private int GetIndexIn1D( int x, int y )
            {
                // y * (y + 1) / 2는 y행이 시작되는 인덱스를 나타내고, 
                // 여기에 x를 더하면 (x, y) 위치의 정확한 인덱스를 계산할 수 있습니다.
                return y * ( y + 1 ) / 2 + x;               
            }

            // 나선형으로 값을 채운 삼각형 배열을 생성하는 함수
            public int [] SnailTriangle( int n )
            {
                // 삼각형 배열에 들어갈 총 원소 개수를 계산합니다.
                int count = n * ( n + 1 ) / 2;

                // 총 원소 개수를 크기로 가지는 결과 배열을 생성합니다.
                int [] answer = new int [count];

                // 초기 위치와 시작 값 설정
                int x = 0, y = 0;    // 시작 위치 (삼각형의 꼭짓점, 즉 (0, 0))
                int value = 1;       // 시작 값은 1입니다.
                int direction = 0;   // 방향을 나타내는 변수 (0: 아래, 1: 오른쪽, 2: 대각선 위)

                // 모든 값을 배열에 채울 때까지 반복합니다.
                for ( int i = 0; i < count; i++ )
                {
                    // 현재 위치 (x, y)에 값을 채웁니다.
                    // GetIndexIn1D(x, y) 함수를 통해 (x, y) 좌표에 해당하는 1차원 배열의 인덱스를 구합니다.
                    answer [GetIndexIn1D(x, y)] = value++;

                    // 방향에 따라 다음 위치로 이동합니다.
                    if ( direction == 0 ) // 현재 방향이 아래쪽일 때
                    {
                        // 아래로 이동할 위치가 배열 범위 내에 있고, 아직 값이 비어있는지 확인합니다.
                        if ( y + 1 < n && answer [GetIndexIn1D(x, y + 1)] == 0 )
                        {
                            // 이동할 수 있으면 y값을 증가시켜 아래로 이동합니다.
                            y++;
                        }
                        else
                        {
                            // 이동할 수 없으면 방향을 오른쪽으로 전환하고, x값을 증가시킵니다.
                            direction = 1;
                            x++;
                        }
                    }
                    else if ( direction == 1 ) // 현재 방향이 오른쪽일 때
                    {
                        // 오른쪽으로 이동할 위치가 현재 행 범위 내에 있고, 아직 값이 비어있는지 확인합니다.
                        if ( x + 1 < y + 1 && answer [GetIndexIn1D(x + 1, y)] == 0 )
                        {
                            // 이동할 수 있으면 x값을 증가시켜 오른쪽으로 이동합니다.
                            x++;
                        }
                        else
                        {
                            // 이동할 수 없으면 방향을 대각선 위로 전환하고, x와 y값을 감소시킵니다.
                            direction = 2;
                            x--;
                            y--;
                        }
                    }
                    else if ( direction == 2 ) // 현재 방향이 대각선 위일 때
                    {
                        // 대각선 위로 이동할 위치가 배열 범위 내에 있고, 아직 값이 비어있는지 확인합니다.
                        if ( y - 1 >= 0 && x - 1 >= 0 && answer [GetIndexIn1D(x - 1, y - 1)] == 0 )
                        {
                            // 이동할 수 있으면 x와 y값을 감소시켜 대각선 위로 이동합니다.
                            x--;
                            y--;
                        }
                        else
                        {
                            // 이동할 수 없으면 방향을 아래로 전환하고, y값을 증가시킵니다.
                            direction = 0;
                            y++;
                        }
                    }
                }

                // 모든 값을 채운 배열을 반환합니다.
                return answer;
            }
        }
    }

    public class Recochat
    {
        public int solution( string [] board )
        {
            int row = board.Length;
            int col = board [0].Length;
            char [,] boardPoint = new char [row, col];
            int [] startPoint = new int [2];
            int [] goalPoint = new int [2];
            bool startFound = false, goalFound = false;

            // 보드를 2D char 배열로 변환하고 시작 위치와 목표 위치 찾기
            for ( int i = 0; i < row; i++ )
            {
                for ( int j = 0; j < col; j++ )
                {
                    boardPoint [i, j] = board [i] [j];
                    if ( boardPoint [i, j] == 'R' )
                    {
                        startPoint = new int [] { i, j };
                        startFound = true;
                    }
                    else if ( boardPoint [i, j] == 'G' )
                    {
                        goalPoint = new int [] { i, j };
                        goalFound = true;
                    }
                }
            }

            if ( !startFound || !goalFound ) return -1; // 시작점이나 목표점이 없으면 -1 반환

            // BFS를 위한 큐와 방문 기록을 위한 HashSet
            Queue<(int [], int)> queue = new Queue<(int [], int)>();
            HashSet<string> visited = new HashSet<string>();

            queue.Enqueue((startPoint, 0)); // 시작점과 이동 횟수(0)를 큐에 추가
            visited.Add($"{startPoint [0]},{startPoint [1]}");

            // BFS 탐색 시작
            while ( queue.Count > 0 )
            {
                var (current, moves) = queue.Dequeue();
                int curRow = current [0];
                int curCol = current [1];

                // 목표 지점에 도달했을 경우 이동 횟수를 반환
                if ( curRow == goalPoint [0] && curCol == goalPoint [1] )
                {
                    return moves;
                }

                // 상, 하, 좌, 우 방향으로 이동 시도
                for ( int dir = 0; dir < 4; dir++ )
                {
                    int [] nextPoint = MovePoint(dir, current, boardPoint);
                    if ( nextPoint != null )
                    {
                        string nextKey = $"{nextPoint [0]},{nextPoint [1]}";
                        if ( !visited.Contains(nextKey) )
                        {
                            visited.Add(nextKey);
                            queue.Enqueue((nextPoint, moves + 1));
                        }
                    }
                }
            }

            // 목표 지점에 도달할 수 없는 경우 -1 반환
            return -1;
        }

        int [] MovePoint( int dir, int [] startPoint, char [,] boardPoint )
        {
            int row = boardPoint.GetLength(0);
            int col = boardPoint.GetLength(1);
            int [] point = ( int [] )startPoint.Clone();

            // 특정 방향으로 끝까지 이동
            while ( true )
            {
                int newRow = point [0] + ( dir == 0 ? 1 : dir == 2 ? -1 : 0 );
                int newCol = point [1] + ( dir == 1 ? -1 : dir == 3 ? 1 : 0 );

                // 범위를 벗어나거나 장애물을 만나면 이동 종료
                if ( newRow < 0 || newRow >= row || newCol < 0 || newCol >= col || boardPoint [newRow, newCol] == 'D' )
                {
                    break;
                }

                // 이동 가능한 위치로 업데이트
                point [0] = newRow;
                point [1] = newCol;
            }

            // 이동 후의 위치가 시작 위치와 동일하다면 null 반환
            return point [0] == startPoint [0] && point [1] == startPoint [1] ? null : point;
        }
    }
}
