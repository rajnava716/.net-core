using System;
using System.Web.Http;
using System.Threading.Tasks;


namespace ImportProgressBar.Controllers
{
    [Route("[controller]")]
    public class DataImportController : ApiController
    {
        [HttpPost]
       
        public async Task<IHttpActionResult> StartImport()
        {
            // Start the import process
            var importTask = Task.Run(() => PerformDataImport());

            // Return a response immediately
            return Ok("Import process started");
        }

        private async Task PerformDataImport()
        {
            // Simulate data import progress
            for (int progress = 0; progress <= 100; progress += 10)
            {
                // Simulate delay (replace with actual import logic)
                await Task.Delay(1000);

                // Update progress (you might use a message queue or other mechanism)
                // For simplicity, storing it in a static variable
                ProgressStorage.SetProgress(progress);
            }
        }

        [HttpGet]
        public IHttpActionResult GetImportProgress()
        {
            var progress = ProgressStorage.GetProgress();
            return Ok(new { progress });
        }
    }
}

