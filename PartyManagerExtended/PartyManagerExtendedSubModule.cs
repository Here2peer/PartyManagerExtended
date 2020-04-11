
using System;
using System.Collections.Generic;

using TaleWorlds.Localization;
using TaleWorlds.Core;
using TaleWorlds.MountAndBlade;
using TaleWorlds.CampaignSystem;
using StoryMode.GameModels;
using TaleWorlds.CampaignSystem;
using TaleWorlds.CampaignSystem.SandBox.GameComponents;
using TaleWorlds.CampaignSystem.SandBox.GameComponents.Map;
using TaleWorlds.CampaignSystem.SandBox.GameComponents.Party;
using TaleWorlds.Core;
using TaleWorlds.MountAndBlade;

namespace PartyManagerExtended
{
    public class PartyManagerExtendedSubModule : MBSubModuleBase
    {

        protected override void OnGameStart(Game game, IGameStarter gameStarterObject)
        {
            try
            {
                new InformationMessage("Mod initialized");
                if (!(game.GameType is Campaign)) return;
                if (!(gameStarterObject is CampaignGameStarter gameInitializer)) return;
            }
            catch (Exception e)
            {
                new InformationMessage("Mod failed to load");
            }
        }

   

	}
}
