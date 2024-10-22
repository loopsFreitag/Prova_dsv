using Guilherme_Freitas.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace Guilherme_Freitas.Utils
{
    public class Imposto
    {
        public static double ImpostoIrrf(int SalarioBruto)
        {
            double aliquota = 0.0;

            if (SalarioBruto >= 1903)
            {
                aliquota = 7.5;
            }
            if (SalarioBruto >= 2826)
            {
                aliquota = 15.0;
            }
            if (SalarioBruto >= 3751)
            {
                aliquota = 22.5;
            }
            if (SalarioBruto >= 4664)
            {
                aliquota = 27.5;
            }

            return aliquota;
        }
    }
}
