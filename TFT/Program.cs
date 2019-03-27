//for working with excel we used information from
//http://csharp.net-informations.com/excel/csharp-create-excel.htm

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//using NLog;
//using Microsoft.Office.Interop.Excel;

namespace TFT
{
    class Program
    {
        #region fields
        //private static Logger logger = LogManager.GetCurrentClassLogger();
        //private static ALog aLogger = new ALog();
        static bool excelAvailable = false;
        static Dictionary<IPlayer, int> scores;
        static int[,] results;
        static List<IPlayer> players;
        #endregion
        static void Main(string[] args)
        {
            RunTFT();
        }

        private static void RunTFT()
        {
            //Microsoft.Office.Interop.Excel.Application xlApp = new Microsoft.Office.Interop.Excel.Application();
            //if (xlApp != null)
            //{
            //    excelAvailable = true;
            //}
            IPlayer cristi = new CristiPlayer();
            IPlayer random = new RandomPlayer2();
            IPlayer ovidiu = new ClassPlayerOvidiu();
            //var game = new Game(cristi2, boss);
            //var var = boss.GetType().ToString();
            players = new List<IPlayer>();
            players.Add(cristi);
            players.Add(random);
            players.Add(ovidiu);
            if (excelAvailable)
            {
                //_Workbook xlWorkBook = xlApp.Workbooks.Add();
                //_Worksheet xlWorkSheet = (Microsoft.Office.Interop.Excel.Worksheet)xlWorkBook.Worksheets.get_Item(1);
                //xlWorkSheet.Cells[1, 1] = "ID";
                //xlWorkSheet.Cells[1, 2] = "Name";
                //xlWorkSheet.Cells[2, 1] = "1";
                //xlWorkSheet.Cells[2, 2] = "One";
                //xlWorkSheet.Cells[3, 1] = "2";
                //xlWorkSheet.Cells[3, 2] = "Two";
                //xlWorkBook.SaveAs("your-file-name.xls");
            }
            scores = new Dictionary<IPlayer, int>();
            results = new int[players.Count, players.Count];
            try
            {
                for (int i = 0; i < players.Count - 1; i++)
                {
                    for (int j = i + 1; j < players.Count; j++)
                    {
                        var game = new Game(players[i], players[j]);
                        game.RunGame();
                        var latestGameResults = game.Scores;
                        if (scores.ContainsKey(players[i]))
                        {
                            scores[players[i]] += latestGameResults[0];
                        }
                        else
                        {
                            scores.Add(players[i], latestGameResults[0]);
                        }
                        if (scores.ContainsKey(players[j]))
                        {
                            scores[players[j]] += latestGameResults[1];
                        }
                        else
                        {
                            scores.Add(players[j], latestGameResults[1]);
                        }
                        results[i, j] = latestGameResults[0];
                        results[j, i] = latestGameResults[1];
                    }
                }
                cwmatrice();
                Console.ReadLine();
            }
            catch (Exception e)
            {
                //aLogger.Log("error message: " + e.Message + ";source: " + e.Source);
                //logger.Error("error message: " + e.Message + ";source: " + e.Source);
                Console.WriteLine("Ai gresit jocu' baiatu meu!");
            }
            Console.ReadLine();
        }

        private static void cwmatrice()
        {
            Console.Write("  ");
            for (int i = 0; i < players.Count; i++)
            {
                Console.Write(("P" + i).PadLeft(4, ' '));
            }
            Console.WriteLine();
            for (int i = 0; i < players.Count; i++)
            {
                Console.Write(("P" + i).PadRight(3, ' '));
                for (int j = 0; j < players.Count; j++)
                {
                    Console.Write(results[i, j].ToString().PadLeft(4, ' '));
                }
                Console.WriteLine();
            }
        }
    }
}
