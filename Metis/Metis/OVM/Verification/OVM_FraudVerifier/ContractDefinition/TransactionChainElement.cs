using System.Numerics;
using Nethereum.ABI.FunctionEncoding.Attributes;

namespace Metis.OVM.Verification.OVM_FraudVerifier.ContractDefinition;

public class TransactionChainElement : TransactionChainElementBase
{
}

public class TransactionChainElementBase
{
    [Parameter("bool", "isSequenced")] public virtual bool IsSequenced { get; set; }

    [Parameter("uint256", "queueIndex", 2)]
    public virtual BigInteger QueueIndex { get; set; }

    [Parameter("uint256", "timestamp", 3)] public virtual BigInteger Timestamp { get; set; }

    [Parameter("uint256", "blockNumber", 4)]
    public virtual BigInteger BlockNumber { get; set; }

    [Parameter("bytes", "txData", 5)] public virtual byte[] TxData { get; set; }
}