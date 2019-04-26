using System;

namespace PAXTEU
{
    class Program
    {
        static void Main(string[] args)
        {
            UsuarioViewModel usuario = new UsuarioViewModel();
            usuario.Id = 1;
            usuario.Nome = "Carlos";
            usuario.Datacriacao = DateTime.Now;
            ProdutoViewModel produto = new ProdutoViewModel();
            produto.id = 1;
            produto.Nome = "Paxtel de flango";
        }
    }
}
