using UnityEngine;

namespace _Assets.Scripts.Configs
{
    [CreateAssetMenu(fileName = "UI Config", menuName = "Configs/UI")]
    public class UIConfig : ScriptableObject
    {
        [SerializeField] private GameObject pauseUI;
        [SerializeField] private GameObject gameUI;
        public GameObject PauseUI => pauseUI;
        public GameObject GameUI => gameUI;
    }
}