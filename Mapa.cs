using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Snake
{
    class Mapa
    {
        private int _width, _height;
        public Mapa(int width, int height)
        {
            _width = width;
            _height = height;
        }

        public int Width { get => _width; set => _width = value; }
        public int Height { get => _height; set => _height = value; }
    }
}
