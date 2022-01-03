using System.Threading;
using System.Threading.Tasks;
using Metis.OVM.Verification.OVM_FraudVerifier.ContractDefinition;
using Nethereum.Contracts.ContractHandlers;
using Nethereum.RPC.Eth.DTOs;
using Nethereum.Web3;

namespace Metis.OVM.Verification.OVM_FraudVerifier;

public class OVM_FraudVerifierService
{
    public OVM_FraudVerifierService(Web3 web3, string contractAddress)
    {
        Web3 = web3;
        ContractHandler = web3.Eth.GetContractHandler(contractAddress);
    }

    protected Web3 Web3 { get; }

    public ContractHandler ContractHandler { get; }

    public static Task<TransactionReceipt> DeployContractAndWaitForReceiptAsync(Web3 web3, OVM_FraudVerifierDeployment oVM_FraudVerifierDeployment,
        CancellationTokenSource cancellationTokenSource = null)
    {
        return web3.Eth.GetContractDeploymentHandler<OVM_FraudVerifierDeployment>()
            .SendRequestAndWaitForReceiptAsync(oVM_FraudVerifierDeployment, cancellationTokenSource);
    }

    public static Task<string> DeployContractAsync(Web3 web3, OVM_FraudVerifierDeployment oVM_FraudVerifierDeployment)
    {
        return web3.Eth.GetContractDeploymentHandler<OVM_FraudVerifierDeployment>().SendRequestAsync(oVM_FraudVerifierDeployment);
    }

    public static async Task<OVM_FraudVerifierService> DeployContractAndGetServiceAsync(Web3 web3,
        OVM_FraudVerifierDeployment oVM_FraudVerifierDeployment, CancellationTokenSource cancellationTokenSource = null)
    {
        var receipt = await DeployContractAndWaitForReceiptAsync(web3, oVM_FraudVerifierDeployment, cancellationTokenSource);
        return new OVM_FraudVerifierService(web3, receipt.ContractAddress);
    }

    public Task<string> FinalizeFraudVerificationRequestAsync(FinalizeFraudVerificationFunction finalizeFraudVerificationFunction)
    {
        return ContractHandler.SendRequestAsync(finalizeFraudVerificationFunction);
    }

    public Task<TransactionReceipt> FinalizeFraudVerificationRequestAndWaitForReceiptAsync(
        FinalizeFraudVerificationFunction finalizeFraudVerificationFunction, CancellationTokenSource cancellationToken = null)
    {
        return ContractHandler.SendRequestAndWaitForReceiptAsync(finalizeFraudVerificationFunction, cancellationToken);
    }

    public Task<string> FinalizeFraudVerificationRequestAsync(byte[] preStateRoot, ChainBatchHeader preStateRootBatchHeader,
        ChainInclusionProof preStateRootProof, byte[] txHash, byte[] postStateRoot, ChainBatchHeader postStateRootBatchHeader,
        ChainInclusionProof postStateRootProof)
    {
        var finalizeFraudVerificationFunction = new FinalizeFraudVerificationFunction();
        finalizeFraudVerificationFunction.PreStateRoot = preStateRoot;
        finalizeFraudVerificationFunction.PreStateRootBatchHeader = preStateRootBatchHeader;
        finalizeFraudVerificationFunction.PreStateRootProof = preStateRootProof;
        finalizeFraudVerificationFunction.TxHash = txHash;
        finalizeFraudVerificationFunction.PostStateRoot = postStateRoot;
        finalizeFraudVerificationFunction.PostStateRootBatchHeader = postStateRootBatchHeader;
        finalizeFraudVerificationFunction.PostStateRootProof = postStateRootProof;

        return ContractHandler.SendRequestAsync(finalizeFraudVerificationFunction);
    }

    public Task<TransactionReceipt> FinalizeFraudVerificationRequestAndWaitForReceiptAsync(byte[] preStateRoot,
        ChainBatchHeader preStateRootBatchHeader, ChainInclusionProof preStateRootProof, byte[] txHash, byte[] postStateRoot,
        ChainBatchHeader postStateRootBatchHeader, ChainInclusionProof postStateRootProof, CancellationTokenSource cancellationToken = null)
    {
        var finalizeFraudVerificationFunction = new FinalizeFraudVerificationFunction();
        finalizeFraudVerificationFunction.PreStateRoot = preStateRoot;
        finalizeFraudVerificationFunction.PreStateRootBatchHeader = preStateRootBatchHeader;
        finalizeFraudVerificationFunction.PreStateRootProof = preStateRootProof;
        finalizeFraudVerificationFunction.TxHash = txHash;
        finalizeFraudVerificationFunction.PostStateRoot = postStateRoot;
        finalizeFraudVerificationFunction.PostStateRootBatchHeader = postStateRootBatchHeader;
        finalizeFraudVerificationFunction.PostStateRootProof = postStateRootProof;

        return ContractHandler.SendRequestAndWaitForReceiptAsync(finalizeFraudVerificationFunction, cancellationToken);
    }

    public Task<string> GetStateTransitionerQueryAsync(GetStateTransitionerFunction getStateTransitionerFunction,
        BlockParameter blockParameter = null)
    {
        return ContractHandler.QueryAsync<GetStateTransitionerFunction, string>(getStateTransitionerFunction, blockParameter);
    }


    public Task<string> GetStateTransitionerQueryAsync(byte[] preStateRoot, byte[] txHash, BlockParameter blockParameter = null)
    {
        var getStateTransitionerFunction = new GetStateTransitionerFunction();
        getStateTransitionerFunction.PreStateRoot = preStateRoot;
        getStateTransitionerFunction.TxHash = txHash;

        return ContractHandler.QueryAsync<GetStateTransitionerFunction, string>(getStateTransitionerFunction, blockParameter);
    }

    public Task<string> InitializeFraudVerificationRequestAsync(InitializeFraudVerificationFunction initializeFraudVerificationFunction)
    {
        return ContractHandler.SendRequestAsync(initializeFraudVerificationFunction);
    }

    public Task<TransactionReceipt> InitializeFraudVerificationRequestAndWaitForReceiptAsync(
        InitializeFraudVerificationFunction initializeFraudVerificationFunction, CancellationTokenSource cancellationToken = null)
    {
        return ContractHandler.SendRequestAndWaitForReceiptAsync(initializeFraudVerificationFunction, cancellationToken);
    }

    public Task<string> InitializeFraudVerificationRequestAsync(byte[] preStateRoot, ChainBatchHeader preStateRootBatchHeader,
        ChainInclusionProof preStateRootProof, OvmTransaction transaction, TransactionChainElement txChainElement,
        ChainBatchHeader transactionBatchHeader, ChainInclusionProof transactionProof)
    {
        var initializeFraudVerificationFunction = new InitializeFraudVerificationFunction();
        initializeFraudVerificationFunction.PreStateRoot = preStateRoot;
        initializeFraudVerificationFunction.PreStateRootBatchHeader = preStateRootBatchHeader;
        initializeFraudVerificationFunction.PreStateRootProof = preStateRootProof;
        initializeFraudVerificationFunction.Transaction = transaction;
        initializeFraudVerificationFunction.TxChainElement = txChainElement;
        initializeFraudVerificationFunction.TransactionBatchHeader = transactionBatchHeader;
        initializeFraudVerificationFunction.TransactionProof = transactionProof;

        return ContractHandler.SendRequestAsync(initializeFraudVerificationFunction);
    }

    public Task<TransactionReceipt> InitializeFraudVerificationRequestAndWaitForReceiptAsync(byte[] preStateRoot,
        ChainBatchHeader preStateRootBatchHeader, ChainInclusionProof preStateRootProof, OvmTransaction transaction,
        TransactionChainElement txChainElement, ChainBatchHeader transactionBatchHeader, ChainInclusionProof transactionProof,
        CancellationTokenSource cancellationToken = null)
    {
        var initializeFraudVerificationFunction = new InitializeFraudVerificationFunction();
        initializeFraudVerificationFunction.PreStateRoot = preStateRoot;
        initializeFraudVerificationFunction.PreStateRootBatchHeader = preStateRootBatchHeader;
        initializeFraudVerificationFunction.PreStateRootProof = preStateRootProof;
        initializeFraudVerificationFunction.Transaction = transaction;
        initializeFraudVerificationFunction.TxChainElement = txChainElement;
        initializeFraudVerificationFunction.TransactionBatchHeader = transactionBatchHeader;
        initializeFraudVerificationFunction.TransactionProof = transactionProof;

        return ContractHandler.SendRequestAndWaitForReceiptAsync(initializeFraudVerificationFunction, cancellationToken);
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