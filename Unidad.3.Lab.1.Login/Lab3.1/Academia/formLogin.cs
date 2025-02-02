﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Academia
{
    public partial class formLogin : Form
    {
        public formLogin()
        {
            InitializeComponent();
        }

        private void btnIngresar_Click(object sender, EventArgs e)
        {
            /*
             * En una aplicacion real(TP2), reemplazar por un método que solicite a la capa
             * de negocio recuperar el usuario con nombre igual al ingresado en el txtUsuario,
             * e invocar un método que si su contraseña coincide con la ingresada en txtPass
             */
            if (this.txtUsuario.Text == "Admin" && this.txtPass.Text == "admin")
            {
                MessageBox.Show("Usted ha ingresado al sistema correctamente.", "Login",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.DialogResult = DialogResult.OK;
            }
            else
            {
                MessageBox.Show("Usuario y/o contraseña incorrectos", "Login",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void lnkOlvidaPass_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Es Ud. un usuario muy descuidado, haga memoria", "Olvidé mi contraseña",
                MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
        }


    }
}
