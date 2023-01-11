﻿using System;
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
    }
}
