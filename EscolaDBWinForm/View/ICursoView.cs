using EscolaDBWinForm.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EscolaDBWinForm.View
{
    internal interface ICursoView
    {
        //Propriedades
        int ReferenciaCurso { get; set; }
        string NomeCurso { get; set; }
        string SiglaCurso { get; set; }
        DateTime DataInicioCurso { get; set; }
        //ICollection das UnidadesCurriculares do Curso
        ICollection<UnidadeCurricular> UnidadeCurricularCurso { get;}


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
        event EventHandler SelectEvent;

        //Metodos 
        void SetCursoListBindingSource(BindingSource cursoList);
        void SetUnidadeCurricularListBindingSource(BindingSource ucList);
        void Show(); 
    }
}
