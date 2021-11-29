<img width="767" alt="thumbnail" src="https://user-images.githubusercontent.com/77754518/137814851-3e575c28-6783-4956-ad27-06754e840a0d.PNG">

# CS 428 Project 3

> _This has been tested on version 2019.4.28f1 of the Unity software_


## Introduction

This project builds off of Project 2 where there are 3 different versions:
 - Mego Playset - which shrinks down project 2 and lets the user play with it like a dollhouse
 - Land of the Giants - which makes the user explore a bigger room and climb on different things
 - Dancing on the Ceiling which allows the user to rotate the room 90 degrees at a time
 - There is also a menu that allows the user to hop between different versions
 - This project is a VR game using the components from the VRTK suite within the [Unity] software.

### Downloading the project

* Download this project repository to your local machine using *one* of the following methods:
  * Git clone the repository with `git clone https://github.com/BanhAnna/CS428Project3a`
  * Download the zip file at `https://github.com/BanhAnna/CS428Project3a` and extract it.

### Opening the downloaded project in the Unity software

> **Do not** drag and drop this downloaded tutorial project into an existing Unity project. The downloaded tutorial project **is a Unity project** already and you should not nest a Unity project inside another Unity project. Follow the instructions below for opening this tutorial project within the Unity software.

#### Using the Unity Hub

* Open the [Unity Hub] panel.
* Click the `Add` Button.
* Browse to the local directory where the repository was cloned/downloaded to and click `Select Folder`.

### Running the game scene on PC

* Open the `Assets/Scenes/megoPlayset` scene.
* Make sure CameraRigs.SpatialSimulator enabled and CameraRigs.UnityXR disabled
* Enable `Maximize On Play` in the Unity Game view control bar to ensure no performance issues are caused by the Unity Editor overhead.
* Play the scene in the Unity Editor (`CTRL` + `P`).

### Running the game scene on VR Headset
* Make sure CameraRigs.UnityXR enabled and CameraRigs.SpatialSimulator disabled
* Go to build settings and make sure it's building to android
* Plug in VR headset to laptop and make quest accept laptop connection
* Build and Run


