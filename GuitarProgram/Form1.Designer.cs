namespace GuitarProgram
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.pictureBoxFretboard = new System.Windows.Forms.PictureBox();
            this.pictureBoxHE = new System.Windows.Forms.PictureBox();
            this.pictureBoxH = new System.Windows.Forms.PictureBox();
            this.pictureBoxG = new System.Windows.Forms.PictureBox();
            this.pictureBoxD = new System.Windows.Forms.PictureBox();
            this.pictureBoxA = new System.Windows.Forms.PictureBox();
            this.pictureBoxLE = new System.Windows.Forms.PictureBox();
            this.comboBoxRootNote = new System.Windows.Forms.ComboBox();
            this.comboBoxChordType = new System.Windows.Forms.ComboBox();
            this.buttonPlayDisplayedChord = new System.Windows.Forms.Button();
            this.buttonChangeChordShape = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxFretboard)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxHE)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxH)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxG)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxD)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxA)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLE)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBoxFretboard
            // 
            this.pictureBoxFretboard.BackgroundImage = global::GuitarProgram.Properties.Resources.Guitar_Fretboard_Blank_Color_Coded_Ai_Graphic;
            this.pictureBoxFretboard.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBoxFretboard.Location = new System.Drawing.Point(12, 472);
            this.pictureBoxFretboard.Name = "pictureBoxFretboard";
            this.pictureBoxFretboard.Size = new System.Drawing.Size(1150, 355);
            this.pictureBoxFretboard.TabIndex = 0;
            this.pictureBoxFretboard.TabStop = false;
            // 
            // pictureBoxHE
            // 
            this.pictureBoxHE.Image = global::GuitarProgram.Properties.Resources.index;
            this.pictureBoxHE.Location = new System.Drawing.Point(50, 558);
            this.pictureBoxHE.Name = "pictureBoxHE";
            this.pictureBoxHE.Size = new System.Drawing.Size(27, 27);
            this.pictureBoxHE.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxHE.TabIndex = 1;
            this.pictureBoxHE.TabStop = false;
            // 
            // pictureBoxH
            // 
            this.pictureBoxH.Image = global::GuitarProgram.Properties.Resources.index;
            this.pictureBoxH.Location = new System.Drawing.Point(50, 591);
            this.pictureBoxH.Name = "pictureBoxH";
            this.pictureBoxH.Size = new System.Drawing.Size(27, 27);
            this.pictureBoxH.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxH.TabIndex = 2;
            this.pictureBoxH.TabStop = false;
            // 
            // pictureBoxG
            // 
            this.pictureBoxG.Image = global::GuitarProgram.Properties.Resources.index;
            this.pictureBoxG.Location = new System.Drawing.Point(50, 636);
            this.pictureBoxG.Name = "pictureBoxG";
            this.pictureBoxG.Size = new System.Drawing.Size(27, 27);
            this.pictureBoxG.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxG.TabIndex = 3;
            this.pictureBoxG.TabStop = false;
            // 
            // pictureBoxD
            // 
            this.pictureBoxD.Image = global::GuitarProgram.Properties.Resources.index;
            this.pictureBoxD.Location = new System.Drawing.Point(50, 669);
            this.pictureBoxD.Name = "pictureBoxD";
            this.pictureBoxD.Size = new System.Drawing.Size(27, 27);
            this.pictureBoxD.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxD.TabIndex = 4;
            this.pictureBoxD.TabStop = false;
            // 
            // pictureBoxA
            // 
            this.pictureBoxA.Image = global::GuitarProgram.Properties.Resources.index;
            this.pictureBoxA.Location = new System.Drawing.Point(50, 711);
            this.pictureBoxA.Name = "pictureBoxA";
            this.pictureBoxA.Size = new System.Drawing.Size(27, 27);
            this.pictureBoxA.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxA.TabIndex = 5;
            this.pictureBoxA.TabStop = false;
            // 
            // pictureBoxLE
            // 
            this.pictureBoxLE.Image = global::GuitarProgram.Properties.Resources.index;
            this.pictureBoxLE.Location = new System.Drawing.Point(50, 744);
            this.pictureBoxLE.Name = "pictureBoxLE";
            this.pictureBoxLE.Size = new System.Drawing.Size(27, 27);
            this.pictureBoxLE.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxLE.TabIndex = 6;
            this.pictureBoxLE.TabStop = false;
            // 
            // comboBoxRootNote
            // 
            this.comboBoxRootNote.FormattingEnabled = true;
            this.comboBoxRootNote.Items.AddRange(new object[] {
            "C",
            "C#",
            "D",
            "D#",
            "E",
            "F",
            "F#",
            "G",
            "G#",
            "A",
            "A#",
            "H"});
            this.comboBoxRootNote.Location = new System.Drawing.Point(12, 55);
            this.comboBoxRootNote.Name = "comboBoxRootNote";
            this.comboBoxRootNote.Size = new System.Drawing.Size(129, 28);
            this.comboBoxRootNote.TabIndex = 7;
            this.comboBoxRootNote.SelectedIndexChanged += new System.EventHandler(this.comboBoxRootNote_SelectedIndexChanged);
            // 
            // comboBoxChordType
            // 
            this.comboBoxChordType.FormattingEnabled = true;
            this.comboBoxChordType.Items.AddRange(new object[] {
            "dur",
            "moll"});
            this.comboBoxChordType.Location = new System.Drawing.Point(147, 55);
            this.comboBoxChordType.Name = "comboBoxChordType";
            this.comboBoxChordType.Size = new System.Drawing.Size(129, 28);
            this.comboBoxChordType.TabIndex = 8;
            this.comboBoxChordType.SelectedIndexChanged += new System.EventHandler(this.comboBoxChordType_SelectedIndexChanged);
            // 
            // buttonPlayDisplayedChord
            // 
            this.buttonPlayDisplayedChord.Enabled = false;
            this.buttonPlayDisplayedChord.Location = new System.Drawing.Point(12, 89);
            this.buttonPlayDisplayedChord.Name = "buttonPlayDisplayedChord";
            this.buttonPlayDisplayedChord.Size = new System.Drawing.Size(264, 78);
            this.buttonPlayDisplayedChord.TabIndex = 9;
            this.buttonPlayDisplayedChord.Text = "Play";
            this.buttonPlayDisplayedChord.UseVisualStyleBackColor = true;
            this.buttonPlayDisplayedChord.Click += new System.EventHandler(this.buttonPlayDisplayedChord_Click);
            // 
            // buttonChangeChordShape
            // 
            this.buttonChangeChordShape.Enabled = false;
            this.buttonChangeChordShape.Location = new System.Drawing.Point(12, 173);
            this.buttonChangeChordShape.Name = "buttonChangeChordShape";
            this.buttonChangeChordShape.Size = new System.Drawing.Size(264, 78);
            this.buttonChangeChordShape.TabIndex = 10;
            this.buttonChangeChordShape.Text = "Change chord shape";
            this.buttonChangeChordShape.UseVisualStyleBackColor = true;
            this.buttonChangeChordShape.Click += new System.EventHandler(this.buttonChangeChordShape_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1176, 839);
            this.Controls.Add(this.buttonChangeChordShape);
            this.Controls.Add(this.buttonPlayDisplayedChord);
            this.Controls.Add(this.comboBoxChordType);
            this.Controls.Add(this.comboBoxRootNote);
            this.Controls.Add(this.pictureBoxLE);
            this.Controls.Add(this.pictureBoxA);
            this.Controls.Add(this.pictureBoxD);
            this.Controls.Add(this.pictureBoxG);
            this.Controls.Add(this.pictureBoxH);
            this.Controls.Add(this.pictureBoxHE);
            this.Controls.Add(this.pictureBoxFretboard);
            this.Name = "Form1";
            this.Text = "Form1";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxFretboard)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxHE)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxH)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxG)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxD)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxA)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLE)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private PictureBox pictureBoxFretboard;
        private PictureBox pictureBoxHE;
        private PictureBox pictureBoxH;
        private PictureBox pictureBoxG;
        private PictureBox pictureBoxD;
        private PictureBox pictureBoxA;
        private PictureBox pictureBoxLE;
        private ComboBox comboBoxRootNote;
        private ComboBox comboBoxChordType;
        private Button buttonPlayDisplayedChord;
        private Button buttonChangeChordShape;
    }
}