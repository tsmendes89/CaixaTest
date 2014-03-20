using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using CaixaLibrary.DAOImpl;
namespace CaixaLibrary.DAOImpl
{
    [TestClass]
    public class ConexaoTest
    {
        [TestMethod]
        public void obterConexao()
        {
            Assert.IsNotNull(Conexao.obterConexao());
        }

        [TestMethod]
        public void fecharConexao()
        {
            Conexao.obterConexao();
            Assert.IsTrue(Conexao.fecharConexao());            
        }
    }
}
