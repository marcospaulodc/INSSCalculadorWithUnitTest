namespace TestINSS
{
    using INSS.Interfaces;
    using Moq;
    using System;
    using Xunit;

    public class CalculoInssUnitTest
    {
        //private readonly Mock<IInssService> inssService;

        public CalculoInssUnitTest()
        {
            //this.inssService = new Mock<IInssService>();
        }

        [Fact(DisplayName ="Teste Cáculo INSS")]
        public void Calcular_Salario_Ano_RetornaAliquotaINSS()
        {
            string ano = "2011";
            decimal salario = 4000.00M;
            decimal valorEsperado = 405.86M;

            var inssService = new INSS.Validators.InssValidator();
            decimal result = inssService.CalculaInssByYear(ano, salario);

            Assert.Equal(valorEsperado, result, 2);
        }
    }
}
