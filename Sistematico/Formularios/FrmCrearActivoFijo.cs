﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sistematico.Formularios
{
    public partial class FrmCrearActivoFijo : Form
    {
        public FrmCrearActivoFijo()
        {
            InitializeComponent();
        }

        private void BtnCancelar_Click(object sender, EventArgs e)
        {
           Dispose();
        }

        private void BtnAceptar_Click(object sender, EventArgs e)
        {

            Dispose();
        }
    }
}
