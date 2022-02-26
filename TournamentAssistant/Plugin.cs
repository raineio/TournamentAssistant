using IPA;
using TournamentAssistant.Behaviors;
using TournamentAssistant.Utilities;
using TournamentAssistantShared;
using UnityEngine;
using UnityEngine.SceneManagement;

/**
 * Created by Moon on 8/5/2019
 * Base plugin class for the TournamentAssistant plugin
 * Intended to be the player-facing UI for tournaments, where
 * players' games can be handled by their match coordinators
 */

namespace TournamentAssistant
{
    [Plugin(RuntimeOptions.SingleStartInit)]
    public class Plugin
    {
        public string Name => SharedConstructs.Name;
        public string Version => SharedConstructs.Version;

        public static bool UseSync { get; set; }
        public static bool UseFloatingScoreboard { get; set; }
        public static bool DisableFail { get; set; }
        public static bool DisablePause { get; set; }
        public static bool DisableScoresaberSubmission { get; set; }

        [OnEnable]
        public void OnEnable()
        {
            SceneManager.sceneLoaded += OnSceneLoaded;
            SceneManager.sceneUnloaded += OnSceneUnloaded;
            SongUtils.OnEnable();

            //This behaviour stays always
            new GameObject("ScreenOverlay").AddComponent<ScreenOverlay>();
        }

        public void OnSceneLoaded(Scene scene, LoadSceneMode sceneMode)
        {
            
        }

        public void OnSceneUnloaded(Scene scene)
        {
            
        }

        public static bool IsInMenu() => SceneManager.GetActiveScene().name == "MainMenu";
    }
}