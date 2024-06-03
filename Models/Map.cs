
namespace PPSI.Nowy_folder
{
    public class Map
    {
        public int  Id { get; set; }
        public string Name { get; set; }

        internal static Map? getMapById(int mapId, List<Map> maps)
        {
            foreach (var map in maps)
            {
                if (map.Id == mapId) return map;
            }
            throw new NotImplementedException();
        }
    }
}
