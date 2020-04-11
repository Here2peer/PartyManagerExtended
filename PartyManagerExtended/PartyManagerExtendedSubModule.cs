
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
    protected override void OnSubModuleLoad()
        {
            Module.CurrentModule.AddInitialStateOption(new InitialStateOption("Hello",
    new TextObject("Hello", null),
    9990,
    () => { InformationManager.DisplayMessage(new InformationMessage("Hello World!")); },
    false));
        }

	}
}
