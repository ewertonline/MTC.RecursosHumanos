using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MTC.RH.DAL.Entidades
{
    public class Beneficio
    {
        [Key]
        public int Id { get; set; }
        public string Nome { get; set; }

        public virtual ICollection<Funcionario> Funcionarios { get; set; }
    }
}
