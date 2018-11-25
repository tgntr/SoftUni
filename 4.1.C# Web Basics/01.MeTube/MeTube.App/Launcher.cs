namespace MeTube.App
{
    using SimpleMvc.Framework.Routers;
    using WebServer;
    using Data;
    using SimpleMvc.Framework;

    public class Launcher
    {
        public static void Main(string[] args)
        {
            var server = new WebServer(1337, new ControllerRouter(), new ResourceRouter());

            var dbContext = new MeTubeDbContext();

            MvcEngine.Run(server, dbContext);
        }
    }
}
