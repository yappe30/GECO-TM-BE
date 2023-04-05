namespace gecoTM.Models.Project
{
    public class ProjectModel
    {
        public int id { get; set; }
        public string project_id { get; set; } = string.Empty;
        public string project_name { get; set; } = string.Empty;
        public string project_description { get; set; } = string.Empty;
        public DateTime create_date { get; set; }


    }
}
