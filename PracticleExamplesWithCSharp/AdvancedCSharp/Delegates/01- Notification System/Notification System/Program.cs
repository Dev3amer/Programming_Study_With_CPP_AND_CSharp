namespace Notification_System
{
    class Notification
    {
        public delegate void delNotifyUserMethod(string message);
        
        private delNotifyUserMethod _NotifyUserMethod;

        public Notification(delNotifyUserMethod notifyUserMethod)
        {
            _NotifyUserMethod = notifyUserMethod;
        }
        public void Notify(string message)
        {
            _NotifyUserMethod(message);
        }
    }
    internal class Program
    {
        static void NotifyViaEmail(string message)
        {
            //We Can Get User Email From DB
            string Email = "test@test.com";

            Console.WriteLine("Email Sent Successfully");
        }
        static void NotifyViaSMS(string message)
        {
            //We Can Get User Phone Number From DB
            string Email = "+201027024252";

            Console.WriteLine("SMS Sent Successfully");
        }
        static void Main(string[] args)
        {
            Notification MyNotificationSysViaSMS = new Notification(NotifyViaSMS);
            MyNotificationSysViaSMS.Notify("Hello My Bro[From SMS Method]");

            Notification MyNotificationSysViaEmail = new Notification(NotifyViaEmail);
            MyNotificationSysViaEmail.Notify("Hello My Bro[From Email Method]");
        }
    }
}