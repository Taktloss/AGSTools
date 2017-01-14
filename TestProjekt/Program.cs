using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AGS;

namespace TestProjekt
{
    class Program
    {
        static void Main(string[] args)
        {
            AGSTools.Gameinfo info = AGSTools.GetGameInfo(@"blackwell1.exe");
            AGSTools.ParseAGSFile(@"blackwell1.exe");

            //Dictionary<string,string> entries = AGSTools.ParseTRS_Translation(@"BlackwellLegacyScript.trs");
            //AGSTools.CreateTRA_File(info, "TEST.tra", entries);
            Console.ReadKey();


        }
    }
}
