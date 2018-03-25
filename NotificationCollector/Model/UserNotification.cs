namespace NotificationCollector.Model
{
    public class UserNotification
    {
        public Severity Severity { get; set; }
        public string Message { get; set; }
        public string Caption { get; set; }
    }
}