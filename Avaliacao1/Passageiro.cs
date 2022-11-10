public class Passageiro : Voo{
    public Passageiro()
    {
        CodigoVoo = codigoVoo;
        Saida = saida;
        Destino = destino;
    }

    public string nome;
    private string cpf;
    public int assento;

    public void Conversar(Passageiro p)
    {
        if (this.codigoVoo == p.codigoVoo)
        {
            Console.WriteLine();
            Console.WriteLine($"Os passageiros {this.nome} e {p.nome} estão conversando.");
        }else
        {
            Console.WriteLine($"Os passageiros {this.nome} e {p.nome} não estão no mesmo vôo, por isso não podem conversar.");
        }

    }

}