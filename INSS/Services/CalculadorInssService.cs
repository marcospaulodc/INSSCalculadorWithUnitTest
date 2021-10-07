// <copyright file="CalculadorInssService.cs" company="IBM">
// Copyright (c) Problema IBM C#. All rights reserved.
// </copyright>

namespace INSS.Services
{
    using INSS.Interfaces;
    using System;

    public class CalculadorInssService : ICalculadorInss
    {
        private readonly IInssService inssRepository;

        public CalculadorInssService(IInssService inssRepository)
        {
            this.inssRepository = inssRepository;
        }

        public decimal CalcularDesconto(DateTime data, decimal salario)
        {
            string year = data.Year.ToString();
            decimal aliquotInss = inssRepository.CalculaInssByYear(year, salario);

            return decimal.Round(aliquotInss, 2);
        }
    }
}
