# Warehouse Pallet Management Simulator

## Description

The Warehouse Pallet Management Simulator is a project that implements AI pathfinding techniques to manage the movement of pallets within a warehouse. Using a combination of C# for the simulation logic and Prolog for handling the goal state evaluation, the application effectively simulates the workflow of moving pallets to designated outbays.

## Objectives

- To simulate the movement of pallets from their initial positions to designated outbays in an efficient manner.
- To showcase AI pathfinding techniques in a practical scenario involving warehouse logistics.

## Goal States

1. **First Goal State**: 
   - `pallet_0` should be at `outbay_0`.

2. **Second Goal State**: 
   - `pallet_0` should be at `outbay_0`.
   - `pallet_1` should be at `outbay_1`.
   - `pallet_2` should be at `outbay_2`.
   - `forklift_0` should be located in `parking`.

## Technologies Used

- **C#**: For implementing the main simulation logic and managing the state of pallets and the forklift.
- **Prolog**: For defining the goal states and handling the decision-making process related to pathfinding.
