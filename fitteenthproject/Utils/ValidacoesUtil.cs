namespace fitteenthproject.Utils
{
    public class ValidacoesUtil
    {
        public static bool ValidadorDeEmail (string email){
            if (email.Contains("@") && email.Contains(".") && email.Length>5)
            {
                return true;
            }
            return false;
        }
        public static bool ValidadorDeSenha(string senha, string confirmaSenha){
            if (senha.Equals(confirmaSenha) && senha.Length >5)
            {
                return true;
            }
            return false;
        }
    }
}