﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace contar
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            button1.Text = Classe.Abrir();
        }
        private Contador Classe = new Contador();

        private void Button1_Click(object sender, EventArgs e)
        {
            Classe.contar(button1);
        }
    }
}
