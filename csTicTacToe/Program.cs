Random r = new();
Game board = new();
Player PlayerX = new Player('x');
Player PlayerO = new Player('o');

Console.WriteLine("Game Options:");
Console.WriteLine("(1)\t\t Human v. Human");
Console.WriteLine("(2)\t\t Human v. AI");
Console.WriteLine("(3)\t\t AI v. AI");
Console.WriteLine("(Any)\t Quit");


switch (int.Parse(Console.ReadLine()))
{
    case 1: twoHumanPlayers(board, PlayerX, PlayerO);
        break;
    case 2: if ((int)r.NextInt64(1, 3) == 1) aiFirst(board, PlayerX, PlayerO);
        else aiSecond(board, PlayerX, PlayerO);
        break;
    case 3: twoAIPlayers(board, PlayerX, PlayerO);
        break;
    default: Console.WriteLine("Game Over."); //idk this is in case they start the game but decide not to play lol
        break;
}

static void twoHumanPlayers(Game board, Player Player1, Player Player2)
{
    int counter = 0;

    board.print();
    while (!(board.end() == 'x' || board.end() == 'o') && counter < 9)
    {

       Console.WriteLine("Player 1's Turn: ");
        while (!(Player1.place(board, int.Parse(Console.ReadLine())))) 
        { //!place(board.board, Player1, (int)r.NextInt64(1,10))
           Console.WriteLine("There's already a piece there. Please try again.");
        }
        board.print();

        counter++;

        if (board.end() == 'x' || board.end() == 'o' || counter == 9)
            break; //Ends the game if Player1 already won or a draw has happened

       Console.WriteLine("Player 2's Turn: ");
        while (!(Player2.place(board, int.Parse(Console.ReadLine()))))
        { //!place(board.board, Player2, (int)r.NextInt64(1,10))
           Console.WriteLine("There's already a piece there. Please try again.");
        }
        board.print();
        counter++;
    }

    endMessage(board);
}

static void aiFirst(Game board, Player Player1, Player Player2)
{
    int counter = 0;
    Random r = new Random();

    board.print();
    while (!(board.end() == 'x' || board.end() == 'o') && counter < 9)
    {

       Console.WriteLine("Player 1's Turn: ");
        while (!Player1.place(board,(int)r.NextInt64(1,10)))
        { //!place(board.board, Player1, (int)r.NextInt64(1,10))
           Console.WriteLine("There's already a piece there. Please try again.");
        }
        board.print();
        counter++;

        if (board.end() == 'x' || board.end() == 'o' || counter == 9)
            break; //Ends the game if Player1 already won or a draw has happened

       Console.WriteLine("Player 2's Turn: ");
        while (!Player2.place(board, (int)r.NextInt64(1,10)))
        { //!place(board.board, Player2, (int)r.NextInt64(1,10))
           Console.WriteLine("There's already a piece there. Please try again.");
        }
        board.print();
        counter++;
    }
    endMessage(board);
}

static void aiSecond(Game board, Player Player1, Player Player2)
{
    int counter = 0;
    Random r = new Random();

    board.print();
    while (!(board.end() == 'x' || board.end() == 'o') && counter < 9)
    {

       Console.WriteLine("Player 1's Turn: ");
        while (!(Player1.place(board, (int)r.NextInt64(1,10))))
        { //!place(board.board, Player1, (int)r.NextInt64(1,10))
           Console.WriteLine("There's already a piece there. Please try again.");
        }
        board.print();
        counter++;

        if (board.end() == 'x' || board.end() == 'o' || counter == 9)
            break; //Ends the game if Player1 already won or a draw has happened

       Console.WriteLine("Player 2's Turn: ");
        while (!(Player2.place(board, (int)r.NextInt64(1, 10))))
        { //!place(board.board, Player2, (int)r.NextInt64(1,10))
           Console.WriteLine("There's already a piece there. Please try again.");
        }
        board.print();
        counter++;
    }
    endMessage(board);
}

static void twoAIPlayers(Game board, Player Player1, Player Player2)
{
    int counter = 0;
    Random r = new Random();

    board.print();
    while (!(board.end() == 'x' || board.end() == 'o') && counter < 9)
    {

       Console.WriteLine("Player 1's Turn: ");
        while (!(Player1.place(board, (int)r.NextInt64(1, 10))))
        { //!place(board.board, Player1, (int)r.NextInt64(1,10))
           Console.WriteLine("There's already a piece there. Please try again.");
        }
        board.print();
        counter++;

        if (board.end() == 'x' || board.end() == 'o' || counter == 9)
            break; //Ends the game if Player1 already won or a draw has happened

       Console.WriteLine("Player 2's Turn: ");
        while (!(Player2.place(board, (int)r.NextInt64(1, 10))))
        { //!place(board.board, Player2, (int)r.NextInt64(1,10))
           Console.WriteLine("There's already a piece there. Please try again.");
        }
        board.print();
        counter++;
    }
    endMessage(board);
}

static void endMessage(Game board)
{
    if (board.end() == 'x')Console.WriteLine("Player 1 wins!");
        else if (board.end() == 'o')Console.WriteLine("Player 2 wins!");
        else Console.WriteLine("Draw.");
} 
