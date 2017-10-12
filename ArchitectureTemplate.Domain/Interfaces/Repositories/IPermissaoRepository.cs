﻿using System.Collections.Generic;
using ArchitectureTemplate.Domain.DataEntities;

namespace ArchitectureTemplate.Domain.Interfaces.Repositories
{
    public interface IPermissaoRepository
    {
        bool AllowAccess(int perfilId, string controllerName, string accessType);
        string GetToken(long userId);
        IEnumerable<PerfilPorTela> GetAll();
        IEnumerable<PerfilPorTela> GetPerfilPorTela(int perfilId);
        PerfilPorTela GetPerfilPorTela(long id);
        PerfilPorTela GetTela(int telaId);
        void EnableOrDisabled(PerfilPorTela entity, long userId);
    }
}