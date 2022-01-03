using System.Threading;
using System.Threading.Tasks;
using Metis.OVM.Accounts.OVM_ProxyEOA.ContractDefinition;
using Nethereum.Contracts.ContractHandlers;
using Nethereum.RPC.Eth.DTOs;
using Nethereum.Web3;

namespace Metis.OVM.Accounts.OVM_ProxyEOA;

public class OVM_ProxyEOAService
{
    public OVM_ProxyEOAService(Web3 web3, string contractAddress)
    {
        Web3 = web3;
        ContractHandler = web3.Eth.GetContractHandler(contractAddress);
    }

    protected Web3 Web3 { get; }

    public ContractHandler ContractHandler { get; }

    public static Task<TransactionReceipt> DeployContractAndWaitForReceiptAsync(Web3 web3, OVM_ProxyEOADeployment oVM_ProxyEOADeployment,
        CancellationTokenSource cancellationTokenSource = null)
    {
        return web3.Eth.GetContractDeploymentHandler<OVM_ProxyEOADeployment>()
            .SendRequestAndWaitForReceiptAsync(oVM_ProxyEOADeployment, cancellationTokenSource);
    }

    public static Task<string> DeployContractAsync(Web3 web3, OVM_ProxyEOADeployment oVM_ProxyEOADeployment)
    {
        return web3.Eth.GetContractDeploymentHandler<OVM_ProxyEOADeployment>().SendRequestAsync(oVM_ProxyEOADeployment);
    }

    public static async Task<OVM_ProxyEOAService> DeployContractAndGetServiceAsync(Web3 web3, OVM_ProxyEOADeployment oVM_ProxyEOADeployment,
        CancellationTokenSource cancellationTokenSource = null)
    {
        var receipt = await DeployContractAndWaitForReceiptAsync(web3, oVM_ProxyEOADeployment, cancellationTokenSource);
        return new OVM_ProxyEOAService(web3, receipt.ContractAddress);
    }

    public Task<string> GetImplementationRequestAsync(GetImplementationFunction getImplementationFunction)
    {
        return ContractHandler.SendRequestAsync(getImplementationFunction);
    }

    public Task<string> GetImplementationRequestAsync()
    {
        return ContractHandler.SendRequestAsync<GetImplementationFunction>();
    }

    public Task<TransactionReceipt> GetImplementationRequestAndWaitForReceiptAsync(GetImplementationFunction getImplementationFunction,
        CancellationTokenSource cancellationToken = null)
    {
        return ContractHandler.SendRequestAndWaitForReceiptAsync(getImplementationFunction, cancellationToken);
    }

    public Task<TransactionReceipt> GetImplementationRequestAndWaitForReceiptAsync(CancellationTokenSource cancellationToken = null)
    {
        return ContractHandler.SendRequestAndWaitForReceiptAsync<GetImplementationFunction>(null, cancellationToken);
    }

    public Task<string> UpgradeRequestAsync(UpgradeFunction upgradeFunction)
    {
        return ContractHandler.SendRequestAsync(upgradeFunction);
    }

    public Task<TransactionReceipt> UpgradeRequestAndWaitForReceiptAsync(UpgradeFunction upgradeFunction,
        CancellationTokenSource cancellationToken = null)
    {
        return ContractHandler.SendRequestAndWaitForReceiptAsync(upgradeFunction, cancellationToken);
    }

    public Task<string> UpgradeRequestAsync(string implementation)
    {
        var upgradeFunction = new UpgradeFunction();
        upgradeFunction.Implementation = implementation;

        return ContractHandler.SendRequestAsync(upgradeFunction);
    }

    public Task<TransactionReceipt> UpgradeRequestAndWaitForReceiptAsync(string implementation, CancellationTokenSource cancellationToken = null)
    {
        var upgradeFunction = new UpgradeFunction();
        upgradeFunction.Implementation = implementation;

        return ContractHandler.SendRequestAndWaitForReceiptAsync(upgradeFunction, cancellationToken);
    }
}