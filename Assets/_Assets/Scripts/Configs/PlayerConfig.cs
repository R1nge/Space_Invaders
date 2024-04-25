using UnityEngine;

namespace _Assets.Scripts.Configs
{
    [CreateAssetMenu(fileName = "Player Config", menuName = "Configs/Player", order = 0)]
    public class PlayerConfig : ScriptableObject
    {
        [SerializeField] private float speed;
        [SerializeField] private float horizontalClamp;
        [SerializeField] private float verticalClamp;
        public float Speed => speed;
        public float HorizontalClamp => horizontalClamp;
        public float VerticalClamp => verticalClamp;
    }
}