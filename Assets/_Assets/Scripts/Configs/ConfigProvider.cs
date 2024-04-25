using UnityEngine;

namespace _Assets.Scripts.Configs
{
    public class ConfigProvider : MonoBehaviour
    {
        [SerializeField] private GameObject playerPrefab;
        [SerializeField] private UIConfig uiConfig;
        public GameObject PlayerPrefab => playerPrefab;
        public UIConfig UIConfig => uiConfig;
    }
}