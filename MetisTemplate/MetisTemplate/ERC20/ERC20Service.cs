using System.Numerics;
using System.Threading;
using System.Threading.Tasks;
using Nethereum.Contracts.ContractHandlers;
using Nethereum.RPC.Eth.DTOs;
using Nethereum.Web3;
using OptimismTemplate.Contracts.ERC20.ContractDefinition;

namespace OptimismTemplate.Contracts.ERC20;

public class ERC20Service
{
    public ERC20Service(Web3 web3, string contractAddress)
    {
        Web3 = web3;
        ContractHandler = web3.Eth.GetContractHandler(contractAddress);
    }

    protected Web3 Web3 { get; }

    public ContractHandler ContractHandler { get; }

    public static Task<TransactionReceipt> DeployContractAndWaitForReceiptAsync(Web3 web3, ERC20Deployment eRC20Deployment,
        CancellationTokenSource cancellationTokenSource = null)
    {
        return web3.Eth.GetContractDeploymentHandler<ERC20Deployment>().SendRequestAndWaitForReceiptAsync(eRC20Deployment, cancellationTokenSource);
    }

    public static Task<string> DeployContractAsync(Web3 web3, ERC20Deployment eRC20Deployment)
    {
        return web3.Eth.GetContractDeploymentHandler<ERC20Deployment>().SendRequestAsync(eRC20Deployment);
    }

    public static async Task<ERC20Service> DeployContractAndGetServiceAsync(Web3 web3, ERC20Deployment eRC20Deployment,
        CancellationTokenSource cancellationTokenSource = null)
    {
        var receipt = await DeployContractAndWaitForReceiptAsync(web3, eRC20Deployment, cancellationTokenSource);
        return new ERC20Service(web3, receipt.ContractAddress);
    }

    public Task<BigInteger> AllowanceQueryAsync(AllowanceFunction allowanceFunction, BlockParameter blockParameter = null)
    {
        return ContractHandler.QueryAsync<AllowanceFunction, BigInteger>(allowanceFunction, blockParameter);
    }


    public Task<BigInteger> AllowanceQueryAsync(string returnValue1, string returnValue2, BlockParameter blockParameter = null)
    {
        var allowanceFunction = new AllowanceFunction();
        allowanceFunction.ReturnValue1 = returnValue1;
        allowanceFunction.ReturnValue2 = returnValue2;

        return ContractHandler.QueryAsync<AllowanceFunction, BigInteger>(allowanceFunction, blockParameter);
    }

    public Task<string> ApproveRequestAsync(ApproveFunction approveFunction)
    {
        return ContractHandler.SendRequestAsync(approveFunction);
    }

    public Task<TransactionReceipt> ApproveRequestAndWaitForReceiptAsync(ApproveFunction approveFunction,
        CancellationTokenSource cancellationToken = null)
    {
        return ContractHandler.SendRequestAndWaitForReceiptAsync(approveFunction, cancellationToken);
    }

    public Task<string> ApproveRequestAsync(string spender, BigInteger value)
    {
        var approveFunction = new ApproveFunction();
        approveFunction.Spender = spender;
        approveFunction.Value = value;

        return ContractHandler.SendRequestAsync(approveFunction);
    }

    public Task<TransactionReceipt> ApproveRequestAndWaitForReceiptAsync(string spender, BigInteger value,
        CancellationTokenSource cancellationToken = null)
    {
        var approveFunction = new ApproveFunction();
        approveFunction.Spender = spender;
        approveFunction.Value = value;

        return ContractHandler.SendRequestAndWaitForReceiptAsync(approveFunction, cancellationToken);
    }

    public Task<BigInteger> BalanceOfQueryAsync(BalanceOfFunction balanceOfFunction, BlockParameter blockParameter = null)
    {
        return ContractHandler.QueryAsync<BalanceOfFunction, BigInteger>(balanceOfFunction, blockParameter);
    }


    public Task<BigInteger> BalanceOfQueryAsync(string returnValue1, BlockParameter blockParameter = null)
    {
        var balanceOfFunction = new BalanceOfFunction();
        balanceOfFunction.ReturnValue1 = returnValue1;

        return ContractHandler.QueryAsync<BalanceOfFunction, BigInteger>(balanceOfFunction, blockParameter);
    }

    public Task<byte> DecimalsQueryAsync(DecimalsFunction decimalsFunction, BlockParameter blockParameter = null)
    {
        return ContractHandler.QueryAsync<DecimalsFunction, byte>(decimalsFunction, blockParameter);
    }


    public Task<byte> DecimalsQueryAsync(BlockParameter blockParameter = null)
    {
        return ContractHandler.QueryAsync<DecimalsFunction, byte>(null, blockParameter);
    }

    public Task<string> NameQueryAsync(NameFunction nameFunction, BlockParameter blockParameter = null)
    {
        return ContractHandler.QueryAsync<NameFunction, string>(nameFunction, blockParameter);
    }


    public Task<string> NameQueryAsync(BlockParameter blockParameter = null)
    {
        return ContractHandler.QueryAsync<NameFunction, string>(null, blockParameter);
    }

    public Task<string> SymbolQueryAsync(SymbolFunction symbolFunction, BlockParameter blockParameter = null)
    {
        return ContractHandler.QueryAsync<SymbolFunction, string>(symbolFunction, blockParameter);
    }


    public Task<string> SymbolQueryAsync(BlockParameter blockParameter = null)
    {
        return ContractHandler.QueryAsync<SymbolFunction, string>(null, blockParameter);
    }

    public Task<BigInteger> TotalSupplyQueryAsync(TotalSupplyFunction totalSupplyFunction, BlockParameter blockParameter = null)
    {
        return ContractHandler.QueryAsync<TotalSupplyFunction, BigInteger>(totalSupplyFunction, blockParameter);
    }


    public Task<BigInteger> TotalSupplyQueryAsync(BlockParameter blockParameter = null)
    {
        return ContractHandler.QueryAsync<TotalSupplyFunction, BigInteger>(null, blockParameter);
    }

    public Task<string> TransferRequestAsync(TransferFunction transferFunction)
    {
        return ContractHandler.SendRequestAsync(transferFunction);
    }

    public Task<TransactionReceipt> TransferRequestAndWaitForReceiptAsync(TransferFunction transferFunction,
        CancellationTokenSource cancellationToken = null)
    {
        return ContractHandler.SendRequestAndWaitForReceiptAsync(transferFunction, cancellationToken);
    }

    public Task<string> TransferRequestAsync(string to, BigInteger value)
    {
        var transferFunction = new TransferFunction();
        transferFunction.To = to;
        transferFunction.Value = value;

        return ContractHandler.SendRequestAsync(transferFunction);
    }

    public Task<TransactionReceipt> TransferRequestAndWaitForReceiptAsync(string to, BigInteger value,
        CancellationTokenSource cancellationToken = null)
    {
        var transferFunction = new TransferFunction();
        transferFunction.To = to;
        transferFunction.Value = value;

        return ContractHandler.SendRequestAndWaitForReceiptAsync(transferFunction, cancellationToken);
    }

    public Task<string> TransferFromRequestAsync(TransferFromFunction transferFromFunction)
    {
        return ContractHandler.SendRequestAsync(transferFromFunction);
    }

    public Task<TransactionReceipt> TransferFromRequestAndWaitForReceiptAsync(TransferFromFunction transferFromFunction,
        CancellationTokenSource cancellationToken = null)
    {
        return ContractHandler.SendRequestAndWaitForReceiptAsync(transferFromFunction, cancellationToken);
    }

    public Task<string> TransferFromRequestAsync(string from, string to, BigInteger value)
    {
        var transferFromFunction = new TransferFromFunction();
        transferFromFunction.From = from;
        transferFromFunction.To = to;
        transferFromFunction.Value = value;

        return ContractHandler.SendRequestAsync(transferFromFunction);
    }

    public Task<TransactionReceipt> TransferFromRequestAndWaitForReceiptAsync(string from, string to, BigInteger value,
        CancellationTokenSource cancellationToken = null)
    {
        var transferFromFunction = new TransferFromFunction();
        transferFromFunction.From = from;
        transferFromFunction.To = to;
        transferFromFunction.Value = value;

        return ContractHandler.SendRequestAndWaitForReceiptAsync(transferFromFunction, cancellationToken);
    }
}