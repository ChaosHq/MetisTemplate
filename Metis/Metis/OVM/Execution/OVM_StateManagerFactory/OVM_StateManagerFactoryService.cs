using System.Threading;
using System.Threading.Tasks;
using Metis.OVM.Execution.OVM_StateManagerFactory.ContractDefinition;
using Nethereum.Contracts.ContractHandlers;
using Nethereum.RPC.Eth.DTOs;
using Nethereum.Web3;

namespace Metis.OVM.Execution.OVM_StateManagerFactory;

public class OVM_StateManagerFactoryService
{
    public OVM_StateManagerFactoryService(Web3 web3, string contractAddress)
    {
        Web3 = web3;
        ContractHandler = web3.Eth.GetContractHandler(contractAddress);
    }

    protected Web3 Web3 { get; }

    public ContractHandler ContractHandler { get; }

    public static Task<TransactionReceipt> DeployContractAndWaitForReceiptAsync(Web3 web3,
        OVM_StateManagerFactoryDeployment oVM_StateManagerFactoryDeployment, CancellationTokenSource cancellationTokenSource = null)
    {
        return web3.Eth.GetContractDeploymentHandler<OVM_StateManagerFactoryDeployment>()
            .SendRequestAndWaitForReceiptAsync(oVM_StateManagerFactoryDeployment, cancellationTokenSource);
    }

    public static Task<string> DeployContractAsync(Web3 web3, OVM_StateManagerFactoryDeployment oVM_StateManagerFactoryDeployment)
    {
        return web3.Eth.GetContractDeploymentHandler<OVM_StateManagerFactoryDeployment>().SendRequestAsync(oVM_StateManagerFactoryDeployment);
    }

    public static async Task<OVM_StateManagerFactoryService> DeployContractAndGetServiceAsync(Web3 web3,
        OVM_StateManagerFactoryDeployment oVM_StateManagerFactoryDeployment, CancellationTokenSource cancellationTokenSource = null)
    {
        var receipt = await DeployContractAndWaitForReceiptAsync(web3, oVM_StateManagerFactoryDeployment, cancellationTokenSource);
        return new OVM_StateManagerFactoryService(web3, receipt.ContractAddress);
    }

    public Task<string> CreateRequestAsync(CreateFunction createFunction)
    {
        return ContractHandler.SendRequestAsync(createFunction);
    }

    public Task<TransactionReceipt> CreateRequestAndWaitForReceiptAsync(CreateFunction createFunction,
        CancellationTokenSource cancellationToken = null)
    {
        return ContractHandler.SendRequestAndWaitForReceiptAsync(createFunction, cancellationToken);
    }

    public Task<string> CreateRequestAsync(string owner)
    {
        var createFunction = new CreateFunction();
        createFunction.Owner = owner;

        return ContractHandler.SendRequestAsync(createFunction);
    }

    public Task<TransactionReceipt> CreateRequestAndWaitForReceiptAsync(string owner, CancellationTokenSource cancellationToken = null)
    {
        var createFunction = new CreateFunction();
        createFunction.Owner = owner;

        return ContractHandler.SendRequestAndWaitForReceiptAsync(createFunction, cancellationToken);
    }
}