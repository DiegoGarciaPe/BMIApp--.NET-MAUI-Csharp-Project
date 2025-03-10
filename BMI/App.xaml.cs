﻿using BMI.MVVM.Views;

namespace BMI
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            if (Current != null)
            {
                Current.UserAppTheme = AppTheme.Light;
            }
            MainPage = new BMIView();
        }
    }
}
