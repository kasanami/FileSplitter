using System;
using System.IO;
using System.Text;

namespace FileSplitter
{
    class Program
    {
        static void Main(string[] args)
        {
            if (args.Length < 2)
            {
                Console.WriteLine("引数には、ファイルのパスと分割サイズが必要です。");
                return;
            }
            var sourcePath = args[0];
            var size = int.Parse(args[1]);

            var buffer = new byte[size];
            try
            {
                using (var readStream = new FileStream(sourcePath, FileMode.Open))
                {
                    for (var no = 1; true; no++)
                    {
                        var readSize = readStream.Read(buffer, 0, size);
                        if (readSize > 0)
                        {
                            var outPath = sourcePath + ".part" + no;
                            using (var writeStream = new FileStream(outPath, FileMode.Create))
                            {
                                writeStream.Write(buffer, 0, readSize);
                            }
                        }
                        else
                        {
                            break;
                        }
                    }
                }
                Console.WriteLine("正常終了");
            }
            catch(Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }
    }
}