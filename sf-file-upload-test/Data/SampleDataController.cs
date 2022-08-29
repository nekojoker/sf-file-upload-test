using System;
using Microsoft.AspNetCore.Mvc;

namespace sf_file_upload_test.Data;

[Route("api/[controller]")]
[ApiController]
public class SampleDataController : ControllerBase
{
    [HttpPost("[action]")]
    public void Save(IList<IFormFile> files)
    {
    }

    [HttpPost("[action]")]
    public void Remove(IList<IFormFile> files)
    {
    }
}

