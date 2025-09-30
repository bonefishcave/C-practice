class Project()
{
    static void Main(string[] args)
    {
        //writeBoardToFile(args);
        //readBoardFromFile(args);
    }

    static void writeBoardToFile(string[] args)
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
        int count = 0;
        try
        {
            for (int width = 0; width < chessboard.Length / 8; width++)
            {
                for (int height = 0; height < chessboard.Length / 8; height++)
                {
                    using StreamWriter writer = new StreamWriter("chessboard.txt", true); // , true makes it append with new line
                    writer.Write(chessboard[width, height] + ",");

                    count = count + 1;
                    Console.WriteLine("a new string should have been inserted into the file, count " + count);
                }
            }
        }
        catch (Exception errorType)
        {
            Console.WriteLine("The error is: " + errorType.Message);
        }
    }
    static void readBoardFromFile(string[] args)
    {
        try
        {
            using StreamReader reader = new StreamReader("chessboard.txt");
            string textFile = reader.ReadToEnd();

            string[] chessPieces = textFile.Split(',');
            foreach (var word in chessPieces)
            {
                string[] readTerms = { };
                readTerms[i] = word; // finish this
                Console.WriteLine("term" + $"<{word}> " + "has been added");
            }



        }
        catch (Exception errorType)
        {
            Console.WriteLine("The error is: " + errorType.Message);
        }
    }
}

    