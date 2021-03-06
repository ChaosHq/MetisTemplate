using System.Numerics;
using Nethereum.ABI.FunctionEncoding.Attributes;

namespace Metis.OVM.Execution.OVM_ExecutionManager.ContractDefinition;

public class GasMeterConfig : GasMeterConfigBase
{
}

public class GasMeterConfigBase
{
    [Parameter("uint256", "minTransactionGasLimit")]
    public virtual BigInteger MinTransactionGasLimit { get; set; }

    [Parameter("uint256", "maxTransactionGasLimit", 2)]
    public virtual BigInteger MaxTransactionGasLimit { get; set; }

    [Parameter("uint256", "maxGasPerQueuePerEpoch", 3)]
    public virtual BigInteger MaxGasPerQueuePerEpoch { get; set; }

    [Parameter("uint256", "secondsPerEpoch", 4)]
    public virtual BigInteger SecondsPerEpoch { get; set; }
}