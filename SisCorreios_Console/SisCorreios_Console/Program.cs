/*
 * Criado por SharpDevelop.
 * Usuário: eymard.silva
 * Data: 06/11/2018
 * Hora: 09:42
 * 
 * Para alterar este modelo use Ferramentas | Opções | Codificação | Editar Cabeçalhos Padrão.
 */
using System;
using System.Linq; //para usar o método FirstOrDefault(), precisa-se da biblioteca System.Linq;

namespace SisCorreios_Console
{
	class Program
	{
		public static void Main(string[] args)
		{
			
			//método criado para chamar o menu principal
			MenuPrincipal();
			
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
					//limpeza da tela
					LimparTela();
					//continuação da execução do software
					ConsultarCEP();
				}
				else
				{
					//Método antigo de saída do software usando diretamente o Enviroment.Exit(0);
					//Environment.Exit(0);
					Encerrar();
				}
		
		}
		
		public static void CalcularPrecoEncomenda()
		{
			System.Console.WriteLine("Bem-vindo ao cálculo de Prazos e Preços de Encomendas com o SisCorreios.\n");
			System.Console.WriteLine("Esse sistema de prazos e cálculos depende vários itens, dentre eles:\n");
			System.Console.WriteLine("CEP de Origem, Destino, Dimensão da Encomenda, Código de Envio, entre outros.\n");
			
			System.Console.WriteLine("\nImportante: \nOs códigos de envio são:\n");
			System.Console.WriteLine("\n1) 40010 - SEDEX Varejo \n2) 40045 - SEDEX a Cobrar Varejo \n3)40215 - SEDEX 10 Varejo \n4) 41106 - PAC Varejo");

			// criando as variáveis necessárias de acordo com a implementação
			System.Console.Write("Digite o código do tipo de envio: ");
			var tipoEnvio = System.Console.ReadLine();
			VerificaCodigo(tipoEnvio);
			System.Console.Write("Digite o CEP de origem: ");
			var cepOrigem = System.Console.ReadLine();
			System.Console.Write("Digite o CEP de destino: ");
			var cepDestino = System.Console.ReadLine();
			System.Console.Write("Digite o peso (kg): ");
			var peso = System.Console.ReadLine();
			
			System.Console.Write("Digite o código do formato (caixa, envelope, etc): ");
			var codigoFormato = System.Console.ReadLine();
			System.Console.Write("Digite o comprimento: ");
			var comprimento = System.Console.ReadLine();
			System.Console.Write("Digite a altura: ");
			var altura = System.Console.ReadLine();
			System.Console.Write("Digite a largura: ");
			var largura = System.Console.ReadLine();
			System.Console.Write("Digite o diâmetro: ");
			var diametro = System.Console.ReadLine();
			System.Console.Write("Entrega em mão própria (S/N)?: ");
			var maoPropria = System.Console.ReadLine();
			System.Console.Write("Digite o valor declarado: ");
			var valorDeclarado = System.Console.ReadLine();
			System.Console.Write("Aviso de recebimento (S/N)?: ");
			var avisoRecebimento = System.Console.ReadLine();
 
		try
		{
    		int codigoFormatoInt;
    		if (!int.TryParse(codigoFormato, out codigoFormatoInt))
        	throw new Exception("Código do formato inválido");
    		decimal comprimentoDecimal;
    		if (!decimal.TryParse(comprimento, out comprimentoDecimal))
        	throw new Exception("Comprimento inválido");
    		decimal alturaDecimal;
    		if (!decimal.TryParse(altura, out alturaDecimal))
        	throw new Exception("Altura inválida");
    		decimal larguraDecimal;
    		if (!decimal.TryParse(largura, out larguraDecimal))
        	throw new Exception("Largura inválida");
    		decimal diametroDecimal;
    		if (!decimal.TryParse(diametro, out diametroDecimal))
        	throw new Exception("Diâmetro inválido");
    		decimal valorDeclaradoDecimal;
    		if (!decimal.TryParse(valorDeclarado, out valorDeclaradoDecimal))
        	throw new Exception("Valor declarado inválido");
    		var ws = new SisCorreiosPrecoPrazo.CalcPrecoPrazoWS();
    		var Resposta = ws.CalcPrecoPrazo(string.Empty, string.Empty, tipoEnvio, cepOrigem, cepDestino, peso, codigoFormatoInt, comprimentoDecimal, alturaDecimal, larguraDecimal, diametroDecimal, maoPropria, valorDeclaradoDecimal, avisoRecebimento);
    		var RespostaReal = Resposta.Servicos.FirstOrDefault();
    		
    	if (RespostaReal != null)
    	{
        	System.Console.WriteLine();
        	System.Console.WriteLine("Prazo: {0} dia", RespostaReal.PrazoEntrega);
        	System.Console.WriteLine("Valor: R$ {0}", RespostaReal.Valor);
    	}
    	else
    	{	
        	throw new Exception("Não foi possível encontrar os valores dentro da resposta do serviço");
    	}
	}
		catch (Exception ex)
		{
	   		System.Console.WriteLine("Erro ao efetuar cálculos: {0}", ex.Message);
		}
			System.Console.ReadLine();
			
		}
		
		//Método para verificar o código do evnio informado
		public static string VerificaCodigo(string codigo)
		{
			var codigoinformado = System.Console.ReadLine();
			
			if (codigoinformado != "40010")
			{
				System.Console.Write("Código informado" + codigoinformado + " é errado ou não existe na base dos correios.");
			}
			if (codigoinformado != "40045") 
			{
				System.Console.Write("O codigo informado: " + codigoinformado + " é errado ou não existe na base dos correios.");
			}
			if (codigoinformado != "40215")
			{
				System.Console.Write("Código informado" + codigoinformado + " é errado ou não existe na base dos correios.");
			}
			if (codigoinformado != "41106")
			{
				System.Console.Write("Código informado" + codigoinformado + " é errado ou não existe na base dos correios");
			}
			
			return codigo;
		}
		
		//Método para criar o menu principal
		public static void MenuPrincipal()
		{
			System.Console.WriteLine("===================== SisCorreios - Console :: EymardSilva =====================");
			System.Console.WriteLine("O que deseja calcular?\n\n");
			System.Console.WriteLine(" 1) Consultar CEP\n 2) Calcular Encomenda (Preço e Prazo)\n 3) Sair do SiSConsole \n\nQual é a opção desejada?");
			
			var opcaodesejada = System.Console.ReadLine();
			if(opcaodesejada == "1")
			{
				ConsultarCEP();
			}
			if(opcaodesejada == "2")
			{
				CalcularPrecoEncomenda();
			}
			if (opcaodesejada == "3")
			{
				Encerrar();
			}
		}
		
		//Método para limpar a tela
		public static void LimparTela ()
		{
			System.Console.Clear();
		}
		
		//Método para sair do sistema
		public static void Encerrar()
		{
			LimparTela();
			System.Console.WriteLine("\nDeseja realmente sair do SisConsole? [S(Sim)/N(Não)");
			string opcaoresposta = Console.ReadLine();
			
			if(opcaoresposta == "s" || opcaoresposta == "sim")
			{
				Environment.Exit(0);
			}
			else
			{
				MenuPrincipal();
			}
		}
	}
}