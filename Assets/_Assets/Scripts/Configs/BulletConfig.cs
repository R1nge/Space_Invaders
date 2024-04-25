using UnityEngine;

namespace _Assets.Scripts.Configs
{
    [CreateAssetMenu(fileName = "Bullet Config", menuName = "Configs/Bullet")]
    public class BulletConfig : ScriptableObject
    {
        [SerializeField] private float speed;
        public float Speed => speed;
    }
}