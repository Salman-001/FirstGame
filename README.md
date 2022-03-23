# FirstGame

<h2>Objectives</h2>
<p>To test students’ knowledge on topics such as:</p>
<ul>
<li>Movement and rotation via the transform component/Movement and rotation via the Physics Rigidbody component.</li>
<li>Collisions and Triggers.</li>
<li>Instantiating and Destroying game objects.</li>
<li>User Input from the Keyboard and the Mouse.</li>
<li>Serialization of variables.</li>

<h2>Requirements</h2>
<ul>
<li>You are asked to develop a small prototype game. It should contain a plane with different primitives on it (cubes, capsules, spheres, Cylinders etc...). The primitives should be scattered the way you want on the plane but make sure that you scatter them in a way to allow your player to navigate smoothly between them and rotate smoothly in different directions around them. You need to create some flattened large cubes that are at a higher level than the plane. The player can jump on these cubes and jump back from them to the plane. So, you need to implement a jump functionality. Please put high walls (they should be primitives) around the plane so that the player can not jump above them nor fall in the abyss! Remember you can do awesome stuff with only primitives. This requirement would help you practice your scene navigation skills: panning, zooming in etc... No need to bring any assets from Unity Asset store or similar places in this homework. </li>
<li> Please follow standard input keys used by players for navigation and jumping in games. In other words, Jump is the space key. WASD keys or the arrows keys should be used for movement in the corresponding directions. </li>
<li> Your player can only be a primitive for this assignment only: a cube, a capsule, a sphere etc... You can use either Rigidbody physics system (i.e. methods such as AddForce or AddTorque etc..) or the transform methods (transform.Translate() etc....) for movements and rotations. </li>
<li> The player movements/rotations must be frame rate independent. Make sure you think clearly which update method to use. </li>
<li> When you click the left mouse, you should be able to shoot small cubes from the player that are destroyed after 4 seconds. Hint: To make a bullet cube: make a small cube and add the adequate functionality scripts and components to it (such as rigidbody and collider) then prefab it to use it in your shooting mechanism. Make sure the cubes are destroyed after they’re instantiated (4 seconds delay). </li>
<li> If the cubes that are shot hit any primitive on the plane, that primitive should be destroyed after 6 seconds. Hint: Consider implementing a code for detecting collisions from bullets. Maybe you can utilize the concept of tags. </li>
<li> Serialize any variable which you find necessary so that we can change their values in the Inspector. Examples: MovementSpeed, BulletSpeed, the bullet prefab etc... </li>
</ul>