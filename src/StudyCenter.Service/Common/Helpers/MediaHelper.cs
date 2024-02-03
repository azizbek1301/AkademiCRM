namespace StudyCenter.Service.Common.Helpers
{
    public class MediaHelper
    {
        public static string MakeImageName(string fileName)
        {
            var fileInfo = new FileInfo(fileName);
            var imageExtensions = GetImageExtensions();

            if (imageExtensions.Any(x => x == fileInfo.Extension))
            {
                string extensions = fileInfo.Extension;
                string name = "IMG_" + Guid.NewGuid() + extensions;
                return name;
            }
            throw new Exception("Image Not Found");

        }



        public static string[] GetImageExtensions()
        {
            return new string[]
            {
                ".jpg",
                ".jpeg",
                ".png",
                ".bmp",
                ".svg"
            };
        }
    }
}
