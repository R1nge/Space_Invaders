using UnityEngine;

namespace _Assets.Scripts.Configs
{
    public class ConfigProvider : MonoBehaviour
    {
        [SerializeField] private GameObject playerPrefab;
        [SerializeField] private GameObject enemyPrefab;
        [SerializeField] private UIConfig uiConfig;
        public GameObject PlayerPrefab => playerPrefab;
        public GameObject EnemyPrefab => enemyPrefab;
        public UIConfig UIConfig => uiConfig;
    }
}