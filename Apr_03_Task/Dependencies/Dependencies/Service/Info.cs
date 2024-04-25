using Microsoft.AspNetCore.Http.HttpResults;

namespace Dependencies
{
    public class Info : IInfo
    {
        public string Display()
        {
            return "Hello";
        }
    }
}