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
            SetView(resul);
            Console.WriteLine(Parcial);
        }


        /*
        * DEL  CE  C
        */
        private void ButtonBorrar_Click(object sender, EventArgs e)
        {
            ViewPartial();
            Parcial = "";
            Console.WriteLine(Parcial);
        }

        private void ButtonQuitar_Click(object sender, EventArgs e)
        {
            if (Parcial != null && Parcial.Length > 0)
                Parcial = Parcial.Remove(Parcial.Length - 1, 1);
            ViewPopLast();
            Console.WriteLine(Parcial);
        }

        private void ButtonReiniciar_Click(object sender, EventArgs e)
        {
            if (Total != null)
                Total = "";
            ViewRestart();
            Console.WriteLine(Total);
        }


        /*
         * View metodos
         */
        private void SetView(string valor)
        {
            View.Text = View.Text + valor;
        }

        private void ViewPopLast()
        {
            if (View.Text != null && View.Text.Length > 0)
                View.Text = View.Text.Remove(View.Text.Length - 1, 1);
        }

        private void ViewRestart()
        {
            if (View.Text != null && View.Text.Length > 0)
                View.Text = "";
        }

        private void ViewPartial()
        {
            if (View.Text != null && View.Text.Length > 0)
            {
               
                for (int i = 0;i < Parcial.Length; i++)
                {
                    ViewPopLast();
                }
            }
        }
    }

    
}
