using BrownianMotionAPP.Models;
using BrownianMotionAPP.Views;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace BrownianMotionAPP.ViewModels
{
    public class MainViewModel : INotifyPropertyChanged
    {
        public double InitialPrice { get; set; }
        public double Volatility { get; set; }
        public double MeanReturn { get; set; }
        public double Time { get; set; }

        private IDrawable _chartDrawable;
        public IDrawable ChartDrawable
        {
            get => _chartDrawable;
            set
            {
                _chartDrawable = value;
                OnPropertyChanged(nameof(ChartDrawable));
            }
        }

        public ICommand GenerateCommand => new Command(() =>
        {
            var data = BrownianMotionModel.GenerateBrownianMotion(InitialPrice, Volatility, MeanReturn, Time);
            ChartDrawable = new ChartDrawable(data);
        });

        public event PropertyChangedEventHandler PropertyChanged;
        protected void OnPropertyChanged(string propertyName) =>
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
    }

}
