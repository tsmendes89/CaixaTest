using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using CaixaLibrary.Model;
using CaixaLibrary.DAOImpl;

namespace CaixaLibrary.DAO
{
    [TestClass]
    public class CaixaDAOTest
    {
        CaixaDAO caixaDAO = new CaixaDAOImpl();
        [TestMethod]
        public void abrirCaixa()
        {
            Caixa caixa = new Caixa();
            caixa.Data = new DateTime(2013, 12, 28);
            caixa.SaldoAtual = 8000.0;
            caixa.SaldoAnterior = 200.0;
            caixaDAO.abrirCaixa(caixa);

        }

        [TestMethod]
        public void existeCaixaNestaData()
        {
            DateTime data = new DateTime(2013, 12, 28);
            Assert.IsTrue(caixaDAO.existeCaixaNestaData(data));
        }

        [TestMethod]
        public void saldoAtual()
        {
            DateTime data = new DateTime(2013, 12, 28);
            Assert.AreEqual(200, caixaDAO.saldoAtual(data));
        }

        [TestMethod]
        public void saldoDia()
        {
            DateTime data = new DateTime(2013, 12, 28);
            Assert.AreEqual(500, caixaDAO.saldoDia(data));
        }

        [TestMethod]
        public void caixaAberto()
        {
            DateTime data = new DateTime(2013, 12, 28);
            Assert.IsTrue(caixaDAO.caixaAberto(data));
        }

        [TestMethod]
        public void caixaFechado()
        {
            DateTime data = new DateTime(2013, 12, 28);
            Assert.IsFalse(caixaDAO.caixaFechado(data));
        }

        [TestMethod]
        public void alterarCaixa()
        {
            Caixa caixa = new Caixa();
            DateTime data = new DateTime(2013, 12, 28);
            caixa.Data = data;
            caixa.Id = 3;
            caixa.Encerrado = false;
            caixa.SaldoAtual = 1600;
            caixa.SaldoDia = 1600;
            caixaDAO.alterarCaixa(caixa);
        }

        [TestMethod]
        public void obterCaixaDoDia()
        {
            Caixa caixa = new Caixa();
            DateTime data = new DateTime(2013, 12, 28);
            caixaDAO.obterCaixaDoDia(data);
        }

        [TestMethod]
        public void obterUltimoCaixa()
        {
            Caixa caixa = caixaDAO.obterUltimoCaixa();
        }

        [TestMethod]
        public void obterUltimoCaixaAnteriorData()
        {
            DateTime data = new DateTime(2013, 12, 31);
            caixaDAO.obterUltimoCaixaAnteriorData(data);
        }

    }
}
