﻿using LiteNetLib.Utils;

namespace MultiplayerARPG.MMO
{
    public partial struct GetUserLevelReq : INetSerializable
    {
        public void Deserialize(NetDataReader reader)
        {
            UserId = reader.GetString();
        }

        public void Serialize(NetDataWriter writer)
        {
            writer.Put(UserId);
        }
    }
}