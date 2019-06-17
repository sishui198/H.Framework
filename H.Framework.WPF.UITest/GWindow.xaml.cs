﻿using H.Framework.Core.Utilities;
using System;
using System.Windows;

namespace H.Framework.WPF.UITest
{
    /// <summary>
    /// GWindow.xaml 的交互逻辑
    /// </summary>
    public partial class GWindow : Window
    {
        public GWindow()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            var nonce = Utility.ObjectID;
            var curTime = TimeHelper.UTCSeconds(DateTime.Now).ToString();
            txt1.Text = nonce;
            txt2.Text = curTime;
            txt3.Text = HashEncryptHepler.SHA1Hash(txt0.Text + nonce + curTime).ToLower();
            var a = HAHA();
            var b = HA();
        }

        AA HA()
        {
            return new AA { aa ="aaa"};
        }

        AA HAHA()
        {
            return new BB { aa ="aaa",bb = "bbb"};
        }

        class AA
        {
            public string aa { get; set; }
        }

        class BB:AA
        {
            public string bb { get; set; }
        }
    }
}