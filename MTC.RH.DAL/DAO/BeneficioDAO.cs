using MTC.RH.DAL.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MTC.RH.DAL.DAO
{
    public class BeneficioDAO
    {
        public static void Incluir(Beneficio beneficio)
        {
            using (var contexto = new BDRecursosHumanos())
            {
                contexto.Beneficios.Add(beneficio);
                contexto.SaveChanges();
            }
        }
        
        public static void Alterar(Beneficio beneficio)
        {
            using (var contexto = new BDRecursosHumanos())
            {
                var beneficioOriginal = contexto.Beneficios.FirstOrDefault(t => t.Id == beneficio.Id);

                contexto.Entry<Beneficio>(beneficioOriginal).CurrentValues.SetValues(beneficio);

                contexto.SaveChanges();
            }
        }

        public static void Excluir(int idBeneficio)
        {
            using (var contexto = new BDRecursosHumanos())
            {
                var beneficio = contexto.Beneficios.FirstOrDefault(t => t.Id == idBeneficio);

                if (beneficio == null)
                    return;

                contexto.Beneficios.Remove(beneficio);
                contexto.SaveChanges();
            }
        }

        public static Beneficio ObterPorId(int idBeneficio)
        {
            Beneficio beneficio = null;

            using (var contexto = new BDRecursosHumanos())
            {
                beneficio = contexto.Beneficios.FirstOrDefault(t => t.Id == idBeneficio);
            }

            return beneficio;
        }
    }
}
