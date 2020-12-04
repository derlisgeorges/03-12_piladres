using System;

namespace Pilares.classe
{
    public class Pessoa
    {
        public string nome;

        private string senha = "12345";

        public void ExibirNome(){
            Console.WriteLine($"O nome cadastrado é {this.nome}");
            
        }

    public void ValidarSenha(string senha){
        if (senha == this.senha){
            Console.WriteLine("Senha Correta");
        }else{
            Console.WriteLine("Senha Incorreta");
        }
    }

    public void Soma(int a, int b){
        Console.WriteLine($"A + B = {a+b}");
    }

    public void soma(int a,int b, int c){
        Console.WriteLine($"A + B + C = {a+b+c}");
    }
    public float soma(int a, float b ){

        return a+b;
    }



    }
}