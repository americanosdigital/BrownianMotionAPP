using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;
using System.Windows.Input;
using BrownianMotionAPP.Models;
using BrownianMotionAPP.Views;

namespace BrownianMotionAPP.ViewModels
{
    public class MainViewModel : INotifyPropertyChanged
    {
        private double _initialPrice;
        private double _volatility = 0.0;
        private double _meanReturn;
        private int _timeInDays;
        private ChartDrawable _chartDrawable;
        private float _scaleX = 1f; // Zoom horizontal
        private float _scaleY = 1f; // Zoom vertical

        public double InitialPrice
        {
            get => _initialPrice;
            set
            {
                _initialPrice = value;
                OnPropertyChanged(nameof(InitialPrice));
            }
        }

        public double Volatility
        {
            get => _volatility;
            set
            {
                if (_volatility != value)
                {
                    _volatility = value;
                    OnPropertyChanged(nameof(Volatility));
                }
            }
        }

        public double MeanReturn
        {
            get => _meanReturn;
            set
            {
                _meanReturn = value;
                OnPropertyChanged(nameof(MeanReturn));
            }
        }

        public int TimeInDays
        {
            get => _timeInDays;
            set
            {
                _timeInDays = value;
                OnPropertyChanged(nameof(TimeInDays));
            }
        }

        public IDrawable ChartDrawable
        {
            get => _chartDrawable;
            private set
            {
                _chartDrawable = (ChartDrawable)value;
                OnPropertyChanged(nameof(ChartDrawable));
            }
        }

        public ICommand GenerateCommand => new Command(() =>
        {
            double timeInYears = TimeInDays / 365.0;

            var data = BrownianMotionModel.GenerateBrownianMotion(InitialPrice, Volatility, MeanReturn, timeInYears);

            _chartDrawable = new ChartDrawable(data);
            _chartDrawable.SetZoom(_scaleX, _scaleY); // Aplicar zoom inicial
            OnPropertyChanged(nameof(ChartDrawable));
        });

        public ICommand ZoomInCommand => new Command(() =>
        {
            _scaleX += 0.2f;
            _scaleY += 0.2f;
            ApplyZoom();
        });

        public ICommand ZoomOutCommand => new Command(() =>
        {
            _scaleX -= 0.2f;
            _scaleY -= 0.2f;
            ApplyZoom();
        });

        public void Zoom(float scale)
        {
            _scaleX *= scale;
            _scaleY *= scale;
            ApplyZoom();
        }

        private void ApplyZoom()
        {
            if (_chartDrawable != null)
            {
                _chartDrawable.SetZoom(_scaleX, _scaleY);
                OnPropertyChanged(nameof(ChartDrawable));
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;
        protected void OnPropertyChanged(string propertyName) =>
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
    }

}