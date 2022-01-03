using System.Numerics;
using System.Threading;
using System.Threading.Tasks;
using Nethereum.Contracts.ContractHandlers;
using Nethereum.RPC.Eth.DTOs;
using Nethereum.Web3;
using OptimismTemplate.Contracts.SimpleStorageL2.ContractDefinition;

namespace OptimismTemplate.Contracts.SimpleStorageL2;

public class SimpleStorageL2Service
{
    public SimpleStorageL2Service(Web3 web3, string contractAddress)
    {
        Web3 = web3;
        ContractHandler = web3.Eth.GetContractHandler(contractAddress);
    }

    protected Web3 Web3 { get; }

    public ContractHandler ContractHandler { get; }

    public static Task<TransactionReceipt> DeployContractAndWaitForReceiptAsync(Web3 web3, SimpleStorageL2Deployment simpleStorageL2Deployment,
        CancellationTokenSource cancellationTokenSource = null)
    {
        return web3.Eth.GetContractDeploymentHandler<SimpleStorageL2Deployment>()
            .SendRequestAndWaitForReceiptAsync(simpleStorageL2Deployment, cancellationTokenSource);
    }

    public static Task<string> DeployContractAsync(Web3 web3, SimpleStorageL2Deployment simpleStorageL2Deployment)
    {
        return web3.Eth.GetContractDeploymentHandler<SimpleStorageL2Deployment>().SendRequestAsync(simpleStorageL2Deployment);
    }

    public static async Task<SimpleStorageL2Service> DeployContractAndGetServiceAsync(Web3 web3, SimpleStorageL2Deployment simpleStorageL2Deployment,
        CancellationTokenSource cancellationTokenSource = null)
    {
        var receipt = await DeployContractAndWaitForReceiptAsync(web3, simpleStorageL2Deployment, cancellationTokenSource);
        return new SimpleStorageL2Service(web3, receipt.ContractAddress);
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