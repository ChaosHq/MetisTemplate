using System.Numerics;
using Nethereum.ABI.FunctionEncoding.Attributes;

namespace Metis.OVM.Bridge.Messaging.OVM_L1MultiMessageRelayer.ContractDefinition;

public class L2ToL1Message : L2ToL1MessageBase
{
}

public class L2ToL1MessageBase
{
    [Parameter("address", "target")] public virtual string Target { get; set; }

    [Parameter("address", "sender", 2)] public virtual string Sender { get; set; }

    [Parameter("bytes", "message", 3)] public virtual byte[] Message { get; set; }

    [Parameter("uint256", "messageNonce", 4)]
    public virtual BigInteger MessageNonce { get; set; }

    [Parameter("tuple", "proof", 5)] public virtual L2MessageInclusionProof Proof { get; set; }
}