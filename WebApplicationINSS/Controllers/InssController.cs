// <copyright file="INSSController.cs" company="IBM">
// Copyright (c) Problema IBM C#. All rights reserved.
// </copyright>

namespace WebApplication.Controllers
{
    using Microsoft.AspNetCore.Mvc;
    using INSS.Interfaces;
    using System;

    [Route("[controller]")]
    [ApiController]
    public class INSSController : Controller
    {
        private readonly ICalculadorInss calculadorInss;

        public INSSController(ICalculadorInss calculadorInss)
        {
            this.calculadorInss = calculadorInss;
        }

        [HttpGet]
        [ProducesResponseType(200)]
        [ProducesResponseType(400)]
        public ActionResult Get([FromHeader] DateTime data, [FromHeader] decimal salario)
        {
            decimal result = calculadorInss.CalcularDesconto(data, salario);
            return Ok(result);
        }
    }
}
