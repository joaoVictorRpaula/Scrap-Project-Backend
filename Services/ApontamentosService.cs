using AutoMapper;
using SCRAP_API.Data;
using SCRAP_API.Data.Dtos;
using SCRAP_API.Models;

namespace SCRAP_API.Services
{
    public class ApontamentosService
    {
        private readonly AppDbContext _db;
        private readonly IMapper _map;

        public ApontamentosService(AppDbContext db, IMapper map)
        {
            _db = db;
            _map = map;
        }

        public AddApontamentosDto AddApontamento(AddApontamentosDto apontamentoDto)
        {
            Apontamentos apontamento = _map.Map<Apontamentos>(apontamentoDto);
            if(apontamento == null)
            {
                return null;
            }
            _db.Apontamentos.Add(apontamento);
            _db.SaveChanges();

            return apontamentoDto;
        }
    }
}
