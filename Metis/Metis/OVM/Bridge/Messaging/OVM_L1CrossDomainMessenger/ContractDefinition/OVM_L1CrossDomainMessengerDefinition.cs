using System.Numerics;
using Nethereum.ABI.FunctionEncoding.Attributes;
using Nethereum.Contracts;

namespace Metis.OVM.Bridge.Messaging.OVM_L1CrossDomainMessenger.ContractDefinition;

public class OVM_L1CrossDomainMessengerDeployment : OVM_L1CrossDomainMessengerDeploymentBase
{
    public OVM_L1CrossDomainMessengerDeployment() : base(BYTECODE)
    {
    }

    public OVM_L1CrossDomainMessengerDeployment(string byteCode) : base(byteCode)
    {
    }
}

public class OVM_L1CrossDomainMessengerDeploymentBase : ContractDeploymentMessage
{
    public static string BYTECODE =
        "6080604052600580546001600160a01b03191661dead17905534801561002457600080fd5b506001600055600680546001600160a01b031916905561266d806100496000396000f3fe608060405234801561001057600080fd5b50600436106100a95760003560e01c8063706ceab611610071578063706ceab61461011c57806382e3702d1461012f578063b1b1b20914610142578063c4d66de814610155578063d7fd19dd14610168578063ecc704281461017b576100a9565b806321d800ec146100ae578063299ca478146100d75780633dbb202b146100ec578063461a4478146101015780636e296e4514610114575b600080fd5b6100c16100bc3660046120ae565b610190565b6040516100ce91906122c4565b60405180910390f35b6100df6101a5565b6040516100ce919061224c565b6100ff6100fa366004612032565b6101b4565b005b6100df61010f3660046120c6565b610243565b6100df61031f565b6100ff61012a366004611fbb565b610368565b6100c161013d3660046120ae565b6103cf565b6100c16101503660046120ae565b6103e4565b6100ff610163366004611e72565b6103f9565b6100ff610176366004611e8c565b61044f565b6101836106d0565b6040516100ce9190612195565b60016020526000908152604090205460ff1681565b6006546001600160a01b031681565b60006101c48433856004546106d6565b60048054600190810190915581516020808401919091206000908152600390915260409020805460ff1916909117905590506102068163ffffffff8416610723565b7f0ee9ffdb2334d78de97ffb066b23a352a4d35180cefb36589d663fbb1eb6f326816040516102359190612346565b60405180910390a150505050565b60065460405163bf40fac160e01b81526020600482018181528451602484015284516000946001600160a01b03169363bf40fac1938793928392604401918501908083838b5b838110156102a1578181015183820152602001610289565b50505050905090810190601f1680156102ce5780820380516001836020036101000a031916815260200191505b509250505060206040518083038186803b1580156102eb57600080fd5b505afa1580156102ff573d6000803e3d6000fd5b505050506040513d602081101561031557600080fd5b505190505b919050565b6005546000906001600160a01b031661dead14156103585760405162461bcd60e51b815260040161034f90612359565b60405180910390fd5b506005546001600160a01b031690565b6000610376868686866106d6565b805160208083019190912060009081526003909152604090205490915060ff1615156001146103b75760405162461bcd60e51b815260040161034f9061244e565b6103c7818363ffffffff16610723565b505050505050565b60036020526000908152604090205460ff1681565b60026020526000908152604090205460ff1681565b6006546001600160a01b0316156104225760405162461bcd60e51b815260040161034f90612536565b600680546001600160a01b039092166001600160a01b03199283161790556005805490911661dead179055565b600260005414156104a7576040805162461bcd60e51b815260206004820152601f60248201527f5265656e7472616e637947756172643a207265656e7472616e742063616c6c00604482015290519081900360640190fd5b6002600090815560408051808201909152601481527327ab26afa61926b2b9b9b0b3b2a932b630bcb2b960611b60208201526104e290610243565b90506001600160a01b0381161561051b57336001600160a01b0382161461051b5760405162461bcd60e51b815260040161034f90612499565b6000610529878787876106d6565b905061053581846107fb565b15156001146105565760405162461bcd60e51b815260040161034f906124ef565b80516020808301919091206000818152600290925260409091205460ff16156105915760405162461bcd60e51b815260040161034f90612390565b600580546001600160a01b0319166001600160a01b03898116919091179091556040516000918a16906105c59089906121ac565b6000604051808303816000865af19150503d8060008114610602576040519150601f19603f3d011682016040523d82523d6000602084013e610607565b606091505b5050600580546001600160a01b03191661dead17905590508015156001141561067c5760008281526002602052604090819020805460ff19166001179055517f4641df4a962071e12719d8c8c8e5ac7fc4d97b927346a3d7a335b1f7517e133c90610673908490612195565b60405180910390a15b6000833343604051602001610693939291906121fa565b60408051601f1981840301815291815281516020928301206000908152600192839052908120805460ff1916831790555550505050505050505050565b60045481565b6060848484846040516024016106ef9493929190612260565b60408051601f198184030181529190526020810180516001600160e01b031663cbd4ece960e01b1790529050949350505050565b6107616040518060400160405280601d81526020017f4f564d5f43616e6f6e6963616c5472616e73616374696f6e436861696e000000815250610243565b6001600160a01b0316636fee07e06107ad6040518060400160405280601a81526020017f4f564d5f4c3243726f7373446f6d61696e4d657373656e676572000000000000815250610243565b83856040518463ffffffff1660e01b81526004016107cd9392919061229d565b600060405180830381600087803b1580156107e757600080fd5b505af11580156103c7573d6000803e3d6000fd5b600061080682610820565b80156108175750610817838361097d565b90505b92915050565b6000806108616040518060400160405280601881526020017f4f564d5f5374617465436f6d6d69746d656e74436861696e0000000000000000815250610243565b6020840151604051639418bddd60e01b81529192506001600160a01b03831691639418bddd9161089391600401612580565b60206040518083038186803b1580156108ab57600080fd5b505afa1580156108bf573d6000803e3d6000fd5b505050506040513d601f19601f820116820180604052508101906108e3919061208e565b1580156109765750825160208401516040808601519051634d69ee5760e01b81526001600160a01b03851693634d69ee57936109269391929091906004016122cf565b60206040518083038186803b15801561093e57600080fd5b505afa158015610952573d6000803e3d6000fd5b505050506040513d601f19601f82011682018060405250810190610976919061208e565b9392505050565b600080836109bf6040518060400160405280601a81526020017f4f564d5f4c3243726f7373446f6d61696e4d657373656e676572000000000000815250610243565b6040516020016109d09291906121c8565b6040516020818303038152906040528051906020012060006040516020016109f992919061219e565b604051602081830303815290604052805190602001209050600080610a48602160991b604051602001610a2c919061217d565b60408051601f1981840301815291905260608701518751610ada565b9092509050600182151514610a6f5760405162461bcd60e51b815260040161034f906123db565b6000610a7a82610b03565b9050610acf84604051602001610a909190612195565b6040516020818303038152906040526001604051602001610ab19190612234565b60405160208183030381529060405288608001518460400151610b95565b979650505050505050565b600060606000610ae986610bb9565b9050610af6818686610be9565b9250925050935093915050565b610b0b611c28565b6000610b1683610cbc565b90506040518060800160405280610b4083600081518110610b3357fe5b6020026020010151610ccf565b8152602001610b5583600181518110610b3357fe5b8152602001610b7783600281518110610b6a57fe5b6020026020010151610cd6565b8152602001610b8c83600381518110610b6a57fe5b90529392505050565b600080610ba186610bb9565b9050610baf81868686610dcf565b9695505050505050565b60608180519060200120604051602001610bd39190612195565b6040516020818303038152906040529050919050565b600060606000610bf885610df5565b90506000806000610c0a848a89610ecc565b81519295509093509150158080610c1e5750815b610c6f576040805162461bcd60e51b815260206004820152601a60248201527f50726f76696465642070726f6f6620697320696e76616c69642e000000000000604482015290519081900360640190fd5b600081610c8b5760405180602001604052806000815250610caa565b610caa866001870381518110610c9d57fe5b602002602001015161126f565b919b919a509098505050505050505050565b606061081a610cca8361128b565b6112b0565b600061081a825b6000602182600001511115610d32576040805162461bcd60e51b815260206004820152601a60248201527f496e76616c696420524c5020627974657333322076616c75652e000000000000604482015290519081900360640190fd5b6000806000610d4085611426565b919450925090506000816001811115610d5557fe5b14610da7576040805162461bcd60e51b815260206004820152601a60248201527f496e76616c696420524c5020627974657333322076616c75652e000000000000604482015290519081900360640190fd5b602080860151840180519091841015610baf5760208490036101000a90049695505050505050565b6000806000610ddf878686610be9565b91509150818015610acf5750610acf868261174f565b60606000610e0283610cbc565b90506000815167ffffffffffffffff81118015610e1e57600080fd5b50604051908082528060200260200182016040528015610e5857816020015b610e45611c4f565b815260200190600190039081610e3d5790505b50905060005b8251811015610ec4576000610e85848381518110610e7857fe5b6020026020010151611765565b90506040518060400160405280828152602001610ea183610cbc565b815250838381518110610eb057fe5b602090810291909101015250600101610e5e565b509392505050565b60006060818080610edc876117f4565b905085600080610eea611c4f565b60005b8c51811015611247578c8181518110610f0257fe5b6020026020010151915082840193506001870196508360001415610f7657815180516020909101208514610f71576040805162461bcd60e51b8152602060048201526011602482015270092dcecc2d8d2c840e4dedee840d0c2e6d607b1b604482015290519081900360640190fd5b61103d565b815151602011610fdd57815180516020909101208514610f71576040805162461bcd60e51b815260206004820152601b60248201527f496e76616c6964206c6172676520696e7465726e616c20686173680000000000604482015290519081900360640190fd5b84610feb83600001516118f1565b1461103d576040805162461bcd60e51b815260206004820152601a60248201527f496e76616c696420696e7465726e616c206e6f64652068617368000000000000604482015290519081900360640190fd5b602082015151601114156110ac57855184141561105957611247565b600086858151811061106757fe5b602001015160f81c60f81b60f81c9050600083602001518260ff168151811061108c57fe5b6020026020010151905061109f8161191d565b965060019450505061123f565b600282602001515114156111f25760006110c583611953565b90506000816000815181106110d657fe5b016020015160f81c90506001811660020360006110f68460ff8416611971565b905060006111048b8a611971565b9050600061111283836119a2565b905060ff851660021480611129575060ff85166003145b1561115b5780835114801561113e5750808251145b1561114857988901985b50600160ff1b9950611247945050505050565b60ff8516158061116e575060ff85166001145b156111bb578061118b5750600160ff1b9950611247945050505050565b6111ac886020015160018151811061119f57fe5b602002602001015161191d565b9a50975061123f945050505050565b60405162461bcd60e51b81526004018080602001828103825260268152602001806126126026913960400191505060405180910390fd5b6040805162461bcd60e51b815260206004820152601d60248201527f526563656976656420616e20756e706172736561626c65206e6f64652e000000604482015290519081900360640190fd5b600101610eed565b50600160ff1b84148661125a8786611971565b909e909d50909b509950505050505050505050565b6020810151805160609161081a916000198101908110610e7857fe5b611293611c69565b506040805180820190915281518152602082810190820152919050565b60606000806112be84611426565b919350909150600190508160018111156112d457fe5b14611326576040805162461bcd60e51b815260206004820152601760248201527f496e76616c696420524c50206c6973742076616c75652e000000000000000000604482015290519081900360640190fd5b6040805160208082526104208201909252600091816020015b611347611c69565b81526020019060019003908161133f5790505090506000835b865181101561141b57602082106113a85760405162461bcd60e51b815260040180806020018281038252602a8152602001806125e8602a913960400191505060405180910390fd5b6000806113d46040518060400160405280858c60000151038152602001858c6020015101815250611426565b509150915060405180604001604052808383018152602001848b602001510181525085858151811061140257fe5b6020908102919091010152600193909301920101611360565b508152949350505050565b600080600080846000015111611483576040805162461bcd60e51b815260206004820152601860248201527f524c50206974656d2063616e6e6f74206265206e756c6c2e0000000000000000604482015290519081900360640190fd5b6020840151805160001a607f81116114a8576000600160009450945094505050611748565b60b7811161151d578551607f19820190811061150b576040805162461bcd60e51b815260206004820152601960248201527f496e76616c696420524c502073686f727420737472696e672e00000000000000604482015290519081900360640190fd5b60019550935060009250611748915050565b60bf811161160157855160b6198201908110611580576040805162461bcd60e51b815260206004820152601f60248201527f496e76616c696420524c50206c6f6e6720737472696e67206c656e6774682e00604482015290519081900360640190fd5b6000816020036101000a60018501510490508082018860000151116115ec576040805162461bcd60e51b815260206004820152601860248201527f496e76616c696420524c50206c6f6e6720737472696e672e0000000000000000604482015290519081900360640190fd5b60019091019550935060009250611748915050565b60f7811161167557855160bf198201908110611664576040805162461bcd60e51b815260206004820152601760248201527f496e76616c696420524c502073686f7274206c6973742e000000000000000000604482015290519081900360640190fd5b600195509350849250611748915050565b855160f61982019081106116d0576040805162461bcd60e51b815260206004820152601d60248201527f496e76616c696420524c50206c6f6e67206c697374206c656e6774682e000000604482015290519081900360640190fd5b6000816020036101000a6001850151049050808201886000015111611735576040805162461bcd60e51b815260206004820152601660248201527524b73b30b634b210292628103637b733903634b9ba1760511b604482015290519081900360640190fd5b6001918201965094509250611748915050565b9193909250565b8051602091820120825192909101919091201490565b6060600080600061177585611426565b91945092509050600081600181111561178a57fe5b146117dc576040805162461bcd60e51b815260206004820152601860248201527f496e76616c696420524c502062797465732076616c75652e0000000000000000604482015290519081900360640190fd5b6117eb85602001518484611a08565b95945050505050565b60606000825160020267ffffffffffffffff8111801561181357600080fd5b506040519080825280601f01601f19166020018201604052801561183e576020820181803683370190505b50905060005b83518110156118ea57600484828151811061185b57fe5b602001015160f81c60f81b6001600160f81b031916901c82826002028151811061188157fe5b60200101906001600160f81b031916908160001a90535060108482815181106118a657fe5b016020015160f81c816118b557fe5b0660f81b8282600202600101815181106118cb57fe5b60200101906001600160f81b031916908160001a905350600101611844565b5092915050565b60006020825110156119085750602081015161031a565b81806020019051602081101561031557600080fd5b6000606060208360000151101561193e5761193783611ab6565b905061194a565b61194783611765565b90505b610976816118f1565b606061081a61196c8360200151600081518110610e7857fe5b6117f4565b60608183510360001415611994575060408051602081019091526000815261081a565b610817838384865103611ac1565b6000805b8084511180156119b65750808351115b80156119fb57508281815181106119c957fe5b602001015160f81c60f81b6001600160f81b0319168482815181106119ea57fe5b01602001516001600160f81b031916145b15610817576001016119a6565b606060008267ffffffffffffffff81118015611a2357600080fd5b506040519080825280601f01601f191660200182016040528015611a4e576020820181803683370190505b509050805160001415611a62579050610976565b8484016020820160005b60208604811015611a8d578251825260209283019290910190600101611a6c565b5080519151601f959095166020036101000a600019019182169119909416179092525092915050565b606061081a82611c12565b60608182601f011015611b0c576040805162461bcd60e51b815260206004820152600e60248201526d736c6963655f6f766572666c6f7760901b604482015290519081900360640190fd5b828284011015611b54576040805162461bcd60e51b815260206004820152600e60248201526d736c6963655f6f766572666c6f7760901b604482015290519081900360640190fd5b81830184511015611ba0576040805162461bcd60e51b8152602060048201526011602482015270736c6963655f6f75744f66426f756e647360781b604482015290519081900360640190fd5b606082158015611bbf5760405191506000825260208201604052611c09565b6040519150601f8416801560200281840101858101878315602002848b0101015b81831015611bf8578051835260209283019201611be0565b5050858452601f01601f1916604052505b50949350505050565b606061081a826020015160008460000151611a08565b60408051608081018252600080825260208201819052918101829052606081019190915290565b604051806040016040528060608152602001606081525090565b604051806040016040528060008152602001600081525090565b600067ffffffffffffffff831115611c9757fe5b611caa601f8401601f1916602001612593565b9050828152838383011115611cbe57600080fd5b828260208301376000602084830101529392505050565b80356001600160a01b038116811461031a57600080fd5b600082601f830112611cfc578081fd5b61081783833560208501611c83565b600060a08284031215611d1c578081fd5b60405160a0810167ffffffffffffffff8282108183111715611d3a57fe5b81604052829350843583526020850135602084015260408501356040840152606085013560608401526080850135915080821115611d7757600080fd5b50611d8485828601611cec565b6080830152505092915050565b600060408284031215611da2578081fd5b6040516040810167ffffffffffffffff8282108183111715611dc057fe5b8160405282935084358352602091508185013581811115611de057600080fd5b8501601f81018713611df157600080fd5b803582811115611dfd57fe5b8381029250611e0d848401612593565b8181528481019083860185850187018b1015611e2857600080fd5b600095505b83861015611e4b578035835260019590950194918601918601611e2d565b5080868801525050505050505092915050565b803563ffffffff8116811461031a57600080fd5b600060208284031215611e83578081fd5b61081782611cd5565b600080600080600060a08688031215611ea3578081fd5b611eac86611cd5565b9450611eba60208701611cd5565b9350604086013567ffffffffffffffff80821115611ed6578283fd5b611ee289838a01611cec565b9450606088013593506080880135915080821115611efe578283fd5b9087019060a0828a031215611f11578283fd5b611f1b60a0612593565b82358152602083013582811115611f30578485fd5b611f3c8b828601611d0b565b602083015250604083013582811115611f53578485fd5b611f5f8b828601611d91565b604083015250606083013582811115611f76578485fd5b611f828b828601611cec565b606083015250608083013582811115611f99578485fd5b611fa58b828601611cec565b6080830152508093505050509295509295909350565b600080600080600060a08688031215611fd2578081fd5b611fdb86611cd5565b9450611fe960208701611cd5565b9350604086013567ffffffffffffffff811115612004578182fd5b61201088828901611cec565b9350506060860135915061202660808701611e5e565b90509295509295909350565b600080600060608486031215612046578283fd5b61204f84611cd5565b9250602084013567ffffffffffffffff81111561206a578283fd5b61207686828701611cec565b92505061208560408501611e5e565b90509250925092565b60006020828403121561209f578081fd5b81518015158114610817578182fd5b6000602082840312156120bf578081fd5b5035919050565b6000602082840312156120d7578081fd5b813567ffffffffffffffff8111156120ed578182fd5b8201601f810184136120fd578182fd5b61210c84823560208401611c83565b949350505050565b6000815180845261212c8160208601602086016125b7565b601f01601f19169290920160200192915050565b600081518352602082015160208401526040820151604084015260608201516060840152608082015160a0608085015261210c60a0850182612114565b60609190911b6001600160601b031916815260140190565b90815260200190565b918252602082015260400190565b600082516121be8184602087016125b7565b9190910192915050565b600083516121da8184602088016125b7565b60609390931b6001600160601b0319169190920190815260140192915050565b6000845161220c8184602089016125b7565b60609490941b6001600160601b03191691909301908152601481019190915260340192915050565b60f89190911b6001600160f81b031916815260010190565b6001600160a01b0391909116815260200190565b6001600160a01b0385811682528416602082015260806040820181905260009061228c90830185612114565b905082606083015295945050505050565b600060018060a01b0385168252836020830152606060408301526117eb6060830184612114565b901515815260200190565b600084825260206060818401526122e96060840186612140565b838103604085015260408101855182528286015160408484015281815180845260608501915085830194508693505b808410156123385784518252938501936001939093019290850190612318565b509998505050505050505050565b6000602082526108176020830184612114565b6020808252601f908201527f78446f6d61696e4d65737361676553656e646572206973206e6f742073657400604082015260600190565b6020808252602b908201527f50726f7669646564206d6573736167652068617320616c72656164792062656560408201526a37103932b1b2b4bb32b21760a91b606082015260800190565b6020808252604d908201527f4d6573736167652070617373696e67207072656465706c6f7920686173206e6f60408201527f74206265656e20696e697469616c697a6564206f7220696e76616c696420707260608201526c37b7b310383937bb34b232b21760991b608082015260a00190565b6020808252602b908201527f50726f7669646564206d65737361676520686173206e6f7420616c726561647960408201526a103132b2b71039b2b73a1760a91b606082015260800190565b60208082526036908201527f4f6e6c79204f564d5f4c324d65737361676552656c617965722063616e2072656040820152753630bc90261916ba3796a6189036b2b9b9b0b3b2b99760511b606082015260800190565b60208082526027908201527f50726f7669646564206d65737361676520636f756c64206e6f742062652076656040820152663934b334b2b21760c91b606082015260800190565b6020808252602a908201527f4c3143726f7373446f6d61696e4d657373656e67657220616c72656164792069604082015269373a34b0b634bd32b21760b11b606082015260800190565b6000602082526108176020830184612140565b60405181810167ffffffffffffffff811182821017156125af57fe5b604052919050565b60005b838110156125d25781810151838201526020016125ba565b838111156125e1576000848401525b5050505056fe50726f766964656420524c50206c6973742065786365656473206d6178206c697374206c656e6774682e52656365697665642061206e6f6465207769746820616e20756e6b6e6f776e20707265666978a26469706673582212202ac7364f61e96cb41ccaafbae353925a4c9ef3a57e24aee1b34f35cdc723b5c364736f6c63430007060033";

    public OVM_L1CrossDomainMessengerDeploymentBase() : base(BYTECODE)
    {
    }

    public OVM_L1CrossDomainMessengerDeploymentBase(string byteCode) : base(byteCode)
    {
    }
}

public class InitializeFunction : InitializeFunctionBase
{
}

[Function("initialize")]
public class InitializeFunctionBase : FunctionMessage
{
    [Parameter("address", "_libAddressManager")]
    public virtual string LibAddressManager { get; set; }
}

public class LibAddressManagerFunction : LibAddressManagerFunctionBase
{
}

[Function("libAddressManager", "address")]
public class LibAddressManagerFunctionBase : FunctionMessage
{
}

public class MessageNonceFunction : MessageNonceFunctionBase
{
}

[Function("messageNonce", "uint256")]
public class MessageNonceFunctionBase : FunctionMessage
{
}

public class RelayMessageFunction : RelayMessageFunctionBase
{
}

[Function("relayMessage")]
public class RelayMessageFunctionBase : FunctionMessage
{
    [Parameter("address", "_target")] public virtual string Target { get; set; }

    [Parameter("address", "_sender", 2)] public virtual string Sender { get; set; }

    [Parameter("bytes", "_message", 3)] public virtual byte[] Message { get; set; }

    [Parameter("uint256", "_messageNonce", 4)]
    public virtual BigInteger MessageNonce { get; set; }

    [Parameter("tuple", "_proof", 5)] public virtual L2MessageInclusionProof Proof { get; set; }
}

public class RelayedMessagesFunction : RelayedMessagesFunctionBase
{
}

[Function("relayedMessages", "bool")]
public class RelayedMessagesFunctionBase : FunctionMessage
{
    [Parameter("bytes32", "")] public virtual byte[] ReturnValue1 { get; set; }
}

public class ReplayMessageFunction : ReplayMessageFunctionBase
{
}

[Function("replayMessage")]
public class ReplayMessageFunctionBase : FunctionMessage
{
    [Parameter("address", "_target")] public virtual string Target { get; set; }

    [Parameter("address", "_sender", 2)] public virtual string Sender { get; set; }

    [Parameter("bytes", "_message", 3)] public virtual byte[] Message { get; set; }

    [Parameter("uint256", "_messageNonce", 4)]
    public virtual BigInteger MessageNonce { get; set; }

    [Parameter("uint32", "_gasLimit", 5)] public virtual uint GasLimit { get; set; }
}

public class ResolveFunction : ResolveFunctionBase
{
}

[Function("resolve", "address")]
public class ResolveFunctionBase : FunctionMessage
{
    [Parameter("string", "_name")] public virtual string Name { get; set; }
}

public class SendMessageFunction : SendMessageFunctionBase
{
}

[Function("sendMessage")]
public class SendMessageFunctionBase : FunctionMessage
{
    [Parameter("address", "_target")] public virtual string Target { get; set; }

    [Parameter("bytes", "_message", 2)] public virtual byte[] Message { get; set; }

    [Parameter("uint32", "_gasLimit", 3)] public virtual uint GasLimit { get; set; }
}

public class SentMessagesFunction : SentMessagesFunctionBase
{
}

[Function("sentMessages", "bool")]
public class SentMessagesFunctionBase : FunctionMessage
{
    [Parameter("bytes32", "")] public virtual byte[] ReturnValue1 { get; set; }
}

public class SuccessfulMessagesFunction : SuccessfulMessagesFunctionBase
{
}

[Function("successfulMessages", "bool")]
public class SuccessfulMessagesFunctionBase : FunctionMessage
{
    [Parameter("bytes32", "")] public virtual byte[] ReturnValue1 { get; set; }
}

public class XDomainMessageSenderFunction : XDomainMessageSenderFunctionBase
{
}

[Function("xDomainMessageSender", "address")]
public class XDomainMessageSenderFunctionBase : FunctionMessage
{
}

public class RelayedMessageEventDTO : RelayedMessageEventDTOBase
{
}

[Event("RelayedMessage")]
public class RelayedMessageEventDTOBase : IEventDTO
{
    [Parameter("bytes32", "msgHash", 1, false)]
    public virtual byte[] MsgHash { get; set; }
}

public class SentMessageEventDTO : SentMessageEventDTOBase
{
}

[Event("SentMessage")]
public class SentMessageEventDTOBase : IEventDTO
{
    [Parameter("bytes", "message", 1, false)]
    public virtual byte[] Message { get; set; }
}

public class LibAddressManagerOutputDTO : LibAddressManagerOutputDTOBase
{
}

[FunctionOutput]
public class LibAddressManagerOutputDTOBase : IFunctionOutputDTO
{
    [Parameter("address", "")] public virtual string ReturnValue1 { get; set; }
}

public class MessageNonceOutputDTO : MessageNonceOutputDTOBase
{
}

[FunctionOutput]
public class MessageNonceOutputDTOBase : IFunctionOutputDTO
{
    [Parameter("uint256", "")] public virtual BigInteger ReturnValue1 { get; set; }
}

public class RelayedMessagesOutputDTO : RelayedMessagesOutputDTOBase
{
}

[FunctionOutput]
public class RelayedMessagesOutputDTOBase : IFunctionOutputDTO
{
    [Parameter("bool", "")] public virtual bool ReturnValue1 { get; set; }
}

public class ResolveOutputDTO : ResolveOutputDTOBase
{
}

[FunctionOutput]
public class ResolveOutputDTOBase : IFunctionOutputDTO
{
    [Parameter("address", "_contract")] public virtual string Contract { get; set; }
}

public class SentMessagesOutputDTO : SentMessagesOutputDTOBase
{
}

[FunctionOutput]
public class SentMessagesOutputDTOBase : IFunctionOutputDTO
{
    [Parameter("bool", "")] public virtual bool ReturnValue1 { get; set; }
}

public class SuccessfulMessagesOutputDTO : SuccessfulMessagesOutputDTOBase
{
}

[FunctionOutput]
public class SuccessfulMessagesOutputDTOBase : IFunctionOutputDTO
{
    [Parameter("bool", "")] public virtual bool ReturnValue1 { get; set; }
}

public class XDomainMessageSenderOutputDTO : XDomainMessageSenderOutputDTOBase
{
}

[FunctionOutput]
public class XDomainMessageSenderOutputDTOBase : IFunctionOutputDTO
{
    [Parameter("address", "")] public virtual string ReturnValue1 { get; set; }
}