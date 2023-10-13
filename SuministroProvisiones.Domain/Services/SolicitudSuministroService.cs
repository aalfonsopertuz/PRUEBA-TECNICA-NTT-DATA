using SuministroProvisiones.Domain.IRepositories;

namespace SuministroProvisiones.Domain.Services
{
    public class SolicitudSuministroService
    {
        private readonly ISolicitudSuministroRepository _solicitudSuministroRepository;
        private readonly ISolicitudSuministroResponseRepository _solicitudSuministroResponseRepository;

        public SolicitudSuministroService(ISolicitudSuministroResponseRepository solicitudSuministroResponseRepository, ISolicitudSuministroRepository solicitudSuministroRepository)
        {
            _solicitudSuministroResponseRepository = solicitudSuministroResponseRepository;
            _solicitudSuministroRepository = solicitudSuministroRepository;
        }


    }
}
