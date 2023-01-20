﻿using ApiBaseReserva.Domain.Dtos;
using ApiBaseReserva.Domain.Entities;
using ApiBaseReserva.Domain.Interfaces.Services.Common;

namespace ApiBaseReserva.Domain.Interfaces.Services
{
    public interface IEmpresaService : IBaseService<Empresa>
    {
        Empresa Add(EmpresaDto empresa);
        EmpresaDto Update(EmpresaDto empresa);
    }
}
