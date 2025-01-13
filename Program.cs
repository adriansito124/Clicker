using static NewSystem.NewConsole;
using System.Threading;

Print("\nBem vindo ao Bosch Clicker!\n");
Print("Espaço => click e iniciar"); // 32
Print("L => loja");// l = 108, L = 76
Print("M => maquinas");// m = 109, M = 77
Print("C => menu\n");// c = 99, C = 67

Click dinheiro = new Click(1);

dinheiro.Valor = 0;

int add = 1;

int start = 0;


// Print($"Valor da tecla pressionada: {tec}");

while (true)
{
    int? tec = ReadKeyInt();

    if (tec == 32 && start == 0)
    {
        start = 1;
    }
    
    if (start == 1)
    {
        
        if (tec == 32)
        {
            dinheiro.Valor = dinheiro.Valor + add;
            Print(dinheiro.Valor.ToString("C1"));
        }

        if (tec == 108 || tec == 76)
        {
            Print("1-garra => R$20,00 | +1 \n2-serra => R$50,00 | +3\n2-serra => R$100,00 | +1pS");
        } 
        if (tec == 109 || tec == 77)
        {
            Print("maquinas");
        }
        if (tec == 99 || tec == 67)
        {
            Print("menu");
        }
    }

    Thread.Sleep(1000);

}








