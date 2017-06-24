using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using MTC.RH.Dominio;
using System.Collections.Generic;
using MTC.RH.Dominio.Exception;

namespace MTC.RH.Test.Dominio
{
    [TestClass]
    public class FuncionarioTest
    {
        [TestMethod]
        public void TestIncluirFuncionarioDominio()
        {
            MTC.RH.DAL.Entidades.Funcionario funcionario = new RH.DAL.Entidades.Funcionario();
            funcionario.Nome = "Ewerton Cerqueira Rodrigues 3";

            Funcionario.Incluir(funcionario, new List<int>() { 1, 2 });
        }

        [TestMethod]
        [ExpectedException(typeof(SalvarFuncionarioException), "Permitido no máximo 2 benefícios!")]
        public void TestIncluirFuncionarioDominioMaisDeDoisBeneficio()
        {
            MTC.RH.DAL.Entidades.Funcionario funcionario = new RH.DAL.Entidades.Funcionario();
            funcionario.Nome = "Ewerton Cerqueira Rodrigues 3";

            Funcionario.Incluir(funcionario, new List<int>() { 1, 2, 3 });
        }

        [TestMethod]
        public void TestAlterarFuncionarioDominio()
        {
            MTC.RH.DAL.Entidades.Funcionario funcionario = Funcionario.Obter(2);
            funcionario.Nome = "Ewerton Cerqueira Rodrigues 3";

            Funcionario.Alterar(funcionario, new List<int>() { 1 });
        }
    }
}
