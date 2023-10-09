using JSONi18n.MASA.Shared.IServices;

namespace JSONi18n.MASA.Server.Services;

internal class YPlatformService : IPlatformService
{
    public bool IsBrower => true;

    public void ChangeStatusBarColor(int ColorArgb)
    {
        throw new NotImplementedException();
    }
}
