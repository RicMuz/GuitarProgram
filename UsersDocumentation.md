# Guitar program

Program offers two modes for users:

- Chord selector mode
- Playback (loop) mode

When the program launches user will notice that most of the buttons are unavialable. That's because program doesn't have enough information yet to use these buttons. The only avialable controls after launch are: two comboboxes, file input button and large textbox. 

#### Chord selector mode

Let's talk about chord selector mode first. To operate this mode there are two comboboxes and two buttons: play chord and change shape. Until the root note and chord type are selected (via comboboxes) buttons will remain unavialable. After selecting desired chord, the shape is created and graphically showed on fretboard. Play button then plays the showed chord. Button change shape will cycle through all shapes for given chord type.


#### Playback (loop) mode

There are two possible inputs to this mode:

1. Via large textbox
2. Via MuseScore file

##### Textbox input

If the input is given via large texxtbox user must follow the given formatting:

- Each chord or dash is on single line
- Line consists of three informations seperated by ;
    - Root note (see combobox)
    - Chord type (see combobox)
    - Duration where possibilities are:
        - Whole
        - Half, HalfD (Half with dot)
        - Eighth, EighthD (Eight with dot)
        - Sixteenth, SixteenthD (Sixteenth with dot)
- If user want insert dash, then root note and chord type must be "none"
- Input isn't case sensitive
- Examples of correct input:
    - C;dur;whole
    - None; none; Eighth 

After every change in textbox program will disable play button and will enable button for control new loop. Pressing this button can have two outputs:

1. There is fatal error in the formmating, hence it must be redone.
2. Program will process input data and reprint them to show how the program interpreted them

If there is no fatal error in the formatting then buttons Play loop and Reset loop will be avialabled.

##### File input

The program can process MuseScore files and only the guitar ones. The file must be uncompressed (.mscx). After succesful load of the file, program will print the content of the file to the textbox and will work with it as with normal user input. Only difference is that there is no need for valiadating the loop after loading and the Play loop and Reset loop buttons will be imidiately avialable.

##### Playing the loaded loop

After loading the loop either way the Play loop button and Reset loop button will be avialabled. Play loop starts playing the loop. While playing all other controls are diabled and Play loop button will become Stop loop button. After stopping it user have to options. Continue (Play loop button again) or reseting the loop to the beginning (Reset loop button) and then play from the beginning (Play button). 