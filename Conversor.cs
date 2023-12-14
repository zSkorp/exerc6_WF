using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EX6WF
{
    internal class Conversor
    {
        private double MilhaMaritimaParaMetro = 1852; // 1 milha marítima em metros
        private double MetroParaQuilometro = 0.001;   // 1 metro em quilômetros

        public Conversor (double milhaMaritimaParaMetro, double metroParaQuilometro)
        {
            this.MilhaMaritimaParaMetro = milhaMaritimaParaMetro;
            this.MetroParaQuilometro = metroParaQuilometro;
        }

        public Conversor ()
        {
            this.MilhaMaritimaParaMetro = 0;
            this.MetroParaQuilometro = 0;
        }

        public void SetMilha (double mi)
        {
            this.MilhaMaritimaParaMetro = mi;
        }

        public void SetMetro(double m)
        {
            this.MetroParaQuilometro = m;
        }

        public double GetMilha ()
        {
            return this.MilhaMaritimaParaMetro;
        }

        public double GetMetro()
        {
            return this.MetroParaQuilometro;
        }

        public double ConverterMilhasParaQuilometros()
        {
            return MetroParaQuilometro* MilhaMaritimaParaMetro;
           

        }
    }
}
