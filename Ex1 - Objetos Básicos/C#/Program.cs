using System;
class Program
{
    public static void Main(string[] args)
    {
        Jogo j1 = new Jogo();
        j1.fabricante = "Garena";
        j1.nome = "Free Fire";
        j1.nota = 4;

        Personagem p1 = new Personagem();
        p1.nome = "Alok";
        p1.habilidade = "Som na caixa";
        p1.tipoHabilidade = "Ativa";
        p1.hp = 200;

        Diamantes d1 = new Diamantes();
        d1.nomePacote = "Básico";
        d1.quantidade = 100;
        d1.valor = 5;

        Usuario u1 = new Usuario();
         u1.nome = "Mazikeen";
         u1.id = "74546392";
         u1.nivel = 64;

    }
}