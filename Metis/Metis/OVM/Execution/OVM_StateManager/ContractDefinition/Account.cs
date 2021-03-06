using System.Numerics;
using Nethereum.ABI.FunctionEncoding.Attributes;

namespace Metis.OVM.Execution.OVM_StateManager.ContractDefinition;

public class Account : AccountBase
{
}

public class AccountBase
{
    [Parameter("uint256", "nonce")] public virtual BigInteger Nonce { get; set; }

    [Parameter("uint256", "balance", 2)] public virtual BigInteger Balance { get; set; }

    [Parameter("bytes32", "storageRoot", 3)]
    public virtual byte[] StorageRoot { get; set; }

    [Parameter("bytes32", "codeHash", 4)] public virtual byte[] CodeHash { get; set; }

    [Parameter("address", "ethAddress", 5)]
    public virtual string EthAddress { get; set; }

    [Parameter("bool", "isFresh", 6)] public virtual bool IsFresh { get; set; }
}