# Copypasta

Standardized code I copy paste into all my personal Unity projects. 


## Installation instructions

Copy paste the **_Copypasta** folder into your project folder. 


## Features

- **Vector library.** What's wrong with Unity's Vector3 and Vector2? Because you can pass a Vector3 to a method with Vector2 as parameter and Unity will accept it and just cut the z coordinate. I've learned the hard way that this will introduce bugs so I always prefer to use my custom vector library.

	- **MyVector3** and **MyVector2**. Similar to Unity's Vector3 and Vector2, but you can't pass a MyVector3 to a method with a MyVector2 as parameter.  
	
	- **MyVector3Double** and **MyVector2**. Similar to Unity's Vector3 and Vector2, but with double instead of float in case you need greater precision. I had to use double when simulating a pendulum - otherwise it would stop swinging prematurely.   
	
	- **MyVector3Int** and **MyVector2Int**. Solves the same problem that MyVector3 and MyVector2 is solving. Should be similar to Unity's Vector3Int and Vector2Int.

	
- **Graphics library.** I used to use Unity's GL.LINES to draw simple lines but it doesn't work with the URP, so instead I started using Unity's [MeshTopology](https://docs.unity3d.com/ScriptReference/MeshTopology.html). Is currently only working with the URP because of the shader it's using, but you only need to change one line of code in the Materials class to make it work with other pipelines. 

	- **DisplayCircle.** Draws a circle in 2d space.
	
	- **DisplayCircle3D.** Draws 3 circles in 2d space around each axis to form something similar to a sphere.
	
	- **DisplayLine.** Draws a line.
	
	- **DisplayThiccLine.** Draws a line which is actually an extruded circle along the line to make it more visible. 
	
	- **DisplayVertices.** Draws a pixel for each coordinate. These can be hard to see so I've used some emission shader to make them more visible.
	
	- **DisplayLineSegments.** Draws multiple line segments. 
	

- **Useful Methods.** A collection of useful methods. 

	- **Remap.** Remap value from range 1 to range 2.
	
	- **ClampListIndex.** This one is my favorite. If you have a list with 5 items (and it also loops), such as [0,1,2,3,4,5] and you want item 7. You can use this method and it will work like magic and spit out number 1. 

	- **AddValueToAverage.** If you want to add to an average, and you don't want to calculate the average every time because it's costly, you can use this method to add to an already existing average. 

	- **PrintScreen.** Takes a screenshot of your Unity project. 
	
	- **DestroyAllChildren.** Destroys all children to a Transform. This should be easy but I tend to always forget how it's done.