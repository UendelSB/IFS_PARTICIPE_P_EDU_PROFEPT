﻿using IfsParticipe.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace IfsParticipe.Libraries
{
    public class LoginUsuario
    {
        private string Key = "Login.Usuario";
        private Sessao.Sessao _sessao;
        public LoginUsuario(Sessao.Sessao sessao) {
            _sessao = sessao;
        }

        public void Login(Usuario usuario)
        {
             string usuarioJson = JsonConvert.SerializeObject(usuario);
            _sessao.Cadastrar(Key, usuarioJson);

        }

        public Usuario GetUsuario()
        {
            if (_sessao.Existe(Key))
            {
                string usuarioJson = _sessao.Consultar(Key);
                return JsonConvert.DeserializeObject<Usuario>(usuarioJson);
            }
            else
            {
                return null;
            }

        }

        public void Logout()
        {
            _sessao.RemoverTodos();
        }

    }
}
