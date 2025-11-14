using Cartify.Application.Contracts.ProfileDtos;
using Cartify.Application.Services.Interfaces.Merchant;

namespace Cartify.Application.Services.Implementation.Merchant
{
    public class MerchantProfileServices : IMerchantProfileServices
    {
        public Task<bool> ChangePasswordAsync(string userId, string oldPassword, string newPassword)
        {
            return Task.FromException<bool>(new NotImplementedException());
        }

        public Task<MerchantProfileDto?> GetProfileByUserIdAsync(string userId)
        {
            return Task.FromException<MerchantProfileDto?>(new NotImplementedException());
        }

        public Task<bool> UpdateProfileAsync(UpdateMerchantProfileDto dto)
        {
            return Task.FromException<bool>(new NotImplementedException());
        }

        public Task<bool> UpdateStoreInfoAsync(UpdateStoreInfoDto dto)
        {
            return Task.FromException<bool>(new NotImplementedException());
        }
    }
}
