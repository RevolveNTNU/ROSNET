﻿using System;
using Xunit;
using RosNet.DataModel;

namespace RosNet.Test
{
    internal class DataModelTests
    {
        [fact]
        public void TestToDateTime()
        {
            // Epoch time corresponding to
            // 2022-02-15 14:35:08.1234567
            uint epochSec = 1644935708;
            uint epochNano = 123456700;
            Time test = new Time(epochSec, epochNano);
            // 1 tick is 100 nano seconds
            Assert.Equal(test.ToDateTime(), new DateTime(2022, 02, 15, 14, 35, 8).AddTicks(epochNano / 100));
        }
    }
}