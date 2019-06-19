using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace projPilha1_Transporte_nTktTna
{
    class Program
    {
        #region atributos

        static Garagens garagens;
        static Veiculos frota;
        static Viagens viagens;
        static int opcao;
        #endregion

        static void Main(string[] args)
        {
            garagens = new Garagens();
            frota = new Veiculos();
            viagens = new Viagens();

            // Criando e instanciando as classes
            carregamentoInicial();

            // Menu
            construaOMenu();
        }


        #region funções

        static void carregamentoInicial() {
            Garagem congonhas = new Garagem("Congonhas - CGH");
            Garagem guarulhos = new Garagem("Guarulhosx - GRU");
            garagens.incluirGaragem(congonhas);
            garagens.incluirGaragem(guarulhos);
            Veiculo van1 = new Veiculo("CBT-0001", 8);
            Veiculo van2 = new Veiculo("CBT-0002", 8);
            Veiculo van3 = new Veiculo("CBT-0003", 8);
            Veiculo van4 = new Veiculo("CBT-0004", 8);
            Veiculo van5 = new Veiculo("CBT-0005", 8);
            Veiculo van6 = new Veiculo("CBT-0006", 8);
            Veiculo van7 = new Veiculo("CBT-0007", 8);
            Veiculo van8 = new Veiculo("CBT-0008", 8);
            frota.cadastrarVeiculo(van1);
            frota.cadastrarVeiculo(van2);
            frota.cadastrarVeiculo(van3);
            frota.cadastrarVeiculo(van4);
            frota.cadastrarVeiculo(van5);
            frota.cadastrarVeiculo(van6);
            frota.cadastrarVeiculo(van7);
            frota.cadastrarVeiculo(van8);
        }

        static void construaOMenu() {

            do
            {
                Console.Clear();
                Console.SetCursorPosition(15, 5); Console.Write("------------------------------------------------ MENU --------------------------------------------------");
                Console.SetCursorPosition(15, 6); Console.Write("1 - Cadastrar veículo ");
                Console.SetCursorPosition(15, 7); Console.Write("2 - Cadastrar garagem");
                Console.SetCursorPosition(15, 8); Console.Write("3 - Iniciar jornada ");
                Console.SetCursorPosition(15, 9); Console.Write("4 - Encerrar jornada");
                Console.SetCursorPosition(15, 10); Console.Write("5 - Liberar viagem de uma determinada origem para um determinado destino ");
                Console.SetCursorPosition(15, 11); Console.Write("6 - Listar veículos em determinada garagem (informando a qtde de veículos e seu potencial de transporte)");
                Console.SetCursorPosition(15, 12); Console.Write("7 - Informar qtde de viagens efetuadas de uma determinada origem para um determinado destino");
                Console.SetCursorPosition(15, 13); Console.Write("8 - Listar viagens efetuadas de uma determinada origem para um determinado destino");
                Console.SetCursorPosition(15, 14); Console.Write("9 - Informar qtde de passageiros transportados de uma determinada origem para um determinado destino");
                Console.SetCursorPosition(15, 15); Console.Write("0 - Sair");
                Console.SetCursorPosition(15, 16); Console.Write("-------------------------------------------------------------------------------------------------------");
                Console.SetCursorPosition(15, 18); Console.Write("-------------------------------------------------------------------------------------------------------");
                Console.SetCursorPosition(15, 17); Console.Write("Digite a opção desejada: ");

                try
                {
                    opcao = int.Parse(Console.ReadLine());
                    if (opcao > 9)
                    {
                        Console.Clear();
                        Console.SetCursorPosition(15, 9); Console.Write("-------------------------------------------------------------------------------------------------------");
                        Console.SetCursorPosition(15, 11); Console.Write("-------------------------------------------------------------------------------------------------------");
                        Console.SetCursorPosition(15, 10); Console.Write("                     Opção inválida, escolha um número entre 0 e 9");
                        Console.ReadKey();
                    }
                }
                catch
                {
                    Console.Clear();
                    Console.SetCursorPosition(15, 9); Console.Write("-------------------------------------------------------------------------------------------------------");
                    Console.SetCursorPosition(15, 11); Console.Write("-------------------------------------------------------------------------------------------------------");
                    Console.SetCursorPosition(15, 10); Console.Write("                     Opção inválida, escolha um número entre 0 e 9");
                    Console.ReadKey();
                    continue;
                }
                                
                switch (opcao)
                {
                    case 1: cadastraVeiculo(); break;
                    case 2: cadastrarGaragem(); break;
                    case 3: iniciarJornada(); break;
                    case 4: encerrarJornada(); break;
                    case 5: liberarViagem(); break;
                    case 6: listarVeicPorGaragem(); break;
                    case 7: informarQuantViagens(); break;
                    case 8: listarViagens(); break;
                    case 9: informarQuantPassageiros(); break;
                }
            } while (opcao != 0);
        }

        // 1. Cadastrar veículo
        // Cadastros de novos veículos e novas garagens só podem ser realizados com a jornada diária encerrada.
        static void cadastraVeiculo() {
            if (!garagens.JornadaAtiva)
            {
                string placa;
                int lotacao;

                Console.Clear();
                Console.SetCursorPosition(15, 10); Console.Write("----------------------------------------CADASTRAR VEICULOS---------------------------------------------");
                Console.SetCursorPosition(15, 13); Console.Write("-------------------------------------------------------------------------------------------------------");
                Console.SetCursorPosition(15, 11); Console.Write("Digite a placa: ");
                placa = Console.ReadLine();
                Console.SetCursorPosition(12, 12); lotacao = recebeInt("Informe a lotação: ");
                frota.cadastrarVeiculo(new Veiculo(placa, lotacao));
            }
            else
            {
                Console.Clear();
                Console.SetCursorPosition(15, 11); Console.Write("-------------------------------------------------------------------------------------------------------");
                Console.SetCursorPosition(15, 13); Console.Write("-------------------------------------------------------------------------------------------------------");
                Console.SetCursorPosition(15, 12); Console.Write("                                     Jornada já foi iniciada");
            }
            Console.ReadKey();
        }

        // 2. Cadastrar garagem
        // Cadastros de novos veículos e novas garagens só podem ser realizados com a jornada diária encerrada.
        static void cadastrarGaragem() {
            if (!garagens.JornadaAtiva)
            {
                int opc;
                Console.Clear();
                Console.SetCursorPosition(15, 10); Console.Write("----------------------------------------CADASTRAR GARAGEM----------------------------------------------");
                Console.SetCursorPosition(15, 12); Console.Write("-------------------------------------------------------------------------------------------------------");
                Console.SetCursorPosition(15, 14); Console.Write("-------------------------------------------------------------------------------------------------------");
                Console.SetCursorPosition(15, 11); Console.Write("Informe o nome da garagem: ");
                string nomeGaragem = Console.ReadLine();
                Console.SetCursorPosition(15, 13); Console.Write("Você inseriu a garagem " + nomeGaragem + ", confirmar?");
                Console.SetCursorPosition(15, 17); Console.Write("1 - Sim | 2 - Não --> ");
                opc = int.Parse(Console.ReadLine());
                try
                {
                    if (opc > 2)
                    {
                        Console.Clear();
                        Console.SetCursorPosition(15, 9); Console.Write("-------------------------------------------------------------------------------------------------------");
                        Console.SetCursorPosition(15, 11); Console.Write("-------------------------------------------------------------------------------------------------------");
                        Console.SetCursorPosition(15, 10); Console.Write("                     Opção inválida, escolha 1 para sim ou 2 para não");
                        opc = int.Parse(Console.ReadLine());
                    }
                }
                catch
                {
                    Console.Clear();
                    Console.Clear();
                    Console.SetCursorPosition(15, 9); Console.Write("-------------------------------------------------------------------------------------------------------");
                    Console.SetCursorPosition(15, 11); Console.Write("-------------------------------------------------------------------------------------------------------");
                    Console.SetCursorPosition(15, 10); Console.Write("                     Opção inválida, escolha 1 para sim ou 2 para não");
                    opc = int.Parse(Console.ReadLine());
                }
                switch (opc) {
                    case 1:
                        try {
                            Garagem garagem = new Garagem(nomeGaragem);
                            garagens.incluirGaragem(garagem);
                            Console.Clear();
                            Console.SetCursorPosition(15, 11); Console.Write("-------------------------------------------------------------------------------------------------------");
                            Console.SetCursorPosition(15, 13); Console.Write("-------------------------------------------------------------------------------------------------------");
                            Console.SetCursorPosition(15, 12); Console.Write("                                   Garagem adicionada com sucesso!");
                            Console.ReadKey();
                            construaOMenu();
                        }
                        catch {

                        }
                    break;
                    case 2: Console.Clear(); break;
                }
                Console.ReadKey();
                
            }
            else
            {
                Console.Clear();
                Console.SetCursorPosition(15, 11); Console.Write("-------------------------------------------------------------------------------------------------------");
                Console.SetCursorPosition(15, 13); Console.Write("-------------------------------------------------------------------------------------------------------");
                Console.SetCursorPosition(15, 12); Console.Write("                                      Jornada já foi iniciada");
                Console.ReadKey();
            }
            Console.ReadKey();
        }

        // 3. Iniciar jornada
        // Todo início de jornada diária, os veículos são alternadamente distribuídos entre os destinos (garagens).
        static void iniciarJornada() {

            if (!garagens.JornadaAtiva)
            {
                garagens.inciarJornada(frota.ListDeVeiculos);
                Console.Clear();
                Console.SetCursorPosition(15, 11); Console.Write("-------------------------------------------------------------------------------------------------------");
                Console.SetCursorPosition(15, 13); Console.Write("-------------------------------------------------------------------------------------------------------");
                Console.SetCursorPosition(15, 12); Console.Write("                                   Jornada iniciada com sucesso!");
            }
            else {
                Console.Clear();
                Console.SetCursorPosition(15, 11); Console.Write("-------------------------------------------------------------------------------------------------------");
                Console.SetCursorPosition(15, 13); Console.Write("-------------------------------------------------------------------------------------------------------");
                Console.SetCursorPosition(15, 12); Console.Write("                                    Jornada já foi iniciada");
            }
            Console.ReadKey();
        }

        // 4. Encerrar jornada
        // O encerramento da jornada consiste na geração de uma lista informando, veículo a veículo, a quantidade
        // de passageiros transportados com a "limpeza" das ocorrências das viagens anteriores.
        static void encerrarJornada() {

            garagens.encerrarJornada();
            foreach (Veiculo veiculo in frota.ListDeVeiculos)
            {
                foreach (Viagem viagem in viagens.ListaDeViagens)
                {
                    Console.Clear();
                    Console.WriteLine("-------------------------------------------------------------------------------------------------------");
                    Console.WriteLine("                                   Encerramento de Frota");
                    Console.WriteLine("-------------------------------------------------------------------------------------------------------");
                    if (viagem.Veiculo.Equals(veiculo))
                    {
                        Console.Write("Veiculo: "+veiculo.Id + ". " + " Placa: " + veiculo.Placa + " Transportados: " + veiculo.Lotacao + " Origem: "+ viagem.Origem.Local+" Destino "+viagem.Destino.Local);
                    }
                    Console.WriteLine("-------------------------------------------------------------------------------------------------------");
                }
            }
            frota = new Veiculos();

            Console.WriteLine("                                            Fim da Jornada!");
            Console.WriteLine("-------------------------------------------------------------------------------------------------------");
            Console.ReadKey();

        }

        // 5. Liberar viagem de uma determinada origem para um determinado destino
        // Uma viagem só pode ser liberada quando a jornada diária foi iniciada.
        // 
        // Sempre que a lotação de um carro está completa, este sai em direção ao destino e, lá chegando, é
        // estacionado na garagem.
        //
        //Quando um estacionamento fica vazio, uma nova viagem só pode ser iniciada desta origem quando um
        //veículo retornar à garagem.
        static void liberarViagem() {
            int idOrigem, idDestino;
           
            Veiculo veiculo;
            Garagem garOrigem = null, garDestino = null;


            if (garagens.JornadaAtiva)
            {
                Console.Clear();
                Console.SetCursorPosition(15, 8); Console.Write("-------------------------------------------------------------------------------------------------------");
                mostreGaragens();
                // recolhe do teclado o id e armazena
                Console.SetCursorPosition(15, 9); Console.Write("Digite o ID origem: ");
                idOrigem = int.Parse(Console.ReadLine());
                // faz o mesmo com o destino
                Console.SetCursorPosition(15, 10); Console.Write("Digite o ID destino: ");
                idDestino = int.Parse(Console.ReadLine());
                // quantos passageiros: 
                foreach (Garagem garagem in garagens.ListaDeGaragens)
                {
                    if (garagem.Id == idOrigem)
                        garOrigem = garagem;
                    if (garagem.Id == idDestino)
                        garDestino = garagem;
                }
                if(garOrigem == null && garDestino == null)
                {
                    Console.Clear();
                    Console.SetCursorPosition(15, 11); Console.Write("-------------------------------------------------------------------------------------------------------");
                    Console.SetCursorPosition(15, 13); Console.Write("-------------------------------------------------------------------------------------------------------");
                    Console.SetCursorPosition(15, 12); Console.Write("                                   Origem ou Destino não existem");
                    Console.ReadKey();
                }
                else if (garOrigem.Id== garDestino.Id)
                {
                    Console.Clear();
                    Console.SetCursorPosition(15, 11); Console.Write("-------------------------------------------------------------------------------------------------------");
                    Console.SetCursorPosition(15, 13); Console.Write("-------------------------------------------------------------------------------------------------------");
                    Console.SetCursorPosition(15, 12); Console.Write("                                      Origem igual destino");
                    Console.ReadKey();
                }
                else if (garOrigem.PilhaVeiculos.Count() != 0)
                {
                    veiculo = garOrigem.PilhaVeiculos.Pop();
                    garDestino.PilhaVeiculos.Push(veiculo);
                    Viagem viagem = new Viagem(veiculo, garOrigem, garDestino);
                    Transporte tranporte = new Transporte(veiculo, veiculo.Lotacao);
                    Console.Clear();
                    Console.SetCursorPosition(15, 11); Console.Write("-------------------------------------------------------------------------------------------------------");
                    Console.SetCursorPosition(15, 13); Console.Write("-------------------------------------------------------------------------------------------------------");
                    Console.SetCursorPosition(15, 12); Console.Write("                                  Viagem iniciada com sucesso!");
                    Console.ReadKey();
                    //incluir viagem na lista
                    viagens.incluirViagem(viagem);
                }
                else
                {
                    Console.Clear();
                    Console.SetCursorPosition(15, 11); Console.Write("-------------------------------------------------------------------------------------------------------");
                    Console.SetCursorPosition(15, 13); Console.Write("-------------------------------------------------------------------------------------------------------");
                    Console.SetCursorPosition(15, 12); Console.Write("                                         Garagem vazia");
                    Console.ReadKey();
                }
            }
            else
            {
                Console.Clear();
                Console.SetCursorPosition(15, 11); Console.Write("-------------------------------------------------------------------------------------------------------");
                Console.SetCursorPosition(15, 13); Console.Write("-------------------------------------------------------------------------------------------------------");
                Console.SetCursorPosition(15, 12); Console.Write("                                    Jornada ainda não foi iniciada");
                Console.ReadKey();
            }
            Console.ReadKey();
        }

        // 6. Listar veículos em determinada garagem (informando a qtde de veículos e seu potencial de transporte)
        static void listarVeicPorGaragem() {
            int idGaragem;

            if (garagens.JornadaAtiva)
            {
                mostreGaragens();
                Console.Clear();
                Console.WriteLine("-------------------------------------------------------------------------------------------------------");
                Console.WriteLine("Qual o ID da Garagem: ");
                idGaragem = int.Parse(Console.ReadLine());
                Console.WriteLine("-------------------------------------------------------------------------------------------------------");

                foreach (Garagem g in garagens.ListaDeGaragens)
                {
                    if (g.Id == idGaragem) {
                        Console.WriteLine("Garagem: " + g.Local);
                        Console.WriteLine("Potencial de transporte: " + g.potencialDeTransporte());
                        foreach (Veiculo v in g.PilhaVeiculos)
                        {
                            Console.WriteLine("Veículo id: " + v.Id + " - Lotação: " + v.Lotacao);
                        }
                        Console.WriteLine("-------------------------------------------------------------------------------------------------------");
                    }
                }
            }
            else
            {
                Console.Clear();
                Console.SetCursorPosition(15, 11); Console.Write("-------------------------------------------------------------------------------------------------------");
                Console.SetCursorPosition(15, 13); Console.Write("-------------------------------------------------------------------------------------------------------");
                Console.SetCursorPosition(15, 12); Console.Write("                                    Jornada ainda não foi iniciada");
            }
            Console.ReadKey();
        }

        // 7. Informar qtde de viagens efetuadas de uma determinada origem para um determinado destino
        static void informarQuantViagens() {
            int idOrigem,idDestino, contViagem = 0;
            if (garagens.JornadaAtiva)
            {
                mostreGaragens();

                // recolhe do teclado o id e armazena
                Console.Clear();
                Console.WriteLine("-------------------------------------------------------------------------------------------------------");
                Console.WriteLine("Digite o ID origem: ");
                idOrigem = int.Parse(Console.ReadLine());
                // faz o mesmo com o destino
                Console.WriteLine("Digite o ID destino: ");
                idDestino = int.Parse(Console.ReadLine());
                Console.WriteLine("-------------------------------------------------------------------------------------------------------");

                if (viagens.ListaDeViagens.Count != 0)
                {
                    foreach (Viagem viagem in viagens.ListaDeViagens)
                    {
                        if (viagem.Origem.Id == idOrigem && viagem.Destino.Id == idDestino)
                            ++contViagem;
                    }
                    Console.Clear();
                    Console.SetCursorPosition(15, 11); Console.Write("-------------------------------------------------------------------------------------------------------");
                    Console.SetCursorPosition(15, 13); Console.Write("-------------------------------------------------------------------------------------------------------");
                    Console.SetCursorPosition(15, 12); Console.Write("                     Esse trecho possui " + contViagem + " viagen(s) feita(s)");
                    Console.ReadKey();
                }
                if (contViagem == 0)
                {
                    Console.Clear();
                    Console.SetCursorPosition(15, 11); Console.Write("-------------------------------------------------------------------------------------------------------");
                    Console.SetCursorPosition(15, 13); Console.Write("-------------------------------------------------------------------------------------------------------");
                    Console.SetCursorPosition(15, 12); Console.Write("                           Esse trecho ainda não possui viagens feitas");
                    Console.ReadKey();
                }
            }
            else
            {
                Console.Clear();
                Console.SetCursorPosition(15, 11); Console.Write("-------------------------------------------------------------------------------------------------------");
                Console.SetCursorPosition(15, 13); Console.Write("-------------------------------------------------------------------------------------------------------");
                Console.SetCursorPosition(15, 12); Console.Write("                                    Jornada ainda não foi iniciada");
            }
            Console.ReadKey();

        }

        // 8. Listar viagens efetuadas de uma determinada origem para um determinado destino
        static void listarViagens() {
            int idOrigem, idDestino;

            if (garagens.JornadaAtiva)
            {
                mostreGaragens();
                // recolhe do teclado o id e armazena
                Console.Clear();
                Console.WriteLine("-------------------------------------------------------------------------------------------------------");
                Console.WriteLine("Digite o ID origem: ");
                idOrigem = int.Parse(Console.ReadLine());
                // faz o mesmo com o destino
                Console.WriteLine("Digite o ID destino: ");
                idDestino = int.Parse(Console.ReadLine());
                Console.WriteLine("-------------------------------------------------------------------------------------------------------");
                if (viagens.ListaDeViagens.Count != 0 && idDestino != idOrigem)
                {
                    foreach (Viagem viagem in viagens.ListaDeViagens)
                    {
                        if (viagem.Origem.Id == idOrigem && viagem.Destino.Id == idDestino)
                            Console.WriteLine("Lista de viagens:");
                            Console.WriteLine("Viagem nº: " + viagem.Id +". Origem: "+ viagem.Origem.Local +" Destino: "+ viagem.Destino.Local);
                    }
                }
                else
                {
                    Console.Clear();
                    Console.SetCursorPosition(15, 11); Console.Write("-------------------------------------------------------------------------------------------------------");
                    Console.SetCursorPosition(15, 13); Console.Write("-------------------------------------------------------------------------------------------------------");
                    Console.SetCursorPosition(15, 12); Console.Write("                           Esse trecho ainda não possui viagens feitas");
                    Console.ReadKey();
                }
            }
            else
            {
                Console.Clear();
                Console.SetCursorPosition(15, 11); Console.Write("-------------------------------------------------------------------------------------------------------");
                Console.SetCursorPosition(15, 13); Console.Write("-------------------------------------------------------------------------------------------------------");
                Console.SetCursorPosition(15, 12); Console.Write("                                    Jornada ainda não foi iniciada");
            }
            Console.ReadKey();
        }

        // 9. Informar qtde de passageiros transportados de uma determinada origem para um determinado destino
        static void informarQuantPassageiros() {
            int idOrigem, idDestino, quantidade = 0;

            if (garagens.JornadaAtiva)
            {
                mostreGaragens();
                // recolhe do teclado o id e armazena
                Console.Clear();
                Console.WriteLine("-------------------------------------------------------------------------------------------------------");
                Console.WriteLine("Digite o ID origem: ");
                idOrigem = int.Parse(Console.ReadLine());
                // faz o mesmo com o destino
                Console.WriteLine("Digite o ID destino: ");
                idDestino = int.Parse(Console.ReadLine());
                Console.WriteLine("-------------------------------------------------------------------------------------------------------");
                if (viagens.ListaDeViagens.Count != 0)
                {
                    foreach (Viagem viagem in viagens.ListaDeViagens)
                    {
                        if (viagem.Origem.Id == idOrigem && viagem.Destino.Id == idDestino)
                            quantidade += viagem.Veiculo.Lotacao;
                    }
                    Console.WriteLine("Esse trecho possui " + quantidade + " passageiros transportados");
                }
                else
                {
                    Console.Clear();
                    Console.SetCursorPosition(15, 11); Console.Write("-------------------------------------------------------------------------------------------------------");
                    Console.SetCursorPosition(15, 13); Console.Write("-------------------------------------------------------------------------------------------------------");
                    Console.SetCursorPosition(15, 12); Console.Write("                           Esse trecho ainda não possui viagens feitas");
                    Console.ReadKey();
                }
            }
            else
            {
                Console.Clear();
                Console.SetCursorPosition(15, 11); Console.Write("-------------------------------------------------------------------------------------------------------");
                Console.SetCursorPosition(15, 13); Console.Write("-------------------------------------------------------------------------------------------------------");
                Console.SetCursorPosition(15, 12); Console.Write("                                    Jornada ainda não foi iniciada");
            }
            Console.ReadKey();
        }
        #endregion

        #region métodos para entrada e saída de dados via teclado

        static public int recebeInt(String str) {
            try
            {
                Console.Write(str);
                return int.Parse(Console.ReadLine());
            }
            catch
            {
                Console.SetCursorPosition(15, 11); Console.Write("-------------------------------------------------------------------------------------------------------");
                Console.SetCursorPosition(15, 13); Console.Write("-------------------------------------------------------------------------------------------------------");
                Console.SetCursorPosition(15, 13); Console.Write("Digite um número inteiro: ");
                return recebeInt(str);
            }
        }

        static public void print(string arg) {
            Console.Write("   " + arg);
        }

        static public void println(string arg) {
            Console.WriteLine("   " + arg);
        }

        static void mostreGaragens()
        {
            Console.WriteLine("-------------------------------------------------------------------------------------------------------");
            Console.WriteLine("                                 Origens e destinos possíveis: ");
            Console.WriteLine("-------------------------------------------------------------------------------------------------------");
            Console.WriteLine("ID  |  GARAGEM");

            foreach (Garagem g in garagens.ListaDeGaragens)
            {
                Console.WriteLine(g.Id + ". " + g.Local);
            }
            Console.WriteLine("-------------------------------------------------------------------------------------------------------");
        }
        #endregion

    }
}
