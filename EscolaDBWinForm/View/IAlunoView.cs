﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EscolaDBWinForm.View
{
    public interface IAlunoView
    {
        //Propriedades - Fields
        int NumeroAluno { get; set; } //Sem set method, tornar autoincremental
        string NomeAluno { get; set; }
        string ApelidoAluno { get; set; }
        DateTime IdadeAluno { get; set; }
        string MoradaAluno { get; set; }
        string EmailAluno { get; set; }
        string TelefoneAluno { get; set; }
        int CursoAluno { get; set; }
        byte[]? FotoAluno { get; set; }

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
        event EventHandler UploadEvent;

        //Metodos 
        void SetAlunoListBindingSource(BindingSource alunoList);
        void SetAlunoImage(Image image);
        void Show(); 
        
    }
}
