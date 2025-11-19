using Ñetflix.Models;

namespace Ñetflix.Services
{
    public interface ISeriesService
    {
        Task<SerieCreatedResponse> CreateSerieAsync(SerieCreateDto serieCreateDto);
        Task<SerieResponseDto> GetSerieByIdAsync(string _id);
        Task<IEnumerable<SerieResponseDto>> GetAllSeriesAsync();
        Task<SerieUpdateResponse> UpdateSerieAsync(string _id, SerieUpdateDto serieUpdateDto);
        Task<SerieDeletedResponse> DeleteSerieAsync(string _id);
    }
}
