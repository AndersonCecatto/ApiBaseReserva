using ApiBaseReserva.Domain.Dtos;
using ApiBaseReserva.Domain.Entities;
using ApiBaseReserva.Domain.Interfaces.Repositories;
using ApiBaseReserva.Domain.Interfaces.Services;
using ApiBaseReserva.Service.Common;
using System.Collections.Generic;
using System.Linq;

namespace ApiBaseReserva.Service
{
    public class EmpresaService : BaseService<Empresa>, IEmpresaService
    {
        private readonly IAvaliacaoRepository _avaliacaoRepository;

        public EmpresaService(IEmpresaRepository empresaRepository, IAvaliacaoRepository avaliacaoRepository) : base(empresaRepository)
        {
            _avaliacaoRepository = avaliacaoRepository;
        }

        private void AdicionarAvaliacao(ref List<Empresa> empresas)
        {
            foreach (var empresa in empresas)
                empresa.Avaliacaos = _avaliacaoRepository.BuscarAvaliacaoPorEmpresaId(empresa.Id).ToList();
        }

        public Empresa Add(EmpresaDto empresa)
        {
            return _baseRepository.Insert(new Empresa(empresa));
        }

        public Empresa BuscarPorId(long empresaId, bool buscarAvaliacoes)
        {
            var retorno = _baseRepository.Find(empresaId);

            if (buscarAvaliacoes)
            {
                var empresa = new List<Empresa> { retorno };
                AdicionarAvaliacao(ref empresa);
                return empresa.FirstOrDefault();
            }

            return retorno;
        }

        public IEnumerable<Empresa> BuscarTodas()
        {
            var empresas = _baseRepository.GetAll().ToList();

            AdicionarAvaliacao(ref empresas);

            return empresas;
        }

        public EmpresaDto Update(EmpresaDto empresa)
        {
            var retorno = _baseRepository.Find(empresa.Id);

            if (empresa.ImagemName == retorno.ImagemName)
                empresa.Imagem = retorno.Imagem;

            _baseRepository.Update(new Empresa(empresa));

            return empresa;
        }
    }
}
