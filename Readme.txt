This repository contains a minimal sample Unity project structure for a simple
2D top-down bullet hell shooter. Copy the contents of this repository into a
Unity project and create a new scene. Then add the prefabs and set up objects
using the provided scripts and sprites under the `Resources` folder.

## Setup Steps
1. Create an empty GameObject called `GameManager` and attach `GameManager`
   and `Spawner` components.
2. Create a player prefab with `SpriteRenderer`, `Rigidbody2D`, `BoxCollider2D`,
   `PlayerController` and `PlayerHealth` components. Assign the bullet prefab
   and a child transform as `bulletSpawn`.
3. Create a bullet prefab with `SpriteRenderer`, `Rigidbody2D`, `BoxCollider2D`
   set as trigger, and `Bullet` component.
4. Create an enemy prefab with `SpriteRenderer`, `Rigidbody2D`, `BoxCollider2D`
   set as trigger, and `EnemyController` component.
5. Create a simple canvas UI with a `GameOver` panel containing a Restart
   button wired to `UIManager.OnRestart`.
6. Place the `Spawner` object above the screen so enemies spawn from the top.

Sprites are simple coloured squares located in `Resources/Sprites`. They can be
loaded using `Resources.Load<Sprite>("Sprites/player")` and so on.
