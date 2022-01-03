using System.Threading;
using System.Threading.Tasks;
using Metis.OVM.Accounts.OVM_ECDSAContractAccount.ContractDefinition;
using Nethereum.Contracts.ContractHandlers;
using Nethereum.RPC.Eth.DTOs;
using Nethereum.Web3;

namespace Metis.OVM.Accounts.OVM_ECDSAContractAccount;

public class OVM_ECDSAContractAccountService
{
    public OVM_ECDSAContractAccountService(Web3 web3, string contractAddress)
    {
        Web3 = web3;
        ContractHandler = web3.Eth.GetContractHandler(contractAddress);
    }

    protected Web3 Web3 { get; }

    public ContractHandler ContractHandler { get; }

    public static Task<TransactionReceipt> DeployContractAndWaitForReceiptAsync(Web3 web3,
        OVM_ECDSAContractAccountDeployment oVM_ECDSAContractAccountDeployment, CancellationTokenSource cancellationTokenSource = null)
    {
        return web3.Eth.GetContractDeploymentHandler<OVM_ECDSAContractAccountDeployment>()
            .SendRequestAndWaitForReceiptAsync(oVM_ECDSAContractAccountDeployment, cancellationTokenSource);
    }

    public static Task<string> DeployContractAsync(Web3 web3, OVM_ECDSAContractAccountDeployment oVM_ECDSAContractAccountDeployment)
    {
        return web3.Eth.GetContractDeploymentHandler<OVM_ECDSAContractAccountDeployment>().SendRequestAsync(oVM_ECDSAContractAccountDeployment);
    }

    public static async Task<OVM_ECDSAContractAccountService> DeployContractAndGetServiceAsync(Web3 web3,
        OVM_ECDSAContractAccountDeployment oVM_ECDSAContractAccountDeployment, CancellationTokenSource cancellationTokenSource = null)
    {
        var receipt = await DeployContractAndWaitForReceiptAsync(web3, oVM_ECDSAContractAccountDeployment, cancellationTokenSource);
        return new OVM_ECDSAContractAccountService(web3, receipt.ContractAddress);
    }

    public Task<string> ExecuteRequestAsync(ExecuteFunction executeFunction)
    {
        return ContractHandler.SendRequestAsync(executeFunction);
    }

    public Task<TransactionReceipt> ExecuteRequestAndWaitForReceiptAsync(ExecuteFunction executeFunction,
        CancellationTokenSource cancellationToken = null)
    {
        return ContractHandler.SendRequestAndWaitForReceiptAsync(executeFunction, cancellationToken);
    }

    public Task<string> ExecuteRequestAsync(byte[] transaction, byte signatureType, byte v, byte[] r, byte[] s)
    {
        var executeFunction = new ExecuteFunction();
        executeFunction.Transaction = transaction;
        executeFunction.SignatureType = signatureType;
        executeFunction.V = v;
        executeFunction.R = r;
        executeFunction.S = s;

        return ContractHandler.SendRequestAsync(executeFunction);
    }

    public Task<TransactionReceipt> ExecuteRequestAndWaitForReceiptAsync(byte[] transaction, byte signatureType, byte v, byte[] r, byte[] s,
        CancellationTokenSource cancellationToken = null)
    {
        var executeFunction = new ExecuteFunction();
        executeFunction.Transaction = transaction;
        executeFunction.SignatureType = signatureType;
        executeFunction.V = v;
        executeFunction.R = r;
        executeFunction.S = s;

        return ContractHandler.SendRequestAndWaitForReceiptAsync(executeFunction, cancellationToken);
    }
}