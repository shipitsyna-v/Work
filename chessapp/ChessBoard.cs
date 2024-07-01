using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using chessapp.Classes;

namespace chessapp
{
    public class ChessBoard
    {
        private List<BaseClass> figures = new List<BaseClass>();

        public void Addfigure(BaseClass figure)
        {
            if (figure.X < 0 || figure.X >= 8 || figure.Y < 0 || figure.Y >= 8)
                throw new ArgumentOutOfRangeException("Координаты должны находиться в пределах шахматной доски (0-7)");

            foreach (var p in figures)
            {
                if (p.X == figure.X && p.Y == figure.Y)
                    throw new InvalidOperationException("Две фигуры не могут занимать одну и ту же позицию");
            }

            figures.Add(figure);
        }

        public void LoadFromFile(string filePath)
        {
            var lines = File.ReadAllLines(filePath);
            foreach (var line in lines)
            {
                var parts = line.Split(' ');
                var type = parts[0];
                var x = int.Parse(parts[1]);
                var y = int.Parse(parts[2]);

                switch (type)
                {
                    case "king":
                        Addfigure(new King(x, y));
                        break;
                    case "queen":
                        Addfigure(new Queen(x, y));
                        break;
                    case "rook":
                        Addfigure(new Rook(x, y));
                        break;
                    case "bishop":
                        Addfigure(new Bishop(x, y));
                        break;
                    case "knight":
                        Addfigure(new Knight(x, y));
                        break;
                    default:
                        throw new InvalidOperationException($"Unknown type: {type}");
                }
            }
        }

        public void DrawBoard()
        {
            char[,] board = new char[8, 8];
            foreach (var figure in figures)
            {
                char symbol = figure switch
                {
                    King => 'K',
                    Queen => 'Q',
                    Rook => 'R',
                    Bishop => 'B',
                    Knight => 'N',
                    _ => ' '
                };
                board[figure.X, figure.Y] = symbol;
            }

            for (int y = 7; y >= 0; y--)
            {
                for (int x = 0; x < 8; x++)
                {
                    Console.Write(board[x, y] == '\0' ? '.' : board[x, y]);
                    Console.Write(' ');
                }
                Console.WriteLine();
            }
        }

        public void CheckAttacks()
        {
            foreach (var attacker in figures)
            {
                foreach (var target in figures)
                {
                    if (attacker != target && attacker.Attack(target))
                    {
                        Console.WriteLine($"{attacker.GetType().Name} at ({attacker.X}, {attacker.Y}) attacks {target.GetType().Name} at ({target.X}, {target.Y})");
                    }
                }
            }
        }
    }
}
