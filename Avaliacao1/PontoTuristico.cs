public class PontoTuristico : Lugar{
    public PontoTuristico()
    {
        Nome = nome;
        Pais = pais;
        Estado = estado;
        Cidade = cidade;
        Rua = rua;
        Aberto = aberto;
    }
    public Lugar lugar;
    public DateTime abertura;
    public DateTime fechamento;

    public void Situação(PontoTuristico pt)
    {
        if ((abertura < DateTime.Now) && (fechamento > DateTime.Now)){
            Console.WriteLine($"O ponto turistico {pt.nome} está aberto para visitas!");
            aberto = true;
        }else{
            Console.WriteLine($"O ponto turistico {pt.nome} está fechado para visitas!");
            aberto = false;
        }
    }

    public void Visitar(Passageiro p){
        if (aberto == true){
            Console.WriteLine($"{p.nome} visitou {this.nome}!");
        }else{
            Console.WriteLine($"{p.nome} não visitou {this.nome} pois o lugar se encontra fechado!");
        }
    }
}
