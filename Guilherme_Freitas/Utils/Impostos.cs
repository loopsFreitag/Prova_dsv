using Guilherme_Freitas.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace Guilherme_Freitas.Utils
{
    public class Imposto
    {
        public static double ImpostoIrrf(double SalarioBruto)
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

            double valor = (SalarioBruto * aliquota) / 100;

            return valor;
        }

        public static double ImpostoInss(double SalarioBruto)
        {
            double aliquota = 8;

            if (SalarioBruto >= 1693.73)
            {
                aliquota = 9;
            }
            if (SalarioBruto >= 2882.9)
            {
                aliquota = 11;
            }
            if (SalarioBruto >= 5645.8)
            {
                return 621.03;
            }

            double valor = (SalarioBruto * aliquota) / 100;

            return valor;
        }

        public static double ImpostoFgts(double SalarioBruto)
        {
            double aliquota = 8;

            double valor = (SalarioBruto * aliquota) / 100;

            return valor;
        }

        
    }
}
