using DotNetty.Buffers;
using DotNetty.Codecs;
using DotNetty.Transport.Channels;
using System.Collections.Generic;
using System.Diagnostics;

namespace mine_game.src.connector.socket
{
    class MessageDecoder : ByteToMessageDecoder
    {
        protected override void Decode(IChannelHandlerContext context, IByteBuffer input, List<object> output)
        {
            input.MarkReaderIndex();
            int messageLength = input.ReadInt();

            if (input.ReadableBytes < messageLength)
            {
                input.ResetReaderIndex();
            }
            else
            {
                byte[] messageBody = new byte[messageLength];
                input.ReadBytes(messageBody);

                Debug.WriteLine(System.Text.Encoding.UTF8.GetString(messageBody));

            }
        }
    }
}
