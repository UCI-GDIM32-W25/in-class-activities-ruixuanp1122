# GDIM32 In Class Activities
# W1
### Activity 1
LA's advice is that we should understand our code, and then we can revise it into a better version. Moreover, we should understand the individual parts of the knowledge well to help us create outstanding work. It's essential to listen carefully in class and read the pre-learning PPT to learn the knowledge well. 
### Activity 2
1. x=10
2. x=2
3. Repeatedly occur "hello world"
4. MonoBehavior
5. It will print "x=10"
6. Name: Parameter; Purpose: It acts as a placeholder that allows the method to receive data as input. By defining an int x, the method PrintMessage can accept any integer passed to it and use that value within its body to perform tasks, making the code more flexible and reusable.
7. Translate can be only an object. 
8. _playerTransform.Translate
### Activity 3:
[https://docs.google.com/document/d/1RY8G4u76Aeqqu-rppdIJhAqMhHotRh3U2m445UlfjAs/edit?usp=sharing](https://docs.google.com/document/d/1RY8G4u76Aeqqu-rppdIJhAqMhHotRh3U2m445UlfjAs/edit?usp=sharing)
## MG1：Unity & C# review
1. Ruixuan Pan, she/her
2. In the MG1 break-down activity, our group described the game world in terms of objects and their relationships, including Seeds, the Player, and UI/Text. According to that, I created a Player GameObject to represent the player object described in the breakdown. The player has attributes such as position and speed, and actions including movement using WASD keys and planting seeds with the Space key. To represent seeds, I created a PlantGameObject as a Prefab rather than placing seeds directly in the Scene. This allowed seeds to exist only when they are planted by the player. In my breakdown, I identified the player’s actions as movement and planting seeds. And I implemented in the Player script that player movement is handled in the Update() method using Input.GetAxisRaw, allowing the player to move with the WASD or arrow keys. The breakdown also describes the interaction “seed → UI (appear, inform, increase + decrease)”, which is implemented through the script. This script manages how the UI responds when a seed is planted. Each time a seed appears in the world, the UI updates to decrease the number of seeds remaining and increase the number of seeds planted.PlantCountUI. I used a separate GameObject and script to manage UI updates and updates only the numeric TextMeshPro elements, allowing the labels to remain static while the values change. After replay Professor's game, I adjusted my UI approach. I initially placed a seed object directly in the Scene, which caused an extra seed to appear at the start of the game. After revisiting the breakdown and the project requirements, I removed all seeds from the Scene and relied entirely on the Prefab system so that seeds only appear when planted by the player.
