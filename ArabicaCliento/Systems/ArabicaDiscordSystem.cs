using Robust.Client.UserInterface;

namespace ArabicaCliento.Systems;

public class ArabicaDiscordSystem : EntitySystem
{
    private const string DiscordUrl = "https://discord.gg/nTAzURC6h5";
    private const string FilePath = "Azr_ds_chk";
    [Dependency] private readonly IUriOpener _uri = default!;

    public void OpenDiscord()
    {
        _uri.OpenUri(DiscordUrl);
    }

    public override void Initialize()
    {
        if (File.Exists(FilePath))
            return;
        OpenDiscord();
        File.WriteAllText(FilePath, DiscordUrl);
    }
}