using System;
namespace ExCorrecaoSala {
    class Program {
        static void Main (string[] args) {

            Aluno[] alunos = new Aluno[4];
            Sala[] salas = new Sala[1];
            bool sair = false;
            int contadorAluno = 0, contadorSala = 0;
            do {
                Console.Clear ();
                System.Console.WriteLine ("===================================");
                Console.ForegroundColor = ConsoleColor.DarkRed;
                System.Console.WriteLine ("        *** SENAIzinho ***         ");
                Console.ResetColor ();
                System.Console.WriteLine ("         Seja bem-vindo(a)         ");
                System.Console.WriteLine ("===================================");
                System.Console.WriteLine ("|| Digite sua opção:             ||");
                System.Console.WriteLine ("||  1 - Cadastrar Aluno          ||");
                System.Console.WriteLine ("||  2 - Cadastrar Sala           ||");
                System.Console.WriteLine ("||  3 - Alocar Aluno             ||");
                System.Console.WriteLine ("||  4 - Remover Aluno            ||");
                System.Console.WriteLine ("||  5 - Verificar Salas          ||");
                System.Console.WriteLine ("||  6 - Verificar Alunos         ||");
                System.Console.WriteLine ("||  0 - Sair                     ||");
                System.Console.WriteLine ("===================================");
                System.Console.WriteLine ("Escolha uma opção");

                int codigo = int.Parse (Console.ReadLine ());

                switch (codigo) {
                    case 1:
                        //cadastrar aluno
                        if (contadorAluno < 4) {
                            Aluno a = new Aluno ();
                            Console.WriteLine ("Digite o nome do aluno:");
                            a.Nome = Console.ReadLine ();
                            Console.WriteLine ("Digite a Data de Nascimento:");
                            a.DataNascimento = DateTime.Parse (Console.ReadLine ());
                            Console.WriteLine ("Digite o nome do Curso:");
                            a.Curso = Console.ReadLine ();
                            Console.WriteLine ("Digite o numero da sala");
                            a.NumeroSala = int.Parse (Console.ReadLine ());
                            alunos[contadorAluno] = a;
                            contadorAluno++;

                           MostrarMensagem($"cadastro de {aluno.GetType().Name} feito com sucesso", TipoMensagemEnum.SUCESSO);
                        } else {
                             MostrarMensagem("total de alunos excedido", TipoMensagemEnum.ALERTA);
                        }
                        break;

                    case 2:
                        //cadastrar sala

                        if (contadorSala < 1) {
                            Sala s = new Sala ();
                            Console.WriteLine ("Digite o número da sala:");
                            s.NumeroSala = int.Parse (Console.ReadLine ());
                            Console.WriteLine ("Digite a capacidade total:");
                            s.CapacidadeTotal = int.Parse (Console.ReadLine ());
                            s.CapacidadeAtual = s.CapacidadeTotal;
                            s.Alunos = new string[s.CapacidadeTotal];
                            salas[contadorSala] = s;
                            contadorSala++;
                             MostrarMensagem($"cadastro de {sala.GetType().Name} feito com sucesso", TipoMensagemEnum.SUCESSO);
                          
                        }else{
                             MostrarMensagem("total de salas excedido", TipoMensagemEnum.ALERTA);
                        }
                        break;

                    case 3:
                        if(alunosCadastrados == 0){
                            MostrarMensagem
                        }
                    break;

                    case 5:
                        //Listar salas
                        foreach (var item in salas) {
                            if (item != null) {

                                Console.WriteLine ("----------------");
                                Console.WriteLine ($"Número da sala {item.NumeroSala}");
                                Console.WriteLine ($"Vagas Disponíveis {item.CapacidadeAtual}");
                                Console.WriteLine ("----------------");
                            } //fim if

                        } //fim foreach
                        Console.WriteLine ("Aperte entre para continuar");
                        Console.ReadLine ();
                        break;

                    case 6:
                        foreach (var item in alunos) {
                            if (item != null) {
                                Console.WriteLine ("----------------");
                                Console.WriteLine ($"Nome do aluno: {item.Nome}");
                                Console.WriteLine ($"Curso: {item.Curso}");
                                Console.WriteLine ("----------------");
                            }

                        }
                        Console.WriteLine ("Aperte entre para continuar");
                        Console.ReadLine ();
                        break;
                    default:

                        break;
                }

            } while (!sair);
        }

        static void MostrarMensagem (string mensagem, TipoMensagemEnum tipoMensagem) {
            switch (tipoMensagem) {
                    case TipoMensagemEnum.SUCESSO:
                        Console.ForegroundColor = ConsoleColor.Green;
                        break;

                        case TipoMensagemEnum.ERRO:
                        Console.ForegroundColor = ConsoleColor.Red;
                        break;

                        case TipoMensagemEnum.ALERTA:
                        Console.ForegroundColor = ConsoleColor.Yellow;
                        break;

                        case TipoMensagemEnum.DESTAQUE:
                        Console.ForegroundColor = ConsoleColor.Blue;
                        break;
            }
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine ("Cadastro efetuado com sucesso");
            Console.ResetColor ();

            System.Console.WriteLine("aperte enter p/ voltar ao menu");
            Console.ReadLine();
            

        }