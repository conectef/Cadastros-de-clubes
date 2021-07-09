using System;

namespace DIO.Clubes
{
    class Program
    {
        static TiposRepositorio repositorio = new TiposRepositorio();
        static void Main(string[] args)
        {
            string opcaoUsuario = ObterOpcaoUsuario();

			while (opcaoUsuario.ToUpper() != "X")
			{
				switch (opcaoUsuario)
				{
					case "1":
						ListarClubes();
						break;
					case "2":
						InserirClubes();
						break;
					case "3":
						AtualizarClubes();
						break;
					case "4":
						ExcluirClubes();
						break;
					case "5":
						VisualizarClubes();
						break;
					case "C":
						Console.Clear();
						break;

					default:
						throw new ArgumentOutOfRangeException();
				}

				opcaoUsuario = ObterOpcaoUsuario();
			}

			Console.WriteLine("Obrigado por utilizar nossos serviços.");
			Console.ReadLine();
        }

        private static void ExcluirTitulos()
		{
			Console.Write("Digite o id do clube: ");
			int indiceSerie = int.Parse(Console.ReadLine());

			repositorio.Exclui(indiceTitulos);
		}

        private static void VisualizarTitulos()
		{
			Console.Write("Digite o id do clube: ");
			int indiceSerie = int.Parse(Console.ReadLine());

			var serie = repositorio.RetornaPorId(indiceSerie);

			Console.WriteLine(serie);
		}

        private static void AtualizarClubes()
		{
			Console.Write("Digite o id do clube: ");
			int indiceSerie = int.Parse(Console.ReadLine());

			// https://docs.microsoft.com/pt-br/dotnet/api/system.enum.getvalues?view=netcore-3.1
			// https://docs.microsoft.com/pt-br/dotnet/api/system.enum.getname?view=netcore-3.1
			foreach (int i in Enum.GetValues(typeof(Times)))
			{
				Console.WriteLine("{0}-{1}", i, Enum.GetName(typeof(Times), i));
			}
			Console.Write("Digite o time entre as opções acima: ");
			int entradaTime = int.Parse(Console.ReadLine());

			Console.Write("Digite o Ano de Fundação: ");
			int entradaAno = int.Parse(Console.ReadLine());

			Console.Write("Digite o artilheiro do time: ");
			string entradaArtilheiro = Console.ReadLine();

			Console.Write("Digite o tecnico do time: ");
			string entradaTecnico = Console.ReadLine();

			Console.Write("Digite as cores do time: ");
			string entradaCores = Console.ReadLine();

			Titulos atualizaSerie = new Titulos(id: indiceTitulos,
										times: (Times)entradaTimes,
										titulo: entradaTitulo,
										ano: entradaAno,
										tecnico: entradaTecnico,
										cores: entradaCores,
										artilheiro: entradaArtilheiro);

			repositorio.Atualiza(indiceTitulos, atualizaTitulos);
		}
        private static void ListarTitulos()
		{
			Console.WriteLine("Listar clubes");

			var lista = repositorio.Lista();

			if (lista.Count == 0)
			{
				Console.WriteLine("Nenhum clube cadastrado.");
				return;
			}

			foreach (var clube in lista)
			{
                var excluido = clube.retornaExcluido();
                
				Console.WriteLine("#ID {0}: - {1} {2}", clube.retornaId(), titulos.retornaTitulo(), (excluido ? "*Excluído*" : ""));
			}
		}

        private static void InserirTitulos()
		{
			Console.WriteLine("Inserir novo clube");

			// https://docs.microsoft.com/pt-br/dotnet/api/system.enum.getvalues?view=netcore-3.1
			// https://docs.microsoft.com/pt-br/dotnet/api/system.enum.getname?view=netcore-3.1
			foreach (int i in Enum.GetValues(typeof(Times)))
			{
				Console.WriteLine("{0}-{1}", i, Enum.GetName(typeof(Times), i));
			}
			Console.Write("Digite o time entre as opções acima: ");
			int entradaTime = int.Parse(Console.ReadLine());

			Console.Write("Digite o Ano de Fundação de time: ");
			int entradaAno = int.Parse(Console.ReadLine());

			Console.Write("Digite o artilheiro do time: ");
			string entradaArtilheiro = Console.ReadLine();

			Console.Write("Digite o nome do tecnico do time: ");
			string entradaTecnico = Console.ReadLine();

			Console.Write("Digite as cores do time: ");
			string entradaCores = Console.ReadLine();

			Titulos novoTitulos = new Titulos(id: repositorio.ProximoId(),
										time: (Times)entradaTime,
										titulo: entradaTitulo,
										ano: entradaAno,
										tecnico: entradaTecnico,
										cores: entradaCores,
										artilheiro: entradaArtilheiro);


			repositorio.Insere(novoTitulos);
		}

        private static string ObterOpcaoUsuario()
		{
			Console.WriteLine();
			Console.WriteLine("DIO Títulos a seu dispor!!!");
			Console.WriteLine("Informe a opção desejada:");

			Console.WriteLine("1- Listar Clubes");
			Console.WriteLine("2- Inserir novos Clubes");
			Console.WriteLine("3- Atualizar Clubes");
			Console.WriteLine("4- Excluir ");
			Console.WriteLine("5- Visualizar Clubes");
			Console.WriteLine("C- Limpar Tela");
			Console.WriteLine("X- Sair");
			Console.WriteLine();

			string opcaoUsuario = Console.ReadLine().ToUpper();
			Console.WriteLine();
			return opcaoUsuario;
		}
    }
}

