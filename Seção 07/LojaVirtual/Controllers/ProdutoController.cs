﻿using LojaVirtual.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LojaVirtual.Controllers
{
    public class ProdutoController : Controller
    {
        /*
         - ActionResult ou IActionResult
         */
        public ActionResult Visualizar()
        {
            Produto produto = GetProduto();


            return View(produto);
            //return new ContentResult {Content = "<h3>Produto -> Visualizar</h3>", ContentType = "Text/html"};
        }

        private Produto GetProduto()
        {
            return new Produto()
            {
                Id = 1,
                Nome = "Xbox One x",
                Descricao = "Jogue em 4k",
                Valor = 2000.00M
            };
        }
    }
}
