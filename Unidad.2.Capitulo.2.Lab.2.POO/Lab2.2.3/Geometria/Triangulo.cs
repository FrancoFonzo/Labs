using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Geometria
{
    public class Triangulo
    {
        private int _base;
        private int _altura;

        public int Altura
        {
            get => this._altura;
            set => this._altura = value;
        }

        public int Base
        {
            get => this._base;
            set => this._base = value;
        }

        public void CalcularPerimetro()
        {
            throw new System.NotImplementedException();
        }

        public void CalcularSuperfie()
        {
            throw new System.NotImplementedException();
        }
    }
}