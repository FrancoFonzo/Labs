using System;

namespace Geometria
{
    public class Circulo
    {
        private int m_radio;

        public int Radio
        {
            get => this.m_radio;
            set => this.m_radio = value;
        }

        public float CalcularPerimetro()
        {
            return 2 * (float) Math.PI * m_radio;
        }

        public float CalcularSuperfie()
        {
            return (float) (Math.PI* Math.Pow(Radio, 2));
        }
    }
}
