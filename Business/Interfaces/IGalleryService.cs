using System.Collections.Generic;
using System.Threading.Tasks;
using Business.ViewModels;
using Business.ViewModels.Gallery;
using Core.Entities;

namespace Business.Interfaces
{
    public interface IGalleryService
    {
        Task<List<GaleryImage>> GetLastimageAsync();
        Task<List<GaleryImage>> GetAllAsync();
        Task<Paginate<GaleryImage>> GetAllPaginatedAsync(int page,int size);
        Task<GaleryImage> GetAsync(int id);
        Task Create(GalleryPostVM galleryPostVm);
        Task Update(int id, GalleryUpdateVM galleryUpdateVm);
        Task Remove(int id);
        Task<int> getPageCount(int take);
    }
}