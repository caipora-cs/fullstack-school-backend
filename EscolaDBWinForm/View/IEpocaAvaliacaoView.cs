using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EscolaDBWinForm.View
{
    internal interface IEpocaAvaliacaoView
    {
        //Propriedades
        string IdEpocaA { get; set; }
        string DescricaoEpocaA { get; set; }
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
        void SetEpocaAListBindingSource(BindingSource e_epoca);
        void Show(); 


    }
}
