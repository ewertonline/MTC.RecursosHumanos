using MTC.RH.Dominio.Exception;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MTC.RH.Dominio
{
    public class Funcionario
    {
        public static DAL.Entidades.Funcionario Obter(int idFuncionario)
        {
            return DAL.DAO.FuncionarioDAO.ObterPorId(idFuncionario);
        }

        public static void Incluir(DAL.Entidades.Funcionario funcionario, List<int> codigosBeneficios)
        {
            // Validar dados
            ValidarSalvar(funcionario, codigosBeneficios);

            DAL.DAO.FuncionarioDAO.Incluir(funcionario, codigosBeneficios);
        }

        public static void Alterar(DAL.Entidades.Funcionario funcionario, List<int> codigosBeneficios)
        {
            // Validar dados
            ValidarSalvar(funcionario, codigosBeneficios);

            DAL.DAO.FuncionarioDAO.Alterar(funcionario, codigosBeneficios);
        }

        public static void Excluir(int idFuncionario)
        {
            // TODO: Codificar regras para permitir excluir
            
            DAL.DAO.FuncionarioDAO.Excluir(idFuncionario);
        }

        public static List<DAL.Entidades.Funcionario> Listar(string nome)
        {
            // TODO: Colocar os demais parâmetros

            return DAL.DAO.FuncionarioDAO.Listar(nome);
        }

        private static void ValidarSalvar(DAL.Entidades.Funcionario funcionario, List<int> codigosBeneficios)
        {
            if (codigosBeneficios.Count() > 2)
                throw new SalvarFuncionarioException("Permitido no máximo 2 benefícios!");
        }
    }
}
