**Unity 22.3.9f1**    

May need to run `git config --system core.longpaths true` to be able to clone

Since I were asked to create an MVP I cut some corners
- I didn't use interfaces for damageable entities
- Could have created a scriptable object for an enemy factory
- Allowed bullets to kill only one enemy at once
- Bullets don't get destroyed off screen
- Since no one asked the score doesn't reset on next level
- The game doesn't really pause, just changes UI
- The game uses old input system
- Enemies don't drop anything since ammo is infinite

```
EnemyView : MonoBehaviour
{
  ...

  public void Die()
  {
    ...
    var typesLength = Enum.GetValues(typeof(BulletType)).Length;
    var type = (BulletType) Random.Range(0, typesLength);
    _ammoFactory.Create(type);
  }
}
```
It's a bit slow, could be cached if needed, it's an MVP anyway
