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
Scenario 1: For this rhythm game, I’m thinking of using a mix of ScriptableObjects, inheritance with polymorphism, and an MVC pattern driven by C# events. Basically, each beat would be a ScriptableObject that just holds pure data—like which key to press, the exact timing, and where it pops up on the screen. The best part about this is that the beat data is totally separate from the scene. It makes it way easier to reuse or tweak levels without having to mess around with messy GameObjects in the hierarchy. On the coding side, I’d set up a base abstract class or interface (something like Beat) to handle the basics, like Spawn() or CheckInput(). Then, different types like hold notes, taps, or slides can just inherit from that and override the specific behavior. 

Scenario 2: For a tactical shooter like Valorant, I’d go with a mix of inheritance, interfaces, and a Finite State Machine (FSM) to keep things manageable. All the agents would inherit from one main Agent base class. This is where I’d keep the common stuff like health, movement, and damage logic. For the unique abilities, I’d use abstract methods or interfaces. This way, every character follows the same structure, but I can still write totally different logic for their specific powers without it getting messy. I also want to use an FSM with C# enums to handle player states—like whether they're idling, shooting, using an ability, or stunned. It’s a lot easier to sync animations with gameplay logic this way. Plus, I’d use ScriptableObjects for all the character stats and ability data. That way, if I need to buff or nerf something, I can just tweak the data file instead of digging through the code.

Scenario 3：
For a farming simulation game, I think a combination of ScriptableObjects and inheritance would be best. I’d start with a base FarmObject class for anything you can find on a farm, such as plants or rocks. These would all share basic properties such as position and interaction methods, but then I would use inheritance to create specific types — so a harvestable crop and a breakable rock would each have their own version of the 'Interact()' behaviour. ScriptableObjects are ideal for this kind of game. I’d use them to store crop-specific data, such as how many days it takes for them to grow and what they drop when harvested. This is much better than duplicating that data across a hundred different prefabs. On the player's side, I’d use a finite state machine (FSM) to manage actions such as watering, planting or mining. This makes it much smoother, ensuring the player isn't trying to perform two animations at once and that everything feels responsive.
### Activity 4
[Proposal First Draft](https://docs.google.com/document/d/1xBZf-TNesHDRlNGUnQIIlStqfWb3MOsQMGyXhkQuQ5s/edit?usp=sharing)

