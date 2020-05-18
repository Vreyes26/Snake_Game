using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Snake
{
    abstract class Entidad2D
    {
        private const int _sizeGrafico = 5;
        private Point _coordenadas;
        private Random _random;

        public Entidad2D(int x, int y)
        {
            _coordenadas = new Point(x, y);
            _random = new Random();
        }

        public int SizeGrafico => _sizeGrafico;
        public Point Coordenadas { get => _coordenadas; set => _coordenadas = value; }
        public Random Random { get => _random; set => _random = value; }
    }
}
