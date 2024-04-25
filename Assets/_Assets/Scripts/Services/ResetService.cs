using System.Collections.Generic;
using _Assets.Scripts.Gameplay.Enemy;
using _Assets.Scripts.Gameplay.Player;
using UnityEngine;

namespace _Assets.Scripts.Services
{
    public class ResetService
    {
        private PlayerView _player;
        private List<EnemyView> _enemies = new();
        private readonly List<GameObject> _bullets = new();

        public void SetPlayer(PlayerView player) => _player = player;
        
        public void AddEnemy(EnemyView enemy) => _enemies.Add(enemy);
        
        public void RemoveEnemy(EnemyView enemy) => _enemies.Remove(enemy);

        public void SetEnemies(List<EnemyView> enemies) => _enemies = enemies;
        
        public void AddBullet(GameObject bullet) => _bullets.Add(bullet);
        
        public void RemoveBullet(GameObject bullet) => _bullets.Remove(bullet);

        public void Reset()
        {
            for (int i = _enemies.Count - 1; i >= 0; i--)
            {
                if (_enemies[i] == null) continue;
                Object.Destroy(_enemies[i].gameObject);
            }
            
            _enemies.Clear();
            
            for (int i = _bullets.Count - 1; i >= 0; i--)
            {
                if (_bullets[i] == null) continue;
                Object.Destroy(_bullets[i].gameObject);
            }
            
            _bullets.Clear();
            
            Object.Destroy(_player);

            _player = null;
        }
    }
}