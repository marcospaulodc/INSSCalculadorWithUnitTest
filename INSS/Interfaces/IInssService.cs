// <copyright file="IInssRepository.cs" company="IBM">
// Copyright (c) Problema IBM C#. All rights reserved.
// </copyright>

namespace INSS.Interfaces
{
    public interface IInssService
    {
        decimal CalculaInssByYear(string year, decimal salario);
    }
}
