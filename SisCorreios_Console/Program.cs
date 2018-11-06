/*
 * Criado por SharpDevelop.
 * Usuário: eymard.silva
 * Data: 06/11/2018
 * Hora: 09:42
 * 
 * Para alterar este modelo use Ferramentas | Opções | Codificação | Editar Cabeçalhos Padrão.
 */
using System;

namespace SisCorreios_Console
{
	class Program
	{
		public static void Main(string[] args)
		{
			System.Console.WriteLine("===================== SisCorreios - Console :: EymardSilva =====================");
			
			//método criado para chamar a consulta
			ConsultarCEP();
			
		}
		
		public static void ConsultarCEP()
		{
			System.Console.WriteLine("Ao fazer uma consulta no CEP, você pode digitar - XXXXX-XXX ou XXXXXXXX.\n");
			System.Console.Write("Digite o CEP: ");
			var cepdigitado = System.Console.ReadLine();
			
			//tentativa de consultar CEP
			
			try
		
			{
				//criando variável para o WebServices consultar dados
				var ws = new WebServicesCorreios.AtendeClienteService();
				var retorno = ws.consultaCEP(cepdigitado);
			
				//fazendo os retornos da consulta do cep na variável cepdigitado
				System.Console.WriteLine("Endereço: {0}", retorno.end);
				System.Console.WriteLine("Complemento: {0}", retorno.complemento2);
				System.Console.WriteLine("Bairro: {0}", retorno.bairro);
				System.Console.WriteLine("Cidade: {0}", retorno.cidade);
				System.Console.WriteLine("CEP: {0}", retorno.cep);
				System.Console.WriteLine("Unidade de Federação: {0}", retorno.uf);
				System.Console.WriteLine("Unidades de Postagem: {0}", retorno.unidadesPostagem);
			
			}
		
			catch (Exception ex)
			{
    			//Exception para capturar erro ao buscar um CEP inválido/não existente
				System.Console.WriteLine("Erro ao efetuar busca do CEP: {0}", ex.Message);
			}
				
				
				//Mensagem é exibida ao finalizar a busca e consultar novamente caso o usuário deseje
				System.Console.WriteLine("\nDeseja fazer uma nova consulta? [S(Sim)/N(Não)]");
				string opcaoresposta = Console.ReadLine();
			
				if(opcaoresposta == "s" || opcaoresposta == "sim")
				{
					
					ConsultarCEP();
				}
				else
				{
					Environment.Exit(0);
				}
		
		}
	}
}