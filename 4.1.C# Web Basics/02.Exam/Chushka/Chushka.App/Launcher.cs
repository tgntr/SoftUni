using Chushka.Data;
using Microsoft.EntityFrameworkCore;
using SoftUni.WebServer.Mvc;
using SoftUni.WebServer.Mvc.Routers;
using SoftUni.WebServer.Server;
using System;

namespace Chushka.App
{
    public class Launcher
    {
        public static void Main(string[] args)
        {
            var server = new WebServer(1337, new ControllerRouter(), new ResourceRouter());

            var dbContext = new ChushkaDbContext();
            using (dbContext)
            {
                dbContext.Database.Migrate();
            }

            MvcEngine.Run(server);
        }
    }
}
