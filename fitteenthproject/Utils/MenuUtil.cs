using System;
namespace fitteenthproject.Utils
{
    public class MenuUtil
    {
        public static void MenuDeslogado(){
           Console.WriteLine("--------------------------------------------");
           Console.WriteLine("-------------      KanBan     --------------");
           Console.WriteLine("-----------      Cadastro      -------------");
           Console.WriteLine("--------------------------------------------");
           Console.WriteLine("           (1) Cadastrar usuário            ");
           Console.WriteLine("           (2) Login                        ");
           Console.WriteLine("           (3) listar usuários              ");
           Console.WriteLine("--------------------------------------------");
           Console.WriteLine("           (0) sair                         ");
           Console.WriteLine("--------------------------------------------");
           Console.WriteLine("           Escolha uma opção                ");

        }
    }
}