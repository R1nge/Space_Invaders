using _Assets.Scripts.Services.UIs;
using UnityEngine;

namespace _Assets.Scripts.Configs
{
    [CreateAssetMenu(fileName = "UI Config", menuName = "Configs/UI")]
    public class UIConfig : ScriptableObject
    {
        [SerializeField] private GameObject pauseUI;
        [SerializeField] private InGameUIView gameUI;
        public GameObject PauseUI => pauseUI;
        public InGameUIView GameUI => gameUI;
    }
}