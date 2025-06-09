# Flappy-bird-2D
Making a Flappy Bird 2D game using UNITY engine.

This is one of the simplest 2d projects that is beginner friendly and helps understand the UNITY enging UI.

1. Import assets in the form of png.
2. create a gameobject under hierarchy and name it bird. Add a component "sprite renderer" in Inspector. import the bird image.png into the sprite field. Set desired resolution and change Main Camera object size as suitable. (this is done to adjust how big the bird looks in the final output.)
3. Under Bird game object, add rigid body component with gravity enabled. Use a circle collider. Attach birdscript code to the gameobject. Drag rigidBody Component to the "my rigidbody" slot. Set flap strength as desired.
4. Create a gameobject and name it pipe. Create a child "top pipe". Crreate sprite renderer component and and import pipe image onto spirte field. Create box collider and change Y axis with X=0 under box collider..
5. Duplicate the gameobject and name it Bottom pipe, change Y=-1 and move it.
6. under the "pipe" gameobject, attach the pipeMoveScript. Drag the pipe gameobject under hierarchy into the assets to create a prefab.
7. Delete the pipe gameobjects.
8. Create a new gameobject "Pipe Spawner" drag it outside the screen area. attach pipespawnscript.
9. Create an UI>Legacy>Text gameobject. under canvas Scaler, set UI scale mode to constant pixel size and a refresh resolution (example: 1920 x 1080). Move text to where desired. Set default text to "0".
10. Create gameobject "Logic Manager" and attach logic script. Drag text gameobject into score text slot.
11. create gameobject called "Middle" as a child of pipe gameobject and attach PipeMiddlesCRIPT. Add a logic tag to logic manager gameobject in inspector. add a bird layer to the bird gameobject.
12. Add "game over screen" empty object as a child of canvas gameobject. Add a text UI and a UI Button under "Game over screen" gameobject.
13. Add the text as desired ("Game over" and "play again").
14. add an "on click" under button and select "logicScript" > "restartGame"
15. disable gameover text by unchecking box in inspector.
16. Build the game.
