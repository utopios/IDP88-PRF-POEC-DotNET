using CoursDemosBlazor.Models;

namespace CoursDemosBlazor.Services
{
    public interface IMarmosetService
    {
        public Task<bool> Post(Marmoset marmoset);
        public Task<bool> Delete(int id);
    }
}
