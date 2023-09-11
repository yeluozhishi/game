using mine_game.src.body;
using System;
using System.Text.Json;

namespace mine_game.src.service
{
    class LoginService : BaseServiceInterface
    {
        public UserInfo userInfo { get; set; }

        public void register()
        {
            var user = new UserDto();
            user.userName = "whk";
            user.pwd = "123";
            user.zone = 1;
            var re = WebClientHelper.Post("http://127.0.0.1:5020/WEB-CENTER/user/register", JsonSerializer.Serialize(user));
            Console.WriteLine(re);
            userInfo = JsonSerializer.Deserialize<UserInfo>(re);
        }


        public void login(string message)
        {
            var user = new UserDto();
            user.userName = "whk";
            user.pwd = "123";
            user.zone = 1;
            user.openId = "";
            var re = WebClientHelper.Post("http://127.0.0.1:5020/WEB-CENTER/user/login", JsonSerializer.Serialize(user));
            Console.WriteLine(re);
            userInfo = JsonSerializer.Deserialize<UserInfo>(re);
            
        }

        
    }
}
