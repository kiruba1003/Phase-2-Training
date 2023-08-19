namespace JWT_Auth.Services.Interface
{
    public interface IToken
    {
        string GenerateToken(string username, string role);
    }
}
