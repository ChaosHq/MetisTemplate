using System.Numerics;
using System.Threading;
using System.Threading.Tasks;
using Metis.OVM.Bridge.Tokens.OVM_L1ETHGateway.ContractDefinition;
using Nethereum.Contracts.ContractHandlers;
using Nethereum.RPC.Eth.DTOs;
using Nethereum.Web3;

namespace Metis.OVM.Bridge.Tokens.OVM_L1ETHGateway;

public class OVM_L1ETHGatewayService
{
    public OVM_L1ETHGatewayService(Web3 web3, string contractAddress)
    {
        Web3 = web3;
        ContractHandler = web3.Eth.GetContractHandler(contractAddress);
    }

    protected Web3 Web3 { get; }

    public ContractHandler ContractHandler { get; }

    public static Task<TransactionReceipt> DeployContractAndWaitForReceiptAsync(Web3 web3, OVM_L1ETHGatewayDeployment oVM_L1ETHGatewayDeployment,
        CancellationTokenSource cancellationTokenSource = null)
    {
        return web3.Eth.GetContractDeploymentHandler<OVM_L1ETHGatewayDeployment>()
            .SendRequestAndWaitForReceiptAsync(oVM_L1ETHGatewayDeployment, cancellationTokenSource);
    }

    public static Task<string> DeployContractAsync(Web3 web3, OVM_L1ETHGatewayDeployment oVM_L1ETHGatewayDeployment)
    {
        return web3.Eth.GetContractDeploymentHandler<OVM_L1ETHGatewayDeployment>().SendRequestAsync(oVM_L1ETHGatewayDeployment);
    }

    public static async Task<OVM_L1ETHGatewayService> DeployContractAndGetServiceAsync(Web3 web3,
        OVM_L1ETHGatewayDeployment oVM_L1ETHGatewayDeployment, CancellationTokenSource cancellationTokenSource = null)
    {
        var receipt = await DeployContractAndWaitForReceiptAsync(web3, oVM_L1ETHGatewayDeployment, cancellationTokenSource);
        return new OVM_L1ETHGatewayService(web3, receipt.ContractAddress);
    }

    public Task<string> DepositRequestAsync(DepositFunction depositFunction)
    {
        return ContractHandler.SendRequestAsync(depositFunction);
    }

    public Task<string> DepositRequestAsync()
    {
        return ContractHandler.SendRequestAsync<DepositFunction>();
    }

    public Task<TransactionReceipt> DepositRequestAndWaitForReceiptAsync(DepositFunction depositFunction,
        CancellationTokenSource cancellationToken = null)
    {
        return ContractHandler.SendRequestAndWaitForReceiptAsync(depositFunction, cancellationToken);
    }

    public Task<TransactionReceipt> DepositRequestAndWaitForReceiptAsync(CancellationTokenSource cancellationToken = null)
    {
        return ContractHandler.SendRequestAndWaitForReceiptAsync<DepositFunction>(null, cancellationToken);
    }

    public Task<string> DepositToRequestAsync(DepositToFunction depositToFunction)
    {
        return ContractHandler.SendRequestAsync(depositToFunction);
    }

    public Task<TransactionReceipt> DepositToRequestAndWaitForReceiptAsync(DepositToFunction depositToFunction,
        CancellationTokenSource cancellationToken = null)
    {
        return ContractHandler.SendRequestAndWaitForReceiptAsync(depositToFunction, cancellationToken);
    }

    public Task<string> DepositToRequestAsync(string to)
    {
        var depositToFunction = new DepositToFunction();
        depositToFunction.To = to;

        return ContractHandler.SendRequestAsync(depositToFunction);
    }

    public Task<TransactionReceipt> DepositToRequestAndWaitForReceiptAsync(string to, CancellationTokenSource cancellationToken = null)
    {
        var depositToFunction = new DepositToFunction();
        depositToFunction.To = to;

        return ContractHandler.SendRequestAndWaitForReceiptAsync(depositToFunction, cancellationToken);
    }

    public Task<string> FinalizeWithdrawalRequestAsync(FinalizeWithdrawalFunction finalizeWithdrawalFunction)
    {
        return ContractHandler.SendRequestAsync(finalizeWithdrawalFunction);
    }

    public Task<TransactionReceipt> FinalizeWithdrawalRequestAndWaitForReceiptAsync(FinalizeWithdrawalFunction finalizeWithdrawalFunction,
        CancellationTokenSource cancellationToken = null)
    {
        return ContractHandler.SendRequestAndWaitForReceiptAsync(finalizeWithdrawalFunction, cancellationToken);
    }

    public Task<string> FinalizeWithdrawalRequestAsync(string to, BigInteger amount)
    {
        var finalizeWithdrawalFunction = new FinalizeWithdrawalFunction();
        finalizeWithdrawalFunction.To = to;
        finalizeWithdrawalFunction.Amount = amount;

        return ContractHandler.SendRequestAsync(finalizeWithdrawalFunction);
    }

    public Task<TransactionReceipt> FinalizeWithdrawalRequestAndWaitForReceiptAsync(string to, BigInteger amount,
        CancellationTokenSource cancellationToken = null)
    {
        var finalizeWithdrawalFunction = new FinalizeWithdrawalFunction();
        finalizeWithdrawalFunction.To = to;
        finalizeWithdrawalFunction.Amount = amount;

        return ContractHandler.SendRequestAndWaitForReceiptAsync(finalizeWithdrawalFunction, cancellationToken);
    }

    public Task<uint> GetFinalizeDepositL2GasQueryAsync(GetFinalizeDepositL2GasFunction getFinalizeDepositL2GasFunction,
        BlockParameter blockParameter = null)
    {
        return ContractHandler.QueryAsync<GetFinalizeDepositL2GasFunction, uint>(getFinalizeDepositL2GasFunction, blockParameter);
    }


    public Task<uint> GetFinalizeDepositL2GasQueryAsync(BlockParameter blockParameter = null)
    {
        return ContractHandler.QueryAsync<GetFinalizeDepositL2GasFunction, uint>(null, blockParameter);
    }

    public Task<string> LibAddressManagerQueryAsync(LibAddressManagerFunction libAddressManagerFunction, BlockParameter blockParameter = null)
    {
        return ContractHandler.QueryAsync<LibAddressManagerFunction, string>(libAddressManagerFunction, blockParameter);
    }


    public Task<string> LibAddressManagerQueryAsync(BlockParameter blockParameter = null)
    {
        return ContractHandler.QueryAsync<LibAddressManagerFunction, string>(null, blockParameter);
    }

    public Task<string> MessengerQueryAsync(MessengerFunction messengerFunction, BlockParameter blockParameter = null)
    {
        return ContractHandler.QueryAsync<MessengerFunction, string>(messengerFunction, blockParameter);
    }


    public Task<string> MessengerQueryAsync(BlockParameter blockParameter = null)
    {
        return ContractHandler.QueryAsync<MessengerFunction, string>(null, blockParameter);
    }

    public Task<string> OvmEthQueryAsync(OvmEthFunction ovmEthFunction, BlockParameter blockParameter = null)
    {
        return ContractHandler.QueryAsync<OvmEthFunction, string>(ovmEthFunction, blockParameter);
    }


    public Task<string> OvmEthQueryAsync(BlockParameter blockParameter = null)
    {
        return ContractHandler.QueryAsync<OvmEthFunction, string>(null, blockParameter);
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