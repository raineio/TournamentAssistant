﻿using System.Linq;
using TournamentAssistantShared.Models;
using static BeatSaberMarkupLanguage.Components.CustomListTableData;

namespace TournamentAssistant.UI.CustomListItems
{
    public class MatchCellInfo : CustomCellInfo
    {
        public Match Match { get; set; }

        public MatchCellInfo(Match match) : base(GetTitleFromMatch(match))
        {
            Match = match;
        }

        private static string GetTitleFromMatch(Match match)
        {
            /*string title = string.Empty;
            foreach (var player in match.Players) title += player.Name + " / ";
            return title.Substring(0, title.Length - 3);*/

            return $"Host: {match.Leader.Name} - {match.AssociatedUsers.Where(x => x.ClientType == User.ClientTypes.Player).Count()} Players";
        }
    }
}
