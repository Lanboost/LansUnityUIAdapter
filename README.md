# LansUnityUIAdapter
Use Unity uGUI outside of Unity (By implementing the interface required from `UnityEngine` as an Adapter)

This library implements the underhood logic required by the `UnityEngine` API to be able to run the uGUI code outside of Unity. The uGUI
implements layout and event handling logic. This is nice as in smaller games and engines the UI is usually not very sophisticated.

Instead by writing a "small" adapter for the engine's rendering of components one can rely on this framework instead.

It also gives the possability to setup and create your UI directly in the `Unity Editor` and then export and run it in outside.


# !!! LICENSE (use the `interface` on your own risk!)!!!

The `UnityEngineAdapter` are based on the interface (API) provided by `UnityEngine` (WHICH IS UNDER COPYRIGHT). I imply a 
FAIR USE statement as I have only copied the necessary interface to work together with the code provided in `UnityTechnologies-uGUI`.

The interface therefore remains under copyright of `Unity` however the implementation of the interface is under MIT license.

The uGUI code itself is not part of this repository (its linked as a submodule) and it is under the license `Unity Companion License`

https://github.com/Unity-Technologies/uGUI/blob/2019.1/LICENSE


## Support me!

[<img src="https://raw.githubusercontent.com/Lanboost/RandomStuff/master/patreon.png">](https://www.patreon.com/bePatron?u=53447812)