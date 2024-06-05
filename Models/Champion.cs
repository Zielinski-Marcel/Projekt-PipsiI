using static System.Net.WebRequestMethods;

namespace PPSI.Models
{
    public class Champion
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string BackgrundPhoto { get; set; }
        public string Photo {  get; set; }

        public static Champion getChampionByName(string name, List<Champion> championList)
        {
            Champion correctChampion = championList[1];
            foreach (Champion champion in championList)
            {
                if (champion.Name == name)
                {
                    correctChampion = champion;
                    return correctChampion;
                }
            }
            return null;
        }
        public static int getChampionIdByName(string name, List<Champion> championList)
        {
            int correctChampion = 0;
            foreach (Champion champion in championList)
            {
                if (champion.Name == name)
                {
                    correctChampion = champion.Id;
                    return correctChampion;
                }
            }
            return correctChampion;
        }
        public static Champion getChampionById(int id, List<Champion> championList)
        {
            Champion correctChampion = null;
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

    }
}
