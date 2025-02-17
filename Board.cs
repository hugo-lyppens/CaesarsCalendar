using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Numerics;

namespace CaesarsCalendar
{
    public class Board
    {
        private readonly byte[] bits;
        private readonly Stack<(Piece,int,int)> pieces;
        public readonly int width, height;
        public int OpenCount { get { return bits.Aggregate(0, (a, b) => a + (8 - BitOperations.PopCount(b))); } }
        public Stack<(Piece, int, int)> Pieces { get => pieces; }

        public Board(byte[] bits, int w, int h)
        {
            this.bits = bits;
            this.width = w;
            this.height = h;
            this.pieces=new Stack<(Piece,int,int)>();
        }

        public Board Clone()
        {
            return new Board(bits.ToArray(), width, height);
        }
        public bool Fits(Piece piece, int x, int y)
        {
            if (x < 0 || y < 0 || x + piece.width > width || y + piece.height > height) return false;
            for (int py = 0; py < piece.height; py++)
            {
                if ((bits[y + py] & (piece.bits[py] >> x)) != 0)
                    return false;
            }
            return true;
        }
        public void Push(Piece piece, int x, int y)
        {
            for (int py = 0; py < piece.height; py++)
            {
                bits[y + py] |= (byte)(piece.bits[py] >> x);
            }
            pieces.Push((piece, x, y));
        }
        public void Pop()
        {
            (Piece piece, int x, int y) = pieces.Pop();
            for (int py = 0; py < piece.height; py++)
            {
                bits[y + py] &= (byte)~(piece.bits[py] >> x);
            }
        }
        public override string ToString()
        {
            return string.Join("|",pieces.Select(t=>$"{t.Item1}@({t.Item2},{t.Item3})"));
        }
        public void Set(int x, int y)
        {
            bits[y] |= (byte)(0x80 >> x);
        }
        public void Clear(int x, int y)
        {
            bits[y] &= (byte)~(0x80 >> x);
        }
        public bool Get(int x, int y)
        {
            return (bits[y] & (byte)(0x80 >> x))!=0;
        }
        public (int,int)? Next(int x, int y)
        {
            (int, int)? r=null;
            while (y>=0&&Get(x,y))
            {
                x++;
                if(x>=width)
                {
                    x = 0; y--;
                }
            }
            if (y >= 0)
                r = (x, y);
            return r;
        }
    }
}
