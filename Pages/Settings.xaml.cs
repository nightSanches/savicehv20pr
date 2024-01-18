﻿using System;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Forms;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace savicehv20pr.Pages
{
    public partial class Settings : Page
    {
        public MainWindow mainWindow;

        OpenFileDialog openFileDialog = new OpenFileDialog();
        ColorDialog colorDialog = new ColorDialog();
        public Settings(MainWindow _mainWindow)
        {
            InitializeComponent();

            mainWindow = _mainWindow;

            openFileDialog.InitialDirectory = "C:\\";
            openFileDialog.Filter = "Access files (*.accbd)|*accbd|All files (*.*)|*.*";
            openFileDialog.FilterIndex = 2;
            openFileDialog.RestoreDirectory = true;

            colorDialog.AllowFullOpen = true;
            colorDialog.ShowHelp = false;
        }

        private void OpenDataBase(object sender, RoutedEventArgs e)
        {
            if(openFileDialog.ShowDialog() == DialogResult.OK)
            {
                tb_database.Text = openFileDialog.FileName;
            }
        }

        private void SelectScreen_Resolution(object sender, SelectionChangedEventArgs e)
        {
            System.Windows.Controls.ComboBox comboBox = sender as System.Windows.Controls.ComboBox;
            TextBlock textBlock = comboBox.SelectedValue as TextBlock;
            string resolution = textBlock.Text;

            string[] separator = new string[1] { "x" };

            mainWindow.Width = int.Parse(resolution.Split(separator, StringSplitOptions.None)[0]);
            mainWindow.Height = int.Parse(resolution.Split(separator, StringSplitOptions.None)[1]);
        }

        private void SelectColorApplication(object sender, RoutedEventArgs e)
        {
            if (colorDialog.ShowDialog() == DialogResult.OK)
            {
                System.Drawing.Color color = colorDialog.Color;

                gr_header.Background = new SolidColorBrush(Color.FromArgb(color.A, color.R, color.G, color.B));
                gr_appliacation.Background = new SolidColorBrush(Color.FromArgb(color.A, color.R, color.G, color.B));
            }
        }
    }
}
