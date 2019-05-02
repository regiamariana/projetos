using System;
using fitteenthproject.Utils;

namespace fitteenthproject {
    class Program {
        static void Main (string[] args) {
            int opcaoDeslogado = 0;
            do {

                MenuUtil.MenuDeslogado ();
                opcaoDeslogado = int.Parse (Console.ReadLine ());

                switch (opcaoDeslogado) {
                    case 1:
                    
                        break;

                    case 2:
                        //Efetuar login

                        break;

                    case 3:
                        //listar usuarios

                        break;

                    case 0:

                        break;

                    default:
                        System.Console.WriteLine ("Opção inválida");
                        break;
                }
            }while();
        }
        }
    }
