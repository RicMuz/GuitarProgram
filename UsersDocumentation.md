# Guitar program

Program offers two modes for users:

- Chord selector mode
- Playback (loop) mode

When the program launches the user will notice that most of the buttons are unavialable. That's because the program doesn't have enough information yet to use these buttons. The only avialable controls after launch are: two combo boxes, the file input button and a large textbox. 

#### Chord selector mode

Let's talk about the chord selector mode first. To operate this mode there are two combo boxes and two buttons: play chord and change shape. Until the root note and chord type are selected (via combo boxes) the other buttons will remain unavialable. After selecting the desired chord, the shape is created and graphically shown on the digital fretboard. Pressing the Play button will play the displayed chord. The Change shape button will cycle through all shapes for the given chord type.


#### Playback (loop) mode

There are two possible inputs for this mode:

1. Via large textbox
2. Via MuseScore file

##### Textbox input

If the input is given via large textbox, the user must follow the given format:

- Each chord or dash is on a single line
- A line consists of three bits of informations seperated by ;
    - Root note (see combo box)
    - Chord type (see combo box)
    - Duration where possibilities are:
        - Whole
        - Half, HalfD (Half with a dot)
        - Quarter, QuarterD (Quarter with a dot)
        - Eighth, EighthD (Eight with a dot)
        - Sixteenth, SixteenthD (Sixteenth with a dot)
- If the user wants to insert a dash, then the root note and chord type must be "none"
- Input isn't case sensitive
- Examples of correct input:
    - C;dur;whole
    - None; none; Eighth 

After every change in the textbox the program will disable the Play loop button and will enable the Validate loop button. Pressing this button can have two outputs:

1. There is an error in the formmating and the program will send you an error message.
2. The program will process the input data and reprint them to show how the program interpreted them

If there is no error in the formatting then the buttons, Play loop and Reset loop will be available.

##### File input

The program can process MuseScore files, but only the guitar ones. The file must be uncompressed (.mscx). After the file has been loaded successfully, the program will print the content of the file in the textbox and will work with it as with normal user input. The only difference is that there is no need for valiadating the loop after loading and the Play loop and Reset loop buttons will be immediately available.

##### Playing the loaded loop

After loading the loop the Play loop button and Reset loop button will be available. Play loop starts playing the loop. While playing, all other controls are diabled and the Play loop button will become the Stop loop button. After stopping it the user has two options. Continue (the Play loop button again) or resetting the loop to the beginning (the Reset loop button) and then play from the beginning (the Play button). 