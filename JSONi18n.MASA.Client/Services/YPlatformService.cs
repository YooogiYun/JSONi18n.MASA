using JSONi18n.MASA.Shared.IServices;

namespace JSONi18n.MASA.Client.Services;

internal class YPlatformService : IPlatformService
{
    public bool IsBrower => false;

    public void ChangeStatusBarColor(int ColorArgb)
    {
        throw new NotImplementedException();
    }
}
