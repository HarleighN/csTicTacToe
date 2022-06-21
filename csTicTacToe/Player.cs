using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class Player 
{
    internal char piece;

    internal Player(char piece)
    {
        this.piece = piece;
    }

    public bool place(Game board, int position)
    {
        return board.place(this, position);
    }
}