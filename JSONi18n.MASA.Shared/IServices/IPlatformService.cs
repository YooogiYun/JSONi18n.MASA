namespace JSONi18n.MASA.Shared.IServices;

public interface IPlatformService
{
    bool IsBrower { get; }
    void ChangeStatusBarColor(int ColorArgb);
}
