// <copyright file="InssValidator.cs" company="IBM">
// Copyright (c) Problema IBM C#. All rights reserved.
// </copyright>

namespace INSS.Validators
{
    public class InssValidator : Interfaces.IInssService
    {
        public decimal CalculaInssByYear(string year, decimal salario)
        {
            
            if (year.Equals("2011"))
            {
                if (salario <= 1106.90M)
                {
                    return salario * 0.08M;
                }
                else if (salario >= 1106.90M && salario <= 1844.83M)
                {
                    return salario * 0.09M;
                }
                else if (salario >= 1844.84M && salario <= 3689.66M)
                {
                    return salario * 0.11M;
                }
                else
                {
                    return 405.86M;
                }
            }
            else if (year.Equals("2012"))
            {
                if (salario <= 1000.00M)
                {
                    return salario * 0.07M;
                }
                else if (salario >= 1000.01M && salario <= 1500.00M)
                {
                    return salario * 0.08M;
                }
                else if (salario >= 1500.01M && salario <= 3000.00M)
                {
                    return salario * 0.09M;
                }
                else if (salario >= 3000.01M && salario <= 4000.00M)
                {
                    return salario * 0.11M;
                }
                else
                {
                    return 500.00M;
                }
            }
            else
            {
                return 0;
            }
        }
    }
}
