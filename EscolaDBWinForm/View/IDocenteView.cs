using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EscolaDBWinForm.Models;

namespace EscolaDBWinForm.View
{
    internal interface IDocenteView
    {
        //Propriedades
        int NumeroDocente { get; set; }
        string NomeDocente { get; set; }
        string ApelidoDocente { get; set; }
        DateTime? DataNascimentoDocente { get; set; }
        string? EmailDocente { get; set; }
        string? TelefoneDocente { get; set; }
        string? ExtensaoDocente { get; set; }
        decimal SalarioDocente { get; set; }
        ICollection<UnidadeCurricular> UnidadeCurricularDocente { get; }

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
        void SetDocenteListBindingSource(BindingSource docenteList);
        void SetUnidadeCurricularListBindingSource(BindingSource ucList);
        void Show(); 

    }
}
