using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using CaixaLibrary.NegocioImpl;
using CaixaLibrary.Enum;
namespace CaixaLibrary.Negocio
{
    [TestClass]
    public class MovimentoNegocioTest
    {
        MovimentoNegocio movimentoNegocio = new MovimentoNegocioImpl();
        [TestMethod]
        public void inserirMovimento()
        {
            movimentoNegocio.inserirMovimento(TipoMovimentoEnum.TipoMovimento.
                ENTRADA.ToString(),
                "ana", "ana DESCRICAO", 10000);
        }

        [TestMethod]
        public void alterarMovimento()
        {
            DateTime data = new DateTime (2013, 12, 31);
            movimentoNegocio.alterarMovimento(15, data, TipoMovimentoEnum.TipoMovimento.ENTRADA.ToString(), "THIAGO",
                "thiago", 1000, true);
        }

    }
}
