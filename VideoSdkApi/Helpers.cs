using JWT.Algorithms;
using JWT.Builder;

namespace VideoSdkApi;

public class Helpers
{
    public static string GenerateToken()
    {
        string VIDEOSDK_API_KEY = "8aee4829-8a3b-434c-8975-0c539761bc19";
        string VIDEOSDK_SECRET_KEY = "bb0bf375e2083fa3c95e79d805537caab45f3edfcaccd23870141cde9f7ea79b";

        var token = JwtBuilder.Create()
            .WithAlgorithm(new HMACSHA256Algorithm()) // symmetric
            .WithSecret(VIDEOSDK_SECRET_KEY)
            .AddClaim("exp", DateTimeOffset.UtcNow.AddHours(2).ToUnixTimeSeconds())
            .AddClaim("iat", DateTimeOffset.UtcNow.ToUnixTimeSeconds())
            .AddClaim("apikey", VIDEOSDK_API_KEY)
            .AddClaim("permissions", new string[1] { "allow_join" }) // "ask_join" || "allow_mod" 
            .Encode();
        return token;
    }

}
