# GDIM32 In Class Activities
## W1
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
[MG1 Breakdown Google Doc](https://docs.google.com/document/d/1RY8G4u76Aeqqu-rppdIJhAqMhHotRh3U2m445UlfjAs/edit?usp=sharing)

## W2
### Activity 1
![d0d42cf4a120d9f60ba2f311913c0229](https://github.com/user-attachments/assets/71ca3dba-92a2-4a4e-9779-00c6e6d44b4f)
### Activity 2
[Inclass Pre-MG2](https://github.com/UCI-GDIM32-W25/mg2-ruixuanp1122/commit/3355a699fc859c54d18a56e8586b7cfa29054ccd)

In this assignment,  I focused on setting up the penguin’s jump behavior using physics, including detecting when the penguin is grounded so that jumping is only possible while on the ground.  I also configured the ground and collision system to ensure the player interacts correctly with the environment. The TA helped me build a great ground layer, and I learned how colliders, Rigidbody2D, and ground checks work together to control movement and prevent unintended behavior such as falling through the ground or double jumping.

## W3
### Activity 0-2
My Buddy: Yan Zhang 

### Aactivity 3
![8cceb080d66e96928dd9b1147e86eece](https://github.com/user-attachments/assets/9bbe670b-ac00-4b52-875c-058878a0f900)

## W4
### Activity 0
My Buddy: Yan Zhang 

### Activity 1
When multiple Locator objects are added to the Scene, all but one are destroyed when the game runs.
This happens because the Locator uses the Singleton pattern: during Awake(), each instance checks whether another instance already exists and destroys itself if so.

### Activity 2
Break Down:
![3043aa5e7d1d66c0231cb32d7fd1b5ac](https://github.com/user-attachments/assets/d58494d0-7978-4f58-bb31-529b44ed0e8d)

### Activity 3
[HW4](https://github.com/ruixuanp1122/HW4/commit/7509c0aa8de2f6976a6b3cfdf32344e911a97dfd)
I downloaded the assets of Yellowbird, Crow, and Pigeon and sliced them separately. I also changed the format to 9:16 instead of the horizontal version for better mobile playback, the same as the Professor's format. 


## W5
### Activity 1
I suppose using the abstract Item class combined with the IBreakable interface is a clear and effective way, and it can show inheritance and interfaces separately. The Item class defines a shared behaviour (Use()), while the IBreakable interface separates optional functionality, which not all items require (e.g. the Elven Sword).

However, for a larger project, I would consider refactoring this design by centralising shared durability logic in a base breakable item class or making durability data-driven rather than hard-coding it in each item. This would reduce duplication and make balancing or extending item behaviour easier.

Overall, I think this structure works well as a learning exercise, providing a solid conceptual foundation. However, I would adapt it for scalability and flexibility in a full game project.

### Activity 2
In the second demo, Model is handled by the ScriptableObject classes (like ItemData or EnemyStats). They’re strictly for holding the "source of truth"—the raw data like health, names, and stats—independent of any logic in the scene.

And view is the UI scripts (like UIManager or HealthBar) and the SpriteRenderers on the GameObjects act as the View. They just listen for changes and update what the player actually sees on the screen.

I think Controller is the MonoBehaviour scripts (like PlayerController or EnemyAI) act as the glue. They take the player input or game logic, grab the data from the Model, and tell the View what to display.

### Activity 3
Scenario 1: I would use a mix of ScriptableObjects, inheritance with polymorphism, and the MVC pattern with C# events to do so. Each beat here should be a ScriptableObject. Since they’re just data (key, location, timing), it’s better than using GameObjects. It keeps the data independent from the scene. I also would use a base abstract class or interface for a generic "Beat." Then, different types like hold notes or slides can inherit from it and override behaviors using polymorphism. And I thinks the MVC approach works best here. The Model handles the song timing and broadcasts C# events, while the View (the notes on screen) just reacts to those events. This keeps the timing logic separate from the visuals.

Scenario 2: For a tactical shooter like Valorant, I’d go with a mix of inheritance, interfaces, and a Finite State Machine (FSM) to keep things manageable. For the character Setup, I’d create a basic parent class (like Agent) for shared stuff like health and movement. For the unique abilities, I’d use abstract classes or interfaces. That way, every character has an Attack() method, but the actual code inside is "incredibly unique" for each agent. I notice that the State Management's characters have different modes (moving, attacking, casting), so a Finite State Machine with C# enums is essential. It makes the way easier to sync the animations with whatever state the player is currently in.

Scenario 3：
For a farming simulation game, I think a combination of ScriptableObjects and inheritance would be best. I’d start with a base FarmObject class for anything you can find on a farm, such as plants or rocks. These would all share basic properties such as position and interaction methods, but then I would use inheritance to create specific types — so a harvestable crop and a breakable rock would each have their own version of the 'Interact()' behaviour. ScriptableObjects are ideal for this kind of game. I’d use them to store crop-specific data, such as how many days it takes for them to grow and what they drop when harvested. This is much better than duplicating that data across a hundred different prefabs. On the player's side, I’d use a finite state machine (FSM) to manage actions such as watering, planting or mining. This makes it much smoother, ensuring the player isn't trying to perform two animations at once and that everything feels responsive. 

### Activity 4
[Proposal First Draft](https://docs.google.com/document/d/1xBZf-TNesHDRlNGUnQIIlStqfWb3MOsQMGyXhkQuQ5s/edit?usp=sharing)


## W6
### Activity 1
- Gizmos:
  - visual aids for debug things
  - OnDrawGizmos()
  - OnDrawGizmosSelected(): Only visible when object is clicked.
  - Use to visualize item interaction zones
- Unity Profiler:
  - A tool to analyze game performance and identify bottlenecks
  - Spikes: Sudden high CPU usage in one frame
  - GC Alloc: Memory allocated will cause stuttering" when cleaned up.
- Breakpoints：
  - Pausing the code at a specific line and check variable values.
- Merging and version control：
  - Resolve conflicts when different teammates edit together
  - Use prefabs to minimize conflicts
- Debug.Log: slow the unity engine
- GetComponent: don't use them frequently in Update
- Profile: look Hierarchy View of Player Loop
- Window → Analysis → Profiler


### Activity 2
Attendance: Peiyi Xiong, Jingyi Bi, Ruixuan Pan 

[proposal final draft document](https://docs.google.com/document/d/1xBZf-TNesHDRlNGUnQIIlStqfWb3MOsQMGyXhkQuQ5s/edit?usp=sharing)

## W7
### Activity 1
- NPC Line-of-Sight and Aggro Mechanics
  - Duck uses a red line to detect the player's line of sight and activates pursuit when unobstructed
  - A finite state machine controls the duck's behavior (turning when obstacles block vision)
- Finite State Machine
  - Duck: wander state and pursue state
  - Enable enemies to switch between chasing and searching based on line-of-sight
- Raycast Line-of-Sight
  - Duck uses raycast to check the line to sight up a maximum distance
  - raycast hits the player-duck can see them; otherwise, obstacles block vision
- NPC Obstacle Avoidance
  - Duck NPC uses a sphere cast to detect obstacles
  - Sphere casts provide volume detection and prevent collisions with low or irregular obstacles

### Activity 2
Attendance: Peiyi Xiong, Ruixuan Pan 

### Activity 3
<img width="2360" height="1640" alt="bba180061bc8e0e349515ee28fa582f0" src="https://github.com/user-attachments/assets/d2c55382-9c45-4dc6-b8a8-3d71be1bb8fc" />

### Activity 4
[Trello](https://trello.com/invite/b/69951d1a0edbf2c293079f02/ATTIeab7c1536d86fdec98b645e8214f9f1c5B39497B/my-trello-board)

### Activity 5
[Final Project](https://github.com/lindenreid/GDIM32-Final/compare/main...ruixuanp1122:GDIM32-Final:main)
In class, I built the Unity project and shared it with two groupmates. I create the ground and the player, and code the fundamental script for this Final 3D Project. Our group  chose the 3D resources of buildings and houses for our game. We also plan the time to work together on this project and to divide our tasks. 
