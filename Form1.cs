using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CSharpCalculadora
{
    public partial class CSharpCalculadora : Form
    {
        private string total; // field
        public string Total   // property
        {
            get { return total; }
            set { total = value; }
        }

        private string parcial; // field
        public string Parcial   // property
        {
            get { return parcial; }
            set { parcial = value; }
        }
        public CSharpCalculadora()
        {
            InitializeComponent();         
        }
        /*
         * Numeros calculadora
         */
        private void ButtonNumero_Click(object sender, EventArgs e)
        {
            string resul = (sender as Button).Text;
            Parcial = Parcial + resul;
            Console.WriteLine(Parcial);
        }
        private void ButtonBorrar_Click(object sender, EventArgs e)
        {
            Parcial = "";
            Console.WriteLine(Parcial);
        }

        private void ButtonQuitar_Click(object sender, EventArgs e)
        {
            if (Parcial != null && Parcial.Length > 0)
                Parcial = Parcial.Remove(Parcial.Length - 1, 1);
            Console.WriteLine(Parcial);
        }

        private void ButtonReiniciar_Click(object sender, EventArgs e)
        {
            if (Total != null)
                Total = "";
            Console.WriteLine(Total);
        }
    }

    
}
