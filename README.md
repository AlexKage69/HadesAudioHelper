# Adding new Audio to Hades via VO.fsb
You'll need:
- The visual studio code in this repo to generate a VO.h. (There's also a Renamer to remove VO- from a bunch of Filename)
- Python-fsb5 (To extract original .ogg from VO.fsb) :https://github.com/HearthSim/python-fsb5/releases/tag/b7bf605
- FMOD Bank Tools (To extract .ogg from VO.fsb, extract VO.txt and recompile): https://www.nexusmods.com/rugbyleaguelive3/mods/2?tab=description
- FMOD Studio 2.02.06 (To open the Project):

## Step 1
If you want to start from scratch, you'll need all of the above, so install them.

The first step is to extract the Audio from Hades\Content\Audio\FMOD\Build\Desktop\VO.fsb. Use Python-fsb5 to extract them to "out" folder.
Then you can rename them all since you'll need to remove the prefix "VO-" from each file. You can use your own code or my option in this repo to rename the inside of a folder.
![image](https://user-images.githubusercontent.com/44212358/175919499-82ecc405-8939-4483-aa7d-0e6de9910987.png)

## Step 2
You now have all original audio in .ogg. You'll need to create a new FMOD project and add all of the audio in a subcomponent VO like the image.
![image](https://user-images.githubusercontent.com/44212358/175917569-1950381e-405e-4bc4-af9f-b00ee726c836.png)
![image](https://user-images.githubusercontent.com/44212358/175917542-c8c5928c-03df-483f-a67c-8e3b22b66525.png)

You just need to File\build and you should have a VO.bank.

I wanted to give my FMOD Project already configured, but it's over 2Gb to share.

## Step 3
You now have your VO.bank but you don't have the VO.fsb and VO.h. You'll need FMOD Bank Tools to extract .wav and .fsb from your VO. Once you extracted in subfolder you should have your VO.fsb ready to use.

In this repo you'll find a code to generate VO.h, just change the string to give the right Path to your Vo.txt in you wav folder. It will generate the correct VO.h under FMOD Bank Tools. 
![image](https://user-images.githubusercontent.com/44212358/175919703-b0bd3e07-5dd9-4906-b1ab-94e934ddadd6.png)
![image](https://user-images.githubusercontent.com/44212358/175919755-26827e21-6cda-412f-a120-9917b2a45256.png)

## Step 4
With the VO.fsb and VO.h in hand, you just need to overwrite them in Hades\Content\Audio\FMOD\Build\Desktop. You'll have access to them.

## Step 5
To use them in game, just look for other code use of VoiceOver like: /VO/Dionysus_0055, /VO/CustomAudio_0001

**Note** 
Multiple mod using Audio changer, would need a patch to add them both to the compiled VO.fsb for both Mod to work.
