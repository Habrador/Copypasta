# Copypasta

Standardized code I copy paste into all my personal Unity projects. 


## Installation instructions

Copy paste the **_Copypasta** folder into your project folder. 


## Features

- **Vector library.** What's wrong with with Unity's Vector3 and Vector2? Because you can pass a Vector3 to a method with Vector2 as parameter and Unity will accept it and just cut the z coordinate. I've learned this will introduce bugs so I always prefer to use my custom vector library.

	- **MyVector3** and **MyVector2**. Same as Vector3 and Vector2.
	
	- **MyVector3Double** and **MyVector2**. Same as Vector3 and Vector2 but with double in case you need greater precision.
	
	- **MyVector3Int** and **MyVector2Int**. Same as Vector3Int and Vector2Int.

	
- **Graphics library.** I used to use Unity's GL.LINES to draw simple lines but it doesn't work in the URP render pipeline, so instead I started using Unity's [MeshTopology](https://docs.unity3d.com/ScriptReference/MeshTopology.html). Is currently only working with the URP render pipeline because of the shader it's using, but you only need to change one line of code in the Materials class to make it work with other pipelines. 

	- **DisplayCircle.** Draws a circle in 2d space.
	
	- **DisplayCircle3D.** Draws 3 circles in 2d space aroud each axis to form something similar to a sphere.
	
	- **DisplayLine.** Draws a line.
	
	- **DisplayVertices.** Draws a pixel for each coordinate. These can be hard to see so I've used some emission shader to make them more visible.
	
	- **DisplayLineSegments.** Draws multiple line segments. 
	

- **Useful Methods.**

	- ****