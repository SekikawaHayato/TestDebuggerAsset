using UnityEngine;
using UnityEngine.SceneManagement;

namespace DebuggerAsset
{
    public class SceneSelectContentPresenter : ContentPresenterBase
    {
        [Header("リスタート時に開くScene名")]
        [SerializeField, SceneName]
        private string restartSceneName;
        [SerializeField] private LabelButton restartButton;

        [Header("今いるSceneを読み直す")]
        [SerializeField] private LabelButton reloadButton;

        public override void Initialize()
        {
            bool isSetRestartScene = !string.IsNullOrEmpty(restartSceneName);
            restartButton.SetInteractable(isSetRestartScene);
            if(isSetRestartScene)
            {
                restartButton.SetData($"Restart : {restartSceneName}");
                restartButton.OnClickButton.AddListener(Restart);
            }

            reloadButton.SetData("Reload Current Scene");
            reloadButton.OnClickButton.AddListener(Reload);
        }

        private void Restart()
        {
            SceneManager.LoadScene(restartSceneName);
        }

        private void Reload()
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().name);
        }
    }
}

