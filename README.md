# SyncManager
UI for Syncing files from server to clients using FileNSync

Uhh, I doubt this readme will help anyone, because this code is rather specific to the file setup I'm working with. However, Onwards!
SyncForm is the main form, has all the background workers
Basically running one thread for each sync type

The UI should be pretty self explanatory
If it's not, that kinda sucks for you
JK, if there's anything that is misleading or not clear I'll fix it.
Theoretically.

You'll also have to make sure that you have a bunch of filensync exes with their own config file if you want it to pull up the
windows with the correct formatting and in the correct places.
C:\FNSYNC, and then you need subfolders for each sync type (if you look at the code itll be obvious what they should be called)

So, that's it for now.
