namespace MeTube.App.Controllers
{
    using MeTube.App.Models;
    using MeTube.Models;
    using SimpleMvc.Framework.Attributes.Methods;
    using SimpleMvc.Framework.Attributes.Security;
    using SimpleMvc.Framework.Interfaces;
    using SimpleMvc.Framework.Views;
    using System.Linq;

    public class TubesController : BaseController
    {
        [HttpGet]
        [PreAuthorize]
        public IActionResult Upload() => this.View();

        [HttpPost]
        public IActionResult Upload(UploadBindingModel model)
        {
            if (!this.IsValidModel(model))
            {
                return this.BuildErrorView();
            }

            var youtubeId = "";
            if (model.YouTubeLink.Contains("youtube.com"))
            {
                youtubeId = model.YouTubeLink.Split("=").Last();
            }
            else if (model.YouTubeLink.Contains("youtu.be"))
            {
                youtubeId = model.YouTubeLink.Split("/").Last();
            }
            else
            {
                this.BuildErrorView("Invalid Youtube link!");
                return this.View();
            }

            var tube = new Tube()
            {
                Title = model.Title,

                Author = model.Author,

                YouTubeId = youtubeId,

                Description = model.Description,

                UploaderId = this.DbUser.Id
            };

            using (this.Context)
            {
                this.Context.Tubes.Add(tube);
                this.Context.SaveChanges();
            }

            return this.RedirectToAction($"/tubes/details?id={tube.Id}");
        }

        [HttpGet]
        [PreAuthorize]
        public IActionResult Details(int id)
        {
            Tube tube;

            using (this.Context)
            {
                tube = this.Context.Tubes.FirstOrDefault(t => t.Id == id);

                if (tube is null)
                {
                    return this.RedirectToHome();
                }

                tube.Views++;
                this.Context.SaveChanges();
            }

            this.Model.Data["title"] = tube.Title;
            this.Model.Data["author"] = tube.Author;
            this.Model.Data["youTubeId"] = tube.YouTubeId;
            this.Model.Data["views"] = tube.Views + " " + ((tube.Views == 1) ? "View" : "Views");
            this.Model.Data["description"] = tube.Description;

            return View();
        }
    }
}
