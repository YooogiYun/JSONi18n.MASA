using CommunityToolkit.Maui.Core;
using JSONi18n.MASA.Shared.IServices;

namespace JSONi18n.MASA.Services;

internal class YPlatformService : IPlatformService
{
    public bool IsBrower => !(DeviceInfo.Platform == (DevicePlatform.Android) || DeviceInfo.Platform == DevicePlatform.iOS);

    public void ChangeStatusBarColor(int ColorArgb)
    {
        CommunityToolkit.Maui.Core.Platform.StatusBar.SetColor(Microsoft.Maui.Graphics.Color.FromInt(ColorArgb));
        CommunityToolkit.Maui.Core.Platform.StatusBar.SetStyle((StatusBarStyle)GetContrastColor(ColorArgb));
    }

    public static Shared.Models.StatusBarStyle GetContrastColor(int ColorArgb)
    {
        // 将 int 类型的 ARGB 颜色值转换为 Color 对象
        var color = System.Drawing.Color.FromArgb(ColorArgb);

        // 获取底色的 RGB 分量值
        int bgRed = color.R;
        int bgGreen = color.G;
        int bgBlue = color.B;

        // 计算底色的亮度
        double brightness = (0.299 * bgRed + 0.587 * bgGreen + 0.114 * bgBlue) / 255;

        // 根据底色亮度选择文字颜色
        return brightness > 0.5 ? Shared.Models.StatusBarStyle.DarkContent : Shared.Models.StatusBarStyle.LightContent;
    }
}
