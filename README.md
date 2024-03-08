# Um Jammer Lammy And Parappa The Rapper Subtitle Editor
This application is designed to edit subtitles in the UJL and PTR game.
![editor](/editor.png)
## How to use:
1. First you need to unpack one of the game files that contains subtitles, for unpacking I recommend using [CDmage](https://www.romhacking.net/utilities/1435/).
2. Next, open the file with subtitles in `ujlptr_subedit`.
3. After saving the file, it can be imported back into the game image, also with [CDmage](https://www.romhacking.net/utilities/1435/).

## Functions:
1. **Drag-and-Drop** support.
Instead of opening the dialogs of the file selection window, you can simply drop the file on the application window.
2. Preview of the text. The program has text preview functions with support for fonts from UJL and PTR.
3. The ability to use additional characters. Usually, in level files, each line of the subtitle has unused characters, the editor allows them to be used.
4. Byte conversion function. You can set your own pattern that will be used to replace bytes. By and large, it is only necessary for those who make localization of the game into another language.
Example(The file must have the `.cfg` extension. And also the file should contain the first and last line from the example, so the program understands that this is a pattern file.):
```
##-##input-output
F3-4C
D4-46
F4-E0
D5-EA
###
```

## Files that the program supports:
* ### For Um Jammer Lammy
The game has these types of files:
```
COMOD*.FileExpansion
COMOD1*.FileExpansion
```
`*` this symbol indicates the level number, from 0 to 8.

`FileExpansion` the file extension can be - `.MEN` menu file, `.SNG` single mode file, `.COP` co-op mode file, `.CMP` versus mode file.
* ### For Parappa The Rapper
The game has these types of files:
```
COMOD*.BIN
```
`*` this symbol indicates the level number, from 0 to 9.
