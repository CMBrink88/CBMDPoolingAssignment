# CbrinkMdavisPoolingAssignment
Chris Brinkley and Morgan Davis' IMM 215 Pooling Assignment
These three scripts combined create an object pooler that spawns cubes within a scene that reuse themselves once every cube in the pool is 
present in the scene. These three script's main functions can be defined as following: 
- A Cube script that defines the movement of the cube along the x, y and z axis through random calculation of their forces. 
- A CubeSpawner script that initiates the Object Pool in the Start update while also instantiating the cubes when every Fixed
  Update is called. 
- An Object Pooler script that initiates a queue within the pool and enables the cubes so that they can be spawned and then removed 
back to the queue. 

How to use these scripts in a scene: 

1. Create an environment with a ground and an empty game object. 
2. Apply the Cube Spawner script to the empty game object. 
3. Apply the Object Pooler script to the same empty game object. 
4. Go into the inspector, under the Object Pooler script, and define the Tag as 'Cube.' 
5. Go to Prefab in that same area and drag the Cube script into the prefab box. 
6. Go to Size in that same area and give the size of the pool a number, like 100. 
7. Run the scene! The cubes should unspawn themselves as need be. 

Assessment of Collaboration: 

Collaboration between Chris and Morgan went great. Constant communication was kept on the project throughout the week and a meeting in the
library occurred for two hours to go over some issues in the scripting. The majority of the scripting itself was done on 
Chris's part while Morgan was responsible for the ReadMe, the scene environment, and the comments on the code. 
