using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EscolaDBWinForm.View
{
    internal interface IMainView
    {
        event EventHandler ShowAlunosView;//Adicionar pictureBox para as Imagens dos alunos
        event EventHandler ShowCursosView;
        //event EventHandler ShowUnidadeCurricularView; //2 gridviews, 1 seleciona UC, 1 mostra os alunos inscritos na UC selecionada. Filtrar UC por Curso.
        //event EventHandler ShowDocentesView;
        //event EventHandler ShowInscricoesView;
        //Dependencias da Inscricao
        //event EventHandler ShowAnoLetivoView;
        //event EventHandler ShowEpocaAvaliacaoView;
        //event EventHandler ShowEstadoEpocaView;
    }
}
