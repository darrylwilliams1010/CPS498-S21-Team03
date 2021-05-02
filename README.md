# Laparoscopic Surgical Training System
> ### _CPS498 Senior Design - Spring 2021 - Team 03_

> #### Table Of Contents:
> 1. Introduction  
> 2. Project Video  
> 3. Team Members  
> 4. Prototype Objectives & Functionality  
> 5. UI Snapshots  
> 6. Future Changes  
> 7. Team Contributions  

> #### Intro
   For this project, we were tasked with improving the training modules for the Simbionix LAP Mentor. The existing modules on the LAP Mentor were good for training with their specific system, but because all of the modules used the same model of a human to operate in, there was no diversity in the operating areas. All of the body parts were in the same place and were all the same size, and medical residents practicing with the LAP Mentor regularly could easily get used to where everything was and be unprepared for real patients who would come in all shapes and sizes. 
   
   Due to some difficulties along the way with acquiring the existing modules howerver, we readjusted our goals to instead create our own version of some of the LAP Mentor modules in VR, where they could be more accessible to the public than Simbionix's system. Our team created four modules that could be used to improve on beginner skills like locating an object, removing an object, or precise movement of the camera. Our modules were created in Unity using the Oculus VR integration Package to allow better controller movement. We each worked to create our own custom modules, so each level has its own look and feel to it.
   
   \* At this time, keyboard input is used as an alternative since there are unknown errors with picking up objects in our modules.  Our system consists of four different projects, so instead of uploading them here on GitHub, we uploaded them into a Ondrive folder which can be accessed with permission from a member of our team. 

Click here to view a summary of our work: <a href="https://youtu.be/mgTneG63id8">Project Video</a>

> #### Meet Our Team
|   Team Members    |     Advisors     |
| ----------------- | ---------------- |
| - Darryl Williams | - Dr. Alex Redei |
| - Dylan White     | - Dr. Faiz Tuma  |
| - Grace Kern      |
| - Nathanial Kos   |

> #### Prototype Objectives & Functionality
> Implemented:
Within our project’s prototype, each group member assembled a working module that took a component from the laparoscopic trainer that would be implemented into VR. The goal of the VR is to have the user be fully immersed in each module as they work through each task. Within the first module, we implemented a ball tracker. The main focus of this module is to get the user exposed to using the VR headset, as the user is tasked with tracking a ball using a crosshair displayed in the center of their vision while using the headset. Additionally, if the user does not have access to VR, there are keyboard controls mapped out as well. Within the second module, we implemented an in-game screen to locate objects in an operating zone with a separate camera tracking your tool movements. The goal of this module is to simulate operating on a patient without being able to directly see what you are doing. The in-game screen floats at eye level to the user and then the user manipulates the camera attached to their controller or via keyboard inputs to remove the various objects within the scene. Within the third module, we implemented a target system using the VR hand controllers. The user is given two tools within the module, a camera and a laser pointer. With the camera, the user is able to navigate around a room of obstacles to find various targets. With the laser pointer, the user then clicks on each target, causing the target to be hit and disappear and relocate to a different area within the room. Within the fourth and final module, we created a score and grading system. The user uses a floating display to view the workspace and they again have access to control a camera and a prod. The prod is used to destroy 3 targets located within the scene and the user must manipulate the camera in order to locate each target. While the user carries out this task, they are given points based on the movement of the camera. The more movement results in more points which in turn causes the user to receive a lower score. The reason being that when performing a real operation, unnecessary movement can result in complications that can harm the patient. During this module, the user gets a live feed of their score and grade so as to know how well they are performing in any given moment. 

Not Implemented:
Within our prototype we decided to not implement a few components. First, we decided to not implement a simulation of a real surgery. The reason for this being that the current simulator available in Saginaw already has a selection of realistic simulations within its library. Additionally we changed the focus of our prototype to being an introduction to the current simulation available in Saginaw. Next week decided against implementing a fake operating room environment around each module. The reason for this was that it was unnecessary since these modules were not simulating a real surgery. Finally, we decided against adding a timer to each module. The reason for this is that each module is already relatively short to the point where a timer would clutter the user’s interface with little to no benefit from it.




> #### UI Snapshots



> #### Future Changes



> #### Team Contributions
|   Team Members    |   Contributions (Hours/Work Done)   |
| ----------------- | ----------------- |
| - Darryl Williams |                   |
| - Dylan White     | 120 hours; Removing objects by looking at screen module, wrote code for picking up/releasing object when collider is breached, keyboard input, and camera moveability |
| - Grace Kern      |                   |
| - Nathanial Kos   | 100 hours; Score and grade module, wrote code for tracking movement and then grading that given score,destroying targets when hit by another object with the tag "nib", and keyboard/camera moveability |
