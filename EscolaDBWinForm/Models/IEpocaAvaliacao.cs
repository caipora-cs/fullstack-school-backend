using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EscolaDBWinForm.Models
{
    internal interface IEpocaAvaliacao
    {
        //Layer de acesso a dados CRUD
        void Add(EpocaAvaliacao epoca_a);
        void Edit(EpocaAvaliacao epoca_a);
        void Delete(string id);
        IEnumerable<EpocaAvaliacao> GetAll();
        IEnumerable<EpocaAvaliacao> GetByValue(string value); //Search por valor

    }
}
