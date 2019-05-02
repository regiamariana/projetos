using System;
using fitteenthproject.Utils;

namespace fitteenthproject.ViewController {
    public class UsuarioViewController {
        public static void CadastrarUsuario () {
            string nome, email, senha, confirmaSenha;
            do
            {
                do {
                System.Console.WriteLine ("Digite o nome do usuário");
                nome = Console.ReadLine ();

                if (string.IsNullOrEmpty (nome)) {
                    System.Console.WriteLine ("Nome Inválido");
                }
            } while (string.IsNullOrEmpty (nome));
            do {
                System.Console.WriteLine ("Digite o e-mail");
                email = Console.ReadLine ();

                if (!ValidacoesUtil.ValidadorDeEmail (email)) {
                    System.Console.WriteLine ("Email inválido");
                }

            } while (!ValidacoesUtil.ValidadorDeEmail (email));
            } while (true);
        }
    }
}