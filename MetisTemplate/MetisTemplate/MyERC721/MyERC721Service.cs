using System.Numerics;
using System.Threading;
using System.Threading.Tasks;
using Nethereum.Contracts.ContractHandlers;
using Nethereum.RPC.Eth.DTOs;
using Nethereum.Web3;
using OptimismTemplate.Contracts.MyERC721.ContractDefinition;

namespace OptimismTemplate.Contracts.MyERC721;

public class MyERC721Service
{
    public MyERC721Service(Web3 web3, string contractAddress)
    {
        Web3 = web3;
        ContractHandler = web3.Eth.GetContractHandler(contractAddress);
    }

    protected Web3 Web3 { get; }

    public ContractHandler ContractHandler { get; }

    public static Task<TransactionReceipt> DeployContractAndWaitForReceiptAsync(Web3 web3, MyERC721Deployment myERC721Deployment,
        CancellationTokenSource cancellationTokenSource = null)
    {
        return web3.Eth.GetContractDeploymentHandler<MyERC721Deployment>()
            .SendRequestAndWaitForReceiptAsync(myERC721Deployment, cancellationTokenSource);
    }

    public static Task<string> DeployContractAsync(Web3 web3, MyERC721Deployment myERC721Deployment)
    {
        return web3.Eth.GetContractDeploymentHandler<MyERC721Deployment>().SendRequestAsync(myERC721Deployment);
    }

    public static async Task<MyERC721Service> DeployContractAndGetServiceAsync(Web3 web3, MyERC721Deployment myERC721Deployment,
        CancellationTokenSource cancellationTokenSource = null)
    {
        var receipt = await DeployContractAndWaitForReceiptAsync(web3, myERC721Deployment, cancellationTokenSource);
        return new MyERC721Service(web3, receipt.ContractAddress);
    }

    public Task<byte[]> DEFAULT_ADMIN_ROLEQueryAsync(DEFAULT_ADMIN_ROLEFunction dEFAULT_ADMIN_ROLEFunction, BlockParameter blockParameter = null)
    {
        return ContractHandler.QueryAsync<DEFAULT_ADMIN_ROLEFunction, byte[]>(dEFAULT_ADMIN_ROLEFunction, blockParameter);
    }


    public Task<byte[]> DEFAULT_ADMIN_ROLEQueryAsync(BlockParameter blockParameter = null)
    {
        return ContractHandler.QueryAsync<DEFAULT_ADMIN_ROLEFunction, byte[]>(null, blockParameter);
    }

    public Task<byte[]> MINTER_ROLEQueryAsync(MINTER_ROLEFunction mINTER_ROLEFunction, BlockParameter blockParameter = null)
    {
        return ContractHandler.QueryAsync<MINTER_ROLEFunction, byte[]>(mINTER_ROLEFunction, blockParameter);
    }


    public Task<byte[]> MINTER_ROLEQueryAsync(BlockParameter blockParameter = null)
    {
        return ContractHandler.QueryAsync<MINTER_ROLEFunction, byte[]>(null, blockParameter);
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

    public Task<string> ApproveRequestAsync(string to, BigInteger tokenId)
    {
        var approveFunction = new ApproveFunction();
        approveFunction.To = to;
        approveFunction.TokenId = tokenId;

        return ContractHandler.SendRequestAsync(approveFunction);
    }

    public Task<TransactionReceipt> ApproveRequestAndWaitForReceiptAsync(string to, BigInteger tokenId,
        CancellationTokenSource cancellationToken = null)
    {
        var approveFunction = new ApproveFunction();
        approveFunction.To = to;
        approveFunction.TokenId = tokenId;

        return ContractHandler.SendRequestAndWaitForReceiptAsync(approveFunction, cancellationToken);
    }

    public Task<BigInteger> BalanceOfQueryAsync(BalanceOfFunction balanceOfFunction, BlockParameter blockParameter = null)
    {
        return ContractHandler.QueryAsync<BalanceOfFunction, BigInteger>(balanceOfFunction, blockParameter);
    }


    public Task<BigInteger> BalanceOfQueryAsync(string owner, BlockParameter blockParameter = null)
    {
        var balanceOfFunction = new BalanceOfFunction();
        balanceOfFunction.Owner = owner;

        return ContractHandler.QueryAsync<BalanceOfFunction, BigInteger>(balanceOfFunction, blockParameter);
    }

    public Task<string> BaseURIQueryAsync(BaseURIFunction baseURIFunction, BlockParameter blockParameter = null)
    {
        return ContractHandler.QueryAsync<BaseURIFunction, string>(baseURIFunction, blockParameter);
    }


    public Task<string> BaseURIQueryAsync(BlockParameter blockParameter = null)
    {
        return ContractHandler.QueryAsync<BaseURIFunction, string>(null, blockParameter);
    }

    public Task<string> GetApprovedQueryAsync(GetApprovedFunction getApprovedFunction, BlockParameter blockParameter = null)
    {
        return ContractHandler.QueryAsync<GetApprovedFunction, string>(getApprovedFunction, blockParameter);
    }


    public Task<string> GetApprovedQueryAsync(BigInteger tokenId, BlockParameter blockParameter = null)
    {
        var getApprovedFunction = new GetApprovedFunction();
        getApprovedFunction.TokenId = tokenId;

        return ContractHandler.QueryAsync<GetApprovedFunction, string>(getApprovedFunction, blockParameter);
    }

    public Task<byte[]> GetRoleAdminQueryAsync(GetRoleAdminFunction getRoleAdminFunction, BlockParameter blockParameter = null)
    {
        return ContractHandler.QueryAsync<GetRoleAdminFunction, byte[]>(getRoleAdminFunction, blockParameter);
    }


    public Task<byte[]> GetRoleAdminQueryAsync(byte[] role, BlockParameter blockParameter = null)
    {
        var getRoleAdminFunction = new GetRoleAdminFunction();
        getRoleAdminFunction.Role = role;

        return ContractHandler.QueryAsync<GetRoleAdminFunction, byte[]>(getRoleAdminFunction, blockParameter);
    }

    public Task<string> GetRoleMemberQueryAsync(GetRoleMemberFunction getRoleMemberFunction, BlockParameter blockParameter = null)
    {
        return ContractHandler.QueryAsync<GetRoleMemberFunction, string>(getRoleMemberFunction, blockParameter);
    }


    public Task<string> GetRoleMemberQueryAsync(byte[] role, BigInteger index, BlockParameter blockParameter = null)
    {
        var getRoleMemberFunction = new GetRoleMemberFunction();
        getRoleMemberFunction.Role = role;
        getRoleMemberFunction.Index = index;

        return ContractHandler.QueryAsync<GetRoleMemberFunction, string>(getRoleMemberFunction, blockParameter);
    }

    public Task<BigInteger> GetRoleMemberCountQueryAsync(GetRoleMemberCountFunction getRoleMemberCountFunction, BlockParameter blockParameter = null)
    {
        return ContractHandler.QueryAsync<GetRoleMemberCountFunction, BigInteger>(getRoleMemberCountFunction, blockParameter);
    }


    public Task<BigInteger> GetRoleMemberCountQueryAsync(byte[] role, BlockParameter blockParameter = null)
    {
        var getRoleMemberCountFunction = new GetRoleMemberCountFunction();
        getRoleMemberCountFunction.Role = role;

        return ContractHandler.QueryAsync<GetRoleMemberCountFunction, BigInteger>(getRoleMemberCountFunction, blockParameter);
    }

    public Task<string> GrantRoleRequestAsync(GrantRoleFunction grantRoleFunction)
    {
        return ContractHandler.SendRequestAsync(grantRoleFunction);
    }

    public Task<TransactionReceipt> GrantRoleRequestAndWaitForReceiptAsync(GrantRoleFunction grantRoleFunction,
        CancellationTokenSource cancellationToken = null)
    {
        return ContractHandler.SendRequestAndWaitForReceiptAsync(grantRoleFunction, cancellationToken);
    }

    public Task<string> GrantRoleRequestAsync(byte[] role, string account)
    {
        var grantRoleFunction = new GrantRoleFunction();
        grantRoleFunction.Role = role;
        grantRoleFunction.Account = account;

        return ContractHandler.SendRequestAsync(grantRoleFunction);
    }

    public Task<TransactionReceipt> GrantRoleRequestAndWaitForReceiptAsync(byte[] role, string account,
        CancellationTokenSource cancellationToken = null)
    {
        var grantRoleFunction = new GrantRoleFunction();
        grantRoleFunction.Role = role;
        grantRoleFunction.Account = account;

        return ContractHandler.SendRequestAndWaitForReceiptAsync(grantRoleFunction, cancellationToken);
    }

    public Task<bool> HasRoleQueryAsync(HasRoleFunction hasRoleFunction, BlockParameter blockParameter = null)
    {
        return ContractHandler.QueryAsync<HasRoleFunction, bool>(hasRoleFunction, blockParameter);
    }


    public Task<bool> HasRoleQueryAsync(byte[] role, string account, BlockParameter blockParameter = null)
    {
        var hasRoleFunction = new HasRoleFunction();
        hasRoleFunction.Role = role;
        hasRoleFunction.Account = account;

        return ContractHandler.QueryAsync<HasRoleFunction, bool>(hasRoleFunction, blockParameter);
    }

    public Task<bool> IsApprovedForAllQueryAsync(IsApprovedForAllFunction isApprovedForAllFunction, BlockParameter blockParameter = null)
    {
        return ContractHandler.QueryAsync<IsApprovedForAllFunction, bool>(isApprovedForAllFunction, blockParameter);
    }


    public Task<bool> IsApprovedForAllQueryAsync(string owner, string @operator, BlockParameter blockParameter = null)
    {
        var isApprovedForAllFunction = new IsApprovedForAllFunction();
        isApprovedForAllFunction.Owner = owner;
        isApprovedForAllFunction.Operator = @operator;

        return ContractHandler.QueryAsync<IsApprovedForAllFunction, bool>(isApprovedForAllFunction, blockParameter);
    }

    public Task<string> MintRequestAsync(MintFunction mintFunction)
    {
        return ContractHandler.SendRequestAsync(mintFunction);
    }

    public Task<TransactionReceipt> MintRequestAndWaitForReceiptAsync(MintFunction mintFunction, CancellationTokenSource cancellationToken = null)
    {
        return ContractHandler.SendRequestAndWaitForReceiptAsync(mintFunction, cancellationToken);
    }

    public Task<string> MintRequestAsync(string to, string tokenURI)
    {
        var mintFunction = new MintFunction();
        mintFunction.To = to;
        mintFunction.TokenURI = tokenURI;

        return ContractHandler.SendRequestAsync(mintFunction);
    }

    public Task<TransactionReceipt> MintRequestAndWaitForReceiptAsync(string to, string tokenURI, CancellationTokenSource cancellationToken = null)
    {
        var mintFunction = new MintFunction();
        mintFunction.To = to;
        mintFunction.TokenURI = tokenURI;

        return ContractHandler.SendRequestAndWaitForReceiptAsync(mintFunction, cancellationToken);
    }

    public Task<string> NameQueryAsync(NameFunction nameFunction, BlockParameter blockParameter = null)
    {
        return ContractHandler.QueryAsync<NameFunction, string>(nameFunction, blockParameter);
    }


    public Task<string> NameQueryAsync(BlockParameter blockParameter = null)
    {
        return ContractHandler.QueryAsync<NameFunction, string>(null, blockParameter);
    }

    public Task<string> OwnerOfQueryAsync(OwnerOfFunction ownerOfFunction, BlockParameter blockParameter = null)
    {
        return ContractHandler.QueryAsync<OwnerOfFunction, string>(ownerOfFunction, blockParameter);
    }


    public Task<string> OwnerOfQueryAsync(BigInteger tokenId, BlockParameter blockParameter = null)
    {
        var ownerOfFunction = new OwnerOfFunction();
        ownerOfFunction.TokenId = tokenId;

        return ContractHandler.QueryAsync<OwnerOfFunction, string>(ownerOfFunction, blockParameter);
    }

    public Task<string> RenounceRoleRequestAsync(RenounceRoleFunction renounceRoleFunction)
    {
        return ContractHandler.SendRequestAsync(renounceRoleFunction);
    }

    public Task<TransactionReceipt> RenounceRoleRequestAndWaitForReceiptAsync(RenounceRoleFunction renounceRoleFunction,
        CancellationTokenSource cancellationToken = null)
    {
        return ContractHandler.SendRequestAndWaitForReceiptAsync(renounceRoleFunction, cancellationToken);
    }

    public Task<string> RenounceRoleRequestAsync(byte[] role, string account)
    {
        var renounceRoleFunction = new RenounceRoleFunction();
        renounceRoleFunction.Role = role;
        renounceRoleFunction.Account = account;

        return ContractHandler.SendRequestAsync(renounceRoleFunction);
    }

    public Task<TransactionReceipt> RenounceRoleRequestAndWaitForReceiptAsync(byte[] role, string account,
        CancellationTokenSource cancellationToken = null)
    {
        var renounceRoleFunction = new RenounceRoleFunction();
        renounceRoleFunction.Role = role;
        renounceRoleFunction.Account = account;

        return ContractHandler.SendRequestAndWaitForReceiptAsync(renounceRoleFunction, cancellationToken);
    }

    public Task<string> RevokeRoleRequestAsync(RevokeRoleFunction revokeRoleFunction)
    {
        return ContractHandler.SendRequestAsync(revokeRoleFunction);
    }

    public Task<TransactionReceipt> RevokeRoleRequestAndWaitForReceiptAsync(RevokeRoleFunction revokeRoleFunction,
        CancellationTokenSource cancellationToken = null)
    {
        return ContractHandler.SendRequestAndWaitForReceiptAsync(revokeRoleFunction, cancellationToken);
    }

    public Task<string> RevokeRoleRequestAsync(byte[] role, string account)
    {
        var revokeRoleFunction = new RevokeRoleFunction();
        revokeRoleFunction.Role = role;
        revokeRoleFunction.Account = account;

        return ContractHandler.SendRequestAsync(revokeRoleFunction);
    }

    public Task<TransactionReceipt> RevokeRoleRequestAndWaitForReceiptAsync(byte[] role, string account,
        CancellationTokenSource cancellationToken = null)
    {
        var revokeRoleFunction = new RevokeRoleFunction();
        revokeRoleFunction.Role = role;
        revokeRoleFunction.Account = account;

        return ContractHandler.SendRequestAndWaitForReceiptAsync(revokeRoleFunction, cancellationToken);
    }

    public Task<string> SafeTransferFromRequestAsync(SafeTransferFromFunction safeTransferFromFunction)
    {
        return ContractHandler.SendRequestAsync(safeTransferFromFunction);
    }

    public Task<TransactionReceipt> SafeTransferFromRequestAndWaitForReceiptAsync(SafeTransferFromFunction safeTransferFromFunction,
        CancellationTokenSource cancellationToken = null)
    {
        return ContractHandler.SendRequestAndWaitForReceiptAsync(safeTransferFromFunction, cancellationToken);
    }

    public Task<string> SafeTransferFromRequestAsync(string from, string to, BigInteger tokenId)
    {
        var safeTransferFromFunction = new SafeTransferFromFunction();
        safeTransferFromFunction.From = from;
        safeTransferFromFunction.To = to;
        safeTransferFromFunction.TokenId = tokenId;

        return ContractHandler.SendRequestAsync(safeTransferFromFunction);
    }

    public Task<TransactionReceipt> SafeTransferFromRequestAndWaitForReceiptAsync(string from, string to, BigInteger tokenId,
        CancellationTokenSource cancellationToken = null)
    {
        var safeTransferFromFunction = new SafeTransferFromFunction();
        safeTransferFromFunction.From = from;
        safeTransferFromFunction.To = to;
        safeTransferFromFunction.TokenId = tokenId;

        return ContractHandler.SendRequestAndWaitForReceiptAsync(safeTransferFromFunction, cancellationToken);
    }

    public Task<string> SafeTransferFromRequestAsync(SafeTransferFromWithDataFunction safeTransferFromFunction)
    {
        return ContractHandler.SendRequestAsync(safeTransferFromFunction);
    }

    public Task<TransactionReceipt> SafeTransferFromRequestAndWaitForReceiptAsync(SafeTransferFromWithDataFunction safeTransferFromFunction,
        CancellationTokenSource cancellationToken = null)
    {
        return ContractHandler.SendRequestAndWaitForReceiptAsync(safeTransferFromFunction, cancellationToken);
    }

    public Task<string> SafeTransferFromRequestAsync(string from, string to, BigInteger tokenId, byte[] data)
    {
        var safeTransferFromFunction = new SafeTransferFromWithDataFunction();
        safeTransferFromFunction.From = from;
        safeTransferFromFunction.To = to;
        safeTransferFromFunction.TokenId = tokenId;
        safeTransferFromFunction.Data = data;

        return ContractHandler.SendRequestAsync(safeTransferFromFunction);
    }

    public Task<TransactionReceipt> SafeTransferFromRequestAndWaitForReceiptAsync(string from, string to, BigInteger tokenId, byte[] data,
        CancellationTokenSource cancellationToken = null)
    {
        var safeTransferFromFunction = new SafeTransferFromWithDataFunction();
        safeTransferFromFunction.From = from;
        safeTransferFromFunction.To = to;
        safeTransferFromFunction.TokenId = tokenId;
        safeTransferFromFunction.Data = data;

        return ContractHandler.SendRequestAndWaitForReceiptAsync(safeTransferFromFunction, cancellationToken);
    }

    public Task<string> SetApprovalForAllRequestAsync(SetApprovalForAllFunction setApprovalForAllFunction)
    {
        return ContractHandler.SendRequestAsync(setApprovalForAllFunction);
    }

    public Task<TransactionReceipt> SetApprovalForAllRequestAndWaitForReceiptAsync(SetApprovalForAllFunction setApprovalForAllFunction,
        CancellationTokenSource cancellationToken = null)
    {
        return ContractHandler.SendRequestAndWaitForReceiptAsync(setApprovalForAllFunction, cancellationToken);
    }

    public Task<string> SetApprovalForAllRequestAsync(string @operator, bool approved)
    {
        var setApprovalForAllFunction = new SetApprovalForAllFunction();
        setApprovalForAllFunction.Operator = @operator;
        setApprovalForAllFunction.Approved = approved;

        return ContractHandler.SendRequestAsync(setApprovalForAllFunction);
    }

    public Task<TransactionReceipt> SetApprovalForAllRequestAndWaitForReceiptAsync(string @operator, bool approved,
        CancellationTokenSource cancellationToken = null)
    {
        var setApprovalForAllFunction = new SetApprovalForAllFunction();
        setApprovalForAllFunction.Operator = @operator;
        setApprovalForAllFunction.Approved = approved;

        return ContractHandler.SendRequestAndWaitForReceiptAsync(setApprovalForAllFunction, cancellationToken);
    }

    public Task<bool> SupportsInterfaceQueryAsync(SupportsInterfaceFunction supportsInterfaceFunction, BlockParameter blockParameter = null)
    {
        return ContractHandler.QueryAsync<SupportsInterfaceFunction, bool>(supportsInterfaceFunction, blockParameter);
    }


    public Task<bool> SupportsInterfaceQueryAsync(byte[] interfaceId, BlockParameter blockParameter = null)
    {
        var supportsInterfaceFunction = new SupportsInterfaceFunction();
        supportsInterfaceFunction.InterfaceId = interfaceId;

        return ContractHandler.QueryAsync<SupportsInterfaceFunction, bool>(supportsInterfaceFunction, blockParameter);
    }

    public Task<string> SymbolQueryAsync(SymbolFunction symbolFunction, BlockParameter blockParameter = null)
    {
        return ContractHandler.QueryAsync<SymbolFunction, string>(symbolFunction, blockParameter);
    }


    public Task<string> SymbolQueryAsync(BlockParameter blockParameter = null)
    {
        return ContractHandler.QueryAsync<SymbolFunction, string>(null, blockParameter);
    }

    public Task<BigInteger> TokenByIndexQueryAsync(TokenByIndexFunction tokenByIndexFunction, BlockParameter blockParameter = null)
    {
        return ContractHandler.QueryAsync<TokenByIndexFunction, BigInteger>(tokenByIndexFunction, blockParameter);
    }


    public Task<BigInteger> TokenByIndexQueryAsync(BigInteger index, BlockParameter blockParameter = null)
    {
        var tokenByIndexFunction = new TokenByIndexFunction();
        tokenByIndexFunction.Index = index;

        return ContractHandler.QueryAsync<TokenByIndexFunction, BigInteger>(tokenByIndexFunction, blockParameter);
    }

    public Task<BigInteger> TokenOfOwnerByIndexQueryAsync(TokenOfOwnerByIndexFunction tokenOfOwnerByIndexFunction,
        BlockParameter blockParameter = null)
    {
        return ContractHandler.QueryAsync<TokenOfOwnerByIndexFunction, BigInteger>(tokenOfOwnerByIndexFunction, blockParameter);
    }


    public Task<BigInteger> TokenOfOwnerByIndexQueryAsync(string owner, BigInteger index, BlockParameter blockParameter = null)
    {
        var tokenOfOwnerByIndexFunction = new TokenOfOwnerByIndexFunction();
        tokenOfOwnerByIndexFunction.Owner = owner;
        tokenOfOwnerByIndexFunction.Index = index;

        return ContractHandler.QueryAsync<TokenOfOwnerByIndexFunction, BigInteger>(tokenOfOwnerByIndexFunction, blockParameter);
    }

    public Task<string> TokenURIQueryAsync(TokenURIFunction tokenURIFunction, BlockParameter blockParameter = null)
    {
        return ContractHandler.QueryAsync<TokenURIFunction, string>(tokenURIFunction, blockParameter);
    }


    public Task<string> TokenURIQueryAsync(BigInteger tokenId, BlockParameter blockParameter = null)
    {
        var tokenURIFunction = new TokenURIFunction();
        tokenURIFunction.TokenId = tokenId;

        return ContractHandler.QueryAsync<TokenURIFunction, string>(tokenURIFunction, blockParameter);
    }

    public Task<BigInteger> TotalSupplyQueryAsync(TotalSupplyFunction totalSupplyFunction, BlockParameter blockParameter = null)
    {
        return ContractHandler.QueryAsync<TotalSupplyFunction, BigInteger>(totalSupplyFunction, blockParameter);
    }


    public Task<BigInteger> TotalSupplyQueryAsync(BlockParameter blockParameter = null)
    {
        return ContractHandler.QueryAsync<TotalSupplyFunction, BigInteger>(null, blockParameter);
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

    public Task<string> TransferFromRequestAsync(string from, string to, BigInteger tokenId)
    {
        var transferFromFunction = new TransferFromFunction();
        transferFromFunction.From = from;
        transferFromFunction.To = to;
        transferFromFunction.TokenId = tokenId;

        return ContractHandler.SendRequestAsync(transferFromFunction);
    }

    public Task<TransactionReceipt> TransferFromRequestAndWaitForReceiptAsync(string from, string to, BigInteger tokenId,
        CancellationTokenSource cancellationToken = null)
    {
        var transferFromFunction = new TransferFromFunction();
        transferFromFunction.From = from;
        transferFromFunction.To = to;
        transferFromFunction.TokenId = tokenId;

        return ContractHandler.SendRequestAndWaitForReceiptAsync(transferFromFunction, cancellationToken);
    }
}