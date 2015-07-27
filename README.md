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

Feel free to contact me with any questions

UPDATE:

Wow, looks like a few people are actually cloning this. Probably should make this readme a bit better.
I think the only thing you need to make sure of if you are trying to run it is that you have all the folders you need. Like I said, you need a bunch of filensync folders, and then it also will look for a config file under C:\Cshow\Extras. If there isn't one there, it will create it, but I don't know what will happen if you don't have a cshow\extras folder.

That's all for now.

You should fork the repo so I can see who you are!
Feel free to contact me with any questions
