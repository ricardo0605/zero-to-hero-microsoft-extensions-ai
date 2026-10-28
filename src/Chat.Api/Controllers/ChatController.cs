using Chat.Api.Models.Requests;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.AI;

namespace Chat.Api.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ChatController(IChatClient client) : ControllerBase
    {
        private readonly IChatClient _client = client;

        [HttpPost]
        public async Task Post([FromBody] ChatRequest request, CancellationToken token)
        {
            await foreach(var response in _client.GetStreamingResponseAsync(request.Message, null, token))
            {
                Console.WriteLine(response);
            }
        }
    }
}
