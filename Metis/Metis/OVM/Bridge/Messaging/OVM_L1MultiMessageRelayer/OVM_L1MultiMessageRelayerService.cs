using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using Metis.OVM.Bridge.Messaging.OVM_L1MultiMessageRelayer.ContractDefinition;
using Nethereum.Contracts.ContractHandlers;
using Nethereum.RPC.Eth.DTOs;
using Nethereum.Web3;

namespace Metis.OVM.Bridge.Messaging.OVM_L1MultiMessageRelayer;

public class OVM_L1MultiMessageRelayerService
{
    public OVM_L1MultiMessageRelayerService(Web3 web3, string contractAddress)
    {
        Web3 = web3;
        ContractHandler = web3.Eth.GetContractHandler(contractAddress);
    }

    protected Web3 Web3 { get; }

    public ContractHandler ContractHandler { get; }

    public static Task<TransactionReceipt> DeployContractAndWaitForReceiptAsync(Web3 web3,
        OVM_L1MultiMessageRelayerDeployment oVM_L1MultiMessageRelayerDeployment, CancellationTokenSource cancellationTokenSource = null)
    {
        return web3.Eth.GetContractDeploymentHandler<OVM_L1MultiMessageRelayerDeployment>()
            .SendRequestAndWaitForReceiptAsync(oVM_L1MultiMessageRelayerDeployment, cancellationTokenSource);
    }

    public static Task<string> DeployContractAsync(Web3 web3, OVM_L1MultiMessageRelayerDeployment oVM_L1MultiMessageRelayerDeployment)
    {
        return web3.Eth.GetContractDeploymentHandler<OVM_L1MultiMessageRelayerDeployment>().SendRequestAsync(oVM_L1MultiMessageRelayerDeployment);
    }

    public static async Task<OVM_L1MultiMessageRelayerService> DeployContractAndGetServiceAsync(Web3 web3,
        OVM_L1MultiMessageRelayerDeployment oVM_L1MultiMessageRelayerDeployment, CancellationTokenSource cancellationTokenSource = null)
    {
        var receipt = await DeployContractAndWaitForReceiptAsync(web3, oVM_L1MultiMessageRelayerDeployment, cancellationTokenSource);
        return new OVM_L1MultiMessageRelayerService(web3, receipt.ContractAddress);
    }

    public Task<string> BatchRelayMessagesRequestAsync(BatchRelayMessagesFunction batchRelayMessagesFunction)
    {
        return ContractHandler.SendRequestAsync(batchRelayMessagesFunction);
    }

    public Task<TransactionReceipt> BatchRelayMessagesRequestAndWaitForReceiptAsync(BatchRelayMessagesFunction batchRelayMessagesFunction,
        CancellationTokenSource cancellationToken = null)
    {
        return ContractHandler.SendRequestAndWaitForReceiptAsync(batchRelayMessagesFunction, cancellationToken);
    }

    public Task<string> BatchRelayMessagesRequestAsync(List<L2ToL1Message> messages)
    {
        var batchRelayMessagesFunction = new BatchRelayMessagesFunction();
        batchRelayMessagesFunction.Messages = messages;

        return ContractHandler.SendRequestAsync(batchRelayMessagesFunction);
    }

    public Task<TransactionReceipt> BatchRelayMessagesRequestAndWaitForReceiptAsync(List<L2ToL1Message> messages,
        CancellationTokenSource cancellationToken = null)
    {
        var batchRelayMessagesFunction = new BatchRelayMessagesFunction();
        batchRelayMessagesFunction.Messages = messages;

        return ContractHandler.SendRequestAndWaitForReceiptAsync(batchRelayMessagesFunction, cancellationToken);
    }

    public Task<string> LibAddressManagerQueryAsync(LibAddressManagerFunction libAddressManagerFunction, BlockParameter blockParameter = null)
    {
        return ContractHandler.QueryAsync<LibAddressManagerFunction, string>(libAddressManagerFunction, blockParameter);
    }


    public Task<string> LibAddressManagerQueryAsync(BlockParameter blockParameter = null)
    {
        return ContractHandler.QueryAsync<LibAddressManagerFunction, string>(null, blockParameter);
    }

    public Task<string> ResolveQueryAsync(ResolveFunction resolveFunction, BlockParameter blockParameter = null)
    {
        return ContractHandler.QueryAsync<ResolveFunction, string>(resolveFunction, blockParameter);
    }


    public Task<string> ResolveQueryAsync(string name, BlockParameter blockParameter = null)
    {
        var resolveFunction = new ResolveFunction();
        resolveFunction.Name = name;

        return ContractHandler.QueryAsync<ResolveFunction, string>(resolveFunction, blockParameter);
    }
}