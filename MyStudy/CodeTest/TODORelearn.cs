using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyStudy.CodeTest
{
    internal class Class1
    {
        public class Solution
        {
            public int [] SnailTriangle( int n )
            {
                // 삼각형 배열에 들어갈 총 원소의 개수를 구합니다.
                // n이 4라면, 원소 개수는 1 + 2 + 3 + 4 = 10개가 됩니다.
                int count = n * ( n + 1 ) / 2; // 총 원소 개수
                int [] answer = new int [count]; // 결과를 저장할 1차원 배열

                // 시작 위치와 시작값, 방향 설정
                int x = 0, y = 0;    // 삼각형에서 시작 위치는 맨 위 꼭짓점입니다 (0, 0)
                int value = 1;       // 채워 넣을 첫 번째 값은 1입니다
                int direction = 0;   // 방향을 나타내는 변수 (0: 아래, 1: 오른쪽, 2: 대각선 위)

                // 총 원소의 개수(count)만큼 반복하며 배열을 채웁니다
                for ( int i = 0; i < count; i++ )
                {
                    // 현재 위치에 값을 채웁니다.
                    // 이때 `y * (y + 1) / 2 + x`는 현재 위치를 1차원 배열 인덱스로 변환합니다.
                    answer [y * ( y + 1 ) / 2 + x] = value++;

                    // 방향에 따라 다음 위치로 이동합니다
                    if ( direction == 0 )
                    {  // 아래로 이동하는 경우
                       // 다음 위치가 배열의 범위 내에 있고, 비어 있는지 확인합니다.
                        if ( y + 1 < n && answer [( y + 1 ) * ( y + 2 ) / 2 + x] == 0 )
                        {
                            y++;  // y값을 증가시켜 아래로 이동합니다
                        }
                        else
                        {
                            // 이동할 수 없으면 방향을 오른쪽으로 바꿉니다.
                            direction = 1;
                            x++;  // 오른쪽으로 이동
                        }
                    }
                    else if ( direction == 1 )
                    {  // 오른쪽으로 이동하는 경우
                       // 다음 위치가 현재 행 범위 내에 있고, 비어 있는지 확인합니다.
                        if ( x + 1 < y + 1 && answer [y * ( y + 1 ) / 2 + x + 1] == 0 )
                        {
                            x++;  // x값을 증가시켜 오른쪽으로 이동합니다
                        }
                        else
                        {
                            // 이동할 수 없으면 방향을 대각선 위로 변경합니다.
                            direction = 2;
                            x--;
                            y--;  // 대각선 위로 이동
                        }
                    }
                    else if ( direction == 2 )
                    {  // 대각선 위로 이동하는 경우
                       // 다음 위치가 배열의 범위 내에 있고, 비어 있는지 확인합니다.
                        if ( y - 1 >= 0 && x - 1 >= 0 && answer [( y - 1 ) * y / 2 + x - 1] == 0 )
                        {
                            x--;
                            y--;  // x와 y를 감소시켜 대각선 위로 이동합니다
                        }
                        else
                        {
                            // 이동할 수 없으면 방향을 아래로 변경하여 반복합니다.
                            direction = 0;
                            y++;  // 아래로 이동
                        }
                    }
                }

                return answer; // 삼각형을 채운 배열을 반환합니다.
            }
        }
    }
}
