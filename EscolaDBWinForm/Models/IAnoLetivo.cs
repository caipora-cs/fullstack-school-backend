using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EscolaDBWinForm.Models
{
    internal interface IAnoLetivo
    {
        void Add(AnoLetivo ano);
        void Edit(AnoLetivo ano);
        void Delete(int id);
        IEnumerable<AnoLetivo> GetAll();
        IEnumerable<AnoLetivo> GetByValue(string value); //Search por valor
        ICollection<Inscricao> GetInscricao(int id); //Busca todas as Inscricoes de um Ano para apresentar na gridview

    }
}
