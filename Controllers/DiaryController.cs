using Diary.Services;
using Microsoft.AspNetCore.Mvc;

namespace Diary.Controllers{

    [ApiController]
    [Route("[controller]")]
    public class DiaryController : ControllerBase
    {
        private DiaryDatabase _Database = new();

    }
}