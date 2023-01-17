using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EscolaDBWinForm.Models;

namespace EscolaDBWinForm.View
{
    internal interface IAnoLetivoView
    {
        //Propriedades
        short IdAno { get; set; }
        short AnoLetivoInicial { get; set; }
        short AnoLetivoFinal { get; set; }
        ICollection<Inscricao> InscricaosAnoLetivo { get; }
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
        void SetAnoLetivoListBindingSource(BindingSource ano);
        void SetInscricaoListBindingSource(BindingSource inscricaoList);
        void Show(); 


    }
}
