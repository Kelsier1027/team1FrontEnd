namespace myapi.Extensions
{
    public static class ImageToByte
    {

        public static byte[] ToByte(this string imgpath)
        {
            byte[] byteArray;

            // 检查文件是否存在
            if (!File.Exists(imgpath))
            {
                throw new FileNotFoundException($"File not found: {imgpath}");
            }

            // 读取文件内容并转换为字节数组
            using (FileStream fileStream = new FileStream(imgpath, FileMode.Open, FileAccess.Read))
            {
                using (BinaryReader binaryReader = new BinaryReader(fileStream))
                {
                    byteArray = binaryReader.ReadBytes((int)fileStream.Length);
                }
            }

            return byteArray;
        }
    }
}
