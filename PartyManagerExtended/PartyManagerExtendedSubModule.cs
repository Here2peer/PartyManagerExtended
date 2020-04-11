
using System;
using System.Collections.Generic;

using TaleWorlds.Core;
using TaleWorlds.MountAndBlade;
using TaleWorlds.CampaignSystem;
using CustomCampaignOptions.Behaviours;
using CustomCampaignOptions.GameModels;
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
                if (!(game.GameType is Campaign)) return;
                if (!(gameStarterObject is CampaignGameStarter gameInitializer)) return;
                new InformationMessage("Mod initialized");
                party
            }
            catch (Exception e)
            {
                new InformationMessage("Mod failed to load");
            }
        }
   

	}
}
