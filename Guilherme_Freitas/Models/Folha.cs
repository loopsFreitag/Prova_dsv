namespace Guilherme_Freitas.Models
{
    public class Folha
    {
        public int Id { get; set; }
        public double Valor { get; set; } = 0;
        public double Quantidade { get; set; } = 0;
        public int Mes { get; set; } = 0;
        public int Ano { get; set; } = 0;

        public double SalarioBruto { get; set; } = 0;
        public double ImpostoIrrf { get; set; } = 0;
        public double ImpostoInss { get; set; } = 0;
        public double ImpostoFgts { get; set; } = 0;
        public double SalarioLiquido { get; set; } = 0;    

        public int FuncionarioId { get; set; }

    }
}