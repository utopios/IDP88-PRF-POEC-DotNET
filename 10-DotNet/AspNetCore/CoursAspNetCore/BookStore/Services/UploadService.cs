namespace BookStore.Services
{
    public class UploadService : IUpload
    {
        private IWebHostEnvironment _env;
        public UploadService(IWebHostEnvironment env)
        {
            _env = env;
        }
        public string Upload(IFormFile formFile)
        {
            string newNameFile = Guid.NewGuid().ToString()+"-"+formFile.FileName;
            string path = Path.Combine(_env.WebRootPath, "images", newNameFile);
            Stream stream = File.Create(path);
            formFile.CopyTo(stream);
            stream.Close();
            return "images/" + newNameFile;
        }
    }
}
