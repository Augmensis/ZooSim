# ZooSim
A Zoo Simulator Project for DA.




## Installation

1. Clone the repository into Visual Studio.
2. Build the solution.
3. Run ZooSim.Main
4. Feed the animals.
5. ???
6. Profit.
7. Award new role to Derek Hampton.



## Usage
A grouped list of animals in the Zoo will be displayed, along with the current Sim time. The list contains all of the animal's stats and statuses and updates automatically after every event.

Every 5 seconds, the Sim time will advance by 1 hour and randomly reduce the health of each of the animals.

If an animal's health reduces below their personal limits or beyond any special circumstances, then the animal will be pronounced dead and no longer receive any more updates.

You can feed the animals! When pressing the big green button, each group will receive a random amount of food and all of the animals within that group will increase their health by the same amount. Dead animals will not be fed... because they're dead.

Elephants have a special case whereby they are unable to walk at a certain point, but can regain that ability if you feed them enough and in-time.

To end the simulation, close the form.

Running the project again will reset the Sim and allow you to start again from scratch.


## Notes
The documentation stated the solution should be written in .NET Standard or .NET Core for a Winforms, Webforms, MVC, Web API’s or client-side Javascript application, specifically using Visual Studio 2015 or 2017. 

Unfortunately, Winforms support for pure .NET Core or .NET Standard is only available in VS 2019+. VS 2019 projects are also incompatible with earlier versions of Visual Studio.

So, to compromise, I've created the models, services and all associated logic in a .NET Standard library and Loaded it into a WinForms (.NET Framework) application as a reference. This way, the same library can be shared across .NET Framework, .NET Standard and .NET Core applications without much complication. The downside is the current project "ZooSim.Main" will only run in a Windows environment.





## License
[MIT](https://choosealicense.com/licenses/mit/)
