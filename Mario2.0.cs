//Mario 8 Bit Lab 2 

   {
    //Mario 

    {
        // Blue Blocks Location

        var Blue = new List<(int x, int y)>
        {
            (0,0), (0,1), (0,2), (0,3), (0,4), (0,5), (0,6), (0,7),
            (0,8), (0,9), (0,10), (0,11), (0,12), (0,13), (0,14), (0,15), (0,16), (0,17),

            (1,0), (1,1), (1,2), (1,3), (1,4), (1,5), (1,6), (1,7), (1,8), (1,9), (1,14), (1,15), (1,17),

            (2,0), (2,1), (2,2), (2,3), (2,7), (2,8), (2,14), (2,17),
            (3,0), (3,1), (3,7), (3,17),
            (4,0), (4,17),
            (5,0), (5,15), (5,16), (5,17),
            (6,0), (6,14), (6,15), (6,16), (6,17),
            (7,0), (7,14), (7,15), (7,16), (7,17),
            (8,0), (8,17),
            (9,0), (9,1), (9,8), (9,17),
            (10,0), (10,1), (10,3), (10,8), (10,17),
            (11,0), (11,1), (11,3), (11,7), (11,8), (11,14), (11,15), (11,17),
            (12,0), (12,1), (12,2), (12,3), (12,4),(12,6), (12,7), (12,8), (12,9), (12,14), (12,15), (12,16), (12,17),
            (13,0), (13,1), (13,2), (13,3), (13,4), (13,5), (13,6), (13,7), (13,8), (13,9),
            (13,10), (13,11), (13,12), (13,13), (13,14), (13,15), (13,16), (13,17),
        };

        Console.BackgroundColor = ConsoleColor.Blue;
        foreach (var pos in Blue)
        {
            Console.SetCursorPosition(pos.x * 2, pos.y);
            Console.Write("  ");
        }

        // Red Blocks Location 
        //I confused myself going left to right instead of top to bottom and the numbers got flipped
        // so I flipped them back and it looks messy
        var Red = new List<(int x, int y)>
        {

           (4, 1), (5, 1), (6, 1), (7, 1), (8, 1),
        (3, 2), (4, 2), (5, 2), (6, 2), (7, 2), (8, 2), (9, 2), (10, 2), (11, 2),
        (5, 8),
        (5, 9), (8, 9),
        (5, 10), (8, 10),
        (5, 11), (6, 11), (7, 11), (8, 11),
        (4, 12), (6, 12), (7, 12), (9, 12),
        (3, 13), (4, 13), (5, 13), (6, 13), (7, 13), (8, 13), (9, 13), (10, 13),
        (3, 14), (4, 14), (5, 14), (8, 14), (9, 14), (10, 14),
        };

        Console.BackgroundColor = ConsoleColor.Red;
        foreach (var pos in Red)
        {
            Console.SetCursorPosition(pos.x * 2, pos.y);
            Console.Write("  ");
        }

        // Dark Blue Blocks Location
        var DarkBlue = new List<(int x, int y)>
        {
           (1,10),
           (2,9),(2,10),
           (3,8),(3,9),(3,10),(3,11),
           (4,8),(4,9),(4,10),(4,11),
           (6,8),(6,9),(6,10),
           (7,8),(7,9),(7,10),
           (8,8),
           (9,9),(9,10),(9,11),
           (10,9),(10,10),(10,11),
           (11,9),(11,10),
           (12,10),
        };

        Console.BackgroundColor = ConsoleColor.DarkBlue;
        foreach (var pos in DarkBlue)
        {
            Console.SetCursorPosition(pos.x * 2, pos.y);
            Console.Write("  ");
        }

        // Yellow Blocks Location
        var Yellow = new List<(int x, int y)>
        {

            (5, 12), (8, 12)
        };

        Console.BackgroundColor = ConsoleColor.Yellow;
        foreach (var pos in Yellow)

        {
            Console.SetCursorPosition(pos.x * 2, pos.y);
            Console.Write("  ");
        }

        // Black Blocks Location
        var Black = new List<(int x, int y)>
        {

            (2,4),(2,5),(2,6),
            (3,3),(3,6),
            (4,3),(4,4),(4,5),
            (5,3),(5,5),
            (8,3),(8,4),(8,6),
            (9,5),(9,6),
            (10,6),
            (11,6),
        };

        Console.BackgroundColor = ConsoleColor.Black;
        foreach (var pos in Black)
        {
            Console.SetCursorPosition(pos.x * 2, pos.y);
            Console.Write("  ");
        }
        // White Blocks Location
        var White = new List<(int x, int y)>
        {
            (1,11),(1,12),(1,13),
            (2,11),(2,12),(2,13),
            (3,4),(3,5),(3,12),
            (4,6),(4,7),
            (5,4),(5,6),(5,7),
            (6,3),(6,4),(6,5),(6,6),(6,7),
            (7,3),(7,4),(7,5),(7,6),(7,7),
            (8,5),(8,7),
            (9,3),(9,4),(9,7),
            (10,4),(10,5),(10,7),(10,12),
            (11,4),(11,5),(11,11),(11,12),(11,13),
            (12,5),(12,11),(12,12),(12,13),
            };

        Console.BackgroundColor = ConsoleColor.White;
        foreach (var pos in White)
        {
            Console.SetCursorPosition(pos.x * 2, pos.y);
            Console.Write("  ");
        }
        // DarkYellow Blocks Location
        var DarkYellow = new List<(int x, int y)>
        {

            (1,16),
            (2,15), (2,16),
            (3,15), (3,16),
            (4,15), (4,16),
            (8,15), (8,16),
            (9,15), (9,16),
            (10,15), (10,16),
            (11,16),
          };

        Console.BackgroundColor = ConsoleColor.DarkYellow;
        foreach (var pos in DarkYellow)
        {
            Console.SetCursorPosition(pos.x * 2, pos.y);
            Console.Write("  ");
        }


    }
}
Console.SetCursorPosition(0, 19);