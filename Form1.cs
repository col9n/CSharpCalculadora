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
            Total = "";
            Parcial = "";
        }

        /*
         * Formats Total y Partial
         */
        private Boolean stringFormatOK(String valor)
        {
            return   (valor != null && valor.Length > 0) ;
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
        * +-
        */
        private void ButtonMasMenos_Click(object sender, EventArgs e)
        {
            if (stringFormatOK(Parcial))
            {
                double masmenos = Convert.ToDouble(Parcial);
                if (masmenos > 0)
                    masmenos = masmenos * -1;
                else
                    masmenos = Math.Abs(masmenos);
                Parcial = masmenos.ToString();
                SetView(Parcial);
                ViewRestart();
                SetView(Total+Parcial);
                Console.WriteLine(Parcial);
            }
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
            if (stringFormatOK(Parcial))
                Parcial = Parcial.Remove(Parcial.Length - 1, 1);
            ViewPopLast();
            Console.WriteLine(Parcial);
        }

        private void ButtonReiniciar_Click(object sender, EventArgs e)
        {  
            Total = "";
            Parcial = "";
            ViewRestart();
            Console.WriteLine(Total);
        }

        /*
         *Operations
         */
        private void ButtonOperation(object sender, EventArgs e)
        {
            List<string> operationList = new List<string>();
            operationList.Add(",");
            operationList.Add("+");
            operationList.Add("-");
            operationList.Add("*");
            operationList.Add("/");   

            string resul = (sender as Button).Text;
            if (stringFormatOK(Parcial))
            {
                if (!operationList.Contains(Parcial.Substring((Parcial.Length - 1), 1)))
                {
                    Total = Total + Parcial + resul;
                    Parcial = "";
                    SetView(resul);
                    Console.WriteLine(Parcial);
                }
            }
            
        }

        private void ButtonSolve(object sender, EventArgs e)
        {
            if (stringFormatOK(Parcial))
            {
                Total = Total + Parcial ;
                Parcial = "";
                DataTable dt = new DataTable();
                Total= Total.Replace(",", ".");
                try { 
                var v = dt.Compute(total, "");
                Total = v.ToString();
                Parcial = Total;
                Total = "";
                ViewRestart();
                SetView(Parcial);
                }
                catch(Exception a)
                {
                }
            }

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
