using System;

namespace Practica1
{
    public class VerificarTeoremaDesigualdadTrianguloService
    {
        public bool Verificar(
            int ladoA,
            int ladoB,
            int ladoC)
        {
            return 
                (ladoA + ladoB > ladoC) &&
                (ladoA + ladoC > ladoB) &&
                (ladoB + ladoC > ladoA);
        }
    }
}
