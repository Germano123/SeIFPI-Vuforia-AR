# SeIFPI-Vuforia-AR

###### This repository should be a foundation for students who participated in the sifk and unity3d vuforia augmented reality workshop at SeIFPI VI

**To get this working into your machine, you should have Unity installed, with Vuforia module.
In order to help you:**

1. Install Unity hub;
2. Install a LTS version with Vuforia module;
3. Create your account at [Vuforia](https://developer.vuforia.com/);
4. Log in and create a new license key;
5. Open a new Unity project and click in Edit > Project Settings > Player and select Vuforia augmented reality in PC XR Options (just for tests with a webcam) and Android/Ios XR Options;
6. Create a new object "Ar Camera" and import Vuforia into your project;
7. Click in the button in your AR Camera component "Open Vuforia Engine Configuration" and paste your license;
8. Get back in Vuforia website and create a new image database and download it (if you choose device option, which I recomend for begginers);
9. Import your image database into Unity;
10. Create a new Vuforia Image, set your image in the component with your database and your image;
11. Create a new model child of the image and then run.

## **Congratulations**

###### If you got here, you're amazing. Try something new, such as rotating the object. Then try something more difficult, such as rotating the object only when the target is detected (yes, your Unity update function will run all the time because your object is only 'disabled' for viewing but still exists in the scene)