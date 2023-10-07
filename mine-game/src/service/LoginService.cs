using mine_game.src.body;
using mine_game.src.connector.socket;
using mine_game.src.constant;
using mine_game.src.entity;
using mine_game.src.entity.vo;
using System;
using System.Diagnostics;
using System.Text.Json;
using System.Threading.Tasks;

namespace mine_game.src.service
{
    class LoginService : BaseServiceInterface
    {
        public static UserInfo userInfo { get; set; }

        public void Register()
        {
            var user = new UserDto();
            user.userName = "whk";
            user.pwd = "123";
            user.zone = 1;
            var re = WebClientHelper.Post(ServiceConstant.WEB_CENTER + ServiceConstant.WEB_CENTER_USER_REGISTER, JsonSerializer.Serialize(user));
            Debug.WriteLine(re);
            userInfo = JsonSerializer.Deserialize<UserInfo>(re);
            Task.Run(() => NettyConnector.RunClientAsync());
        }


        public void Login(string message)
        {
            var user = new UserDto();
            user.userName = "whk";
            user.pwd = "123";
            user.zone = 1;
            user.openId = "";
            var re = WebClientHelper.Post(ServiceConstant.WEB_CENTER + ServiceConstant.WEB_CENTER_USER_LOGIN, JsonSerializer.Serialize(user));
            Debug.WriteLine(re);
            userInfo = JsonSerializer.Deserialize<UserInfo>(re);
            Task.Run(() => NettyConnector.RunClientAsync());
        }


        public void GetPlayers()
        {
            MessageSendHelper.SendMessage(4, new Empty(), Message.BodyOneofCase.Empty);

        }

        public void CreatPlayer()
        {
            var create = new CreatePlayer();
            create.ServerId = 1;
            create.Sex = 1;
            create.Kind = 1;
            create.UserId = userInfo.id;
            MessageSendHelper.SendMessage(1, create, Message.BodyOneofCase.CreatePlayer);

        }

        public void ChosePlayer()
        {
            var tips = new Tips();
            tips.Msg = "hello";
            MessageSendHelper.SendMessage(3, tips, Message.BodyOneofCase.Tips);
        }
    }
}
