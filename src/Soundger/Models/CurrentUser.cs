namespace Soundger.Models
{
    internal class CurrentUser
    {
        public string Token { get; set; }

        public string Username { get; set; }

        public int Id { get; set; }

        public bool IsAuthorized { get; set; }
    }
}
