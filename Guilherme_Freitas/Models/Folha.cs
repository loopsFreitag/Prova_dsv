namespace Guilherme_Freitas.Models
{
    public class Folha
    {
        public int Id { get; set; }
        public int Valor { get; set; } = 0;
        public int Quantidade { get; set; } = 0;
        public int Mes { get; set; } = 0;
        public int Ano { get; set; } = 0;

        public int SalarioBruto { get; set; } = 0;
        public int ImpostoIrrf { get; set; } = 0;
        public int ImpostoInss { get; set; } = 0;
        public int ImpostoFgts { get; set; } = 0;
        public int SalarioLiquido { get; set; } = 0;    
        
        public int FuncionarioId { get; set; }

    }
}