using System.Numerics;
using Nethereum.ABI.FunctionEncoding.Attributes;

namespace Metis.OVM.Execution.OVM_ExecutionManager.ContractDefinition;

public class GlobalContext : GlobalContextBase
{
}

public class GlobalContextBase
{
    [Parameter("uint256", "ovmCHAINID")] public virtual BigInteger OvmCHAINID { get; set; }
}