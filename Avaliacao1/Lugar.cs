public class Lugar
{
    public string nome;
    public string pais;
    public string estado;
    public string cidade;
    public string rua;
    public bool aberto;

    public void Visitar(Passageiro p){
        if (aberto == true){
            Console.WriteLine($"{p.nome} visitou {this.nome}!");
        }else{
            Console.WriteLine($"{p.nome} não visitou {this.nome} pois o lugar se encontra fechado!");
        }
    }

    public string Nome { get => nome; set => nome = value; }
    public string Pais { get => pais; set => pais = value; }
    public string Estado { get => estado; set => estado = value; }
    public string Cidade { get => cidade; set => cidade = value; }
    public string Rua { get => rua; set => rua = value; }
    public bool Aberto { get => aberto; set => aberto = value; }
}