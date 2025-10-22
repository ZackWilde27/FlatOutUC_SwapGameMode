# FlatOut: Ultimate Carnage Swap Game Mode

I've started to port my mods over to UC, I thought this would be a fun one to start with

Every 30 seconds, everybody switches cars

You can change how often the switch occurs, whether everybody switches in-place or teleports to their new car, and more in the settings

<br>

## Building

I used Visual Studio on Windows, you'll need the [FlatOutUC SDK](https://github.com/ZackWilde27/FlatOutUC_SDK)

<br>

## Using
Modding Ultimate Carnage is a bit more complicated, since you can't launch it through reloaded, and xlive will get in your way.

<br>

First, get rid of xlive, either through [Xliveless](https://community.pcgamingwiki.com/files/file/576-xliveless/), the [Chloe Collection Mod](https://gaycoderprincess.github.io/project/chloe-collection), or using the Collector's Edition on steam, any of those will do

<br>

Then, in reloaded add `fouc.exe` and add your mod(s)

If you installed the Chloe Collection, you can launch it through reloaded just fine, though you will get a bunch of Fossilize warnings printed to the console, you can ignore those.

Otherwise you'll have go to `Edit Application`, scroll down and click on `Advanced Tools & Options`, and then enable `Auto-Inject`

From there you can now launch the game through steam and the mods will load when the game starts running
