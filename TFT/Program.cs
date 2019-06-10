//for working with excel we used information from
//http://csharp.net-informations.com/excel/csharp-create-excel.htm

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NLog;
//using Microsoft.Office.Interop.Excel;

namespace TFT
{
    class Program
    {
        #region fields
        private static Logger logger = LogManager.GetCurrentClassLogger();
        //private static ALog aLogger = new ALog();
        static bool excelAvailable = false;
        static Dictionary<IPlayer, int> scores;
        static int[,] results;
        static List<IPlayer> players;
        static List<IPlayer> newPlayers;
        #endregion
        static void Main(string[] args)
        {
            RunTFT();
        }


        private static void RunTFT()
        {
            logger.Fatal("Fatal test RunTFT started");
            //Microsoft.Office.Interop.Excel.Application xlApp = new Microsoft.Office.Interop.Excel.Application();
            //if (xlApp != null)
            //{
            //    excelAvailable = true;
            //}
            //IPlayer cristi = new CristiPlayer();
            IPlayer random = new RandomPlayer2();
            //IPlayer ovidiu = new ClassPlayerOvidiu();
            IPlayer diana = new DianaPlayer();
            //IPlayer liviu = new LiviuPlayer();
            //var game = new Game(cristi2, boss);
            //var var = boss.GetType().ToString();
            //players.Add(cristi);
            //players.Add(ovidiu);
            IPlayer manu = new ManuPlayer();
            IPlayer manu2 = new ManuReloaded();
            IPlayer teo = new Teo1();
            IPlayer liviu = new LiviuPlayer();
            IPlayer dan = new DanielPlayer();
            IPlayer dan2 = new DanielPlayer2();
            IPlayer profu = new PlayLikeABoss();
            IPlayer profu2 = new Player2();
            IPlayer diana2 = new DianaPlayer2();
            logger.Trace("trace line before creating players List");
            players = new List<IPlayer> { diana, diana2, manu, manu2, teo, liviu, dan, dan2, profu, profu2 };
            newPlayers = new List<IPlayer>();

            var r = new Random();
            while (players.Count > 0)
            {
                var loto = players[r.Next(players.Count)];
                newPlayers.Add(loto);
                players.Remove(loto);
            }
            logger.Log(LogLevel.Error,"logException test before checking availability of excel",new Exception());
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
            results = new int[newPlayers.Count, newPlayers.Count];
            try
            {
                for (int i = 0; i < newPlayers.Count - 1; i++)
                {
                    for (int j = i + 1; j < newPlayers.Count; j++)
                    {
                        var game = new Game(newPlayers[i], newPlayers[j]);
                        game.RunGame();
                        var latestGameResults = game.Scores;
                        if (scores.ContainsKey(newPlayers[i]))
                        {
                            scores[newPlayers[i]] += latestGameResults[0];
                        }
                        else
                        {
                            scores.Add(newPlayers[i], latestGameResults[0]);
                        }
                        if (scores.ContainsKey(newPlayers[j]))
                        {
                            scores[newPlayers[j]] += latestGameResults[1];
                        }
                        else
                        {
                            scores.Add(newPlayers[j], latestGameResults[1]);
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
                logger.Error("error message: " + e.Message + ";source: " + e.Source);
                Console.WriteLine("Ai gresit jocu' baiatu meu!");
            }
            Console.ReadLine();
        }

        private static void cwmatrice()
        {
            Console.Write("  ");
            for (int i = 0; i < newPlayers.Count; i++)
            {
                Console.Write(("P" + i).PadLeft(4, ' '));
            }
            Console.WriteLine();
            for (int i = 0; i < newPlayers.Count; i++)
            {
                Console.Write(("P" + i).PadRight(3, ' '));
                for (int j = 0; j < newPlayers.Count; j++)
                {
                    Console.Write(results[i, j].ToString().PadLeft(4, ' '));
                }
                Console.WriteLine();
            }
        }
    }
}
