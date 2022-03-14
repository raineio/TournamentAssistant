using System;
using System.Linq;
using System.Threading.Tasks;
using TournamentAssistant.Misc;
using UnityEngine;

namespace TournamentAssistant.Utilities
{
    public class PlayerUtils
    {
        private readonly IPlatformUserModel userModel;

        public PlayerUtils(IPlatformUserModel userModel)
        {
            this.userModel = userModel;
        }
        
        public async Task<string> GetPlatformUserData()
        {
            var userID = await userModel.GetUserInfo();
            return userID.platformUserId;
        }

        public static void ReturnToMenu()
        {
            UnityMainThreadDispatcher.Instance().Enqueue(() =>
            {
                var results = Resources.FindObjectsOfTypeAll<PrepareLevelCompletionResults>().FirstOrDefault()?.FillLevelCompletionResults(LevelCompletionResults.LevelEndStateType.None, LevelCompletionResults.LevelEndAction.Quit);
                if (results != null) Resources.FindObjectsOfTypeAll<StandardLevelScenesTransitionSetupDataSO>().FirstOrDefault()?.Finish(results);
            });
        }
    }
}
