﻿namespace Corale.Colore.Tester.ViewModels
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel;
    using System.Linq;
    using System.Text;
    using System.Windows.Input;
    using System.Windows.Media;
    using Corale.Colore.Razer.Keypad.Effects;
    using Corale.Colore.Razer.Mouse;
    using Corale.Colore.Tester.Classes;
    using Key = Corale.Colore.Razer.Keyboard.Key;

    public class KeypadViewModel : INotifyPropertyChanged
    {
        private Key _selectedKey;
        private Duration _selectedReactiveDuration;
        private Direction _selectedWaveDirection;
        public KeypadViewModel()
        {
            this.SelectedKey = Key.A;
            this.SelectedReactiveDuration = Duration.Long;
            this.SelectedWaveDirection = Direction.LeftToRight;
            ColorOne.Color = Core.Color.Red;
            ColorTwo.Color = Core.Color.Blue;
        }

        public int Col { get; set; }

        public int Row { get; set; }

        public SolidColorBrush ColorOne { get; set; } = new SolidColorBrush();

        public SolidColorBrush ColorTwo { get; set; } = new SolidColorBrush();

        public event PropertyChangedEventHandler PropertyChanged;

        public Led Keys { get; set; }

        public Key SelectedKey
        {
            get
            {
                return this._selectedKey;
            }

            set
            {
                this._selectedKey = value;
                this.OnPropertyChanged(nameof(this.SelectedKey));
            }
        }

        public Duration SelectedReactiveDuration
        {
            get
            {
                return this._selectedReactiveDuration;
            }

            set
            {
                this._selectedReactiveDuration = value;
                this.OnPropertyChanged(nameof(this.SelectedReactiveDuration));
            }
        }

        public Direction SelectedWaveDirection
        {
            get
            {
                return _selectedWaveDirection;
            }

            set
            {
                _selectedWaveDirection = value;
                this.OnPropertyChanged(nameof(SelectedWaveDirection));
            }
        }

        public ICommand AllCommand => new DelegateCommand(() => Core.Keypad.Instance.SetAll(ColorOne.Color));

        public ICommand BreathingCommand => new DelegateCommand(() => Core.Keypad.Instance.SetBreathing(ColorOne.Color, ColorTwo.Color));

        public ICommand ReactiveCommand => new DelegateCommand(() => Core.Keypad.Instance.SetReactive(this.SelectedReactiveDuration, ColorOne.Color));

        public ICommand WaveCommand => new DelegateCommand(() => Core.Keypad.Instance.SetWave(this.SelectedWaveDirection));

        public ICommand StaticCommand => new DelegateCommand(() => Core.Keypad.Instance.SetStatic(new Static(ColorOne.Color)));

        public ICommand IndexerCommand
            => new DelegateCommand(() => Core.Keypad.Instance[this.Row, this.Col] = ColorOne.Color);

        public IEnumerable<Direction> WaveDirectionValues => Enum.GetValues(typeof(Direction)).Cast<Direction>();

        public IEnumerable<Duration> ReactiveDurationValues => Enum.GetValues(typeof(Duration)).Cast<Duration>();

        [Annotations.NotifyPropertyChangedInvocator]
        protected virtual void OnPropertyChanged(string propertyName)
        {
            this.PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}