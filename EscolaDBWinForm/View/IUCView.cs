using EscolaDBWinForm.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EscolaDBWinForm.View
{
    internal interface IUCView
    {
        //Propriedades
        int IdUC { get; set; }
        int ReferenciaCursoUC { get; set; }
        int NumeroDocenteUC { get; set; }
        string NomeUC { get; set; }
        string SiglaUC { get; set; }
        decimal CreditosUC { get; set; }
        string AnoUC { get; set; }
        string SemestreUC { get; set; }
        
        // TODO: Props de Navigations 
        //Docente DocenteUC { get; set; }
        //Curso CursoUC { get; set; }

        //ICollection dos Alunos da UC (Inscricoes)
        ICollection<Inscricao> UnidadeCurricularCurso { get;}


        //State
        string SearchValue { get; set; }
        bool IsEdit { get; set; }
        bool IsSuccessful { get; set; }
        string Message { get; set; }

        //Events - Acoes do Utilizador
        event EventHandler SearchEvent;
        event EventHandler AddNewEvent;
        event EventHandler EditEvent;
        event EventHandler DeleteEvent;
        event EventHandler SaveEvent;
        event EventHandler CancelEvent;

        //Metodos 
        void SetUCListBindingSource(BindingSource ucList);
        void Show(); 
    }
}
