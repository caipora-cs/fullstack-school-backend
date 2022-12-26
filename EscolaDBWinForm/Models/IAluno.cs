using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EscolaDBWinForm.Models
{
    public interface IAluno
    {
        //Layer de acesso a dados CRUD
        void Add(Aluno aluno);
        void Edit(Aluno aluno);
        void Delete(int id);
        IEnumerable<Aluno> GetAll();
        IEnumerable<Aluno> GetByValue(string value); //Search por valor

    }
}
