using mine_game.src.service;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mine_game.src.common
{
    class MessageFactory
    {
        private static MessageFactory instance;

        public static MessageFactory Instance()
        {
            if (instance == null)
            {
                instance = new MessageFactory();
            }
            return instance;
        }

        public Message getMessage(int command, Message.BodyOneofCase oneofCase, object ob)
        {
            Message message = new Message();
            message.Command = command;
            switch (oneofCase)
            {
                case Message.BodyOneofCase.LoginRes: message.LoginRes = (global::LoginRes) ob; break;
                case Message.BodyOneofCase.LoginReq: 
                    message.LoginReq = (LoginReq)ob;
                    message.PlayerId = LoginService.userInfo.id;
                    break;
                case Message.BodyOneofCase.Empty: message.Empty = (Empty)ob; break;
                case Message.BodyOneofCase.Tips: message.Tips = (Tips)ob; break;
                default: break;

            }

            return message;
        }
    }
}
