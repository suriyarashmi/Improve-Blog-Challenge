using System.Threading.Tasks;
using static SimpleBlog.API.Infrastructure.WebClient;

namespace SimpleBlog.API.Infrastructure 
{
    public interface IWebClient
    {
        EnumEntityType EntityType { get; set; }

        Task<string> GetData(string suffix = "");
    }
}