using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Text;

namespace RoR2EquipmentDroneUse
{
    public class ModSupport
    {
        public static Dictionary<string, DroneMode> itk_dm = new Dictionary<string, DroneMode>();

        [MethodImpl(MethodImplOptions.NoInlining | MethodImplOptions.NoOptimization)]
        public static void SetupModdedDictionary()
        {
            //DroneModeDictionary.Add(EquipmentIndex.None, DroneMode.None);

            if (BepInEx.Bootstrap.Chainloader.PluginInfos.ContainsKey("com.ThinkInvisible.TinkersSatchel"))
            {
                Compat_TinkersSatchel();
            }
        }

        //https://github.com/ThinkInvis/RoR2-TinkersSatchel/tree/master/Items/Eqp
        //https://github.com/ThinkInvis/RoR2-TinkersSatchel/tree/master/Items/LunarEqp
        [MethodImpl(MethodImplOptions.NoInlining | MethodImplOptions.NoOptimization)]
        public static void Compat_TinkersSatchel()
        {
            itk_dm["TINKERSSATCHEL_DODGE_NAME"] = DroneMode.Evade;
            itk_dm["TINKERSSATCHEL_LODESTONE_NAME"] = DroneMode.Evade;
            //itk_dm["TINKERSSATCHEL_PACKBOX_NAME"] = DroneMode.None; //picks up turret on use, drops on use
            //itk_dm["TINKERSSATCHEL_RECOMBOBULATOR_NAME"] = DroneMode.None; //rerolls interactable
            itk_dm["TINKERSSATCHEL_REVIVEONCE_NAME"] = DroneMode.None; //rez ally or summon drone
            itk_dm["TINKERSSATCHEL_REWIND_NAME"] = DroneMode.Evade; //10s buildup while CD is off

            itk_dm["TINKERSSATCHEL_COMPASS_NAME"] = DroneMode.None; //marks TP, adds mountain stack
            itk_dm["TINKERSSATCHEL_EMP_NAME"] = DroneMode.None;

            itk_dm["TINKERSSATCHEL_UNSTABLEBOMB_NAME"] = DroneMode.None;
        }
    }
}
