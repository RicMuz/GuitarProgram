# Guitar program

### Assignment

The program should be able to graphically display and play chords on the guitar. It will have a user-friendly environment. It will also be possible to line up chords one after the other or load them from a MuseScore file and play them on a loop. When playing a loop, the chords will be displayed graphically as well as audibly.

### Algorithm

##### Visual representation

For visual representation I decided for simply having 7 picture boxes: fretboard and six dots for each string. When the chord changes numbers of the frets are given and picture boxes with the points move to correct positions.

__Rejected__: drawing the points (would do the same, but more complicated)

##### Audio 

For audio I decided to use midi. The biggest advantage of using midi is simple manipulation and easy change of sound. Quality of sound does not depent on the program, but on midi synth.

__Rejected__: recording own sounds and using player (the program would depend fully on given sounds bank, less flexible)

##### File loading

Used defaut XML file reader and switches.

##### Loop player

Because there is a lot of waiting, it was necessary to use threading (for not losing control over the program). Simple while cyclus that gives next chord in the loop.

### Program

See map

### Adding chord shape

List where changes must be done:

1. MusicStructures.cs => ChordTypes => add enum
2. Guitar.cs => constructor => add shape
3. FileLoader.cs => according to file formatting (may change more things) => getChordType function
4. LoopPlayer.cs => getChordType function