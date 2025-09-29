class Project()
{
    static void Main(string[] args)
    {
        chessBoardGame(args);
    }

    static void chessBoardGame(string[] args)
    {
        string[,] chessboard =
        {
            { "R", "K", "B", "Q", "Ki", "B", "K", "R" },
            { ".", ".", ".", ".", ".", ".", ".", "." },
            { ".", ".", ".", ".", ".", ".", ".", "."},
            { ".", ".", ".", ".", ".", ".", ".", "."},
            {".", ".", ".", ".", ".", ".", ".", "."},
            {".", ".", ".", ".", ".", ".", ".", "."},
            {".", ".", ".", ".", ".", ".", ".", "."},
            { "R", "K", "B", "Ki", "Q", "B", "K", "R"}

        };

        //int length = chessboard.Length;
        //Console.WriteLine(length);

        try
        {
            for (int width = 0; width < chessboard.Length; width++)
            {
                for (int height = 0; height < chessboard.Length; height++)
                {
                    using StreamWriter writer = new StreamWriter("chessboard.txt");
                    writer.WriteLine(chessboard[width, height]);
                }
            }

        }
        catch (Exception errorType)
        {
            Console.WriteLine("The error is: " + errorType.Message);
        }
    }
}

    