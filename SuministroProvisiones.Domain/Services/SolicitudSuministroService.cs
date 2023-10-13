using AutoMapper;
using SuministroProvisiones.Commons.Models;
using SuministroProvisiones.Domain.IRepositories;
using SuministroProvisiones.Domain.Services.IServices;
using SuministroProvisiones.DOMAIN.Entities;
using System.Transactions;

namespace SuministroProvisiones.Domain.Services
{
    public class SolicitudSuministroService : ISolicitudSuministroService
    {
        private readonly ISolicitudSuministroRepository _solicitudSuministroRepository;
        private readonly ISolicitudSuministroResponseRepository _solicitudSuministroResponseRepository;
        private readonly IMapper _mapper;

        public SolicitudSuministroService(ISolicitudSuministroResponseRepository solicitudSuministroResponseRepository, ISolicitudSuministroRepository solicitudSuministroRepository, IMapper mapper)
        {
            _solicitudSuministroResponseRepository = solicitudSuministroResponseRepository;
            _solicitudSuministroRepository = solicitudSuministroRepository;
            _mapper = mapper;
        }

        public async Task<SolicitudSuministroResponseDto> SolicitarSumministro(SolicitudSuministroDto solicitudDto)
        {
            using TransactionScope scope = new();
            try
            {
                SolicitudSuministro solicitudEntity = _mapper.Map<SolicitudSuministro>(solicitudDto);
                await _solicitudSuministroRepository.AddAsync(solicitudEntity);
                _solicitudSuministroRepository.SaveChanges();

                SolicitudSuministroResponse solicitudResponse = new(solicitudEntity);
                await _solicitudSuministroResponseRepository.AddAsync(solicitudResponse);
                _solicitudSuministroResponseRepository.SaveChanges();

                scope.Complete();
                return _mapper.Map<SolicitudSuministroResponseDto>(solicitudResponse);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
    }
}
