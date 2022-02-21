﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using RosNet.Field;

namespace RosNet.DataModel
{
    internal interface IMessage
    {
        //Header fields of message record:
        public int Conn { get; }
        public Time TimeStamp { get; }

        //Data in message record:
        public Dictionary<string, FieldValue> Data { get; }

        public string ToString();
    }
}
