﻿using ApiBaseReserva.Domain.Entities;
using ApiBaseReserva.Domain.Interfaces.Repositories;
using ApiBaseReserva.Domain.Interfaces.Services;
using ApiBaseReserva.Service.Common;

namespace ApiBaseReserva.Service
{
    public class EmpresaAdicionalService : BaseService<EmpresaAdicional>, IEmpresaAdicionalService
    {

        public EmpresaAdicionalService(IEmpresaAdicionalRepository empresaAdicionalRepository) : base(empresaAdicionalRepository)
        {
        }
    }
}
