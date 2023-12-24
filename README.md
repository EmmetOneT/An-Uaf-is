# An-Uaf-is
Horror Game for Simulated Work Experience using C# and Playmaker visual scripting for Unity


https://github.com/EmmetOneT/An-Uaf-is/assets/78142923/510b89b6-067a-4b03-8723-dd111de24041

The game starts with a basic main menu including 'Start Game', 'Options' & 'Exit Buttons'
![Menu](https://github.com/EmmetOneT/An-Uaf-is/assets/78142923/8e080231-ceea-4558-b734-d33e97517acd)

The options menu includes a workin resolution picker,  a fullscreen toggle and master volume slider.
![Options](https://github.com/EmmetOneT/An-Uaf-is/assets/78142923/e10b3b4b-8e79-41a7-9fc1-7a55ca61fd3f)

The game includes npc dialog.
![Chat](https://github.com/EmmetOneT/An-Uaf-is/assets/78142923/4e709fe4-ba4e-4df3-b774-3e2474a421f4)

There is a randomised sliding puzzle that randomises on every playthrough. The C# code can be easily changed to increase or decrease the number of tiles in the given puzzle. 
![Puzzle](https://github.com/EmmetOneT/An-Uaf-is/assets/78142923/8f1620f3-af1c-4a39-9ce0-98fbfc3e6bb7)

There is a simple inventory system where, the items that are picked up by the player are stored and the player can switch between inventory items using the mouse scroll wheel.
![Pickup](https://github.com/EmmetOneT/An-Uaf-is/assets/78142923/13a6e376-b894-41fc-94aa-b4aa154ccfdd)

The player can find batteries throughout the game. The flashlight needs these batteries to function. An indicator on the GUI lets the player know how much battery they have left. The light will get progressively more dim as the battery levels run out and once out, the battery will turn off.
![Flashlight](https://github.com/EmmetOneT/An-Uaf-is/assets/78142923/dc6c577a-f342-4c29-bcd5-b2f51579658e)

There are notes throughout the game that may give hints or outright give the player codes to safes. The safes require the player to input the correct code. If incorrect, the player will be brough out of the input screen and will be able to try again. 
![Note](https://github.com/EmmetOneT/An-Uaf-is/assets/78142923/e0ef8f63-4765-4e20-8c3a-b4591bea16e0)
![Code](https://github.com/EmmetOneT/An-Uaf-is/assets/78142923/f269882c-e8a3-4d72-93ec-64e88332f18c)

There is a pistol for the player to pick up. They will need to find ammunition to fire it. Finding ammunition will add to the ammunition counter and decrease as it is fired. There is a fire sound and light effect when the gun is fired. 
![Gun](https://github.com/EmmetOneT/An-Uaf-is/assets/78142923/8a1fc9fb-d0c6-46d3-be6f-52b6bfe7adbd)

Most of the doors in the game are locked to direct the player in the right direction. they will need specific keys to be opened. 
![Key](https://github.com/EmmetOneT/An-Uaf-is/assets/78142923/d655f4d7-c67b-40d0-8852-99c58a08f743)

There are enemies through out the house. When one spawns, it will follow the player using the NavMesh. The enemies have a damage taken model. If shot in the head, they will die instantly. The body will take 5 shots and the limbs will take more. 
![image](https://github.com/EmmetOneT/An-Uaf-is/assets/78142923/b3495708-de90-4d9d-9021-07f96a41790b)
![Enemy Dead](https://github.com/EmmetOneT/An-Uaf-is/assets/78142923/a1a88379-d5f0-4190-a8d8-beec57f63936)

The enemies can deal damage to the player if they get too close. They Grab on and a biting animation plays. If the player takes too much damage, they die and the game ends.
![Player dead](https://github.com/EmmetOneT/An-Uaf-is/assets/78142923/58861a46-e1ba-435d-8da6-ed86c4caf2d5)

The Final boss takes place in an attic maze. The boss Teleports on a random timer and spawns in a radius around the player. The closer the enemy gets, the screen starts to lose colour and shakes. 
![Final Boss](https://github.com/EmmetOneT/An-Uaf-is/assets/78142923/8c613308-3318-4e5e-af53-3782b3c31853)















https://trello.com/b/ImPv6vDl/the-horror

