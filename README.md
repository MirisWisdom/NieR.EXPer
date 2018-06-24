<h1 align="center">NieRexper</h1>
<p align="center">
	<img src="https://user-images.githubusercontent.com/10241434/41816662-3e8405e6-77bd-11e8-967f-ff47ec9ac5e1.png"/>
 <br><br>
 Level Patcher for NieR:Automata
</p>

# Introduction

In a nutshell, this little tool changes the level on your NieR:Automata save file. Want to be level 25 again? Click on the button, choose your slot and that's it!

## How?

The technical gist of it is that N:A deduces the level based on your current EXP, thus the EXP value must be changed to the value required by the respective level.

## Why?

Once you reach level 50+, the game's difficulty becomes rather trivial. To bring back the difficulty, I've made this program to swiftly downgrade my level. Of course, one could use it to boost their level. >_>

# Instructions

0. Note that .NET 4.5 is required to run the executable!
1. Download the executable and run it.
2. Click on the save slot you want to modify, then click on the level you want to apply. Done!
3. If all worked, you should see `Status: SUCCESS` in the window!
   - The tool will make a backup of your original save with a random string appended to its name; e.g. `SlotData_0-5d8fe167.dat`.