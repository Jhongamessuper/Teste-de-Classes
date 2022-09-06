using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Teste_de_Classes
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnMostrar_Click(object sender, EventArgs e)
        {
            Cliente cliente = new Cliente();
            cliente.Nome = txtNome.Text;
            cliente.Email = txtEmail.Text;
            cliente.Telefone1 = int.Parse(txtTelefone1.Text);
            cliente.Telefone2 = int.Parse(txtTelefone2.Text);

            System.Windows.Forms.MessageBox.Show(
            "Nome : " + cliente.Nome + "\n" +
            "Email : " + cliente.Email + "\n" +
            "Telefone 1 : " + cliente.Telefone1 + "\n" +
            "Telefone 2 : " + cliente.Telefone2
            );
        }
    }
}
