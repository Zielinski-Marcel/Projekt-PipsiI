namespace PoroCounter2.Models
{
    public class PlatformData
    {
        public string Id { get; set; }
        public string Name { get; set; }
        public List<string> Locales { get; set; } = new List<string>();
        public List<Maintenance> Maintenances { get; set; }
        public List<Incident> Incidents { get; set; }


        public class Maintenance
        {
            public string Maintance { get; set; }
        }

        public class Incident
        {
            public int Id { get; set; }
            public DateTime CreatedAt { get; set; }
            public DateTime UpdatedAt { get; set; }
            public DateTime? ArchiveAt { get; set; }
            public List<Title> Titles { get; set; }
            public List<Update> Updates { get; set; }
            public List<string> Platforms { get; set; }
            public string MaintenanceStatus { get; set; }
            public string IncidentSeverity { get; set; }
        }

        public class Title
        {
            public string Locale { get; set; }
            public string Content { get; set; }
        }

        public class Update
        {
            public int Id { get; set; }
            public DateTime CreatedAt { get; set; }
            public DateTime UpdatedAt { get; set; }
            public bool Publish { get; set; }
            public string Author { get; set; }
            public List<Translation> Translations { get; set; }
            public List<string> PublishLocations { get; set; }
        }

        public class Translation
        {
            public string Locale { get; set; }
            public string Content { get; set; }
        }
    }
}
