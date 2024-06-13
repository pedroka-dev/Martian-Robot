# Martian Robot
A robot that moves and rotates based on a string input

# About the System
The chosen area for analysis is curiously rectangular, and the robots must walk through it with their cameras on, collecting all kinds of information. A robot's position is represented by a combination of X and Y coordinates and also a letter representing the direction it is facing. The area is divided into a grid to simplify navigation. An example of a position could be: 0,0,N, meaning the robot is in the bottom left part facing north. Use the following orientations: N = north, S = south, L = east, O = west. To control the robot, AEB sends simple strings with commands. Possible letters are: E, D, and M. The letters E and D make the robot turn 90 degrees to the left and right, respectively, without moving from its place. The letter M means moving one position forward on the grid, maintaining the same direction. Assume that moving the robot forward means moving its position from (X, Y) to (X, Y+1). For example, a robot at position (0,0) facing north, when moving one position, will end up at (0,1).

# Input
The program should have the following parameters: – The first line should be the coordinates of the upper right corner of the area. The lower left corner is always (0,0). – The rest of the inputs should be the commands the robot must execute. Each command should be sent in 2 parts: the first part is the initial position of the robot, and the second is a series of instructions that the robot must follow to explore the area. The position is given with 2 integers and a letter, separated by spaces, corresponding to the X and Y coordinates and the robot's orientation. Each robot will execute the instructions sequentially: the second robot will only start its actions when the first one finishes.

# Output
For each robot, the final position and its orientation after executing the instructions.

# Examples

Input:  

5 5 

1 2 N 

EMEMEMEMM 

3 3 L 

MMDMMDMDDM

Expected Output:

1 3 N 

5 1 L
