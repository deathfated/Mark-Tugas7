# Mark-Tugas7
Sample Game for practicing game optimization (reduce draw call, object pooling, resource load)

Optimization Steps:

(poin 2)
-unactive all bgm objects, change the inspector settings to "play on awake"
-change in script AudioManager, PlayBgm method from ...gameObject.Play() to gameObject.Setactive(true) 
*this makes it so all game objects are inactive on starting the game, and when the button is pressed the randomized bgm is the only one activeated and playing
-on the audio clip of each bgm file, set the "Preload Audio Data" to false
*this makes it so all audio clips are not loaded until when they are actually used, saving memory
 
 (point 3)
 -implemented texture atlas using create>2D>SpriteAtlas
 *reduces batches from 4 to 3
 
 (point 4)
 -implemented object pooling in the MushroomSpawner script
 
 (point 5)
 -implemented static batching
