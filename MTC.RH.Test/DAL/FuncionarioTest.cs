using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using MTC.RH.DAL.Entidades;
using System.Collections.Generic;

namespace MTC.RH.Test.DAL
{
    [TestClass]
    public class FuncionarioTest
    {
        [TestMethod]
        public void TestIncluirFuncionarioDAO()
        {
            Funcionario funcionario = new Funcionario();
            funcionario.Nome = "Ewerton Cerqueira Rodrigues 3";

            MTC.RH.DAL.DAO.FuncionarioDAO.Incluir(funcionario, new List<int>() { 1, 2 });
        }

        [TestMethod]
        public void TestAlterarFuncionarioDAO()
        {
            var funcionario = MTC.RH.DAL.DAO.FuncionarioDAO.ObterPorId(2);
            funcionario.Nome = "João 2";
            MTC.RH.DAL.DAO.FuncionarioDAO.Alterar(funcionario, new List<int>() { 1, 2 });

            var funcionarioAlterado = MTC.RH.DAL.DAO.FuncionarioDAO.ObterPorId(2);
            Assert.AreEqual(funcionario.Nome, funcionarioAlterado.Nome);
        }

        [TestMethod]
        public void TestObterFuncionarioDAOPorId()
        {
            var funcionario = MTC.RH.DAL.DAO.FuncionarioDAO.ObterPorId(1);
            Assert.AreNotEqual(null, funcionario);
            Assert.AreEqual(1, funcionario.Id);
        }

        [TestMethod]
        public void TestExcluirFuncionarioDAO()
        {
            MTC.RH.DAL.DAO.FuncionarioDAO.Excluir(1);
        }
    }
}
