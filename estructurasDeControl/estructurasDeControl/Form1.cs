using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace estructurasDeControl
{
    public partial class Form1 : Form
       

    {
        public Form1()
        {
            InitializeComponent();
        }
        
        private void Form1_Load(object sender, EventArgs e)
        {
            
            
        }

        private void btnEvaluar_Click(object sender, EventArgs e)
        {
            //double dato = Convert.ToDouble(txtDato1.Text);

            // if (dato < 6)
            // {

            //label1.Text = "Necesita Mejorar";



            // }
            // else if (dato <= 6 && dato < 7)
            //{

            // label1.Text = "Su nota es Buena ";

            //}
            //else if (dato >= 7 && dato < 8)
            //{

            // label1.Text = "Su nota es Muy Buena";

            // cortar decisión 
            //}
            //else {
            //label1.Text = "Su nota es exelente";

            //}

           

            //creación de bucle

            for (int i=0; i<10;i++) {

                if (i ==6) {
                    // break -- punto de quiebre
                   break;
                }

                MessageBox.Show(i.ToString());

            }





        }
    }
}
