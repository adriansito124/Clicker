public class Click
{
    public int Valor { get; set; }

    public Click(int valor)
    {
        this.Valor = valor;
    }

    public int getClick () => this.Valor;
}