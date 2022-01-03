using System.Threading;
using System.Threading.Tasks;
using Metis.OVM.Execution.OVM_SafetyChecker.ContractDefinition;
using Nethereum.Contracts.ContractHandlers;
using Nethereum.RPC.Eth.DTOs;
using Nethereum.Web3;

namespace Metis.OVM.Execution.OVM_SafetyChecker;

public class OVM_SafetyCheckerService
{
    public OVM_SafetyCheckerService(Web3 web3, string contractAddress)
    {
        Web3 = web3;
        ContractHandler = web3.Eth.GetContractHandler(contractAddress);
    }

    protected Web3 Web3 { get; }

    public ContractHandler ContractHandler { get; }

    public static Task<TransactionReceipt> DeployContractAndWaitForReceiptAsync(Web3 web3, OVM_SafetyCheckerDeployment oVM_SafetyCheckerDeployment,
        CancellationTokenSource cancellationTokenSource = null)
    {
        return web3.Eth.GetContractDeploymentHandler<OVM_SafetyCheckerDeployment>()
            .SendRequestAndWaitForReceiptAsync(oVM_SafetyCheckerDeployment, cancellationTokenSource);
    }

    public static Task<string> DeployContractAsync(Web3 web3, OVM_SafetyCheckerDeployment oVM_SafetyCheckerDeployment)
    {
        return web3.Eth.GetContractDeploymentHandler<OVM_SafetyCheckerDeployment>().SendRequestAsync(oVM_SafetyCheckerDeployment);
    }

    public static async Task<OVM_SafetyCheckerService> DeployContractAndGetServiceAsync(Web3 web3,
        OVM_SafetyCheckerDeployment oVM_SafetyCheckerDeployment, CancellationTokenSource cancellationTokenSource = null)
    {
        var receipt = await DeployContractAndWaitForReceiptAsync(web3, oVM_SafetyCheckerDeployment, cancellationTokenSource);
        return new OVM_SafetyCheckerService(web3, receipt.ContractAddress);
    }

    public Task<bool> IsBytecodeSafeQueryAsync(IsBytecodeSafeFunction isBytecodeSafeFunction, BlockParameter blockParameter = null)
    {
        return ContractHandler.QueryAsync<IsBytecodeSafeFunction, bool>(isBytecodeSafeFunction, blockParameter);
    }


    public Task<bool> IsBytecodeSafeQueryAsync(byte[] bytecode, BlockParameter blockParameter = null)
    {
        var isBytecodeSafeFunction = new IsBytecodeSafeFunction();
        isBytecodeSafeFunction.Bytecode = bytecode;

        return ContractHandler.QueryAsync<IsBytecodeSafeFunction, bool>(isBytecodeSafeFunction, blockParameter);
    }
}