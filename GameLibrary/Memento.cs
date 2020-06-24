using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameLibrary
{
    class Memento
    {
        public int[,] field;
        public Memento(int[,] field, int size)
        {
            this.field = new int[size, size];
            for (int i = 0; i < size; ++i)
            {
                for (int j = 0; j < size; ++j)
                {
                    this.field[i, j] = field[i, j];
                }
            }
        }
        public int[,] Getfield()
        {
            return field;
        }
    }
}
