namespace MeTube.App.Controllers
{
    using SimpleMvc.Framework.Attributes.Methods;
    using SimpleMvc.Framework.Interfaces;
    using System.Linq;
    using System.Text;

    public class HomeController : BaseController
    {
        [HttpGet]
        public IActionResult Index()
        {
            if (!this.User.IsAuthenticated)
            {
                this.Model.Data["index"] =
                    @"<div class=""jumbotron"">
                        <p class=""h1 display-3"" >Welcome to MeTube&trade;!</p>
                        <p class=""h3"" >The simplest, easiest to use, most comfortable Multimedia Application.</p>
                        <hr class=""my -3"" >
                        <p><a href=""/users/login"" >Login</a> if you have an account or <a href=""/users/register"">Register</a> now and start tubing.</p>
                       </div>";

                return this.View();
            }
            var tubesAsIndexHtml =
                @"<div class=""col-4 text-center"">
                    <a href=""/tubes/details?id={0}"">
                        <img src=""http://img.youtube.com/vi/{1}/mqdefault.jpg"" alt =""{3} - {2}"" />
                        <h4>{2}</h4>
                        <p><em>{3}</em></p>
                    </a>
                </div>";

            var indexHtml = new StringBuilder();
            indexHtml.AppendLine($@"<div class=""text-center text-info"" ><h1>Welcome, @{DbUser.Username}!</h1></div><br/><hr/>");
            indexHtml.AppendLine(@"<div class=""row"">");
            var tubesAsHtml = this.Context.Tubes
                .Select(t => string.Format(tubesAsIndexHtml, t.Id, t.YouTubeId, t.Title, t.Author))
                .ToArray();


            for (int i = 0; i < tubesAsHtml.Length; i++)
            {
                indexHtml.AppendLine(tubesAsHtml[i]);
                if (i % 3 == 2)
                {
                    indexHtml.AppendLine("</div><br/>");
                    indexHtml.AppendLine(@"<div class=""row"">");
                }
            }

            indexHtml.AppendLine("</div>");
            
            this.Model.Data["username"] = DbUser.Username;
            this.Model.Data["index"] = indexHtml.ToString();

            return this.View();
        }
    }
}
