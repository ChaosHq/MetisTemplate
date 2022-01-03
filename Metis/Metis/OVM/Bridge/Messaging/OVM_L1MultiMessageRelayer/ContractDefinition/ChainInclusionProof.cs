using System.Collections.Generic;
using System.Numerics;
using Nethereum.ABI.FunctionEncoding.Attributes;

namespace Metis.OVM.Bridge.Messaging.OVM_L1MultiMessageRelayer.ContractDefinition;

public class ChainInclusionProof : ChainInclusionProofBase
{
}

public class ChainInclusionProofBase
{
    [Parameter("uint256", "index")] public virtual BigInteger Index { get; set; }

    [Parameter("bytes32[]", "siblings", 2)]
    public virtual List<byte[]> Siblings { get; set; }
}