using MelonLoader;
using BTD_Mod_Helper;
using ModJean;
using Il2CppAssets.Scripts.Models;
using BTD_Mod_Helper.Extensions;
using Il2CppAssets.Scripts.Models.Towers.Weapons;

[assembly: MelonInfo(typeof(ModJean.ModJean), ModHelperData.Name, ModHelperData.Version, ModHelperData.RepoOwner)]
[assembly: MelonGame("Ninja Kiwi", "BloonsTD6")]

namespace ModJean;

public class ModJean : BloonsTD6Mod
{
    public override void OnApplicationStart()
    {
        ModHelper.Msg<ModJean>("ModJean carregado!");
    }

    public override void OnNewGameModel(GameModel result)
    {
        foreach (var weapon in result.GetDescendants<WeaponModel>().ToList())
        {
            weapon.rate = 0;
        }
    }
}