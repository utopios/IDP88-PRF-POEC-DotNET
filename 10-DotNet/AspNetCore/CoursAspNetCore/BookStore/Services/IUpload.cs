namespace BookStore.Services
{
    public interface IUpload
    {
        public string Upload(IFormFile formFile);
    }
}
