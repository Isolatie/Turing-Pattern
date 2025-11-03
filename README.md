# Turing Pattern Simulation 

This project simulates **Turing patterns**. It’s implemented in Visual Studio 2022, however the algorithm in made in MATLAB using sparse matrix operations and implicit finite difference methods.

**You'll need both the Turing and Turing Library folder in order to make adjustements.**

---

## Overview

Turing patterns describe how interacting chemical substances can spontaneously form **spots**, **stripes**, or **waves**, as first proposed by **Alan Turing (1952)**.  
This simulation models two reacting and diffusing species, `u` and `v`, using equations inspired by the **Gray–Scott reaction–diffusion model**.

---

## | Parameter | Description |

| `d0` | Dirichlet boundary value for `u` at x = 0 | <br>
| `d1` | Dirichlet boundary value for `u` at x = 1 | <br>
| `n and m` | Grid resolution (number of spatial points per dimension) | <br>
| `timestep` | Time step size | <br>
| `color 1 and 2` | Colour in which you want the simulation to end with | <br>
| `end time` | Maximum simulation time | <br>

The function returns the **final concentration field** of species `v` as a 2D matrix (`R × R`), normalized to the range `[0, 1]`.

---

## How It Works

1. **Initial conditions:**  
   - `u` starts uniform (value = 1).  
   - `v` starts as a small circular patch in the center.  

2. **Diffusion:**  
   - Each species spreads according to its diffusion coefficient (`Du`, `Dv`).  

3. **Reaction:**  
   - The species interact according to feed (`f`) and kill (`k`) rates.  

4. **Boundary conditions:**  
   - Dirichlet on left/right edges (`u(0)=d0`, `u(1)=d1`).  
   - Neumann (zero-flux) on top/bottom edges.  

5. **Time evolution:**  
   - The system evolves over time using an **implicit solver** for numerical stability.  
   - Iterations continue until the pattern stabilizes or `maxt` is reached.  

---

## What it looks like

<img width="1047" height="568" alt="turingpattern" src="https://github.com/user-attachments/assets/059a5988-2b37-4eab-af2d-1f929608162c" />

