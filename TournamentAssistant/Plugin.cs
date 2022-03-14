using System;
using IPA;
using SiraUtil.Web.SiraSync;
using SiraUtil.Zenject;
using TournamentAssistant.Behaviors;
using TournamentAssistant.Installers;
using TournamentAssistant.Utilities;
using TournamentAssistantShared;
using UnityEngine;
using IPALogger = IPA.Logging.Logger;

///
/// Created by Moon on 8/5/2019
/// Rewrite done by Raine, started on 26/2/2022
/// Base plugin class for the TournamentAssistant plugin
/// Intended to be the player-facing UI for tournaments, where
/// players' games can be handled by their match coordinators
/// 

namespace TournamentAssistant
{
    [Plugin(RuntimeOptions.DynamicInit)]
    public class Plugin
    {
        public string Name => SharedConstructs.Name;
        public string Version => SharedConstructs.Version;

        public IPALogger logger;

        public static bool UseSync { get; set; }
        public static bool UseFloatingScoreboard { get; set; }
        public static bool DisableFail { get; set; }
        public static bool DisablePause { get; set; }
        public static bool DisableScoresaberSubmission { get; set; }

        // This is required for BSIPA and SiraUtil's Zenject implementation.
        // DO NOT CHANGE THIS METHODS ATTRIBUTE! BSIPA REQUIRES IT TO BE INIT
        [Init]
        public void Init(Zenjector zenject)
        {
            zenject.UseLogger(logger);
            zenject.UseSiraSync(SiraSyncServiceType.GitHub, "MatrikMoon");
            
            zenject.Install(Location.App, _ => _.Bind(typeof(IDisposable)).To<PluginClient>().AsSingle());
            
            zenject.Install<TournamentAssistantMenuInstaller>(Location.Menu);
            zenject.Install<TournamentAssistantGameInstaller>(Location.StandardPlayer);
        }

        [OnEnable]
        public void OnEnable()
        {
            // SceneManager.sceneLoaded += OnSceneLoaded;
            // SceneManager.sceneUnloaded += OnSceneUnloaded;
            SongUtils.OnEnable();

            //This behaviour stays always
            new GameObject("ScreenOverlay").AddComponent<ScreenOverlay>();
        }

        // not needed with Zenject lifetimes.
        // public static bool IsInMenu() => SceneManager.GetActiveScene().name == "MainMenu";
    }
}