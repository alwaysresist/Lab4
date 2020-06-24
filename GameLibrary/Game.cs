using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameLibrary
{
    public class Game
    {
        CaraTaker Save;
        Random Rand = new Random();
        int[,] field;
        int size;
        public int count = 0, _x, _y; 

        public Game(int size) 
        {
            this.size = size;
            field = new int[size, size];
            Save = new CaraTaker();
        }

        public void Start()
        {
            for (int x = 0; x < size; ++x)//поле field заполнили значениям 1-16
            {
                for (int y = 0; y < size; ++y)
                {
                    field[x, y] = CoordinatesToPosition(x, y) + 1;
                }
            }
            _x = size - 1;
            _y = size - 1;
            field[_x, _y] = 0;
        }

        public bool Shift(int position)
        {
            int x, y;
            PositionToCoordinates(position, out x, out y);//по параметру position находим координаты x,y той ячейки массива, которую нужно поменять с нулевой ячейкой
            if (Math.Abs(x - _x) + Math.Abs(y - _y) != 1)
            {
                return false;
            }
            GameSave();
            field[_x, _y] = field[x, y];//меняем местами ячейки
            field[x, y] = 0;
            _x = x;
            _y = y;
            return true;
        }

        public void ShiftRandom()
        {
            int a = Rand.Next(0, 4);
            int x = _x;
            int y = _y;
            if (a == 0)//ходим на одну из 4 соседних кнопок
                x++;
            else if (a == 1)
                x--;
            else if (a == 2)
                y++;
            else
                y--;
            Shift(CoordinatesToPosition(x, y));
        }

        private int CoordinatesToPosition(int x, int y)//координаты в друмерном массиве переводим в номер кнопки на поле
        {
            if (x < 0) 
                x = 0;
            if (y < 0) 
                y = 0;
            if (x > size - 1) 
                x = size - 1;
            if (y > size - 1)
                y = size - 1;
            return y * size + x;
        }

        private void PositionToCoordinates(int position, out int x, out int y)//номер кнопки переводим в координаты в двумером массиве
        {
            if (position < 0)
            {
                position = 0;
            }
            if (position > Math.Pow(size, 2) - 1)
            {
                position = size * size - 1;
            }
            x = position % size;
            y = position / size;
        }
       
        public int GetNumber(int position)//по позиции нажатой кнопки получаем значение, хранящееся в соответствующей ячейке поля
        {
            int x, y;
            PositionToCoordinates(position, out x, out y);
            if (x < 0 && x >= size * size) //если координаты некорректны, возвращаем 0
                return 0;
            if (y < 0 && y >= size * size) 
                return 0;
            return field[x, y];
        }
        
        public bool Check()//проверка завершения игры
        {
            if (!(_x != 0 && _y != 0))//если клетка не последняя, то игра еще не завершена
            {
                return false;
            }
            for (int x = 0; x < size; ++x)
            {
                for (int y = 0; y < size; ++y)
                {
                    if (x == size - 1 && y == size - 1)
                    {
                        return true;
                    }
                    else if (field[x, y] != CoordinatesToPosition(x, y) + 1)
                    {
                        return false;
                    }
                }
            }
            return true;
        }

        public void GameSave()//сохранить ход
        { 
            Save.In(new Memento(field, size)); 
        }

        public void GameRestore()//вывод последнего сохранения
        {
            Memento memento = Save.Out();
            int[,] fieldSave = memento.Getfield();
            for (int i = 0; i < size; ++i)
            {
                for (int j = 0; j < size; ++j)
                {
                    field[i, j] = fieldSave[i, j];
                    if (field[i, j] == 0)
                    {
                        _x = i; _y = j;
                    }
                }
            }
        }
    }
}
