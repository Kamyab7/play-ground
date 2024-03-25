using Microsoft.AspNetCore.Mvc;
using Refit;
using refit_sample.Models;

namespace refit_sample.Controllers;

[ApiController]
[Route("[controller]")]
public class DummyController : ControllerBase
{
    private readonly IFakeStoreAPI _fakeStoreAPI;

    public DummyController()
    {
        _fakeStoreAPI = RestService.For<IFakeStoreAPI>("https://fakestoreapi.com");
    }

    [HttpGet("/products")]
    public async Task<List<Product>?> GetProducts()
    {
        var response= await _fakeStoreAPI.GetProducts();
        return response.Content;
    }
}
