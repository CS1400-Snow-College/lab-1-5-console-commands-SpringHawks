//Mario 8 Bit Lab 2 
{
    //Mario 

    {
        // Which blocks are Blue

        var Blue = new List<(int x, int y)>
        { (0,0), (0,1), (0,2), (0,3), (0,4), (0,5), (0,6), (0,7),
          (0,8), (0,9), (0,10), (0,11), (0,12), (0,13),(0,14), (0,15), (0,16), (0,17),

          (1,0), (1,1), (1,2), (1,3), (1,4), (1,5), (1,6), (1,7), (1,8), (1,9),(1, 14), (1,15), (1,17),

          (2,0), (2,1), (2,2), (2,3), (2,7), (2,8), (2,14), (2,17),

                };

        //Where the Blue blocks go
        Console.BackgroundColor = ConsoleColor.Blue;
        foreach (var pos in Blue)
        {// If I set the posistion for x times two it will widen the square to be mostly even with the height of y
            Console.SetCursorPosition(pos.x * 2, pos.y);
            Console.Write("  ");
        }
    }
}
            