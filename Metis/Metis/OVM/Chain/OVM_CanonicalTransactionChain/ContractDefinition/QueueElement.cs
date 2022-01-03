using Nethereum.ABI.FunctionEncoding.Attributes;

namespace Metis.OVM.Chain.OVM_CanonicalTransactionChain.ContractDefinition;

public class QueueElement : QueueElementBase
{
}

public class QueueElementBase
{
    [Parameter("bytes32", "transactionHash")]
    public virtual byte[] TransactionHash { get; set; }

    [Parameter("uint40", "timestamp", 2)] public virtual ulong Timestamp { get; set; }

    [Parameter("uint40", "blockNumber", 3)]
    public virtual ulong BlockNumber { get; set; }
}