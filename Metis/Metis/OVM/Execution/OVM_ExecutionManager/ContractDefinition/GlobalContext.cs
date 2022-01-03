using System.Numerics;
using Nethereum.ABI.FunctionEncoding.Attributes;

namespace Metis.OVM.Execution.OVM_ExecutionManager.ContractDefinition
{
    public partial class GlobalContext : GlobalContextBase { }

    public class GlobalContextBase 
    {
        [Parameter("uint256", "ovmCHAINID", 1)]
        public virtual BigInteger OvmCHAINID { get; set; }
    }
}
