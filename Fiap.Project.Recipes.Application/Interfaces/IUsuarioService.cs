﻿using Fiap.Project.Recipes.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fiap.Project.Recipes.Application.Interfaces
{
    public interface IUsuarioService
    {
        Usuario Obter(int usuarioId);
        Usuario Login(string login, string senha);
        int SalvarUsuario(Usuario usuario);
    }
}
