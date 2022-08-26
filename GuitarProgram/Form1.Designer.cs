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
            this.menuStripMenu = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openFileDialogFileInput = new System.Windows.Forms.OpenFileDialog();
            this.richTextBoxLoop = new System.Windows.Forms.RichTextBox();
            this.buttonPlayStopLoop = new System.Windows.Forms.Button();
            this.labelLayout = new System.Windows.Forms.Label();
            this.buttonValidateLoop = new System.Windows.Forms.Button();
            this.buttonResetLoop = new System.Windows.Forms.Button();
            this.comboBoxDuration = new System.Windows.Forms.ComboBox();
            this.buttonAddToLoop = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxFretboard)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxHE)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxH)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxG)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxD)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxA)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLE)).BeginInit();
            this.menuStripMenu.SuspendLayout();
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
            "Cis",
            "D",
            "Dis",
            "E",
            "F",
            "Fis",
            "G",
            "Gis",
            "A",
            "Ais",
            "H"});
            this.comboBoxRootNote.Location = new System.Drawing.Point(12, 31);
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
            this.comboBoxChordType.Location = new System.Drawing.Point(147, 31);
            this.comboBoxChordType.Name = "comboBoxChordType";
            this.comboBoxChordType.Size = new System.Drawing.Size(129, 28);
            this.comboBoxChordType.TabIndex = 8;
            this.comboBoxChordType.SelectedIndexChanged += new System.EventHandler(this.comboBoxChordType_SelectedIndexChanged);
            // 
            // buttonPlayDisplayedChord
            // 
            this.buttonPlayDisplayedChord.Enabled = false;
            this.buttonPlayDisplayedChord.Location = new System.Drawing.Point(12, 99);
            this.buttonPlayDisplayedChord.Name = "buttonPlayDisplayedChord";
            this.buttonPlayDisplayedChord.Size = new System.Drawing.Size(264, 78);
            this.buttonPlayDisplayedChord.TabIndex = 9;
            this.buttonPlayDisplayedChord.Text = "Play selected chord";
            this.buttonPlayDisplayedChord.UseVisualStyleBackColor = true;
            this.buttonPlayDisplayedChord.Click += new System.EventHandler(this.buttonPlayDisplayedChord_Click);
            // 
            // buttonChangeChordShape
            // 
            this.buttonChangeChordShape.Enabled = false;
            this.buttonChangeChordShape.Location = new System.Drawing.Point(12, 183);
            this.buttonChangeChordShape.Name = "buttonChangeChordShape";
            this.buttonChangeChordShape.Size = new System.Drawing.Size(264, 78);
            this.buttonChangeChordShape.TabIndex = 10;
            this.buttonChangeChordShape.Text = "Change chord shape";
            this.buttonChangeChordShape.UseVisualStyleBackColor = true;
            this.buttonChangeChordShape.Click += new System.EventHandler(this.buttonChangeChordShape_Click);
            // 
            // menuStripMenu
            // 
            this.menuStripMenu.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStripMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem});
            this.menuStripMenu.Location = new System.Drawing.Point(0, 0);
            this.menuStripMenu.Name = "menuStripMenu";
            this.menuStripMenu.Size = new System.Drawing.Size(1176, 28);
            this.menuStripMenu.TabIndex = 11;
            this.menuStripMenu.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.openToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(46, 24);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // openToolStripMenuItem
            // 
            this.openToolStripMenuItem.Name = "openToolStripMenuItem";
            this.openToolStripMenuItem.Size = new System.Drawing.Size(128, 26);
            this.openToolStripMenuItem.Text = "Open";
            this.openToolStripMenuItem.Click += new System.EventHandler(this.openToolStripMenuItem_Click);
            // 
            // openFileDialogFileInput
            // 
            this.openFileDialogFileInput.FileName = "openFileDialog1";
            this.openFileDialogFileInput.Filter = "MuseScore file|*.mscx";
            // 
            // richTextBoxLoop
            // 
            this.richTextBoxLoop.Location = new System.Drawing.Point(282, 65);
            this.richTextBoxLoop.Name = "richTextBoxLoop";
            this.richTextBoxLoop.Size = new System.Drawing.Size(394, 401);
            this.richTextBoxLoop.TabIndex = 12;
            this.richTextBoxLoop.Text = "";
            this.richTextBoxLoop.TextChanged += new System.EventHandler(this.richTextBoxLoop_TextChanged);
            // 
            // buttonPlayStopLoop
            // 
            this.buttonPlayStopLoop.Enabled = false;
            this.buttonPlayStopLoop.Location = new System.Drawing.Point(682, 65);
            this.buttonPlayStopLoop.Name = "buttonPlayStopLoop";
            this.buttonPlayStopLoop.Size = new System.Drawing.Size(264, 78);
            this.buttonPlayStopLoop.TabIndex = 13;
            this.buttonPlayStopLoop.Text = "Play Loop";
            this.buttonPlayStopLoop.UseVisualStyleBackColor = true;
            this.buttonPlayStopLoop.Click += new System.EventHandler(this.buttonPlayStopLoop_Click);
            // 
            // labelLayout
            // 
            this.labelLayout.AutoSize = true;
            this.labelLayout.Location = new System.Drawing.Point(282, 34);
            this.labelLayout.Name = "labelLayout";
            this.labelLayout.Size = new System.Drawing.Size(190, 20);
            this.labelLayout.TabIndex = 14;
            this.labelLayout.Text = "Tones; ChordType; Duration";
            // 
            // buttonValidateLoop
            // 
            this.buttonValidateLoop.Enabled = false;
            this.buttonValidateLoop.Location = new System.Drawing.Point(682, 149);
            this.buttonValidateLoop.Name = "buttonValidateLoop";
            this.buttonValidateLoop.Size = new System.Drawing.Size(264, 78);
            this.buttonValidateLoop.TabIndex = 15;
            this.buttonValidateLoop.Text = "Validate Loop";
            this.buttonValidateLoop.UseVisualStyleBackColor = true;
            this.buttonValidateLoop.Click += new System.EventHandler(this.buttonValidateLoop_Click);
            // 
            // buttonResetLoop
            // 
            this.buttonResetLoop.Enabled = false;
            this.buttonResetLoop.Location = new System.Drawing.Point(682, 233);
            this.buttonResetLoop.Name = "buttonResetLoop";
            this.buttonResetLoop.Size = new System.Drawing.Size(264, 78);
            this.buttonResetLoop.TabIndex = 16;
            this.buttonResetLoop.Text = "Reset loop";
            this.buttonResetLoop.UseVisualStyleBackColor = true;
            this.buttonResetLoop.Click += new System.EventHandler(this.buttonResetLoop_Click);
            // 
            // comboBoxDuration
            // 
            this.comboBoxDuration.FormattingEnabled = true;
            this.comboBoxDuration.Items.AddRange(new object[] {
            "Whole",
            "HalfD",
            "Half",
            "Quarter",
            "QuarterD",
            "EightD",
            "Eight",
            "Sixteenth",
            "SixteenthD"});
            this.comboBoxDuration.Location = new System.Drawing.Point(81, 65);
            this.comboBoxDuration.Name = "comboBoxDuration";
            this.comboBoxDuration.Size = new System.Drawing.Size(129, 28);
            this.comboBoxDuration.TabIndex = 17;
            // 
            // buttonAddToLoop
            // 
            this.buttonAddToLoop.Enabled = false;
            this.buttonAddToLoop.Location = new System.Drawing.Point(12, 267);
            this.buttonAddToLoop.Name = "buttonAddToLoop";
            this.buttonAddToLoop.Size = new System.Drawing.Size(264, 78);
            this.buttonAddToLoop.TabIndex = 18;
            this.buttonAddToLoop.Text = "Adds selected chord to the end of current loop";
            this.buttonAddToLoop.UseVisualStyleBackColor = true;
            this.buttonAddToLoop.Click += new System.EventHandler(this.buttonAddToLoop_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1176, 839);
            this.Controls.Add(this.buttonAddToLoop);
            this.Controls.Add(this.comboBoxDuration);
            this.Controls.Add(this.buttonResetLoop);
            this.Controls.Add(this.buttonValidateLoop);
            this.Controls.Add(this.labelLayout);
            this.Controls.Add(this.buttonPlayStopLoop);
            this.Controls.Add(this.richTextBoxLoop);
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
            this.Controls.Add(this.menuStripMenu);
            this.MainMenuStrip = this.menuStripMenu;
            this.Name = "Form1";
            this.Text = "Guitar program";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxFretboard)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxHE)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxH)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxG)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxD)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxA)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLE)).EndInit();
            this.menuStripMenu.ResumeLayout(false);
            this.menuStripMenu.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

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
        private MenuStrip menuStripMenu;
        private ToolStripMenuItem fileToolStripMenuItem;
        private ToolStripMenuItem openToolStripMenuItem;
        private OpenFileDialog openFileDialogFileInput;
        private RichTextBox richTextBoxLoop;
        private Button buttonPlayStopLoop;
        private Label labelLayout;
        private Button buttonValidateLoop;
        private Button buttonResetLoop;
        private ComboBox comboBoxDuration;
        private Button buttonAddToLoop;
    }
}