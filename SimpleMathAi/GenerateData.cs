using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleMathAi
{
    class GenerateData
    {
        public static void main()
        {
            try
            {
                FileStream fileStream = new FileStream(@"C:\Users\Dell Precision\source\repos\SimpleMathAi\SimpleMathAi\Data\MathEquations.csv", FileMode.Append, FileAccess.Write);
                StreamWriter fileWriter = new StreamWriter(fileStream);
                Random r = new Random();

                for (int i = 0; i < 1000; i++)
                {
                    string build = "";
                    int i1 = r.Next(1, 20);
                    int i2 = r.Next(1, 20);

                    build += i1;
                    build += "," + i2 + ",";

                    build += (i1 + 12);

                    fileWriter.WriteLine(build);
                }
                fileWriter.Flush();
                fileWriter.Close();
            }
            catch (Exception)
            {

            }
        }
    }
}
