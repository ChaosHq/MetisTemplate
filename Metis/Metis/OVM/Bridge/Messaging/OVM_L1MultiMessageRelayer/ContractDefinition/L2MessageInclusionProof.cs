using Nethereum.ABI.FunctionEncoding.Attributes;

namespace Metis.OVM.Bridge.Messaging.OVM_L1MultiMessageRelayer.ContractDefinition;

public class L2MessageInclusionProof : L2MessageInclusionProofBase
{
}

public class L2MessageInclusionProofBase
{
    [Parameter("bytes32", "stateRoot")] public virtual byte[] StateRoot { get; set; }

    [Parameter("tuple", "stateRootBatchHeader", 2)]
    public virtual ChainBatchHeader StateRootBatchHeader { get; set; }

    [Parameter("tuple", "stateRootProof", 3)]
    public virtual ChainInclusionProof StateRootProof { get; set; }

    [Parameter("bytes", "stateTrieWitness", 4)]
    public virtual byte[] StateTrieWitness { get; set; }

    [Parameter("bytes", "storageTrieWitness", 5)]
    public virtual byte[] StorageTrieWitness { get; set; }
}