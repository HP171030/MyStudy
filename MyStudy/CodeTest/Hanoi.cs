using System;

public class TowerOfHanoi
{
    IntPtr unManagedRs;
    public int [,] Solution( int n )
    {

        List<int []> list = new List<int []>();     //배열에 넣을 리스트

        Solve(n, 1, 3, 2,ref list);                 //n개 원반 1 => 3 2를 보조로 활용

        int [,] answer = new int [,] { { list.Count,2 } };          //2차원 배열 리스트 갯수만큼 생성, 내부 배열 크기 2개
        for ( int i = 0; i < list.Count; i++ )
        {
            answer [i, 0] = list [i] [0];               //리스트 i의 배열의 첫번째 요소
            answer [i, 1] = list [i] [1];               //리스트 i의 배열의 두번째 요소
        }

        return answer;

    }

    void Solve(int n,int start,int end,int temp,ref List<int []> answer )
    {
        
                                                        //맨 아래 칸이 end 쪽으로 가야함
        if( n == 1 )                                    // 옮기는 원반이 한개이면 옮기기 (배열에 넣기)
        {
            answer.Add(new int [] { start, end });
        }
        else
        {
            Solve(n - 1, start, temp, end,ref answer);          //맨 아래칸이 end쪽으로 가야하니까 나머지를(n-1)개를 temp 칸으로 이동                                 
            answer.Add(new int [] { start, end });              //start에서 end로 마지막 원형을 이동
            Solve(n - 1, temp, end, start, ref answer);         //임시칸에 있던거 end칸으로 이동

        }
    }


}

public class Program
{
    public static void Main3( string [] args )
    {
        TowerOfHanoi hanoi = new TowerOfHanoi();
        int numberOfDisks = 2; // Example: 2 disks
        int [,] result = hanoi.Solution(numberOfDisks);

        // Display the result
        for ( int i = 0; i < ( int )Math.Pow(2, numberOfDisks) - 1; i++ )
        {
            Console.WriteLine($"[{result [i, 0]}, {result [i, 1]}]");
        }
    }
}
