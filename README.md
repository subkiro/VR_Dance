# VR_Dance


Virtual Reality Interactive Dance Tutorial
This project implements a Virtual Reality (VR) Multitracking interaction with 3D characters resulting in an immersive dance training application using the Occulus Rift HMD system and the Leap Motion hand tracking controller. The player, who is placed in the main scene, is trained by the 3D laser scanned human character in a virtual environment which is designed and developed in Unity3D. Realistic animations were applied to the character using a complex Inverse Kinematics (IK) system applied to the rigged 3D human model. Characters are rigged with custom skeletons using 3D geometrical bones and IK solvers. Motion capture data were re-targetted so that animations of the 3D character are produced. The motion capture data, derived from the tracking device Kinect v2, were applied to the rigged 3D model to create realistic dance animations. Rendering optimization techniques such as Baked GI, were applied in the scene to reduce the GPU's rendering load and to increase the frame rate per second (FPS) of the VR application. The training process starts with the first option named "Basic Steps" of the Salsa Latin dance which includes the "Basic A", the "Side Steps" and the "Right Turn" dance routine. By selecting the "Interaction" option, the users can practice dance by leading the 3D model to execute the "Side Steps" and the "Turn" animation. Finally, the users can select the last "Dance" option, where they can improvise and dance, leading the 3D character while they execute the basic steps they have learned. This procedure allows the users to practice their actions by interacting with User Interface panels using gestures such as thumb and waving hands, combining touches and pinch actions. 

Needed devices:

Oculus rift
Leapmotion (Orion)
