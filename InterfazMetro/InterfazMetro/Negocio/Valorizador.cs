using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Negocio
{
    public class Valorizador
    {
        public int Asistentes { get; set; }
        public int PersonalAdicional { get; set; }
        public Contrato Contrato { get; set; }
        public Valorizador()
        {
            this.Init();
        }
        private void Init()
        {
            Asistentes = 0;
            PersonalAdicional = 0;
            Contrato = new Contrato();
        }
        public double CalcularValorEvento(int Asis, int Per, double valorbase, int personalbase)
        {
            double valortotal;
            this.Asistentes = Asis;
            this.PersonalAdicional = Per;
            if (Asistentes >= 1 && Asistentes <= 20)
            {
                valortotal = valorbase + 3;
            }
            else
            {
                if (Asistentes >= 21 && Asistentes <= 50)
                {
                    valortotal = valorbase + 5;
                }
                else
                {
                    valortotal = ((Asistentes / 20) * 2) + valorbase;
                }
            }
            if (PersonalAdicional == 2)
            {
                valortotal = valortotal + 2 + personalbase;
            }
            else
            {
                if (PersonalAdicional == 3)
                {
                    valortotal = valortotal + 3 + personalbase;
                }
                else
                {
                    if (PersonalAdicional == 4)
                    {
                        valortotal = valortotal + 3.5 + personalbase;
                    }
                    else
                    {
                        valortotal = ((PersonalAdicional - 4) * 0.5) + 3.5+personalbase;
                    }
                }
            }
            return valortotal;

        }

    }
}
