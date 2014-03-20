using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using CaixaLibrary.Enum;
using CaixaLibrary.DAO;
using CaixaLibrary.DAOImpl;
using CaixaLibrary.Model;

namespace CaixaLibrary.DAO
{
        [TestClass]
        public class MovimentoDAOTest
        {
            MovimentoDAO movimentoDAO = new MovimentoDAOImpl();
            [TestMethod]
            public void inserirMovimento()
            {
                
                DateTime data = DateTime.Now;
                String tipoMovimento = TipoMovimentoEnum.TipoMovimento
                    .ENTRADA.ToString();
                String referencia = "TESTE2";
                String descricao = "TESTE";
                Double valor = 200.80;

                Movimento movimento = new Movimento();
                movimento.DataInclusao = data;
                movimento.TipoMovimento = tipoMovimento;
                movimento.Referencia = referencia;
                movimento.Descricao = descricao;
                movimento.Valor = valor;

                movimentoDAO.inserirMovimento(movimento);

            }

            [TestMethod]
            public void alterarMovimento()
            {

                DateTime data = DateTime.Now;
                String tipoMovimento = TipoMovimentoEnum.TipoMovimento
                    .ENTRADA.ToString();
                String referencia = "TESTE";
                String descricao = "ALTERADO4";
                Double valor = 300.80;

                Movimento movimento = new Movimento();
                movimento.DataInclusao = data;
                movimento.TipoMovimento = tipoMovimento;
                movimento.Referencia = referencia;
                movimento.Descricao = descricao;
                movimento.Valor = valor;
                movimento.Id = 6;
                movimento.IncluidoCaixa = true;

                movimentoDAO.alterarMovimento(movimento);

            }

            [TestMethod]
            public void excluirMovimento()
            {

                movimentoDAO.excluirMovimentoPorId(5);

            }

            [TestMethod]
            public void listarMovimentosDoDia()
            {

                DateTime dataInclusao = new DateTime(2013, 12, 24);
                movimentoDAO.listarMovimentosDoDia(dataInclusao);

            }


            [TestMethod]
            public void obterMovimentoPorId()
            {
                movimentoDAO.obterMovimentoPorId(6);
            }
        }  
}
