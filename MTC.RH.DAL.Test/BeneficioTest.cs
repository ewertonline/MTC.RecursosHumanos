using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using MTC.RH.DAL.Entidades;

namespace MTC.RH.DAL.Test
{
    [TestClass]
    public class BeneficioTest
    {
        [TestMethod]
        public void TestIncluirBeneficio()
        {
            Beneficio beneficio = new Beneficio();
            beneficio.Nome = "Plano de Saúde";

            MTC.RH.DAL.DAO.BeneficioDAO.Incluir(beneficio);
        }

        /*[TestMethod]
        public void TestObterPorId()
        {
            var funcionario = MTC.RH.DAL.DAO.FuncionarioDAO.ObterPorId(1);
            Assert.AreNotEqual(null, funcionario);
            Assert.AreEqual(1, funcionario.Id);
        }

        [TestMethod]
        public void TestAlterar()
        {
            var funcionario = MTC.RH.DAL.DAO.FuncionarioDAO.ObterPorId(1);
            funcionario.Nome = "João";
            MTC.RH.DAL.DAO.FuncionarioDAO.Alterar(funcionario);

            var funcionarioAlterado = MTC.RH.DAL.DAO.FuncionarioDAO.ObterPorId(1);
            Assert.AreEqual(funcionario.Nome, funcionarioAlterado.Nome);
        }

        [TestMethod]
        public void TestExcluir()
        {
            MTC.RH.DAL.DAO.FuncionarioDAO.Excluir(1);
        }*/
    }
}
