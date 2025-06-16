using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GuessWord
{
    public class UserProfile
    {
        string path;
        public string Name { get; set; }
        public int CountGames {  get; set; }
        public int CurrentStreak {  get; set; }
        public int MaxStreak {  get; set; }
        public int CountWins {  get; set; }
        public string WinsForSteps {  get; set; }
        public UserProfile(string name)
        {
            Name = name;
            path = $@"users/{Name}.txt";
        }
        public void ExportProfile()
        {
            string[] createText = { CountGames.ToString(), CountWins.ToString(), CurrentStreak.ToString(), MaxStreak.ToString(), WinsForSteps, /*stringTime*/ };
            File.WriteAllLines(path, createText, Encoding.UTF8);
        }
        public void ImportProfile()
        {
            if (File.Exists(path))
            {
                string[] readText = File.ReadAllLines(path, Encoding.UTF8);
                FormMenu.User.CountGames = Convert.ToInt32(readText[0]);
                FormMenu.User.CountWins = Convert.ToInt32(readText[1]);
                FormMenu.User.CurrentStreak = Convert.ToInt32(readText[2]);
                FormMenu.User.MaxStreak = Convert.ToInt32(readText[3]);
                FormMenu.User.WinsForSteps = readText[4];
                //string[] arrayTime = readText[5].Split('#');
                //timeList.Clear();
                //foreach (var item in arrayTime)
                //{
                //    timeList.Add(Convert.ToInt32(item));
                //}
            }
            else
            {
                CountGames = 0;
                CountWins = 0;
                CurrentStreak = 0;
                MaxStreak = 0;
                WinsForSteps = "";
            }
        }
        public override string ToString()
        {
            return Name;
        }
    }
}
