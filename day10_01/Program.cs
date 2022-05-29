using System.IO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace day10_01
{
    class Program
    {
        static void Main(string[] args)
        {
            FileStream fs = new FileStream("test.dat", FileMode.Create);
            BinaryWriter bw = new BinaryWriter(fs);

            bw.Write(12);
            bw.Write(3.14f);
            bw.Write("hello world");

            bw.Close();

            int var01;
            float var02;
            string var03;

            using (BinaryReader br = new BinaryReader(File.Open("test.dat", FileMode.Open)))
            {
                var01 = br.ReadInt32();
                var02 = br.ReadSingle();
                var03 = br.ReadString();
            }
            Console.WriteLine("{0} {1} {2}", var01, var02, var03);
        }
    }
}
