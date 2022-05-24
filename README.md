# Um Jammer Lammy Subtitle Editor
This application is designed to edit subtitles in the UJL game.

**_Only the usa version of the game is supported._**

## How to use:
1. First you need to unpack one of the game files that contains subtitles, for unpacking I recommend using [CDmage](https://www.romhacking.net/utilities/1435/).
2. Next, open the file with subtitles in `ujl_subedit`.
3. After saving the file, it can be imported back into the game image, also with [CDmage](https://www.romhacking.net/utilities/1435/).

## Functions:
1. **symbol converter** converts the symbols `00`(`null` symbol) to `2F`(`/` symbol), `0A`(`line` break symbol) to `23`(`#` symbol).
When saving the file, the reverse conversion will occur.
This function is designed to make it easier to edit the text of subtitles.

2. **Drag-and-Drop** support.
Instead of opening the dialogs of the file selection window, you can simply drop the file on the application window.

## Files that the program supports:
The game has these types of files:
```
COMOD*.FileExpansion
COMOD1*.FileExpansion
```
`*` this symbol indicates the level number, from 0 to 8.

`FileExpansion` the file extension can be - `.MEN` menu file, `.SNG` single mode file, `.COP` co-op mode file, `.CMP` versus mode file.
