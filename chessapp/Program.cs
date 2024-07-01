using chessapp;
using System;

namespace chessapp
{
    class Program
    {
        static void Main(string[] args)
        {
            var chessBoard = new ChessBoard();
            try
            {
                chessBoard.LoadFromFile("input.txt");
                chessBoard.DrawBoard();
                chessBoard.CheckAttacks();
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error: {ex.Message}");
            }
        }
    }
}