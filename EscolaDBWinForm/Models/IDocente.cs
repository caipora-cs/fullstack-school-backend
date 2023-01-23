using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EscolaDBWinForm.Models
{
    internal interface IDocente
    {
        //Layer de acesso a dados CRUD
        void Add(Docente docente);
        void Edit(Docente docente);
        void Delete(int id);
        IEnumerable<Docente> GetAll();
        IEnumerable<Docente> GetByValue(string value); //Search por valor
        ICollection<UnidadeCurricular> GetUCs(int id);


    }
}
