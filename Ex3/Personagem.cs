public class Personagem
{
    public string nome;
    private string raca;
    private int idRaca;
    private int vida;
    private int forca;
    public int ataque;
    private int defesa;
    private int nivel;
    private string posicao;
    private Arma arma;
    private int idArma;
    private Magia magia;
    private int idMagia;
    Random rd = new Random();


    public Personagem(string nome, int idRaca, int idArma, int idMagia)
    {
        this.Nome = nome;

        switch (idRaca)
        {
            case 1:
                raca = "Tanque";
                vida = 150;
                vida += rd.Next(5, 80);
                forca = 10;
                forca += rd.Next(2, 5);

                if (idArma <= 3)
                {
                    arma = new Arma("Bota do Vigor", 3);
                    this.forca += arma.Poder;
                }
                else if (idArma <= 8)
                {
                    arma = new Arma("Protetor de Athena", 6);
                    this.forca += arma.Poder;
                }
                else
                {
                    arma = new Arma("Cinturão do Trovão", 15);
                    this.forca += arma.Poder;
                    this.vida += 10;
                }

                if (idMagia == 0)
                {
                    magia = new Magia("Não possui.", 0);
                }

                break;

            case 2:
                raca = "Mago";
                vida = 70;
                vida += rd.Next(2, 50);
                forca = 15;
                forca += rd.Next(6, 10);

                if (idArma == 0)
                {
                    arma = new Arma("Não possui.", 0);
                }

                if (idMagia <= 3)
                {
                    magia = new Magia("Bota Arcana", 3);
                    this.forca += magia.Poder;
                }
                else if (idMagia <= 8)
                {
                    magia = new Magia("Relógio do Destino", 7);
                    this.forca += magia.Poder;
                }
                else
                {
                    magia = new Magia("Cetro Relâmpago", 15);
                    this.forca += magia.Poder;
                }
                break;

            case 3:
                raca = "Atirador";
                vida = 50;
                vida += rd.Next(2, 6);
                forca = 20;
                forca += rd.Next(6, 15);

                if (idArma == 0)
                {
                    arma = new Arma("Não possui.", 0);
                }

                if (idMagia <= 3)
                {
                    magia = new Magia("Bota da Agilidade", 3);
                    this.forca += magia.Poder;
                }
                else if (idMagia <= 8)
                {
                    magia = new Magia("Voz do Vento", 7);
                    this.forca += magia.Poder;
                }
                else
                {
                    magia = new Magia("Fantasma Escarlate", 15);
                    this.forca += magia.Poder;
                }
                break;

            case 4:
                raca = "Assassino";
                vida = 100;
                vida += rd.Next(9, 15);
                forca = 60;
                forca += rd.Next(8, 18);

                if (idArma <= 3)
                {
                    arma = new Arma("Bota Veloz", 3);
                    this.forca += arma.Poder;
                }
                else if (idArma <= 8)
                {
                    arma = new Arma("Machado de Guerra", 6);
                    this.forca += arma.Poder;
                }
                else
                {
                    arma = new Arma("Lâmina do Desespero", 15);
                    this.forca += arma.Poder;
                    this.vida += 10;
                }

                if (idMagia == 0)
                {
                    magia = new Magia("Não possui.", 0);
                }

                break;

            case 5:
                raca = "Soldado";
                vida = 110;
                //vida += rd.Next(2, 80);
                forca = 25;
                //forca += rd.Next(2, 10);

                if (idArma <= 3)
                {
                    arma = new Arma("Bota do Guerreiro", 3);
                    this.forca += arma.Poder;
                }
                else if (idArma <= 8)
                {
                    arma = new Arma("Cajado Genial", 6);
                    this.forca += arma.Poder;
                }
                else
                {
                    arma = new Arma("Varinha Brilhante", 15);
                    this.forca += arma.Poder;
                    this.vida += 10;
                }

                if (idMagia <= 3)
                {
                    magia = new Magia("Força Reunida", 3);
                    this.forca += magia.Poder;
                }
                else if (idMagia <= 8)
                {
                    magia = new Magia("Cetro do Inverno", 7);
                    this.forca += magia.Poder;
                }
                else
                {
                    magia = new Magia("Imortal", 15);
                    this.forca += magia.Poder;
                }
                break;

            default:
                break;
        }
    }

    public void Heroi()
    {
        Console.WriteLine();
        Console.WriteLine("--------------------- HEROÍ -----------------------");
        Console.WriteLine("Nome: " + Nome);
        Console.WriteLine("Função: " + raca);
        Console.WriteLine("Força: " + forca);
        Console.WriteLine("Arma: " + arma.Nome);
        Console.WriteLine("Magia: " + magia.Nome);
        Console.WriteLine("----------------------------------------------------");
    }

    public void Lane(Personagem p)
    {
        if (p.raca == "Tanque")
        {
            p.posicao = "Rotacionando";
        }
        else if (p.raca == "Mago")
        {
            p.posicao = "na Rota do Meio";
        }
        else if (p.raca == "Atirador")
        {
            p.posicao = "na Rota do Ouro";
        }
        else if (p.raca == "Assassino")
        {
            p.posicao = "na Selva";
        }
        else if (p.raca == "Soldado")
        {
            p.posicao = "na Rota do XP";
        }

        Console.WriteLine();
        Console.WriteLine("------------------ POSIÇÃO ATUAL -------------------");
        Console.WriteLine($"{p.nome} está {p.posicao}.");
        Console.WriteLine("----------------------------------------------------");
    }

    public void Lutar(Personagem p)
    {
        if (this.posicao == p.posicao)
        {
            Console.WriteLine();
            Console.WriteLine("-------------------- COMBATE -----------------------");
            Console.WriteLine($"Os personagens {this.nome} e {p.nome} estão lutando.");
            Console.WriteLine($"Vida inicial {this.nome}: {this.vida}. ");
            Console.WriteLine($"Vida inicial {p.nome}: {p.vida}. ");
            Console.WriteLine();
            Console.WriteLine("-------------------- ATAQUES -----------------------");
            Console.WriteLine();
            while (this.vida > 0 && p.vida > 0)
            {

                this.ataque = rd.Next(1, 30);
                p.ataque = rd.Next(1, 30);
                
                if (this.ataque > p.ataque)
                {
                    p.vida -= (this.ataque);
                    Console.WriteLine($"{this.nome} atacou {p.nome} com {this.ataque} de dano.");
                    Console.WriteLine();
                }
                else if (this.ataque < p.ataque)
                {
                    this.vida -= (p.ataque);
                    Console.WriteLine($"{p.nome} atacou {this.nome} com {p.ataque} de dano.");
                    Console.WriteLine();
                }

                Console.WriteLine($"{this.nome} ficou com {this.vida} de vida.");
                Console.WriteLine($"{p.nome} ficou com {p.vida} de vida.");
                Console.WriteLine("----------------------------------------------------");
                Console.WriteLine();
            }

            Console.WriteLine("A Luta Acabou:");


            if (this.vida <= 0)
            {
                Console.WriteLine($"{p.nome} matou {this.nome}!");
            }
            else if (p.vida <= 0)
            {
                Console.WriteLine($"{this.nome} matou {p.nome}!");
            }

        }else
        {
            Console.WriteLine($"Os personagens {this.nome} e {p.nome} não estão na mesma rota, por isso não podem lutar.");
        }

    }

    public string Nome { get => nome; set => nome = value; }
    public string Raca { get => raca; set => raca = value; }

}

