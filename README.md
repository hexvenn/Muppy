# Muppy
Muppy is a small program to assist you with mining (or perhaps other processing tasks, if they can be ran from the command line) on your PC. The purpose of this software is to switch between programs or turn them off, depending on how you're using your computer at the time.
For example, you can configure Muppy to stop mining when you're playing games and/or mine with higher intensity when you're not at the computer.

NOTE: Muppy does not come with mining software. It will not mine on it's own. It's up to you to set that up.
## Requirements
* Windows 7 (x64)
* .NET 4.6.1
## Interface
![UI](http://aeterniadev.com/github/MuppyUI.png)
You can enable the states that you'd like to be used by checking the checkboxes in appropriate sections. 
* "Computer is idle": Programs to run when the computer is idle. Additionally, you can specify the time interval after which the computer will be considered idle.
* "Computer is not idle: Programs to run when you are currently using the computer. Leave the text box empty and Muppy will simply not run anything during that state.
* "Running certain programs": Programs to run when there are specified programs running. Specify the program names as comma separated, you may use either the window title or process name (case insensitive i.e. "world of warcraft,Dota 2" will work. Note that "wow-64,dota2", which are the process names, should also work)
Additionally, you can enable and set an interval at which programs will be closed and reopened, should you need to work around certain issues.

## Example usage
1. We'd like to only mine when the computer is not being used. Notice that "Computer is not idle" is enabled, but the text box is empty.
![UseCase](http://aeterniadev.com/github/MuppyUseCase1.png)

2. We'd like to mine with both CPU and GPU when we're not there, only with gpu when we are using the computer, and not at all when we're playing games. Notice that "Running certain programs" is enabled, but the text box is empty.
Tip: you can decrease the mining intensity for when you're using the computer, if your mining software supports that.
![UseCase](http://aeterniadev.com/github/MuppyUseCase2.png)

## Disclaimer
This software has been created mostly for personal use, to automate turning the miner on whether possible. Even though I have been using it for some time now, you may run into issues that I did not. While you may report issues you encounter, this software comes with NO WARRANTY OF ANY KIND.