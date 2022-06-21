using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class Game
{
    char[] board;

    public Game()
    {
        board = new char[9];

        for (int i = 0; i < board.Length; i++)
        {
            board[i] = ' ';
        }
    }

    public void print()
    {
        Console.WriteLine(
@$"{board[0]}|{board[1]}|{board[2]}
------
{board[3]}|{board[4]}|{board[5]}
------
{board[6]}|{board[7]}|{board[8]}");

        /*
        for (int i = 1; i < board.Length + 1; i++)
        {
            if(board)
            Console.Write(board[i - 1] + " ");

            if (i % 3 == 0) Console.WriteLine();
        }
        */
    }

    public bool place(Player player, int position)
    {
        if (board[position - 1].Equals(' '))
        {
            board[position - 1] = player.piece;
            return true; //Piece was placed
        }

        return false; //Piece was not placed
    }

    //There are 9 end conditions, 8 wins or a draw.
    public char end()
    {
        if (!board[0].Equals(' ') && board[0] == board[1] && board[1] == board[2]) return board[0];
        if (!board[3].Equals(' ') && board[3] == board[4] && board[4] == board[5]) return board[3];
        if (!board[6].Equals(' ') && board[6] == board[7] && board[7] == board[8]) return board[6];

        if (!board[0].Equals(' ') && board[0] == board[3] && board[3] == board[6]) return board[0];
        if (!board[1].Equals(' ') && board[1] == board[4] && board[4] == board[7]) return board[1];
        if (!board[2].Equals(' ') && board[2] == board[5] && board[5] == board[8]) return board[2];

        if (!board[0].Equals(' ') && board[0] == board[4] && board[4] == board[8]) return board[0];
        if (!board[2].Equals(' ') && board[2] == board[4] && board[4] == board[6]) return board[2];

        return ' '; // Maybe a draw? Or the game just isn't over
    }

}