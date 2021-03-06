// Copyright (c) Microsoft Corporation.
// Licensed under the MIT License.

using System.Diagnostics.CodeAnalysis;
using Xunit;

namespace BuildXL.Cache.MemoizationStore.VstsTest
{
    [Trait("Category", "Simulation")]
    [SuppressMessage("ReSharper", "UnusedMember.Global")]
    public class BlobDistributedWriteThroughBuildCacheSimulationTests : DistributedWriteThroughBuildCacheSimulationTests
    {
        public BlobDistributedWriteThroughBuildCacheSimulationTests()
            : base(StorageOption.Blob)
        {
        }
    }
}
