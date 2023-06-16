using System.Windows.Forms;

public class Funcionario
{
    string funcao;
    double salario;
    double salarioTotal;
    double irpf;

    public Funcionario(double salario, double salarioTotal, double irpf)
    {
        this.salario = salario;
        this.salarioTotal = salarioTotal;
        this.irpf = irpf;
    }
    public string FuncaoSel()
    {
        if(funcao == "Médico")
        {
            double periculosidade = (salario * 20) / 100;
            double salarioT = periculosidade + salario;
            return salarioT.ToString("C2");

        }
        else if(funcao == "TI")
        {
            double adcTecn = (salario + 5.600);
            double salarioT = adcTecn;
            return salarioT.ToString("C2");
        }
        else if( funcao == "ADM")
        {
            double valTransport = salario + ((salario * 15) / 100);
            double valALimento = valTransport + 200;
            double salarioT = valALimento;
            return salarioT.ToString("C2");
        }
        else
        {
            return "Função não selecionada!";
        }
        

    }
    
}
}