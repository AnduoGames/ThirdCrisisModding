![Modding](https://github.com/AnduoGames/ThirdCrisisModding/assets/63800758/b342e306-8baf-44da-8b9e-7a829e977a00)

# Third Crisis Modding

Modding Third Crisis works by loading a C# dll into the game at runtime. Through this dll file, you can change anything in the game.

Join our [discord](https://discord.gg/q8V9jKDGmk), we have a dedicated channel for modding! c: 

Requirements for C# modding:
- A bought copy of Third Crisis ([Steam](https://store.steampowered.com/app/1260820/Third_Crisis/) | [Itchio](https://anduogames.itch.io/third-crisis) | [GOG](https://www.gog.com/en/game/third_crisis))
- [Visual Studio 2022](https://visualstudio.microsoft.com/downloads/)
- .net 2.1 installed



# [<b>WIKI with code examples</b>](https://github.com/AnduoGames/ThirdCrisisModding/wiki)



<h2>SETUP</h2>

Clone the repository, open the .sln. You will need to tell Visual Studio where 3 dll files that come with the game are located. These dll files can be found in your game installation Third Crisis\ThirdCrisis_Data\Managed
- Assembly-CSharp.dll
- UnityEngine.CoreModule.dll
- UnityEngine.PhysicsModule.dll

https://github.com/AnduoGames/ThirdCrisisModding/assets/63800758/536e12a7-74fb-48c0-a48a-c780d9f15b61

Once this is done, you can Press F7 to build your mod dll. To find your dll, navigate to your cloned repository and go to 
TCModExample\obj\Debug\netstandard2.1

Now open Third Crisis.
Go into the Game settings and turn on the console. You can now open it by pressing F2. Enter the command modmenu.
Export an empty mod manifest by pressing the button. Save it next to your dll.

https://github.com/AnduoGames/ThirdCrisisModding/assets/63800758/fe478884-1176-431e-8d98-c7d664a8cde2

Next, open your manifest.json and change the PathToDLL to the name of your dll file.
<img width="702" alt="Code_RX8aLHKLHD" src="https://github.com/AnduoGames/ThirdCrisisModding/assets/63800758/ccd0932d-6181-4147-907d-d16b1079195e">

Now, back in Third Crisis, you can open your manifest.json file and your dll file will be loaded by the game!
Happy modding!

https://github.com/AnduoGames/ThirdCrisisModding/assets/63800758/c215214c-16c2-4222-ba5d-c61a05ba2216

Check out the Wiki for more instructions!
[<b>WIKI with code examples</b>](https://github.com/AnduoGames/ThirdCrisisModding/wiki)

Please note the [Prohibited Content](https://github.com/AnduoGames/ThirdCrisisModding/wiki/Prohibited-Content)

Thanks to BlauKitten for the support in making this SDK! ♥
