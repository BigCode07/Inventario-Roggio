﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ChameleonProject
{
    public partial class Presentation : Form
    {
        public Presentation()
        {
            InitializeComponent();
        }

        private void Timer(object sender, EventArgs e)
        {
            this.Visible = false;
            this.Time.Stop();

         
            MainScreen main_Screen = new MainScreen();
            main_Screen.UsuarioMenu = ClaseCompartida.Usuario;
            main_Screen.Contador = Convert.ToString(ClaseCompartida.Contador);
            main_Screen.Show();
        }

        public static class ClaseCompartida
        {
            public static string Usuario;
            public static object Contador;

        }
    }
}
