using System.Threading;
using System.Threading.Tasks;
using Metis.OVM.Predeploys.OVM_SequencerEntrypoint.ContractDefinition;
using Nethereum.Contracts.ContractHandlers;
using Nethereum.RPC.Eth.DTOs;
using Nethereum.Web3;

namespace Metis.OVM.Predeploys.OVM_SequencerEntrypoint;

public class OVM_SequencerEntrypointService
{
    public OVM_SequencerEntrypointService(Web3 web3, string contractAddress)
    {
        Web3 = web3;
        ContractHandler = web3.Eth.GetContractHandler(contractAddress);
    }

    protected Web3 Web3 { get; }

    public ContractHandler ContractHandler { get; }

    public static Task<TransactionReceipt> DeployContractAndWaitForReceiptAsync(Web3 web3,
        OVM_SequencerEntrypointDeployment oVM_SequencerEntrypointDeployment, CancellationTokenSource cancellationTokenSource = null)
    {
        return web3.Eth.GetContractDeploymentHandler<OVM_SequencerEntrypointDeployment>()
            .SendRequestAndWaitForReceiptAsync(oVM_SequencerEntrypointDeployment, cancellationTokenSource);
    }

    public static Task<string> DeployContractAsync(Web3 web3, OVM_SequencerEntrypointDeployment oVM_SequencerEntrypointDeployment)
    {
        return web3.Eth.GetContractDeploymentHandler<OVM_SequencerEntrypointDeployment>().SendRequestAsync(oVM_SequencerEntrypointDeployment);
    }

    public static async Task<OVM_SequencerEntrypointService> DeployContractAndGetServiceAsync(Web3 web3,
        OVM_SequencerEntrypointDeployment oVM_SequencerEntrypointDeployment, CancellationTokenSource cancellationTokenSource = null)
    {
        var receipt = await DeployContractAndWaitForReceiptAsync(web3, oVM_SequencerEntrypointDeployment, cancellationTokenSource);
        return new OVM_SequencerEntrypointService(web3, receipt.ContractAddress);
    }
}