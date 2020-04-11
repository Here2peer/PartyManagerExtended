using TaleWorlds.CampaignSystem.ViewModelCollection;
using TaleWorlds.Core;
using TaleWorlds.CampaignSystem;
using TaleWorlds.MountAndBlade.View.Missions;

using System;

namespace PartyManagerExtended
{
    [OverrideView(typeof(PartyCharacterVM))]
    class PartyManagerExtended : PartyCharacterVM
    {
        public PartyManagerExtended(PartyScreenLogic partyScreenLogic, 
            Action<PartyCharacterVM> setSelected,
          Action<PartyCharacterVM, int, int, PartyScreenLogic.PartyRosterSide> onTransfer,
          Action<PartyCharacterVM> onShift,
          PartyVM partyVm,
          TroopRoster troops,
          int index,
          PartyScreenLogic.TroopType type,
          PartyScreenLogic.PartyRosterSide side,
          bool isTroopTransferrable, 
      string fiveStackShortcutKeyText) : 
            base(partyScreenLogic, setSelected, onTransfer, onShift, partyVm, troops, index, type, side, isTroopTransferrable, fiveStackShortcutKeyText)
        {

        }
        public override void RefreshValues()
        {
            base.RefreshValues();
            this.Name = this.Troop.Character.Name.ToString();
            this.TradeData?.RefreshValues();
            new InformationMessage("Mod initialized");
        }
    }
}
