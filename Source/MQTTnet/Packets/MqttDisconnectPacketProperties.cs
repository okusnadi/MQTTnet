﻿using System.Collections.Generic;

namespace MQTTnet.Packets
{
    public class MqttDisconnectPacketProperties
    {
        public uint? SessionExpiryInterval { get; set; }

        public string ReasonString { get; set; }

        public List<MqttUserProperty> UserProperties { get; } = new List<MqttUserProperty>();

        public string ServerReference { get; set; }
    }
}