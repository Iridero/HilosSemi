using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;
namespace Hilos
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnMax_Click(object sender, EventArgs e)
        {
            nmrNum.Value = int.MaxValue;
        }

        delegate void delCambiaLabel(string texto);
        void cambiaLabel(string texto)
        {
            if (lblMensaje.InvokeRequired)
            {
                var d = new delCambiaLabel(cambiaLabel);
                lblMensaje.Invoke(d,new object[]{ texto });
            }
            else
            {
                lblMensaje.Text = texto;
            }
        }


        public void EsPrimo(object o)
        {
            
                int n = (int)o;
                for (int i = 2; i < n; i++)
                {
                    if ((n % i) == 0)
                    {
                    cambiaLabel("no es primo");
                    return;
                    }
                }
                cambiaLabel( "Es primo");
            

        }

        private void btnEsPrimo_Click(object sender, EventArgs e)
        {
            var n = (int)nmrNum.Value;
            Thread t = new Thread(new ParameterizedThreadStart(EsPrimo));
            t.Start(n);
        }
    }
}
