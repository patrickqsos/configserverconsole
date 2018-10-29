namespace ConfigServerConsole
{
    public class ConfigServerData
    {
        public Spring Spring { get; set; }
        public Topic Topic { get; set; }
        public Database Database { get; set; }
    }

    public class Spring
    {
        public Kafka Kafka { get; set; }
    }
    
    public class Kafka
    {
        public string BootstrapServers { get; set; }
    }
    
    public class Topic
    {
        public Auth Auth { get; set; }
    }
  
    public class Auth
    {
        public string Job { get; set; }
        public string Response { get; set; }
    }

    public class Database
    {
        public string Host { get; set; }
        public string Db { get; set; }
        public string User { get; set; }
        public string Password { get; set; }
    }
}