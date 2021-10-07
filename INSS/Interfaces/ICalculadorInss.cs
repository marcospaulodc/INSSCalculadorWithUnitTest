// <copyright file="ICalculadorInss.cs" company="IBM">
// Copyright (c) Problema IBM C#. All rights reserved.
// </copyright>

namespace INSS.Interfaces
{
	using System;

	public interface ICalculadorInss
	{
		decimal CalcularDesconto(DateTime data, decimal salario);
    }
}