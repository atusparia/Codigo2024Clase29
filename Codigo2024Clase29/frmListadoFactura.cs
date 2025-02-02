﻿using Entidad;
using Negocio;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Codigo2024Clase29
{
    public partial class frmListadoFactura : Form
    {
        public frmListadoFactura()
        {
            InitializeComponent();
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            NCabecera nCabecera = new NCabecera();
            List<ECabecera> eCabeceras = nCabecera.Listar(txtCliente.Text);
            dgvCabecera.DataSource = eCabeceras;
        }
    }
}
