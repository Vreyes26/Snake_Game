using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Snake
{
    class Snake : Entidad2D
    {
        
        private int _hp;
        private const int _velocidad = 10;
        
        public Snake(int x, int y) : base(x, y)
        {
            _hp = 1;
        }

        public int Hp { get => _hp; set => _hp = value; }
        public int Velocidad => _velocidad;

        public void Comiendo()
        {
            // agrandar la serpiente
        }
    }
}
