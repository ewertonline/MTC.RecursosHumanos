using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using MTC.RH.DAL.Entidades;

namespace MTC.RH.Test.DAL
{
    [TestClass]
    public class BeneficioTest
    {
        [TestMethod]
        public void TestIncluirBeneficioDAO()
        {
            Beneficio beneficio = new Beneficio();
            beneficio.Nome = "Plano de Saúde";

            MTC.RH.DAL.DAO.BeneficioDAO.Incluir(beneficio);
        }
    }
}