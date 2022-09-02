namespace VisTu.Services
{
    public class SaltServices
    {
        public static string CreateSalt(int size)
        {
            ///Cria uma string de bites aleatória para concatenar com a senha usando o padrão salt de segurança
            RandomNumberGenerator rng = RandomNumberGenerator.Create();
            byte[] salt = new byte[size];
            rng.GetBytes(salt);
            return Convert.ToBase64String(salt);
        }
    }
}
