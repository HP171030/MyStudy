using System;

public class TowerOfHanoi
{
    IntPtr unManagedRs;
    public int [,] Solution( int n )
    {
        int totalMoves = ( int )Math.Pow(2, n) - 1; // Total number of moves
        int [,] moves = new int [totalMoves, 2]; // Create 2D array to hold the moves
        MoveDisks(n, 1, 3, 2, moves, ref moveIndex);
        return moves;
    }

    private int moveIndex = 0; // To keep track of the current move index

    private void MoveDisks( int n, int source, int destination, int auxiliary, int [,] moves, ref int moveIndex )
    {
        if ( n == 1 )
        {
            moves [moveIndex, 0] = source; // Move from source
            moves [moveIndex, 1] = destination; // Move to destination
            moveIndex++; // Increment the move index
            return;
        }

        // Step 1: Move n-1 disks from source to auxiliary
        MoveDisks(n - 1, source, auxiliary, destination, moves, ref moveIndex);

        // Step 2: Move the nth disk from source to destination
        moves [moveIndex, 0] = source;
        moves [moveIndex, 1] = destination;
        moveIndex++; // Increment the move index

        // Step 3: Move n-1 disks from auxiliary to destination
        MoveDisks(n - 1, auxiliary, destination, source, moves, ref moveIndex);
    }
    void Dispose()
    {

    }
    ~TowerOfHanoi()
    {
        GC.SuppressFinalize(this);

    }
}

public class Program
{
    public static void Main( string [] args )
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
