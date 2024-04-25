using UnityEngine;

namespace _Assets.Scripts.Gameplay.Enemy
{
    public class EnemyView : MonoBehaviour
    {
        public void Die() => Destroy(gameObject);
    }
}