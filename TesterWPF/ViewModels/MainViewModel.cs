﻿using TesterWPF.Models;
using Prism.Commands;
using TesterWPF.ViewModels.Base;
using Microsoft.VisualBasic;
using System.Windows.Input;
using System.Windows;
using System;
using TesterWPF.Infrastructure.Commands;

namespace TesterWPF.ViewModels
{
    internal class MainViewModel : ViewModel
    {
        private int amountLearned = 100;
        public int AmounrLeaened { get { return amountLearned; } }

        //#region Commands
        //public ICommand OpenWindowCommand { get; }

        //#region OpenWindowCommand
        //public bool CanOpenWindowCommandExecute(object p) => true;

        //public void OnOpenWindowCommandExecuted(object p)
        //{
        //    Application.Current.Shutdown();
        //}
        //#endregion

        //#endregion
        public MainViewModel()
        {
            //#region Команды
            //OpenWindowCommand = new RelayCommand(OnOpenWindowCommandExecuted, CanOpenWindowCommandExecute);
            //#endregion

        }



    }
}
