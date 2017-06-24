using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MTC.RH.DAL.Entidades
{
    public class Funcionario
    {
        [Key]
        public int Id { get; set; }
        public string Nome { get; set; }

        public virtual ICollection<Beneficio> Beneficios { get; set; }

        public virtual void Salvar(List<int> IdsBeneficio)
        {
            if (this.Id == 0)
                MTC.RH.DAL.DAO.FuncionarioDAO.Incluir(this, IdsBeneficio);
            else
                MTC.RH.DAL.DAO.FuncionarioDAO.Alterar(this, IdsBeneficio);
        }
    }
}
