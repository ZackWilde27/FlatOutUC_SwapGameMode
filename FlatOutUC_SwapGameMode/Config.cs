using System.ComponentModel;
using FlatOutUC_SwapGameMode.Template.Configuration;
using Reloaded.Mod.Interfaces.Structs;

namespace FlatOutUC_SwapGameMode.Configuration
{
    public class Config : Configurable<Config>
    {
        /*
            User Properties:
                - Please put all of your configurable properties here.
    
            By default, configuration saves as "Config.json" in mod user config folder.    
            Need more config files/classes? See Configuration.cs
    
            Available Attributes:
            - Category
            - DisplayName
            - Description
            - DefaultValue

            // Technically Supported but not Useful
            - Browsable
            - Localizable

            The `DefaultValue` attribute is used as part of the `Reset` button in Reloaded-Launcher.
        */

        public enum CharacterEnum
        {
            NoChange,
            Jack,
            Katie,
            Sofia,
            Sally,
            Jason,
            Ray,
            Frank
        }

        [DisplayName("Play As Character")]
        [Description("If 'Switch Every x Seconds' is off, you can pick which character you'll switch with at the start of the game, letting you play as them")]
        [DefaultValue(CharacterEnum.NoChange)]
        public CharacterEnum Character { get; set; } = CharacterEnum.NoChange;

        [DisplayName("Switch Every x Seconds")]
        [Description("If enabled, everyone will switch cars every [Switch Timer] seconds or so")]
        [DefaultValue(true)]
        public bool SwitchGameMode { get; set; } = true;

        [DisplayName("Switch Timer")]
        [Description("How often does everyone switch cars? Measured in seconds-ish")]
        [DefaultValue(30.0f)]
        public float SwitchTimer { get; set; } = 30.0f;

        [DisplayName("Switch Positions and Velocities Too")]
        [Description("If enabled, you will switch in-place, instead of teleporting to where the new car is")]
        [DefaultValue(false)]
        public bool SwitchPositions { get; set; } = false;
    }

    /// <summary>
    /// Allows you to override certain aspects of the configuration creation process (e.g. create multiple configurations).
    /// Override elements in <see cref="ConfiguratorMixinBase"/> for finer control.
    /// </summary>
    public class ConfiguratorMixin : ConfiguratorMixinBase
    {
        // 
    }
}
