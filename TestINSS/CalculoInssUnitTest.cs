namespace TestINSS
{
    using INSS.Interfaces;
    using Moq;
    using Xunit;

    public class CalculoInssUnitTest
    {
        private readonly Mock<IInssService> inssService;

        public CalculoInssUnitTest()
        {
            this.inssService = new Mock<IInssService>();
        }

        [Fact(DisplayName ="Teste Cáculo INSS")]
        public void Calcular_Aliquota_INSS()
        {
            string ano = "2011";
            decimal salario = 1000.00M;

            inssService.Setup(m => m.CalculaInssByYear(ano, salario));
        }
    }
}
