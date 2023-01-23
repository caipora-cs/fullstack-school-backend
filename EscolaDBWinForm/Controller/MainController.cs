using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EscolaDBWinForm.View;
using EscolaDBWinForm.Models;
using EscolaDBWinForm.Data;

namespace EscolaDBWinForm.Controller
{
    internal class MainController
    {
        private IMainView mainView;
        private EscolaDbContext _context;

        public MainController(IMainView mainView)
        {
            this.mainView = mainView;
            this.mainView.ShowAlunosView += ShowAlunoView;
            this.mainView.ShowCursosView += ShowCursoView;
            this.mainView.ShowUnidadeCurricularView += ShowUnidadeCurricularView;
            this.mainView.ShowDocentesView += ShowDocenteView;
            this.mainView.ShowInscricoesView += ShowInscricaoView;
            this.mainView.ShowAnoLetivoView += ShowAnoLetivoView;
            this.mainView.ShowEpocaAvaliacaoView += ShowEpocaAvaliacaoView;
            this.mainView.ShowEstadoEpocaView += ShowEstadoEpocaView;
            this.mainView.AcercaView += ShowAcercaView;
            this.mainView.SairView += SairView;
        }

        private void SairView(object? sender, EventArgs e)
        {
            //Fechar programa quando clicar no botão Sair da MainView 
            Environment.Exit(0);

        }

        private void ShowAcercaView(object? sender, EventArgs e)
        {
            //Mostrar a View Acerca com o metodo GetInstance da classe AcercaView 
            AcercaView.GetInstance((MainView)mainView).Show();
        }

        private void ShowEstadoEpocaView(object? sender, EventArgs e)
        {
            IEstadoEpocaView view = EstadoEpocaView.GetInstance((MainView)mainView);
            IEstadoEpoca model = new EstadoEpocaDbLogic();
            new EstadoEpocaController(view, model);
        }

        private void ShowEpocaAvaliacaoView(object? sender, EventArgs e)
        {
            IEpocaAvaliacaoView view = EpocaAvaliacaoView.GetInstance((MainView)mainView);
            IEpocaAvaliacao model = new EpocaAvaliacaoDbLogic();
            new EpocaAvaliacaoController(view, model);
        }

        private void ShowAnoLetivoView(object? sender, EventArgs e)
        {
            IAnoLetivoView view = AnoLetivoView.GetInstance((MainView)mainView);
            IAnoLetivo model = new AnoLetivoDbLogic();
            new AnoLetivoController(view, model);
        }

        private void ShowInscricaoView(object? sender, EventArgs e)
        {
            IInscricaoView view = InscricaoView.GetInstance((MainView)mainView);
            IInscricao model = new InscricaoDbLogic();
            new InscricaoController(view, model);
        }

        private void ShowDocenteView(object? sender, EventArgs e)
        {
            IDocenteView view = DocenteView.GetInstance((MainView)mainView);
            IDocente model = new DocenteDbLogic();
            new DocenteController(view, model);
        }

        private void ShowCursoView(object? sender, EventArgs e)
        {
            ICursoView view = CursoView.GetInstance((MainView)mainView);
            ICurso model = new CursoDbLogic();
            new CursoController(view, model);
        }

        private void ShowAlunoView(object? sender, EventArgs e)
        {
            IAlunoView view = AlunoView.GetInstance((MainView)mainView);
            IAluno model = new AlunoDbLogic();
            new AlunoController(view, model);
;
        }

        private void ShowUnidadeCurricularView(object? sender, EventArgs e)
        {
            IUCView view = UCView.GetInstance((MainView)mainView);
            IUnidadeCurricular model = new UCDbLogic();
            new UCController(view, model);
        }
    }
}
