﻿using System;
using Senai.PastelStore.MVC.Utils;
using Senai.PastelStore.MVC.ViewController;
using Senai.PastelStore.MVC.ViewModel;

namespace Senai.PastelStore.MVC
{
    class Program
    {
        static void Main(string[] args)
        {
            /* UsuarioViewModel usuario = new UsuarioViewModel();
            usuario.Id = 1;
            usuario.Nome = "Carlos";
            usuario.DataCriacao = DateTime.Now;

            ProdutoViewModel produto = new ProdutoViewModel();
            produto.Id = 1;
            produto.Nome = "Paxtel de Flango";*/
            int opcaoDeslogado = 0;
            do{

                MenuUtil.MenuDeslogado();
                opcaoDeslogado = int.Parse(Console.ReadLine());

                switch (opcaoDeslogado)
                {
                    case 1:
                    UsuarioViewController.CadastrarUsuario();
                    break;

                    case 2:
                    //Efetuar login
                    UsuarioViewModel usuarioRtornado = UsuarioViewController.EfetuarLogin();
                    System.Console.WriteLine($"seja bem vindo {usuarioRtornado.Nome}");
                    break;

                    case 3:
                    //listar usuarios
                    UsuarioViewController.ListarUsuario();
                    break;

                    case 0:
                    //sair
                    break;

                    default:
                    System.Console.WriteLine("Opção inválida");
                    break;
                }
            } while (opcaoDeslogado != 0);
            

        }
    }
}
