public class Voo{
    public int codigoVoo;
    public string saida;
    public DateTime horario;
    public string destino;
    public decimal valor;
    public int capacidade;
    public bool partiu;
    private Passageiro passageiro;

    public int CodigoVoo { get => codigoVoo; set => codigoVoo = value; }
    public string Saida { get => saida; set => saida = value; }
    public string Destino { get => destino; set => destino = value; }
    
    public void AvisoVoo(Voo v)
    {
        if (horario < DateTime.Now){
            partiu = false;
            Console.WriteLine($"Atenção passageiros, o vôo {v.codigoVoo} irá partir às {v.horario}!");
        }else if(horario == DateTime.Now){
            Console.WriteLine($"Atenção passageiros, o vôo {v.codigoVoo} está prestes a partir!");
            partiu = false;
        }else{
            Console.WriteLine($"O vôo {v.codigoVoo} já partiu!");
            partiu = true;
        }
    }

    public void Embarcar(Voo v){
        if (v.partiu == false){
            Console.WriteLine($"O passageiro embarcou no vôo {v.codigoVoo}.");
        }else{
            Console.WriteLine($"O passageiro não pode embarcar no vôo {v.codigoVoo} pois ele já partiu.");
        }
    }
    
}

