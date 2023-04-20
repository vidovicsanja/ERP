namespace Poslasticarnica.Configuration
{
    public class ProjectConfiguration
    {
        public string ClientId { get; set; }
        public string ClientSecret { get; set; }


        public Jwt Jwt { get; set; } = new Jwt();
        public DatabaseConfiguration DatabaseConfiguration { get; set; } = new DatabaseConfiguration();

    }
    public class DatabaseConfiguration
    {
        public string ConnectionString { get; set; }
    }

    public class Jwt 
    {
        public string Key { get; set; } = "dsadsadasdasdsadsadasdasdsadsadasdasdsadsadasdasdsadsadasdasdsadsadasdasdsadsadasdasdsadsadasdasdsadsadasdas";
        public string Issuer { get; set; } = "543534ergfdvfddsadsadasdasdsadsadasdasdsadsadasdasdsadsadasdasdsadsadasdasdsadsadasdasdsadsadasdasdsadsadasdas";
        public string Audience { get; set; } = "dsadsadsadasdsadsadasdasdsadsadasdasdsadsadasdasdsadsadasdasdsadsadasdasdsadsadasdasdsadsadasdas";

        public string Subject { get; set; } = "test";
    }
    
}
