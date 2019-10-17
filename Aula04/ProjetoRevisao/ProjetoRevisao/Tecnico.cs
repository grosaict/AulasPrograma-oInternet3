using System;
using System.Collections.Generic;
using System.Text;

namespace ProjetoRevisao
{
    class Tecnico : Pessoa, Assalariado
    {
        //Quantidade é uma propriedade da classe
        public static int Quantidade { get; set; }
        public string Funcao { get; set; }
        public double Salario { get; set; }

        public Tecnico(
            string nome, int idade, 
            string funcao, double salario):base(
                nome, idade) {
            this.Salario = salario;
            this.Funcao = funcao;
            if (Quantidade == 0)
            {
                Quantidade = 1;
            }
            else {
                Quantidade++;
            }
        }
        /*Indica que o método herdado esta sendo 
         * sobrescrito*/
        public override void MostrarDados() {
            //Chama o método implementado na classe pai
            base.MostrarDados();
            Console.WriteLine("Função: " + Funcao);
            Console.WriteLine("Salário: " + Salario);
        }

        /*Fui obrigado a implementar esse método,
         por ser um método abstrato no meu pai*/
        public override void Cumprimentar() {
            Console.WriteLine("Estou ocupado");
        }

        public double GetSalario() {
            return Salario;
        }

    }
}
