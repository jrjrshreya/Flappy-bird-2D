# Flappy-bird-2D
Making a Flappy Bird 2D game using UNITY engine.

This is one of the simplest 2d projects that is beginner friendly and helps understand the UNITY enging UI.

1. Import assets in the form of png.
2. create a gameobject under hierarchy and name it bird. Add a component "sprite renderer" in Inspector. import the bird image.png into the sprite field. Set desired resolution and change Main Camera object size as suitable. (this is done to adjust how big the bird looks in the final output.)
3. Under Bird game object, add rigid body component with gravity enabled. Use a circle collider. Attach birdscript code to the gameobject. Drag rigidBody Component to the "my rigidbody" slot. Set flap strength as desired.
4. Create a gameobject and name it pipe. Create a child "top pipe". Crreate sprite renderer component and and import pipe image onto spirte field. Create box collider and change Y axis with X=0 under box collider..
5. Duplicate the gameobject and name it Bottom pipe, change Y=-1 and move it.
6. under the "pipe" gameobject, attach the pipeMoveScript. Drag the pipe gameobject under hierarchy into the assets to create an asset.
7. Delete the pipe gameobjects.
8. Create a new gameobject "Pipe Spawner" drag it outside the screen area. attach pipespawnscript.
