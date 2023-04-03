namespace P230_Pronia.Utilities.Extensions
{
    public static class FileUpload
    {
        public static async Task<string> CreateImage(this IFormFile file,string imagesFolderPath,string folder)
        {
            var detinationPath = Path.Combine(imagesFolderPath, folder);
            Random r = new Random();
            int random = r.Next(0, 1000);
            var filaName = string.Concat(random, file.FileName);
            var path = Path.Combine(detinationPath, filaName);
            using (FileStream stream = new FileStream(path, FileMode.Create))
            {
                await file.CopyToAsync(stream);
            }
            return filaName;
        }
    }
}
