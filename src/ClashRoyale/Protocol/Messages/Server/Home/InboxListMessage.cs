using ClashRoyale.Logic;
using ClashRoyale.Utilities.Netty;

namespace ClashRoyale.Protocol.Messages.Server
{
    public class InboxListMessage : PiranhaMessage
    {


        public InboxListMessage(Device device) : base(device)
        {
            Id = 24445;
        }

        public override void Encode()
        {

            Writer.WriteInt(1);

            Writer.WriteScString("https://56f230c6d142ad8a925f-b174a1d8fb2cf6907e1c742c46071d76.ssl.cf2.rackcdn.com/inbox/ClashRoyale_logo_small.png");
            Writer.WriteScString("<c4>Retro Royale - Emulator</c>!"); //Title
            Writer.WriteScString("Official Retro Royale Emulator Best Royale Server Out There");//Description
            Writer.WriteScString("Visit our Site");//Button Name
            Writer.WriteScString("https://retroroyale.xyz/");//Button Link
            Writer.WriteScString("");//Unk
            Writer.WriteScString("");//Unk
            Writer.WriteScString("");//Unk
        }


    }

}
