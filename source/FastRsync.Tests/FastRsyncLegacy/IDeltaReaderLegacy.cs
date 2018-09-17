﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FastRsync.Delta;
using FastRsync.Hash;
using FastRsync.Signature;

namespace FastRsync.Tests.FastRsyncLegacy
{
    internal interface IDeltaReaderLegacy
    {
        byte[] ExpectedHash { get; }
        IHashAlgorithm HashAlgorithm { get; }
        DeltaMetadataLegacy Metadata { get; }
        RsyncFormatType Type { get; }
        void Apply(
            Action<byte[]> writeData,
            Action<long, long> copy
        );

        Task ApplyAsync(
            Func<byte[], Task> writeData,
            Func<long, long, Task> copy
        );
    }
}
