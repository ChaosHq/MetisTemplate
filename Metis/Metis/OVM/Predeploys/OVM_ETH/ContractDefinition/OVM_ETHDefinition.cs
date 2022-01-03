using System.Numerics;
using Nethereum.ABI.FunctionEncoding.Attributes;
using Nethereum.Contracts;

namespace Metis.OVM.Predeploys.OVM_ETH.ContractDefinition;

public class OVM_ETHDeployment : OVM_ETHDeploymentBase
{
    public OVM_ETHDeployment() : base(BYTECODE)
    {
    }

    public OVM_ETHDeployment(string byteCode) : base(byteCode)
    {
    }
}

public class OVM_ETHDeploymentBase : ContractDeploymentMessage
{
    public static string BYTECODE =
        "60806040523480156200001c576000806200001962000398565b50505b5060405162001f0738038062001f07833981810160405260408110156200004d576000806200004a62000398565b50505b81019080805192919060200180519250839150604090505160408082018152600582526422ba3432b960d91b60208301525160408082019052600381526208aa8960eb1b602082015281818480806000600181620000aa62000405565b816001600160a01b0302191690836001600160a01b0316021790620000ce62000467565b5050505050816002908051620000e9929160200190620004b6565b506003818051620000ff929160200190620004b6565b5060005a6200010d62000578565b90507f8b73c3c69bb8fe3d512ecc4cf759cc79239f7b179b0ffacaa9a75d522b39400f60026040518082806200014262000405565b60018160011615610100020316600290048015620001ac5780601f10620001805761010080836200017262000405565b0402835291820191620001ac565b820191906000526020600020905b816200019962000405565b815290600101906020018083116200018e575b505091505060405180910390206040516040808201905260018152603160f81b602082015280519060200120835a63996d79a5598160e01b8152602081600483336000905af158600e01573d6000803e3d6000fd5b3d6001141558600a015760016000f35b8051925060005b6040811015620002315760008282015260200162000218565b5050506040516020810195909552604080860194909452606085019290925260808401526001600160a01b031660a083015260c09091019051602081830303815290604052805190602001208060076200028a62000467565b505050505050505050620002a481620002ac60201b60201c565b50506200063b565b6000806001620002bb62000405565b906101000a90046001600160a01b03166001600160a01b031614620003085760405162461bcd60e51b8152600401620002f490620005f6565b604051809103906200030562000398565b50505b80600180806200031762000405565b816001600160a01b0302191690836001600160a01b03160217906200033b62000467565b5050507f908408e307fc569b417f6cbec5d5a06f44a0a505ac0479b47d421a4b2fd6a1e660016000906200036e62000405565b906101000a90046001600160a01b03166040516200038d9190620005e2565b60405180910390a150565b632a2a7adb598160e01b8152600481016020815285602082015260005b86811015620003d2578086015182820160400152602001620003b5565b506020828760640184336000905af158600e01573d6000803e3d6000fd5b3d6001141558600a015760016000f35b505050565b6303daa959598160e01b8152836004820152602081602483336000905af158600e01573d6000803e3d6000fd5b3d6001141558600a015760016000f35b8051935060005b6040811015620004625760008282015260200162000449565b505050565b6322bd64c0598160e01b8152836004820152846024820152600081604483336000905af158600e01573d6000803e3d6000fd5b3d6001141558600a015760016000f35b60008152602062000449565b8280620004c262000405565b600181600116156101000203166002900490600052602060002090601f0160209004810192826200050257600085620004fa62000467565b505062000566565b82601f106200052057805160ff19168380011785620004fa62000467565b828001600101856200053162000467565b5050821562000566579182015b8281111562000566578251826200055462000467565b5050916020019190600101906200053e565b5062000574929150620005bf565b5090565b6390580256598160e01b8152602081600483336000905af158600e01573d6000803e3d6000fd5b3d6001141558600a015760016000f35b8051600082529350602062000449565b80821115620005745760008082620005d662000467565b505050600101620005bf565b6001600160a01b0391909116815260200190565b60208082526025908201527f436f6e74726163742068617320616c7265616479206265656e20696e697469616040820152641b1a5e995960da1b606082015260800190565b6118bc806200064b6000396000f3fe6080604052348015610019576000806100166113fb565b50505b50600436106101355760003560e01c80633cb747bf116100b6578063a84ce98c1161007a578063a84ce98c146103dd578063a9059cbb146103e5578063bdeaf6411461041a578063d505accf1461043b578063dd62ed3e1461049557610135565b80633cb747bf1461031e57806370a08231146103425780637ecebe00146103715780638d6e9a5b146103a057806395d89b41146103d557610135565b806323b872dd116100fd57806323b872dd1461028b5780632e1a7d4d146102ca57806330adf81f146102f0578063313ce567146102f85780633644e5151461031657610135565b806306fdde0314610143578063095ea7b3146101c257806318160ddd1461020b57806319ab453c14610225578063205c287814610256575b6000806101406113fb565b50505b61014b6104cc565b60405160208082528190810183818151815260200191508051906020019080838360005b8381101561018757808201518382015260200161016f565b50505050905090810190601f1680156101b45780820380516001836020036101000a031916815260200191505b509250505060405180910390f35b6101f7600480360360408110156101e1576000806101de6113fb565b50505b506001600160a01b038135169060200135610585565b604051901515815260200160405180910390f35b6102136105a4565b60405190815260200160405180910390f35b61025460048036036020811015610244576000806102416113fb565b50505b50356001600160a01b03166105b1565b005b61025460048036036040811015610275576000806102726113fb565b50505b506001600160a01b03813516906020013561068e565b6101f7600480360360608110156102aa576000806102a76113fb565b50505b506001600160a01b038135811691602081013590911690604001356106f2565b610254600480360360208110156102e9576000806102e66113fb565b50505b5035610802565b61021361086d565b610300610891565b60405160ff909116815260200160405180910390f35b610213610896565b6103266108a0565b6040516001600160a01b03909116815260200160405180910390f35b610213600480360360208110156103615760008061035e6113fb565b50505b50356001600160a01b03166108be565b610213600480360360208110156103905760008061038d6113fb565b50505b50356001600160a01b03166108d6565b610254600480360360408110156103bf576000806103bc6113fb565b50505b506001600160a01b0381351690602001356108ee565b61014b610b16565b610326610bb8565b6101f760048036036040811015610404576000806104016113fb565b50505b506001600160a01b038135169060200135610bc4565b610422610bd9565b60405163ffffffff909116815260200160405180910390f35b610254600480360360e081101561045a576000806104576113fb565b50505b506001600160a01b03813581169160208101359091169060408101359060608101359060ff6080820135169060a08101359060c00135610be0565b610213600480360360408110156104b4576000806104b16113fb565b50505b506001600160a01b0381358116916020013516610e49565b6002806104d7611466565b600181600116156101000203166002900480601f016020809104026020016040519081016040528181529190602083018280610511611466565b6001816001161561010002031660029004801561057d5780601f1061054b57610100808361053d611466565b04028352916020019161057d565b820191906000526020600020905b81610562611466565b8152906001019060200180831161055957829003601f168201915b505050505081565b600061059a5a6105936114c6565b8484610e6f565b5060015b92915050565b60046105ae611466565b81565b60008060016105be611466565b906101000a90046001600160a01b03166001600160a01b0316146106065760405162461bcd60e51b81526004016105f4906117ca565b604051809103906106036113fb565b50505b8060018080610613611466565b816001600160a01b0302191690836001600160a01b031602179061063561150c565b5050507f908408e307fc569b417f6cbec5d5a06f44a0a505ac0479b47d421a4b2fd6a1e66001600090610666611466565b906101000a90046001600160a01b031660405161068391906117b6565b60405180910390a150565b600080600161069b611466565b906101000a90046001600160a01b03166001600160a01b031614156106e45760405162461bcd60e51b81526004016106d29061180f565b604051809103906106e16113fb565b50505b6106ee8282610efb565b5050565b6001600160a01b038316600090815260066020526000196040822060005a6107186114c6565b6001600160a01b03166001600160a01b03168152602001908152602001600020610740611466565b146107ed576001600160a01b0384166000908152600660205261079c9083906040902060005a61076e6114c6565b6001600160a01b03166001600160a01b03168152602001908152602001600020610796611466565b90610fc2565b6001600160a01b038516600090815260066020526040902060005a6107bf6114c6565b6001600160a01b03166001600160a01b0316815260200190815260200160002081906107e961150c565b5050505b6107f884848461101f565b5060019392505050565b600080600161080f611466565b906101000a90046001600160a01b03166001600160a01b031614156108585760405162461bcd60e51b81526004016108469061180f565b604051809103906108556113fb565b50505b61086a5a6108646114c6565b82610efb565b50565b7f6e71edae12b1b97f4d1f60370fef10105fa2faae0126114a169c64845d6126c981565b601281565b60076105ae611466565b6000806108ab611466565b906101000a90046001600160a01b031681565b600560205280600052604060002090506105ae611466565b600860205280600052604060002090506105ae611466565b60008060016108fb611466565b906101000a90046001600160a01b03166001600160a01b031614156109445760405162461bcd60e51b81526004016109329061180f565b604051809103906109416113fb565b50505b60006001610950611466565b906101000a90046001600160a01b0316610968611107565b6001600160a01b03165a61097a6114c6565b6001600160a01b0316146109c85760405162461bcd60e51b815260040180806020018281038252602e81526020018061185e602e9139604001915050604051809103906109c56113fb565b50505b806001600160a01b03166109da611107565b6001600160a01b0316636e296e456040518163ffffffff1660e01b81526004016020604051808303818680610a0d61155a565b158015610a2257600080610a1f6113fb565b50505b505a610a2c6115a6565b5050505050158015610a4b573d6000803e3d6000610a486113fb565b50505b505050506040513d6020811015610a6a57600080610a676113fb565b50505b8101908080516001600160a01b0316939093149250610ac69150505760405162461bcd60e51b815260040180806020018281038252603081526020018061188c6030913960400191505060405180910390610ac36113fb565b50505b610ad08383611128565b826001600160a01b03167f162eb12ad2bd8b6ca7960f162208414ab3bc2da9f37953788ffd8cf850c3492b83604051610b099190611854565b60405180910390a2505050565b600380610b21611466565b600181600116156101000203166002900480601f016020809104026020016040519081016040528181529190602083018280610b5b611466565b6001816001161561010002031660029004801561057d5780601f10610b8757610100808361053d611466565b820191906000526020600020905b81610b9e611466565b81529060010190602001808311610b955750859350505050565b600060016108ab611466565b600061059a5a610bd26114c6565b848461101f565b620186a090565b5a610be9611691565b841015610c3a5760405162461bcd60e51b8152602060048201526012602482015271155b9a5cddd85c158c8e881156141254915160721b604482015260640160405180910390610c376113fb565b50505b60006007610c46611466565b6001600160a01b038916600090815260086020527f6e71edae12b1b97f4d1f60370fef10105fa2faae0126114a169c64845d6126c9908a908a908a9060409020600081610c91611466565b91600183019150610ca061150c565b50508a60405160200180878152602001866001600160a01b03168152602001856001600160a01b0316815260200184815260200183815260200182815260200196505050505050506040516020818303038152906040528051906020012060405161190160f01b602082015260228101929092526042820152606201604051602081830303815290604052805190602001209050600060018286868660405160008152602001604052604051808581526020018460ff1681526020018381526020018281526020019450505050506020604051602081039080840390855a610d866115a6565b5050505050158015610da5573d6000803e3d6000610da26113fb565b50505b5050506020604051035190506001600160a01b03811615801590610dda5750886001600160a01b0316816001600160a01b0316145b610e335760405162461bcd60e51b815260206004820152601c60248201527f556e697377617056323a20494e56414c49445f5349474e415455524500000000604482015260640160405180910390610e306113fb565b50505b610e3e898989610e6f565b505050505050505050565b600660205281600052604060002060205280600052604060002091506105ae9050611466565b6001600160a01b038316600090815260066020528190604090206001600160a01b0384166000908152602091909152604090208190610eac61150c565b505050816001600160a01b0316836001600160a01b03167f8c5be1e5ebec7d5bd14f71427d1e84f3dd0314c0f7b2291e5b200ac8c7c3b9258360405190815260200160405180910390a3505050565b610f058282611132565b6000637a7bda0d60e11b8383604051602401610f2292919061179d565b604051602081830303815290604052906001600160e01b0319166020820180516001600160e01b031690911790529050610f7f60006001610f61611466565b906101000a90046001600160a01b031682610f7a610bd9565b611144565b5a610f886114c6565b6001600160a01b03167fbb2689ff876f7ef453cf8865dde5ab10349d222e2e1383c5152fbdb083f02da28484604051610b0992919061179d565b8082038281111561059e5760405162461bcd60e51b815260206004820152601560248201527464732d6d6174682d7375622d756e646572666c6f7760581b6044820152606401604051809103906110176113fb565b505092915050565b6001600160a01b0383166000908152600560205261104590829060409020610796611466565b6001600160a01b0384166000908152600560205260409020819061106761150c565b5050506001600160a01b0382166000908152600560205261109690829060409020611090611466565b90611252565b6001600160a01b038316600090815260056020526040902081906110b861150c565b505050816001600160a01b0316836001600160a01b03167fddf252ad1be2c89b69c2b068fc378daa952ba7f163c4a11628f55a4df523b3ef8360405190815260200160405180910390a3505050565b60008080611113611466565b906101000a90046001600160a01b0316905090565b6106ee82826112a6565b6106ee5a61113e6114c6565b82611350565b61114c611107565b6001600160a01b0316633dbb202b8484846040518463ffffffff1660e01b815260040180846001600160a01b03168152602001806020018363ffffffff168152602001828103825284818151815260200191508051906020019080838360005b838110156111c45780820151838201526020016111ac565b50505050905090810190601f1680156111f15780820380516001836020036101000a031916815260200191505b509450505050506000604051808303816000878061120d61155a565b1580156112225760008061121f6113fb565b50505b505a61122c6116d7565b505050505050158015611249573d6000803e3d6000610e3e6113fb565b50505050505050565b8082018281101561059e5760405162461bcd60e51b815260206004820152601460248201527364732d6d6174682d6164642d6f766572666c6f7760601b6044820152606401604051809103906110176113fb565b6112b4816004611090611466565b8060046112bf61150c565b5050506001600160a01b038216600090815260056020526112e890829060409020611090611466565b6001600160a01b0383166000908152600560205260409020819061130a61150c565b5050506001600160a01b03821660007fddf252ad1be2c89b69c2b068fc378daa952ba7f163c4a11628f55a4df523b3ef8360405190815260200160405180910390a35050565b6001600160a01b0382166000908152600560205261137690829060409020610796611466565b6001600160a01b0383166000908152600560205260409020819061139861150c565b5050506113a9816004610796611466565b8060046113b461150c565b5060009150506001600160a01b0383167fddf252ad1be2c89b69c2b068fc378daa952ba7f163c4a11628f55a4df523b3ef8360405190815260200160405180910390a35050565b632a2a7adb598160e01b8152600481016020815285602082015260005b86811015611433578086015182820160400152602001611418565b506020828760640184336000905af158600e01573d6000803e3d6000fd5b3d6001141558600a015760016000f35b505050565b6303daa959598160e01b8152836004820152602081602483336000905af158600e01573d6000803e3d6000fd5b3d6001141558600a015760016000f35b8051935060005b60408110156114c1576000828201526020016114aa565b505050565b6373509064598160e01b8152602081600483336000905af158600e01573d6000803e3d6000fd5b3d6001141558600a015760016000f35b805160008252935060206114aa565b6322bd64c0598160e01b8152836004820152846024820152600081604483336000905af158600e01573d6000803e3d6000fd5b3d6001141558600a015760016000f35b6000815260206114aa565b638435035b598160e01b8152836004820152602081602483336000905af158600e01573d6000803e3d6000fd5b3d6001141558600a015760016000f35b805160008252935060206114aa565b638540661f598160e01b81526115d7565b808083111561059e575090919050565b808083101561059e575090919050565b836004820152846024820152606060448201528660648201526084810160005b8881101561160f5780880151828201526020016115f7565b506060828960a40184336000905af158600e01573d6000803e3d6000fd5b3d6001141558600a015760016000f35b815160408301513d6000853e8b8b82606087013350600060045af150596116648d3d6115c7565b8c0161167081876115b7565b5b828110156116855760008152602001611671565b50929c50505050505050565b63bdbf8c36598160e01b8152602081600483336000905af158600e01573d6000803e3d6000fd5b3d6001141558600a015760016000f35b805160008252935060206114aa565b6385979f76598160e01b8152836004820152846024820152606060448201528760648201526084810160005b8981101561171b578089015182820152602001611703565b506060828a60a40184336000905af158600e01573d6000803e3d6000fd5b3d6001141558600a015760016000f35b815160408301513d6000853e8c8c82606087013350600060045af150596117708e3d6115c7565b8d0161177c81876115b7565b5b82811015611791576000815260200161177d565b50929d50505050505050565b6001600160a01b03929092168252602082015260400190565b6001600160a01b0391909116815260200190565b60208082526025908201527f436f6e74726163742068617320616c7265616479206265656e20696e697469616040820152641b1a5e995960da1b606082015260800190565b60208082526025908201527f436f6e747261637420686173206e6f7420796574206265656e20696e697469616040820152641b1a5e995960da1b606082015260800190565b9081526020019056fe4f564d5f58434841494e3a206d657373656e67657220636f6e747261637420756e61757468656e746963617465644f564d5f58434841494e3a2077726f6e672073656e646572206f662063726f73732d646f6d61696e206d657373616765";

    public OVM_ETHDeploymentBase() : base(BYTECODE)
    {
    }

    public OVM_ETHDeploymentBase(string byteCode) : base(byteCode)
    {
    }

    [Parameter("address", "_l2CrossDomainMessenger")]
    public virtual string L2CrossDomainMessenger { get; set; }

    [Parameter("address", "_l1ETHGateway", 2)]
    public virtual string L1ETHGateway { get; set; }
}

public class DOMAIN_SEPARATORFunction : DOMAIN_SEPARATORFunctionBase
{
}

[Function("DOMAIN_SEPARATOR", "bytes32")]
public class DOMAIN_SEPARATORFunctionBase : FunctionMessage
{
}

public class PERMIT_TYPEHASHFunction : PERMIT_TYPEHASHFunctionBase
{
}

[Function("PERMIT_TYPEHASH", "bytes32")]
public class PERMIT_TYPEHASHFunctionBase : FunctionMessage
{
}

public class AllowanceFunction : AllowanceFunctionBase
{
}

[Function("allowance", "uint256")]
public class AllowanceFunctionBase : FunctionMessage
{
    [Parameter("address", "")] public virtual string ReturnValue1 { get; set; }

    [Parameter("address", "", 2)] public virtual string ReturnValue2 { get; set; }
}

public class ApproveFunction : ApproveFunctionBase
{
}

[Function("approve", "bool")]
public class ApproveFunctionBase : FunctionMessage
{
    [Parameter("address", "spender")] public virtual string Spender { get; set; }

    [Parameter("uint256", "value", 2)] public virtual BigInteger Value { get; set; }
}

public class BalanceOfFunction : BalanceOfFunctionBase
{
}

[Function("balanceOf", "uint256")]
public class BalanceOfFunctionBase : FunctionMessage
{
    [Parameter("address", "")] public virtual string ReturnValue1 { get; set; }
}

public class DecimalsFunction : DecimalsFunctionBase
{
}

[Function("decimals", "uint8")]
public class DecimalsFunctionBase : FunctionMessage
{
}

public class FinalizeDepositFunction : FinalizeDepositFunctionBase
{
}

[Function("finalizeDeposit")]
public class FinalizeDepositFunctionBase : FunctionMessage
{
    [Parameter("address", "_to")] public virtual string To { get; set; }

    [Parameter("uint256", "_amount", 2)] public virtual BigInteger Amount { get; set; }
}

public class GetFinalizeWithdrawalL1GasFunction : GetFinalizeWithdrawalL1GasFunctionBase
{
}

[Function("getFinalizeWithdrawalL1Gas", "uint32")]
public class GetFinalizeWithdrawalL1GasFunctionBase : FunctionMessage
{
}

public class InitFunction : InitFunctionBase
{
}

[Function("init")]
public class InitFunctionBase : FunctionMessage
{
    [Parameter("address", "_l1TokenGateway")]
    public virtual string L1TokenGateway { get; set; }
}

public class L1TokenGatewayFunction : L1TokenGatewayFunctionBase
{
}

[Function("l1TokenGateway", "address")]
public class L1TokenGatewayFunctionBase : FunctionMessage
{
}

public class MessengerFunction : MessengerFunctionBase
{
}

[Function("messenger", "address")]
public class MessengerFunctionBase : FunctionMessage
{
}

public class NameFunction : NameFunctionBase
{
}

[Function("name", "string")]
public class NameFunctionBase : FunctionMessage
{
}

public class NoncesFunction : NoncesFunctionBase
{
}

[Function("nonces", "uint256")]
public class NoncesFunctionBase : FunctionMessage
{
    [Parameter("address", "")] public virtual string ReturnValue1 { get; set; }
}

public class PermitFunction : PermitFunctionBase
{
}

[Function("permit")]
public class PermitFunctionBase : FunctionMessage
{
    [Parameter("address", "owner")] public virtual string Owner { get; set; }

    [Parameter("address", "spender", 2)] public virtual string Spender { get; set; }

    [Parameter("uint256", "value", 3)] public virtual BigInteger Value { get; set; }

    [Parameter("uint256", "deadline", 4)] public virtual BigInteger Deadline { get; set; }

    [Parameter("uint8", "v", 5)] public virtual byte V { get; set; }

    [Parameter("bytes32", "r", 6)] public virtual byte[] R { get; set; }

    [Parameter("bytes32", "s", 7)] public virtual byte[] S { get; set; }
}

public class SymbolFunction : SymbolFunctionBase
{
}

[Function("symbol", "string")]
public class SymbolFunctionBase : FunctionMessage
{
}

public class TotalSupplyFunction : TotalSupplyFunctionBase
{
}

[Function("totalSupply", "uint256")]
public class TotalSupplyFunctionBase : FunctionMessage
{
}

public class TransferFunction : TransferFunctionBase
{
}

[Function("transfer", "bool")]
public class TransferFunctionBase : FunctionMessage
{
    [Parameter("address", "to")] public virtual string To { get; set; }

    [Parameter("uint256", "value", 2)] public virtual BigInteger Value { get; set; }
}

public class TransferFromFunction : TransferFromFunctionBase
{
}

[Function("transferFrom", "bool")]
public class TransferFromFunctionBase : FunctionMessage
{
    [Parameter("address", "from")] public virtual string From { get; set; }

    [Parameter("address", "to", 2)] public virtual string To { get; set; }

    [Parameter("uint256", "value", 3)] public virtual BigInteger Value { get; set; }
}

public class WithdrawFunction : WithdrawFunctionBase
{
}

[Function("withdraw")]
public class WithdrawFunctionBase : FunctionMessage
{
    [Parameter("uint256", "_amount")] public virtual BigInteger Amount { get; set; }
}

public class WithdrawToFunction : WithdrawToFunctionBase
{
}

[Function("withdrawTo")]
public class WithdrawToFunctionBase : FunctionMessage
{
    [Parameter("address", "_to")] public virtual string To { get; set; }

    [Parameter("uint256", "_amount", 2)] public virtual BigInteger Amount { get; set; }
}

public class ApprovalEventDTO : ApprovalEventDTOBase
{
}

[Event("Approval")]
public class ApprovalEventDTOBase : IEventDTO
{
    [Parameter("address", "owner", 1, true)]
    public virtual string Owner { get; set; }

    [Parameter("address", "spender", 2, true)]
    public virtual string Spender { get; set; }

    [Parameter("uint256", "value", 3, false)]
    public virtual BigInteger Value { get; set; }
}

public class DepositFinalizedEventDTO : DepositFinalizedEventDTOBase
{
}

[Event("DepositFinalized")]
public class DepositFinalizedEventDTOBase : IEventDTO
{
    [Parameter("address", "_to", 1, true)] public virtual string To { get; set; }

    [Parameter("uint256", "_amount", 2, false)]
    public virtual BigInteger Amount { get; set; }
}

public class InitializedEventDTO : InitializedEventDTOBase
{
}

[Event("Initialized")]
public class InitializedEventDTOBase : IEventDTO
{
    [Parameter("address", "_l1TokenGateway", 1, false)]
    public virtual string L1TokenGateway { get; set; }
}

public class TransferEventDTO : TransferEventDTOBase
{
}

[Event("Transfer")]
public class TransferEventDTOBase : IEventDTO
{
    [Parameter("address", "from", 1, true)]
    public virtual string From { get; set; }

    [Parameter("address", "to", 2, true)] public virtual string To { get; set; }

    [Parameter("uint256", "value", 3, false)]
    public virtual BigInteger Value { get; set; }
}

public class WithdrawalInitiatedEventDTO : WithdrawalInitiatedEventDTOBase
{
}

[Event("WithdrawalInitiated")]
public class WithdrawalInitiatedEventDTOBase : IEventDTO
{
    [Parameter("address", "_from", 1, true)]
    public virtual string From { get; set; }

    [Parameter("address", "_to", 2, false)]
    public virtual string To { get; set; }

    [Parameter("uint256", "_amount", 3, false)]
    public virtual BigInteger Amount { get; set; }
}

public class DOMAIN_SEPARATOROutputDTO : DOMAIN_SEPARATOROutputDTOBase
{
}

[FunctionOutput]
public class DOMAIN_SEPARATOROutputDTOBase : IFunctionOutputDTO
{
    [Parameter("bytes32", "")] public virtual byte[] ReturnValue1 { get; set; }
}

public class PERMIT_TYPEHASHOutputDTO : PERMIT_TYPEHASHOutputDTOBase
{
}

[FunctionOutput]
public class PERMIT_TYPEHASHOutputDTOBase : IFunctionOutputDTO
{
    [Parameter("bytes32", "")] public virtual byte[] ReturnValue1 { get; set; }
}

public class AllowanceOutputDTO : AllowanceOutputDTOBase
{
}

[FunctionOutput]
public class AllowanceOutputDTOBase : IFunctionOutputDTO
{
    [Parameter("uint256", "")] public virtual BigInteger ReturnValue1 { get; set; }
}

public class BalanceOfOutputDTO : BalanceOfOutputDTOBase
{
}

[FunctionOutput]
public class BalanceOfOutputDTOBase : IFunctionOutputDTO
{
    [Parameter("uint256", "")] public virtual BigInteger ReturnValue1 { get; set; }
}

public class DecimalsOutputDTO : DecimalsOutputDTOBase
{
}

[FunctionOutput]
public class DecimalsOutputDTOBase : IFunctionOutputDTO
{
    [Parameter("uint8", "")] public virtual byte ReturnValue1 { get; set; }
}

public class GetFinalizeWithdrawalL1GasOutputDTO : GetFinalizeWithdrawalL1GasOutputDTOBase
{
}

[FunctionOutput]
public class GetFinalizeWithdrawalL1GasOutputDTOBase : IFunctionOutputDTO
{
    [Parameter("uint32", "")] public virtual uint ReturnValue1 { get; set; }
}

public class L1TokenGatewayOutputDTO : L1TokenGatewayOutputDTOBase
{
}

[FunctionOutput]
public class L1TokenGatewayOutputDTOBase : IFunctionOutputDTO
{
    [Parameter("address", "")] public virtual string ReturnValue1 { get; set; }
}

public class MessengerOutputDTO : MessengerOutputDTOBase
{
}

[FunctionOutput]
public class MessengerOutputDTOBase : IFunctionOutputDTO
{
    [Parameter("address", "")] public virtual string ReturnValue1 { get; set; }
}

public class NameOutputDTO : NameOutputDTOBase
{
}

[FunctionOutput]
public class NameOutputDTOBase : IFunctionOutputDTO
{
    [Parameter("string", "")] public virtual string ReturnValue1 { get; set; }
}

public class NoncesOutputDTO : NoncesOutputDTOBase
{
}

[FunctionOutput]
public class NoncesOutputDTOBase : IFunctionOutputDTO
{
    [Parameter("uint256", "")] public virtual BigInteger ReturnValue1 { get; set; }
}

public class SymbolOutputDTO : SymbolOutputDTOBase
{
}

[FunctionOutput]
public class SymbolOutputDTOBase : IFunctionOutputDTO
{
    [Parameter("string", "")] public virtual string ReturnValue1 { get; set; }
}

public class TotalSupplyOutputDTO : TotalSupplyOutputDTOBase
{
}

[FunctionOutput]
public class TotalSupplyOutputDTOBase : IFunctionOutputDTO
{
    [Parameter("uint256", "")] public virtual BigInteger ReturnValue1 { get; set; }
}