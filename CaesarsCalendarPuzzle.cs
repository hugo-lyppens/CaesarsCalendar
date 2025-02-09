using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;

namespace CaesarsCalendar
{
    internal class CaesarsCalendarPuzzle
    {
        public CaesarsCalendarPuzzle()
        {
            rotatedPiecesList = new List<Tuple<Piece, int, int>>[pieces.Length];
            for (int i = 0; i < pieces.Length; i++)
            {
                var piece = pieces[i];
                var rotatedPieces = new List<Tuple<Piece, int, int>>();
                rotatedPiecesList[i] = rotatedPieces;
                for (int d = 0; d < 4; d++)
                {
                    for (int m = 0; m < 2; m++)
                    {
                        var r_piece = (m & 1) == 0 ? piece : piece.Mirror();
                        if (rotatedPieces.All(t => !t.Item1.Equals(r_piece)))
                        {
                            rotatedPieces.Add(Tuple.Create(r_piece, d, m));
                            Debug.WriteLine(i + " " + d + " " + m + ": " + r_piece.offset);
                        }
                    }
                    if (d < 3)
                        piece = piece.Rotate90();
                }
            }
        }
        private static readonly int BoardWidth = 7;
        private static readonly int BoardHeight = 8;
        public int Width {  get { return BoardWidth; } }
        public int Height { get { return BoardHeight; } }

        private static readonly Board emptyBoard = new Board(new byte[]
        {
            0b00000011,
            0b00000011,
            0b00000001,
            0b00000001,
            0b00000001,
            0b00000001,
            0b00000001,
            0b11110001
        }, BoardWidth, BoardHeight);
        private static readonly Piece[] pieces = new Piece[]
        {
            new Piece(new byte[] {0b10000000,0b11100000 }),
            new Piece(new byte[] {0b11110000 }),
            new Piece(new byte[] {0b10000000,0b11100000,0b10000000 }),
            new Piece(new byte[] {0b11000000,0b10000000,0b11000000 }),
            new Piece(new byte[] {0b00110000,0b11100000 }),
            new Piece(new byte[] {0b10000000,0b11110000 }),
            new Piece(new byte[] { 0b10000000, 0b10000000, 0b11100000 }),
            new Piece(new byte[] {0b11000000,0b01000000,0b01100000 }),
            new Piece(new byte[] {0b11100000,0b11000000 }),
            new Piece(new byte[] {0b01100000,0b11000000 })
        };
        private List<Tuple<Piece, int, int>>[] rotatedPiecesList;


        public List<List<Tuple<Piece, int, int>>> Solve(int month, int day, int weekday)
        {
            Board board = emptyBoard.Clone();
            int daym1 = day - 1;
            board.Set(month % 6, month / 6);
            if (weekday < 4)
                board.Set(weekday + 3, 6);
            else
                board.Set(weekday, 7);
            board.Set(daym1 % 7, 2 + (daym1) / 7);
            List<List<Tuple<Piece, int, int>>> solutions = new List<List<Tuple<Piece, int, int>>>();
            Solve(board, Enumerable.Range(0, pieces.Length).ToArray(), 0, board.Next(4, board.height - 1), solutions);
            return solutions;
        }
        private bool Solve(Board board, int[] pieceIndices, int level, (int, int)? pos, List<List<Tuple<Piece, int, int>>> solutions)
        {
            int l = pieceIndices.Length;
            if (level == l)
            {
                Debug.WriteLine("Found Solution: " + String.Join(",", pieceIndices));
                solutions.Add(new List<Tuple<Piece, int, int>>(board.Pieces));
                return true;
            }
            (int x, int y) = pos.Value;
            bool b = false;
            for (int i = level; i < l; i++)
            {
                int pieceIndex = pieceIndices[i];
                foreach ((var p, int d, int m) in rotatedPiecesList[pieceIndex])
                {
                    int px = x - p.offset;
                    int py = y - p.height + 1;
                    if (board.Fits(p, px, py))
                    {
                        board.Add(p, px, py);
                        pieceIndices[i] = pieceIndices[level];
                        pieceIndices[level] = pieceIndex;
                        var n = board.Next(x, y);

                        b |= Solve(board, pieceIndices, level + 1, n, solutions);
                        board.Subtract(p, px, py);
                        pieceIndices[level] = pieceIndices[i];
                        pieceIndices[i] = pieceIndex;
                    }
                }
            }
            return b;
        }
    }
}
