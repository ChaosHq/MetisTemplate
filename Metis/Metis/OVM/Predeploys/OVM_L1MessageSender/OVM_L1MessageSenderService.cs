using System.Threading;
using System.Threading.Tasks;
using Metis.OVM.Predeploys.OVM_L1MessageSender.ContractDefinition;
using Nethereum.Contracts.ContractHandlers;
using Nethereum.RPC.Eth.DTOs;
using Nethereum.Web3;

namespace Metis.OVM.Predeploys.OVM_L1MessageSender;

public class OVM_L1MessageSenderService
{
    public OVM_L1MessageSenderService(Web3 web3, string contractAddress)
    {
        Web3 = web3;
        ContractHandler = web3.Eth.GetContractHandler(contractAddress);
    }

    protected Web3 Web3 { get; }

    public ContractHandler ContractHandler { get; }

    public static Task<TransactionReceipt> DeployContractAndWaitForReceiptAsync(Web3 web3,
        OVM_L1MessageSenderDeployment oVM_L1MessageSenderDeployment, CancellationTokenSource cancellationTokenSource = null)
    {
        return web3.Eth.GetContractDeploymentHandler<OVM_L1MessageSenderDeployment>()
            .SendRequestAndWaitForReceiptAsync(oVM_L1MessageSenderDeployment, cancellationTokenSource);
    }

    public static Task<string> DeployContractAsync(Web3 web3, OVM_L1MessageSenderDeployment oVM_L1MessageSenderDeployment)
    {
        return web3.Eth.GetContractDeploymentHandler<OVM_L1MessageSenderDeployment>().SendRequestAsync(oVM_L1MessageSenderDeployment);
    }

    public static async Task<OVM_L1MessageSenderService> DeployContractAndGetServiceAsync(Web3 web3,
        OVM_L1MessageSenderDeployment oVM_L1MessageSenderDeployment, CancellationTokenSource cancellationTokenSource = null)
    {
        var receipt = await DeployContractAndWaitForReceiptAsync(web3, oVM_L1MessageSenderDeployment, cancellationTokenSource);
        return new OVM_L1MessageSenderService(web3, receipt.ContractAddress);
    }

    public Task<string> GetL1MessageSenderQueryAsync(GetL1MessageSenderFunction getL1MessageSenderFunction, BlockParameter blockParameter = null)
    {
        return ContractHandler.QueryAsync<GetL1MessageSenderFunction, string>(getL1MessageSenderFunction, blockParameter);
    }


    public Task<string> GetL1MessageSenderQueryAsync(BlockParameter blockParameter = null)
    {
        return ContractHandler.QueryAsync<GetL1MessageSenderFunction, string>(null, blockParameter);
    }
}