namespace TelebeYaziqdiElemeyin
{
    internal class Program
    {
        static void Main(string[] args)
        {
            User user = new User ("Asiman", "19Sentyabr");
            Admin admin = new Admin("Lutfu", "12345", true, "kndfb");

            admin.signIn();
        }
       
    }
}