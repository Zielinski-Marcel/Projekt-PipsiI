using PPSI3.Models;
using static System.Net.WebRequestMethods;

namespace PPSI.Nowy_folder
{
    public class Champion
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string BackgrundPhoto { get; set; }
        public string Photo {  get; set; }

        public static int getChampionIdByName(string name, List<Champion> championList)
        {
            Champion correctChampion = championList[1];
            foreach (Champion champion in championList)
            {
                if (champion.Name == name)
                {
                    correctChampion = champion;
                    return correctChampion.Id;
                }
            }
            return 0;
        }
        public static Champion getChampionById(int id, List<Champion> championList)
        {
            Champion correctChampion = championList[1];
            foreach (Champion champion in championList)
            {
                if (champion.Id == id)
                {
                    correctChampion = champion;
                    return correctChampion;
                }
            }
            return correctChampion;
        }

        public static string getChampionPhotoByName(string name, List<Champion> championList)
        {
            string correctChampion = "https://static.wikia.nocookie.net/leagueoflegends/images/c/c0/Enemy_Missing_ping.png";
            foreach (Champion champion in championList)
            {
                if (champion.Name == name)
                {
                    correctChampion = champion.Photo;
                    return correctChampion;
                }
            }
            return correctChampion;
        }
    }
}
