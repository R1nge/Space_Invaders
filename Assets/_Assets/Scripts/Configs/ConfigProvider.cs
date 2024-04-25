using UnityEngine;

namespace _Assets.Scripts.Configs
{
    public class ConfigProvider : MonoBehaviour
    {
        [SerializeField] private GameObject playerPrefab;
        [SerializeField] private GameObject enemyPrefab;
        [SerializeField] private GameObject regularBulletPrefab;
        [SerializeField] private GameObject rareBulletPrefab;
        [SerializeField] private UIConfig uiConfig;
        public GameObject PlayerPrefab => playerPrefab;
        public GameObject EnemyPrefab => enemyPrefab;
        public GameObject RegularBulletPrefab => regularBulletPrefab;
        public GameObject RareBulletPrefab => rareBulletPrefab;
        public UIConfig UIConfig => uiConfig;
    }
}