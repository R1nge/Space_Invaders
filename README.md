May need to run `git config --system core.longpaths true` to be able to clone (Will test it when it's done)

Since I were asked to create an MVP I cut some corners
- I didn't use interfaces for damageable entities
- Could have created a scriptable object for an enemy factory
- Allowed bullets to kill only one enemy at once
- Bullets don't get destroyed off screen
- Since no one asked the score doesn't reset on next level
