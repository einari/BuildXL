﻿using System;

namespace BuildXL.Cache.Monitor.App
{
    internal static class Constants
    {
        public const string ServiceName = "ContentAddressableStoreService";

        public const string MasterServiceName = "ContentAddressableStoreMasterService";

        public static TimeSpan KustoIngestionDelay = TimeSpan.FromMinutes(20);
    }
}
