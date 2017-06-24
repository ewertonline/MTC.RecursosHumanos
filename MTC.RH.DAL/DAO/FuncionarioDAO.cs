using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MTC.RH.DAL.Entidades;

namespace MTC.RH.DAL.DAO
{
    public class FuncionarioDAO
    {
        public static void Incluir(Funcionario funcionario, List<int> codigosBeneficios)
        {
            using (var contexto = new BDRecursosHumanos())
            {
                var novosBeneficios = contexto.Beneficios.Where(r => codigosBeneficios.Contains(r.Id)).ToList();
                funcionario.Beneficios = new List<Beneficio>();

                foreach (var beneficio in novosBeneficios)
                    funcionario.Beneficios.Add(beneficio);
                
                contexto.Funcionarios.Add(funcionario);
                contexto.SaveChanges();
            }
        }
        
        public static void Alterar(Funcionario funcionario, List<int> codigosBeneficios)
        {
            using (var contexto = new BDRecursosHumanos())
            {
                var funcionarioOriginal = contexto.Funcionarios.FirstOrDefault(t => t.Id == funcionario.Id);

                var novosBeneficios = contexto.Beneficios.Where(r => codigosBeneficios.Contains(r.Id)).ToList();

                if (funcionarioOriginal.Beneficios != null)
                    funcionarioOriginal.Beneficios.Clear();
                else
                    funcionarioOriginal.Beneficios = new List<Beneficio>();

                foreach (var beneficio in novosBeneficios)
                    funcionarioOriginal.Beneficios.Add(beneficio);

                contexto.Entry<Funcionario>(funcionarioOriginal).CurrentValues.SetValues(funcionario);

                contexto.SaveChanges();
            }
        }

        public static void Excluir(int idFuncionario)
        {
            using (var contexto = new BDRecursosHumanos())
            {
                var funcionario = contexto.Funcionarios.FirstOrDefault(t => t.Id == idFuncionario);

                if (funcionario == null)
                    return;

                contexto.Funcionarios.Remove(funcionario);
                contexto.SaveChanges();
            }
        }

        public static List<Funcionario> Listar(string nome)
        {
            List<Funcionario> lista = null;

            using (var contexto = new BDRecursosHumanos())
            {
                lista = contexto.Funcionarios.Where(t=>t.Nome.Contains(nome)).ToList();
            }

            return lista;
        }

        public static Funcionario ObterPorId(int idFuncionario)
        {
            Funcionario funcionario = null;

            using (var contexto = new BDRecursosHumanos())
            {
                funcionario = contexto.Funcionarios.FirstOrDefault(t => t.Id == idFuncionario);
            }

            return funcionario;
        }

        public static void ObterPorId(int idFuncionario, ref Funcionario funcionario)
        {
            using (var contexto = new BDRecursosHumanos())
            {
                funcionario = contexto.Funcionarios.FirstOrDefault(t => t.Id == idFuncionario);
            }
        }
    }
}
