using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Cadastro_Funcionario
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            lbl_salarioTotal.Text = "";
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string funcao = Convert.ToString(comboBoX_funcao.Text);
            double salario = Convert.ToDouble(tx_salario.Text);
            double salarioTotal = Convert.ToDouble(lbl_salarioTotal.Text);
            double irpf = Convert.ToDouble(tx_irpf.Text);
            
            Funcionario f = new Funcionario(salario, salarioTotal, irpf);

            lbl_salarioTotal.Text = f.FuncaoSel();

        }
    }
}
