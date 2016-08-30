namespace Task4.Mines
{
    using System;
    using System.Collections.Generic;
    using Task4.Mines.Models;

    public class StartUp
    {
        private const int MinCommandLength = 3;
        private const int MaxPlayersOnScoreBoard = 5;
        private const int enteredCells = 35;
        private const int fieldRow = 5;
        private const int fieldColumn = 10;

        public static void Main()
        {
            string command = string.Empty;
            char[,] field = CreateGameField();
            char[,] bombs = PlaceMines();
            int counter = 0;
            bool isDead = false;
            List<Score> champions = new List<Score>(6);
            int row = 0;
            int column = 0;
            bool isGameStart = true;
            bool isComplete = false;

            do
            {
                if (isGameStart)
                {
                    Console.WriteLine("Lets play “Mines”. Try to find the fields without mines and do your best. Command 'top' shows the scoreboard, 'restart' starts a new game, 'exit' exits the game!");

                    DrawField(field);
                    isGameStart = false;
                }

                Console.Write("Please enter row and column : ");

                command = Console.ReadLine().Trim();

                if (command.Length >= MinCommandLength)
                {
                    if (int.TryParse(command[0].ToString(), out row) &&
                    int.TryParse(command[2].ToString(), out column) &&
                    row <= field.GetLength(0) && 
                    column <= field.GetLength(1))
                    {
                        command = "turn";
                    }
                }

                switch (command)
                {
                    case "top":
                        ScoreBoard(champions);
                        break;
                    case "restart":
                        field = CreateGameField();
                        bombs = PlaceMines();
                        DrawField(field);
                        isDead = false;
                        isGameStart = false;
                        break;
                    case "exit":
                        Console.WriteLine("You have quit the game!");
                        break;
                    case "turn":
                        if (bombs[row, column] != '*')
                        {
                            if (bombs[row, column] == '-')
                            {
                                NextTurn(field, bombs, row, column);
                                counter++;
                            }
                            if (enteredCells == counter)
                            {
                                isComplete = true;
                            }
                            else
                            {
                                DrawField(field);
                            }
                        }
                        else
                        {
                            isDead = true;
                        }
                        break;
                    default:
                        Console.WriteLine($"{Environment.NewLine}Error! Invalid command.{Environment.NewLine}");
                        break;
                }

                if (isDead)
                {
                    DrawField(bombs);
                    Console.Write($"{Environment.NewLine}Ops you hit a bomb! You have finnished the game with {counter} points. Please enter your name: ");
                    string currentPlayerName = Console.ReadLine();
                    Score currentPlayer = new Score(currentPlayerName, counter);
                    if (champions.Count < MaxPlayersOnScoreBoard)
                    {
                        champions.Add(currentPlayer);
                    }
                    else
                    {
                        for (int i = 0; i < champions.Count; i++)
                        {
                            if (champions[i].Result < currentPlayer.Result)
                            {
                                champions.Insert(i, currentPlayer);
                                champions.RemoveAt(champions.Count - 1);
                                break;
                            }
                        }
                    }

                    champions.Sort((Score first, Score second) => second.Name.CompareTo(first.Name));
                    champions.Sort((Score first, Score second) => second.Result.CompareTo(first.Result));

                    ScoreBoard(champions);

                    field = CreateGameField();
                    bombs = PlaceMines();
                    counter = 0;
                    isDead = false;
                    isGameStart = true;
                }

                if (isComplete)
                {
                    Console.WriteLine($"{Environment.NewLine}Congratulations! You have opened all 35 cells without hitting a bomb.");
                    DrawField(bombs);
                    Console.WriteLine("Please enter your name, winner: ");
                    string name = Console.ReadLine();

                    Score score = new Score(name, counter);
                    champions.Add(score);

                    ScoreBoard(champions);
                    field = CreateGameField();
                    bombs = PlaceMines();

                    counter = 0;
                    isComplete = false;
                    isGameStart = true;
                }
            } while (command != "exit");

            Console.WriteLine("This Game is Made in Bulgaria!");
            Console.WriteLine("Lets Begin The Game.");
            Console.Read();
        }


        

        private static void ScoreBoard(List<Score> scores)
        {
            Console.WriteLine($"{Environment.NewLine}Points:");
            if (scores.Count > 0)
            {
                for (int i = 0; i < scores.Count; i++)
                {
                    Console.WriteLine($"{i + 1}. {scores[i].Name} --> {scores[i].Result} cells");
                }
                Console.WriteLine();
            }
            else
            {
                Console.WriteLine($"Scoreboard is empty!{Environment.NewLine}");
            }
        }

        private static void NextTurn(char[,] field, char[,] mines, int row, int column)
        {
            char numberOfMinesSoroundingTheCell = GetNumberOfMinesSoroundingTheCell(mines, row, column);
            mines[row, column] = numberOfMinesSoroundingTheCell;
            field[row, column] = numberOfMinesSoroundingTheCell;
        }

        private static void DrawField(char[,] board)
        {
            int rows = board.GetLength(0);
            int columns = board.GetLength(1);
            Console.WriteLine($"{Environment.NewLine}    0 1 2 3 4 5 6 7 8 9");
            Console.WriteLine("   ---------------------");
            for (int i = 0; i < rows; i++)
            {
                Console.Write($"{i} | ");
                for (int j = 0; j < columns; j++)
                {
                    Console.Write(string.Format($"{board[i, j]} "));
                }

                Console.Write("|");
                Console.WriteLine();
            }

            Console.WriteLine($"   ---------------------{Environment.NewLine}");
        }

        private static char[,] CreateGameField()
        {
            int boardRows = fieldRow;
            int boardColumns = fieldColumn;
            char[,] board = new char[boardRows, boardColumns];
            for (int i = 0; i < boardRows; i++)
            {
                for (int j = 0; j < boardColumns; j++)
                {
                    board[i, j] = '?';
                }
            }

            return board;
        }

        private static char[,] PlaceMines()
        {
            int rows = fieldRow;
            int columns = fieldColumn;
            char[,] gameField = new char[rows, columns];

            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    gameField[i, j] = '-';
                }
            }

            List<int> numbers = new List<int>();
            while (numbers.Count < fieldColumn + fieldRow)
            {
                Random random = new Random();
                int randomNumber = random.Next(50);
                if (!numbers.Contains(randomNumber))
                {
                    numbers.Add(randomNumber);
                }
            }

            foreach (int number in numbers)
            {
                int currentColumn = (number / columns);
                int currentRow = (number % columns);
                if (currentRow == 0 && number != 0)
                {
                    currentColumn--;
                    currentRow = columns;
                }
                else
                {
                    currentRow++;
                }
                gameField[currentColumn, currentRow - 1] = '*';
            }

            return gameField;
        }

        private static void Calculate(char[,] gamefield)
        {
            int currentColumn = gamefield.GetLength(0);
            int currentRow = gamefield.GetLength(1);

            for (int i = 0; i < currentColumn; i++)
            {
                for (int j = 0; j < currentRow; j++)
                {
                    if (gamefield[i, j] != '*')
                    {
                        char numberOfMinesSoroundingTheCell = GetNumberOfMinesSoroundingTheCell(gamefield, i, j);
                        gamefield[i, j] = numberOfMinesSoroundingTheCell;
                    }
                }
            }
        }

        private static char GetNumberOfMinesSoroundingTheCell(char[,] gameField, int row, int column)
        {
            int count = 0;
            int currentRow = gameField.GetLength(0);
            int currentColums = gameField.GetLength(1);

            if (row - 1 >= 0)
            {
                if (gameField[row - 1, column] == '*')
                {
                    count++;
                }
            }
            if (row + 1 < currentRow)
            {
                if (gameField[row + 1, column] == '*')
                {
                    count++;
                }
            }
            if (column - 1 >= 0)
            {
                if (gameField[row, column - 1] == '*')
                {
                    count++;
                }
            }
            if (column + 1 < currentColums)
            {
                if (gameField[row, column + 1] == '*')
                {
                    count++;
                }
            }
            if ((row - 1 >= 0) && (column - 1 >= 0))
            {
                if (gameField[row - 1, column - 1] == '*')
                {
                    count++;
                }
            }
            if ((row - 1 >= 0) && (column + 1 < currentColums))
            {
                if (gameField[row - 1, column + 1] == '*')
                {
                    count++;
                }
            }
            if ((row + 1 < currentRow) && (column - 1 >= 0))
            {
                if (gameField[row + 1, column - 1] == '*')
                {
                    count++;
                }
            }
            if ((row + 1 < currentRow) && (column + 1 < currentColums))
            {
                if (gameField[row + 1, column + 1] == '*')
                {
                    count++;
                }
            }
            return char.Parse(count.ToString());
        }
    }
}
