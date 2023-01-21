using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EscolaDBWinForm.Models
{
    internal interface IEstadoEpoca
    {
        //Layer de acesso a dados CRUD
        void Add(EstadoEpoca e_epoca);
        void Edit(EstadoEpoca e_espoca);
        void Delete(short id);
        IEnumerable<EstadoEpoca> GetAll();
        IEnumerable<EstadoEpoca> GetByValue(string value); //Search por valor
        ICollection<Inscricao> GetInscricao(int id); //Busca todas as Inscricoes de uma Epoca para apresentar na gridview

    }
}
