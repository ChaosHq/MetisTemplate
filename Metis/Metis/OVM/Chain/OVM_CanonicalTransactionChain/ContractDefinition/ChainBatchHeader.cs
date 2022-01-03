using System.Numerics;
using Nethereum.ABI.FunctionEncoding.Attributes;

namespace Metis.OVM.Chain.OVM_CanonicalTransactionChain.ContractDefinition;

public class ChainBatchHeader : ChainBatchHeaderBase
{
}

public class ChainBatchHeaderBase
{
    [Parameter("uint256", "batchIndex")] public virtual BigInteger BatchIndex { get; set; }

    [Parameter("bytes32", "batchRoot", 2)] public virtual byte[] BatchRoot { get; set; }

    [Parameter("uint256", "batchSize", 3)] public virtual BigInteger BatchSize { get; set; }

    [Parameter("uint256", "prevTotalElements", 4)]
    public virtual BigInteger PrevTotalElements { get; set; }

    [Parameter("bytes", "extraData", 5)] public virtual byte[] ExtraData { get; set; }
}