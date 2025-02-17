using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Numerics;

namespace CaesarsCalendar
{
    public class Piece : IEquatable<Piece>
    {
        public readonly byte[] bits;
        public readonly int hashCode;
        public readonly int width, height, offset;
        public readonly int popCount;
        public Piece(byte[] bits, int w, int h)
        {
            this.bits = bits;
            this.hashCode = bits.Aggregate(0, HashCode.Combine);
            this.width = w;
            this.height = h;
            offset = BitOperations.LeadingZeroCount((uint)(bits.Last()) << 24);
            this.popCount = bits.Aggregate(0, (a, b) => a + BitOperations.PopCount(b));
        }

        public Piece(byte[] bits): 
            this(bits, 
                8 - BitOperations.TrailingZeroCount(bits.Aggregate((byte)0b0, (a, b) => (byte) (a | b))), 
                bits.Length)
        {
        }
        public override String ToString()
        {
            return String.Join("/",bits.Select(x => Convert.ToString(x,2).PadLeft(8,'0').Substring(0,width)));
        }
        public Piece Mirror()
        {
            return new Piece(bits.Reverse().ToArray(), width, height );
        }
        static Pen blackPen = new Pen(Color.Black, 3);
        static Brush pieceBrush = new SolidBrush(Color.FromArgb(225, 174, 143));

        public Piece Rotate90()
        {
            int new_width = height;
            int new_height = width;
            var new_bits = new byte[new_height];
            byte new_bit = (byte)(0x80>>(new_width-1));
            foreach (var row in bits)
            {
                byte bit = 0x80;
                for(int y = 0; y < new_height; y++)
                {
                    if ((row & bit)!=0)
                        new_bits[y] |= new_bit;
                    bit >>= 1;
                }
                new_bit <<= 1;
            }
            return new Piece(new_bits, new_width,new_height);
        }

        public override bool Equals(object obj)
        {
            return Equals(obj as Piece);
        }

        public bool Equals(Piece other)
        {
            return !(other is null) &&
//                       EqualityComparer<byte[]>.Default.Equals(bits, other.bits) &&
                    bits.SequenceEqual( other.bits) &&
                    width == other.width &&
                    height == other.height;
        }

        internal void Render(Graphics graphics, int x, int y, int blockWidth, int blockHeight)
        {
            byte prevRow = 0;
            byte row = bits[0];
            for (int py=0;py<height;py++)
            {
                byte bitMask = 0x80;
                bool prevBit = false;
                byte nextRow=(py<height-1)?bits[py+1]:(byte)0;
                bool bit = (row & bitMask) != 0;
                for (int px = 0; px < width; px++)
                {
                    bool prevRowBit = (prevRow & bitMask) != 0;
                    bool nextRowBit = (nextRow & bitMask) != 0;
                    bitMask >>= 1;
                    bool nextBit = (row & bitMask) != 0;
                    if (bit)
                    {
                        int x1 = x + px*blockWidth;
                        int x2 = x1 + blockWidth;
                        int y1 = y + py*blockHeight;
                        int y2 = y1 + blockHeight;
                        graphics.FillRectangle(pieceBrush, x1, y1, blockWidth, blockHeight);
                        if(!prevBit)
                            graphics.DrawLine(blackPen, x1, y1, x1, y2);
                        if(!nextBit)
                            graphics.DrawLine(blackPen, x2, y1, x2, y2);
                        if(!prevRowBit)
                            graphics.DrawLine(blackPen, x1, y1, x2, y1);
                        if(!nextRowBit)
                            graphics.DrawLine(blackPen, x1, y2, x2, y2);
                    }
                    prevBit = bit;
                    bit = nextBit;
                }
                prevRow = row; 
                row = nextRow;
            }
        }

        public override int GetHashCode()
        {
            return hashCode;
        }

        public static bool operator ==(Piece left, Piece right)
        {
            return EqualityComparer<Piece>.Default.Equals(left, right);
        }

        public static bool operator !=(Piece left, Piece right)
        {
            return !(left == right);
        }
    }
}
