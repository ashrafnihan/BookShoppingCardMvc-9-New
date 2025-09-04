using Microsoft.AspNetCore.Identity;

namespace BookShoppingCardMvcUI.Data
{
    public class DbSeeder
    {
        public static void SeedDefaultData(IServiceProvider service)
        {
            var userMgr = service.GetService<UserManager<IdentityUser>>();
            

        }
    }
}
