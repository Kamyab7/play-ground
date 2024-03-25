using Refit;
using refit_sample.Models;

namespace refit_sample;

public interface IFakeStoreAPI
{
    [Get("/products")]
    Task<ApiResponse<List<Product>>> GetProducts();
}
