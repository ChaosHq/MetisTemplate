using System.Numerics;
using System.Threading;
using System.Threading.Tasks;
using Metis.OVM.Verification.OVM_BondManager.ContractDefinition;
using Nethereum.Contracts.ContractHandlers;
using Nethereum.RPC.Eth.DTOs;
using Nethereum.Web3;

namespace Metis.OVM.Verification.OVM_BondManager;

public class OVM_BondManagerService
{
    public OVM_BondManagerService(Web3 web3, string contractAddress)
    {
        Web3 = web3;
        ContractHandler = web3.Eth.GetContractHandler(contractAddress);
    }

    protected Web3 Web3 { get; }

    public ContractHandler ContractHandler { get; }

    public static Task<TransactionReceipt> DeployContractAndWaitForReceiptAsync(Web3 web3, OVM_BondManagerDeployment oVM_BondManagerDeployment,
        CancellationTokenSource cancellationTokenSource = null)
    {
        return web3.Eth.GetContractDeploymentHandler<OVM_BondManagerDeployment>()
            .SendRequestAndWaitForReceiptAsync(oVM_BondManagerDeployment, cancellationTokenSource);
    }

    public static Task<string> DeployContractAsync(Web3 web3, OVM_BondManagerDeployment oVM_BondManagerDeployment)
    {
        return web3.Eth.GetContractDeploymentHandler<OVM_BondManagerDeployment>().SendRequestAsync(oVM_BondManagerDeployment);
    }

    public static async Task<OVM_BondManagerService> DeployContractAndGetServiceAsync(Web3 web3, OVM_BondManagerDeployment oVM_BondManagerDeployment,
        CancellationTokenSource cancellationTokenSource = null)
    {
        var receipt = await DeployContractAndWaitForReceiptAsync(web3, oVM_BondManagerDeployment, cancellationTokenSource);
        return new OVM_BondManagerService(web3, receipt.ContractAddress);
    }

    public Task<BondsOutputDTO> BondsQueryAsync(BondsFunction bondsFunction, BlockParameter blockParameter = null)
    {
        return ContractHandler.QueryDeserializingToObjectAsync<BondsFunction, BondsOutputDTO>(bondsFunction, blockParameter);
    }

    public Task<BondsOutputDTO> BondsQueryAsync(string returnValue1, BlockParameter blockParameter = null)
    {
        var bondsFunction = new BondsFunction();
        bondsFunction.ReturnValue1 = returnValue1;

        return ContractHandler.QueryDeserializingToObjectAsync<BondsFunction, BondsOutputDTO>(bondsFunction, blockParameter);
    }

    public Task<string> ClaimRequestAsync(ClaimFunction claimFunction)
    {
        return ContractHandler.SendRequestAsync(claimFunction);
    }

    public Task<TransactionReceipt> ClaimRequestAndWaitForReceiptAsync(ClaimFunction claimFunction, CancellationTokenSource cancellationToken = null)
    {
        return ContractHandler.SendRequestAndWaitForReceiptAsync(claimFunction, cancellationToken);
    }

    public Task<string> ClaimRequestAsync(string who)
    {
        var claimFunction = new ClaimFunction();
        claimFunction.Who = who;

        return ContractHandler.SendRequestAsync(claimFunction);
    }

    public Task<TransactionReceipt> ClaimRequestAndWaitForReceiptAsync(string who, CancellationTokenSource cancellationToken = null)
    {
        var claimFunction = new ClaimFunction();
        claimFunction.Who = who;

        return ContractHandler.SendRequestAndWaitForReceiptAsync(claimFunction, cancellationToken);
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

    public Task<BigInteger> DisputePeriodSecondsQueryAsync(DisputePeriodSecondsFunction disputePeriodSecondsFunction,
        BlockParameter blockParameter = null)
    {
        return ContractHandler.QueryAsync<DisputePeriodSecondsFunction, BigInteger>(disputePeriodSecondsFunction, blockParameter);
    }


    public Task<BigInteger> DisputePeriodSecondsQueryAsync(BlockParameter blockParameter = null)
    {
        return ContractHandler.QueryAsync<DisputePeriodSecondsFunction, BigInteger>(null, blockParameter);
    }

    public Task<string> FinalizeRequestAsync(FinalizeFunction finalizeFunction)
    {
        return ContractHandler.SendRequestAsync(finalizeFunction);
    }

    public Task<TransactionReceipt> FinalizeRequestAndWaitForReceiptAsync(FinalizeFunction finalizeFunction,
        CancellationTokenSource cancellationToken = null)
    {
        return ContractHandler.SendRequestAndWaitForReceiptAsync(finalizeFunction, cancellationToken);
    }

    public Task<string> FinalizeRequestAsync(byte[] preStateRoot, string publisher, BigInteger timestamp)
    {
        var finalizeFunction = new FinalizeFunction();
        finalizeFunction.PreStateRoot = preStateRoot;
        finalizeFunction.Publisher = publisher;
        finalizeFunction.Timestamp = timestamp;

        return ContractHandler.SendRequestAsync(finalizeFunction);
    }

    public Task<TransactionReceipt> FinalizeRequestAndWaitForReceiptAsync(byte[] preStateRoot, string publisher, BigInteger timestamp,
        CancellationTokenSource cancellationToken = null)
    {
        var finalizeFunction = new FinalizeFunction();
        finalizeFunction.PreStateRoot = preStateRoot;
        finalizeFunction.Publisher = publisher;
        finalizeFunction.Timestamp = timestamp;

        return ContractHandler.SendRequestAndWaitForReceiptAsync(finalizeFunction, cancellationToken);
    }

    public Task<string> FinalizeWithdrawalRequestAsync(FinalizeWithdrawalFunction finalizeWithdrawalFunction)
    {
        return ContractHandler.SendRequestAsync(finalizeWithdrawalFunction);
    }

    public Task<string> FinalizeWithdrawalRequestAsync()
    {
        return ContractHandler.SendRequestAsync<FinalizeWithdrawalFunction>();
    }

    public Task<TransactionReceipt> FinalizeWithdrawalRequestAndWaitForReceiptAsync(FinalizeWithdrawalFunction finalizeWithdrawalFunction,
        CancellationTokenSource cancellationToken = null)
    {
        return ContractHandler.SendRequestAndWaitForReceiptAsync(finalizeWithdrawalFunction, cancellationToken);
    }

    public Task<TransactionReceipt> FinalizeWithdrawalRequestAndWaitForReceiptAsync(CancellationTokenSource cancellationToken = null)
    {
        return ContractHandler.SendRequestAndWaitForReceiptAsync<FinalizeWithdrawalFunction>(null, cancellationToken);
    }

    public Task<BigInteger> GetGasSpentQueryAsync(GetGasSpentFunction getGasSpentFunction, BlockParameter blockParameter = null)
    {
        return ContractHandler.QueryAsync<GetGasSpentFunction, BigInteger>(getGasSpentFunction, blockParameter);
    }


    public Task<BigInteger> GetGasSpentQueryAsync(byte[] preStateRoot, string who, BlockParameter blockParameter = null)
    {
        var getGasSpentFunction = new GetGasSpentFunction();
        getGasSpentFunction.PreStateRoot = preStateRoot;
        getGasSpentFunction.Who = who;

        return ContractHandler.QueryAsync<GetGasSpentFunction, BigInteger>(getGasSpentFunction, blockParameter);
    }

    public Task<bool> IsCollateralizedQueryAsync(IsCollateralizedFunction isCollateralizedFunction, BlockParameter blockParameter = null)
    {
        return ContractHandler.QueryAsync<IsCollateralizedFunction, bool>(isCollateralizedFunction, blockParameter);
    }


    public Task<bool> IsCollateralizedQueryAsync(string who, BlockParameter blockParameter = null)
    {
        var isCollateralizedFunction = new IsCollateralizedFunction();
        isCollateralizedFunction.Who = who;

        return ContractHandler.QueryAsync<IsCollateralizedFunction, bool>(isCollateralizedFunction, blockParameter);
    }

    public Task<string> LibAddressManagerQueryAsync(LibAddressManagerFunction libAddressManagerFunction, BlockParameter blockParameter = null)
    {
        return ContractHandler.QueryAsync<LibAddressManagerFunction, string>(libAddressManagerFunction, blockParameter);
    }


    public Task<string> LibAddressManagerQueryAsync(BlockParameter blockParameter = null)
    {
        return ContractHandler.QueryAsync<LibAddressManagerFunction, string>(null, blockParameter);
    }

    public Task<BigInteger> MultiFraudProofPeriodQueryAsync(MultiFraudProofPeriodFunction multiFraudProofPeriodFunction,
        BlockParameter blockParameter = null)
    {
        return ContractHandler.QueryAsync<MultiFraudProofPeriodFunction, BigInteger>(multiFraudProofPeriodFunction, blockParameter);
    }


    public Task<BigInteger> MultiFraudProofPeriodQueryAsync(BlockParameter blockParameter = null)
    {
        return ContractHandler.QueryAsync<MultiFraudProofPeriodFunction, BigInteger>(null, blockParameter);
    }

    public Task<string> RecordGasSpentRequestAsync(RecordGasSpentFunction recordGasSpentFunction)
    {
        return ContractHandler.SendRequestAsync(recordGasSpentFunction);
    }

    public Task<TransactionReceipt> RecordGasSpentRequestAndWaitForReceiptAsync(RecordGasSpentFunction recordGasSpentFunction,
        CancellationTokenSource cancellationToken = null)
    {
        return ContractHandler.SendRequestAndWaitForReceiptAsync(recordGasSpentFunction, cancellationToken);
    }

    public Task<string> RecordGasSpentRequestAsync(byte[] preStateRoot, byte[] txHash, string who, BigInteger gasSpent)
    {
        var recordGasSpentFunction = new RecordGasSpentFunction();
        recordGasSpentFunction.PreStateRoot = preStateRoot;
        recordGasSpentFunction.TxHash = txHash;
        recordGasSpentFunction.Who = who;
        recordGasSpentFunction.GasSpent = gasSpent;

        return ContractHandler.SendRequestAsync(recordGasSpentFunction);
    }

    public Task<TransactionReceipt> RecordGasSpentRequestAndWaitForReceiptAsync(byte[] preStateRoot, byte[] txHash, string who, BigInteger gasSpent,
        CancellationTokenSource cancellationToken = null)
    {
        var recordGasSpentFunction = new RecordGasSpentFunction();
        recordGasSpentFunction.PreStateRoot = preStateRoot;
        recordGasSpentFunction.TxHash = txHash;
        recordGasSpentFunction.Who = who;
        recordGasSpentFunction.GasSpent = gasSpent;

        return ContractHandler.SendRequestAndWaitForReceiptAsync(recordGasSpentFunction, cancellationToken);
    }

    public Task<BigInteger> RequiredCollateralQueryAsync(RequiredCollateralFunction requiredCollateralFunction, BlockParameter blockParameter = null)
    {
        return ContractHandler.QueryAsync<RequiredCollateralFunction, BigInteger>(requiredCollateralFunction, blockParameter);
    }


    public Task<BigInteger> RequiredCollateralQueryAsync(BlockParameter blockParameter = null)
    {
        return ContractHandler.QueryAsync<RequiredCollateralFunction, BigInteger>(null, blockParameter);
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

    public Task<string> StartWithdrawalRequestAsync(StartWithdrawalFunction startWithdrawalFunction)
    {
        return ContractHandler.SendRequestAsync(startWithdrawalFunction);
    }

    public Task<string> StartWithdrawalRequestAsync()
    {
        return ContractHandler.SendRequestAsync<StartWithdrawalFunction>();
    }

    public Task<TransactionReceipt> StartWithdrawalRequestAndWaitForReceiptAsync(StartWithdrawalFunction startWithdrawalFunction,
        CancellationTokenSource cancellationToken = null)
    {
        return ContractHandler.SendRequestAndWaitForReceiptAsync(startWithdrawalFunction, cancellationToken);
    }

    public Task<TransactionReceipt> StartWithdrawalRequestAndWaitForReceiptAsync(CancellationTokenSource cancellationToken = null)
    {
        return ContractHandler.SendRequestAndWaitForReceiptAsync<StartWithdrawalFunction>(null, cancellationToken);
    }

    public Task<string> TokenQueryAsync(TokenFunction tokenFunction, BlockParameter blockParameter = null)
    {
        return ContractHandler.QueryAsync<TokenFunction, string>(tokenFunction, blockParameter);
    }


    public Task<string> TokenQueryAsync(BlockParameter blockParameter = null)
    {
        return ContractHandler.QueryAsync<TokenFunction, string>(null, blockParameter);
    }

    public Task<WitnessProvidersOutputDTO> WitnessProvidersQueryAsync(WitnessProvidersFunction witnessProvidersFunction,
        BlockParameter blockParameter = null)
    {
        return ContractHandler.QueryDeserializingToObjectAsync<WitnessProvidersFunction, WitnessProvidersOutputDTO>(witnessProvidersFunction,
            blockParameter);
    }

    public Task<WitnessProvidersOutputDTO> WitnessProvidersQueryAsync(byte[] returnValue1, BlockParameter blockParameter = null)
    {
        var witnessProvidersFunction = new WitnessProvidersFunction();
        witnessProvidersFunction.ReturnValue1 = returnValue1;

        return ContractHandler.QueryDeserializingToObjectAsync<WitnessProvidersFunction, WitnessProvidersOutputDTO>(witnessProvidersFunction,
            blockParameter);
    }
}