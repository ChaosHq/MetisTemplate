using System.Numerics;
using System.Threading;
using System.Threading.Tasks;
using Nethereum.Contracts.ContractHandlers;
using Nethereum.RPC.Eth.DTOs;
using Nethereum.Web3;
using OptimismTemplate.Contracts.SimpleStorage.ContractDefinition;

namespace OptimismTemplate.Contracts.SimpleStorage;

public class SimpleStorageService
{
    public SimpleStorageService(Web3 web3, string contractAddress)
    {
        Web3 = web3;
        ContractHandler = web3.Eth.GetContractHandler(contractAddress);
    }

    protected Web3 Web3 { get; }

    public ContractHandler ContractHandler { get; }

    public static Task<TransactionReceipt> DeployContractAndWaitForReceiptAsync(Web3 web3, SimpleStorageDeployment simpleStorageDeployment,
        CancellationTokenSource cancellationTokenSource = null)
    {
        return web3.Eth.GetContractDeploymentHandler<SimpleStorageDeployment>()
            .SendRequestAndWaitForReceiptAsync(simpleStorageDeployment, cancellationTokenSource);
    }

    public static Task<string> DeployContractAsync(Web3 web3, SimpleStorageDeployment simpleStorageDeployment)
    {
        return web3.Eth.GetContractDeploymentHandler<SimpleStorageDeployment>().SendRequestAsync(simpleStorageDeployment);
    }

    public static async Task<SimpleStorageService> DeployContractAndGetServiceAsync(Web3 web3, SimpleStorageDeployment simpleStorageDeployment,
        CancellationTokenSource cancellationTokenSource = null)
    {
        var receipt = await DeployContractAndWaitForReceiptAsync(web3, simpleStorageDeployment, cancellationTokenSource);
        return new SimpleStorageService(web3, receipt.ContractAddress);
    }

    public Task<string> DumbSetValueRequestAsync(DumbSetValueFunction dumbSetValueFunction)
    {
        return ContractHandler.SendRequestAsync(dumbSetValueFunction);
    }

    public Task<TransactionReceipt> DumbSetValueRequestAndWaitForReceiptAsync(DumbSetValueFunction dumbSetValueFunction,
        CancellationTokenSource cancellationToken = null)
    {
        return ContractHandler.SendRequestAndWaitForReceiptAsync(dumbSetValueFunction, cancellationToken);
    }

    public Task<string> DumbSetValueRequestAsync(byte[] newValue)
    {
        var dumbSetValueFunction = new DumbSetValueFunction();
        dumbSetValueFunction.NewValue = newValue;

        return ContractHandler.SendRequestAsync(dumbSetValueFunction);
    }

    public Task<TransactionReceipt> DumbSetValueRequestAndWaitForReceiptAsync(byte[] newValue, CancellationTokenSource cancellationToken = null)
    {
        var dumbSetValueFunction = new DumbSetValueFunction();
        dumbSetValueFunction.NewValue = newValue;

        return ContractHandler.SendRequestAndWaitForReceiptAsync(dumbSetValueFunction, cancellationToken);
    }

    public Task<string> MsgSenderQueryAsync(MsgSenderFunction msgSenderFunction, BlockParameter blockParameter = null)
    {
        return ContractHandler.QueryAsync<MsgSenderFunction, string>(msgSenderFunction, blockParameter);
    }


    public Task<string> MsgSenderQueryAsync(BlockParameter blockParameter = null)
    {
        return ContractHandler.QueryAsync<MsgSenderFunction, string>(null, blockParameter);
    }

    public Task<string> SetValueRequestAsync(SetValueFunction setValueFunction)
    {
        return ContractHandler.SendRequestAsync(setValueFunction);
    }

    public Task<TransactionReceipt> SetValueRequestAndWaitForReceiptAsync(SetValueFunction setValueFunction,
        CancellationTokenSource cancellationToken = null)
    {
        return ContractHandler.SendRequestAndWaitForReceiptAsync(setValueFunction, cancellationToken);
    }

    public Task<string> SetValueRequestAsync(byte[] newValue)
    {
        var setValueFunction = new SetValueFunction();
        setValueFunction.NewValue = newValue;

        return ContractHandler.SendRequestAsync(setValueFunction);
    }

    public Task<TransactionReceipt> SetValueRequestAndWaitForReceiptAsync(byte[] newValue, CancellationTokenSource cancellationToken = null)
    {
        var setValueFunction = new SetValueFunction();
        setValueFunction.NewValue = newValue;

        return ContractHandler.SendRequestAndWaitForReceiptAsync(setValueFunction, cancellationToken);
    }

    public Task<BigInteger> TotalCountQueryAsync(TotalCountFunction totalCountFunction, BlockParameter blockParameter = null)
    {
        return ContractHandler.QueryAsync<TotalCountFunction, BigInteger>(totalCountFunction, blockParameter);
    }


    public Task<BigInteger> TotalCountQueryAsync(BlockParameter blockParameter = null)
    {
        return ContractHandler.QueryAsync<TotalCountFunction, BigInteger>(null, blockParameter);
    }

    public Task<byte[]> ValueQueryAsync(ValueFunction valueFunction, BlockParameter blockParameter = null)
    {
        return ContractHandler.QueryAsync<ValueFunction, byte[]>(valueFunction, blockParameter);
    }


    public Task<byte[]> ValueQueryAsync(BlockParameter blockParameter = null)
    {
        return ContractHandler.QueryAsync<ValueFunction, byte[]>(null, blockParameter);
    }

    public Task<string> XDomainSenderQueryAsync(XDomainSenderFunction xDomainSenderFunction, BlockParameter blockParameter = null)
    {
        return ContractHandler.QueryAsync<XDomainSenderFunction, string>(xDomainSenderFunction, blockParameter);
    }


    public Task<string> XDomainSenderQueryAsync(BlockParameter blockParameter = null)
    {
        return ContractHandler.QueryAsync<XDomainSenderFunction, string>(null, blockParameter);
    }
}