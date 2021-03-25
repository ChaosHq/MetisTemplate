using System;
using System.Threading.Tasks;
using System.Collections.Generic;
using System.Numerics;
using Nethereum.Hex.HexTypes;
using Nethereum.ABI.FunctionEncoding.Attributes;
using Nethereum.Web3;
using Nethereum.RPC.Eth.DTOs;
using Nethereum.Contracts.CQS;
using Nethereum.Contracts;
using System.Threading;

namespace OptimismTemplate.Contracts.OVM_L1MultiMessageRelayer.ContractDefinition
{


    public partial class OVM_L1MultiMessageRelayerDeployment : OVM_L1MultiMessageRelayerDeploymentBase
    {
        public OVM_L1MultiMessageRelayerDeployment() : base(BYTECODE) { }
        public OVM_L1MultiMessageRelayerDeployment(string byteCode) : base(byteCode) { }
    }

    public class OVM_L1MultiMessageRelayerDeploymentBase : ContractDeploymentMessage
    {
        public static string BYTECODE = "608060405234801561001057600080fd5b50604051610a00380380610a0083398101604081905261002f91610054565b600080546001600160a01b0319166001600160a01b0392909216919091179055610082565b600060208284031215610065578081fd5b81516001600160a01b038116811461007b578182fd5b9392505050565b61096f806100916000396000f3fe608060405234801561001057600080fd5b50600436106100365760003560e01c806316e9cd9b1461003b578063461a447814610050575b600080fd5b61004e61004936600461055b565b610079565b005b61006361005e3660046105ca565b6101d7565b60405161007091906106b9565b60405180910390f35b6100b76040518060400160405280601981526020017f4f564d5f4c3242617463684d65737361676552656c61796572000000000000008152506101d7565b6001600160a01b0316336001600160a01b0316146100f05760405162461bcd60e51b81526004016100e7906107b5565b60405180910390fd5b6000610113604051806060016040528060218152602001610919602191396101d7565b905060005b828110156101d157600084848381811061012e57fe5b90506020028101906101409190610838565b6101499061087b565b8051602082015160408084015160608501516080860151925163d7fd19dd60e01b81529596506001600160a01b0389169563d7fd19dd95610192959094909392916004016106cd565b600060405180830381600087803b1580156101ac57600080fd5b505af11580156101c0573d6000803e3d6000fd5b505060019093019250610118915050565b50505050565b6000805460405163bf40fac160e01b81526020600482018181528551602484015285516001600160a01b039094169363bf40fac19387938392604490920191908501908083838b5b8381101561023757818101518382015260200161021f565b50505050905090810190601f1680156102645780820380516001836020036101000a031916815260200191505b509250505060206040518083038186803b15801561028157600080fd5b505afa158015610295573d6000803e3d6000fd5b505050506040513d60208110156102ab57600080fd5b505190505b919050565b600067ffffffffffffffff8311156102c957fe5b6102dc601f8401601f1916602001610857565b90508281528383830111156102f057600080fd5b828260208301376000602084830101529392505050565b80356001600160a01b03811681146102b057600080fd5b600082601f83011261032e578081fd5b61033d838335602085016102b5565b9392505050565b600060a08284031215610355578081fd5b60405160a0810167ffffffffffffffff828210818311171561037357fe5b816040528293508435835260208501356020840152604085013560408401526060850135606084015260808501359150808211156103b057600080fd5b506103bd8582860161031e565b6080830152505092915050565b6000604082840312156103db578081fd5b6040516040810167ffffffffffffffff82821081831117156103f957fe5b816040528293508435835260209150818501358181111561041957600080fd5b8501601f8101871361042a57600080fd5b80358281111561043657fe5b8381029250610446848401610857565b8181528481019083860185850187018b101561046157600080fd5b600095505b83861015610484578035835260019590950194918601918601610466565b5080868801525050505050505092915050565b600060a082840312156104a8578081fd5b6104b260a0610857565b905081358152602082013567ffffffffffffffff808211156104d357600080fd5b6104df85838601610344565b602084015260408401359150808211156104f857600080fd5b610504858386016103ca565b6040840152606084013591508082111561051d57600080fd5b6105298583860161031e565b6060840152608084013591508082111561054257600080fd5b5061054f8482850161031e565b60808301525092915050565b6000806020838503121561056d578182fd5b823567ffffffffffffffff80821115610584578384fd5b818501915085601f830112610597578384fd5b8135818111156105a5578485fd5b86602080830285010111156105b8578485fd5b60209290920196919550909350505050565b6000602082840312156105db578081fd5b813567ffffffffffffffff8111156105f1578182fd5b8201601f81018413610601578182fd5b610610848235602084016102b5565b949350505050565b60008151808452815b8181101561063d57602081850181015186830182015201610621565b8181111561064e5782602083870101525b50601f01601f19169290920160200192915050565b6000604083018251845260208084015160408287015282815180855260608801915083830194508592505b808310156106ae578451825293830193600192909201919083019061068e565b509695505050505050565b6001600160a01b0391909116815260200190565b6001600160a01b0386811682528516602082015260a0604082018190526000906106f990830186610618565b846060840152828103608084015283518152602084015160a06020830152805160a0830152602081015160c0830152604081015160e083015260608101516101008301526080810151905060a061012083015261075a610140830182610618565b9050604085015182820360408401526107738282610663565b9150506060850151828203606084015261078d8282610618565b915050608085015182820360808401526107a78282610618565b9a9950505050505050505050565b60208082526057908201527f4f564d5f4c314d756c74694d65737361676552656c617965723a2046756e637460408201527f696f6e2063616e206f6e6c792062652063616c6c656420627920746865204f5660608201527f4d5f4c3242617463684d65737361676552656c61796572000000000000000000608082015260a00190565b60008235609e1983360301811261084d578182fd5b9190910192915050565b60405181810167ffffffffffffffff8111828210171561087357fe5b604052919050565b600060a0823603121561088c578081fd5b60405160a0810167ffffffffffffffff82821081831117156108aa57fe5b816040526108b785610307565b83526108c560208601610307565b602084015260408501359150808211156108dd578384fd5b6108e93683870161031e565b604084015260608501356060840152608085013591508082111561090b578384fd5b5061054f3682860161049756fe50726f78795f5f4f564d5f4c3143726f7373446f6d61696e4d657373656e676572a2646970667358221220108ecef32e585213fd4e8a48e2fa7ee49c48587de115dfb7ba963515e732de9b64736f6c63430007060033";
        public OVM_L1MultiMessageRelayerDeploymentBase() : base(BYTECODE) { }
        public OVM_L1MultiMessageRelayerDeploymentBase(string byteCode) : base(byteCode) { }
        [Parameter("address", "_libAddressManager", 1)]
        public virtual string LibAddressManager { get; set; }
    }

    public partial class BatchRelayMessagesFunction : BatchRelayMessagesFunctionBase { }

    [Function("batchRelayMessages")]
    public class BatchRelayMessagesFunctionBase : FunctionMessage
    {
        [Parameter("tuple[]", "_messages", 1)]
        public virtual List<L2ToL1Message> Messages { get; set; }
    }

    public partial class ResolveFunction : ResolveFunctionBase { }

    [Function("resolve", "address")]
    public class ResolveFunctionBase : FunctionMessage
    {
        [Parameter("string", "_name", 1)]
        public virtual string Name { get; set; }
    }



    public partial class ResolveOutputDTO : ResolveOutputDTOBase { }

    [FunctionOutput]
    public class ResolveOutputDTOBase : IFunctionOutputDTO 
    {
        [Parameter("address", "_contract", 1)]
        public virtual string Contract { get; set; }
    }
}