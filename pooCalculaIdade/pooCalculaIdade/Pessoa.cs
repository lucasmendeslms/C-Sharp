 using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pooCalculaIdade
{
    public class Pessoa
    {
		private int anoNascimento;

		public int AnoNascimento
		{
			get { return this.anoNascimento; }
			set { this.anoNascimento = value; }
		}

		private String nome;

		public String Nome
		{
			get{ return nome; }
			set{ nome = value; }
		}

		private int idade;

		public int Idade
		{
			get 
			{
				this.CalcularIdade();
				return this.idade; 
			}
		}

		public void ExibirDados()
		{
			Console.WriteLine("Nome: " + this.Nome);
			Console.WriteLine("Ano de nascimento: " + this.AnoNascimento);
			Console.WriteLine("Idade: " + this.Idade);
		}

		private void CalcularIdade()
		{
			DateTime data = DateTime.Now;
			this.idade = data.Year - this.anoNascimento;
		}
	}
}
