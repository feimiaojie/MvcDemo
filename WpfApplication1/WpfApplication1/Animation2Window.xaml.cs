﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Animation;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace WpfApplication1
{
    /// <summary>
    /// Interaction logic for Animation2Window.xaml
    /// </summary>
    public partial class Animation2Window : Window
    {
        public Animation2Window()
        {
            InitializeComponent();
        }

        private void SliderSpeed_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
            fadeStoryboard.SetSpeedRatio(this, sliderSpeed.Value);
        }

        private void FadeStoryboard_CurrentTimeInvalidated(object sender, EventArgs e)
        {
            Clock storyboardClock = (Clock)sender;

            if (storyboardClock.CurrentProgress == null)
            {
                lblTime.Text = "[[ stopped ]]";
                processBar.Value = 0;
            }
            else
            {
                lblTime.Text = storyboardClock.CurrentTime.ToString();
                processBar.Value = (double)storyboardClock.CurrentProgress;
            }
        }
    }
}
