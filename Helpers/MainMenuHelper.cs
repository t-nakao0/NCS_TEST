using NCS_TEST.Models;

namespace NCS_TEST.Helpers
{
    public static class MainMenuHelper
    {
        public static void SetForm(
            MainMenuModel model,
            string userName)
        {
            model.Form = new MainMenuForm
            {
                UserName = userName
            };
        }
    }
}