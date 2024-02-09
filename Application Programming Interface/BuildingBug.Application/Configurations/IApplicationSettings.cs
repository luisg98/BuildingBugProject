namespace BuildingBug.Application.Configurations
{
    public interface IApplicationSettings
    {
        public SQLSettings SQLSettings { get; set; }
        public SMTPSettings SMTPSettings { get; set; }
    }
}
