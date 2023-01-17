using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EscolaDBWinForm.View
{
    internal interface IInscricaoView
    {
        //Propriedades
        int NumeroAlunoInscricao { get; set; }
        int IdUCInscricao { get; set; }
        short IdAnoInscricao { get; set; }
        string IdEpocaAInscricao { get; set; }
        short IdEEpocaInscricao { get; set; }
        string PresencaInscricao { get; set; }
        short NotaInscricao { get; set; }
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
        void SetInscricaoListBindingSource(BindingSource inscricao);
        void Show(); 

    }
}
