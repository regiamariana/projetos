using System;
using Senaizinho_2_Tarde.enums;

namespace Senaizinho_2_Tarde {
    class Program {
    static void Main (string[] args) {
    int limiteAlunos = 3;
    int limiteSalas = 2;

    Aluno[] alunos = new Aluno[limiteAlunos];
    Sala[] salas = new Sala[limiteSalas];

    int alunosCadastrados = 0;
    int salasCadastradas = 0;

    bool querSair = false;
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

    System.Console.Write ("Código: ");
    int codigo = int.Parse (Console.ReadLine ());

    switch (codigo) {
    case 1:
    #region cadastrar_alunos 
    if (limiteAlunos != alunosCadastrados) {

    Aluno aluno = new Aluno ();

    System.Console.WriteLine ("Digite o nome do aluno");
    aluno.Nome = Console.ReadLine ();

    System.Console.WriteLine ("Digite a data de nascimento (dd/mm/aaaa)");
    aluno.DataNascimento = DateTime.Parse (Console.ReadLine ());

    System.Console.WriteLine ("Digite o nome do curso");
    aluno.Curso = Console.ReadLine ();

    alunos[alunosCadastrados] = aluno;

    alunosCadastrados++;

    MostrarMensagem ($"Cadastro de {aluno.GetType().Nome} feito com sucesso!", TipoMensagemEnum.SUCESSO);
    } else {
    MostrarMensagem ($"Total de alunos foi excedido!", TipoMensagemEnum.ALERTA);
                        }

                        break;
                        #endregion
                    case 2:
                        #region cadastrar_salas 
                        if (limiteSalas != salasCadastradas) {

                            System.Console.WriteLine ("Digite o número da sala");
                            sala.NumeroSala = int.Parse (Console.ReadLine ());

                            System.Console.WriteLine ("Digite a capacidade total");
                            sala.CapacidadeTotal = int.Parse (Console.ReadLine ());

                            Sala sala = new Sala (numeroSalaCadastrar , CapacidadeTotalCadastrar);

                            sala.CapacidadeAtual = sala.CapacidadeTotal;

                            sala.Alunos = new string[sala.CapacidadeTotal];

                            salas[salasCadastradas] = sala;

                            salasCadastradas++;

                            MostrarMensagem ($"Cadastro de {sala.GetType().Name} feito com sucesso!", TipoMensagemEnum.SUCESSO);
                        } else {
                            MostrarMensagem ($"Número de salas foi excedido!", TipoMensagemEnum.ALERTA);
                        }

                        break;
                        #endregion
                    case 3:
                        #region alocar_alunos
                        ValidarAlocarouRemover (alunosCadastrados, salasCadastradas);
                        System.Console.WriteLine ("Digite o nome do aluno");
                        string nomeAluno = Console.ReadLine ();
                        Aluno alunoRecuperado = ProcurarAlunoPorNome (nomeAluno, alunos);

                        if (alunoRecuperado == null) {
                            Console.ForegroundColor = ConsoleColor.Yellow;
                            System.Console.WriteLine ($"Aluno {nomeAluno} não encontrado!");
                            Console.ResetColor ();

                            System.Console.WriteLine ("Aperte ENTER para voltar ao menu");
                            Console.ReadLine ();
                            continue;
                        }

                        // Recupera o numero da sala
                        System.Console.WriteLine ("Digite o número da sala");
                        int numeroSala = int.Parse (Console.ReadLine ());

                        // Busca pela Sala correta
                        Sala salaRecuperada = null;
                        foreach (Sala item in salas) {
                            if (item != null && numeroSala.Equals (item.numeroSala)) {
                                salaRecuperada = item;
                                break;
                            }
                        }

                        if (salaRecuperada == null) {
                            Console.ForegroundColor = ConsoleColor.Yellow;
                            System.Console.WriteLine ($"Sala {numeroSala} não encontrada!");
                            Console.ResetColor ();

                            System.Console.WriteLine ("Aperte ENTER para voltar ao menu");
                            Console.ReadLine ();
                            continue;

                        }

                        Console.ForegroundColor = ConsoleColor.Blue;
                        System.Console.WriteLine (salaRecuperada.AlocarAluno (alunoRecuperado.nome));
                        Console.ResetColor ();

                        System.Console.WriteLine ("Aperte ENTER para voltar ao menu");
                        Console.ReadLine ();

                        break;
                        #endregion
                    case 4:
                        #region remover_aluno
                        ValidarAlocarouRemover (alunosCadastrados, salasCadastradas);

                        System.Console.WriteLine ("Digite o nome do aluno");
                        string nomeAlunoRemover = Console.ReadLine ();

                        Aluno alunoRemover = null;

                        foreach (Aluno item in alunos) {
                            if (item != null && nomeAlunoRemover.Equals (item.nome)) {
                                alunoRemover = item;
                                break;
                            }
                        }

                        if (alunoRemover == null) {
                            Console.ForegroundColor = ConsoleColor.Yellow;
                            System.Console.WriteLine ($"Aluno {nomeAlunoRemover} não encontrado!");
                            Console.ResetColor ();

                            System.Console.WriteLine ("Aperte ENTER para voltar ao menu");
                            Console.ReadLine ();
                            continue;
                        }

                        // Recupera o numero da sala
                        System.Console.WriteLine ("Digite o número da sala");
                        int numeroSalaRemover = int.Parse (Console.ReadLine ());

                        // Busca pela Sala correta
                        Sala salaRemover = null;
                        foreach (Sala item in salas) {
                            if (item != null && numeroSalaRemover.Equals (item.numeroSala)) {
                                salaRemover = item;
                                break;
                            }
                        }

                        if (salaRemover == null) {
                            Console.ForegroundColor = ConsoleColor.Yellow;
                            System.Console.WriteLine ($"Sala {numeroSalaRemover} não encontrada!");
                            Console.ResetColor ();

                            System.Console.WriteLine ("Aperte ENTER para voltar ao menu");
                            Console.ReadLine ();
                            continue;

                        }

                        Console.ForegroundColor = ConsoleColor.Blue;
                        System.Console.WriteLine (salaRemover.RemoverAluno (alunoRemover.nome));
                        Console.ResetColor ();

                        System.Console.WriteLine ("Aperte ENTER para voltar ao menu");
                        Console.ReadLine ();
                        break;
                        #endregion
                    case 5:
                        #region verificar_salas
                        foreach (var item in salas) {
                            if (item != null) {
                                System.Console.WriteLine ("-----------------------------------------------------");
                                System.Console.WriteLine ($"Número da sala: {item.numeroSala}");
                                System.Console.WriteLine ($"Vagas disponíveis: {item.capacidadeAtual}");
                                System.Console.WriteLine ($"Alunos: {item.ExibirAlunos()}");
                                System.Console.WriteLine ("-----------------------------------------------------");
                            }
                        }

                        System.Console.WriteLine ("Aperte ENTER para voltar ao menu principal");
                        Console.ReadLine ();
                        break;
                        #endregion
                    case 6:
                        #region verificar_alunos
                        foreach (var item in alunos) {
                            if (item != null) {
                                System.Console.WriteLine ("-----------------------------------------------------");
                                System.Console.WriteLine ($"Nome do aluno: {item.nome}");
                                System.Console.WriteLine ($"Curso: {item.curso}");
                                System.Console.WriteLine ("-----------------------------------------------------");
                            }
                        }
                        System.Console.WriteLine ("Aperte ENTER para voltar ao menu principal");
                        Console.ReadLine ();

                        break;
                        #endregion

                }

            } while (!querSair);
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

            System.Console.WriteLine (mensagem);
            Console.ResetColor ();

            System.Console.WriteLine ("Aperte ENTER para voltar ao menu");
            Console.ReadLine ();
        }

        static bool ValidarAlocarouRemover (int alunosCadastrados, int salasCadastradas) {
            if (alunosCadastrados == 0) {
                MostrarMensagem ("nenhum aluno cadastrado", TipoMensagemEnum.ALERTA);
                return false;

            } else if (salasCadastradas == 0) {
                MostrarMensagem ("nenhum sala cadastrad", TipoMensagemEnum.ALERTA);
                return false;
            }
            return true;
        }

        static Aluno ProcurarAlunoPorNome (string nomeAluno, Aluno[] alunos) {
            foreach (Aluno item in alunos) {
                if (item != null && nomeAluno.Equals (item.Nome)) {
                    return item;

                }
            }
            return null;
        }

    }
}