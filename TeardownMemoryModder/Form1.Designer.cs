namespace TeardownMemoryModder
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.savedCords = new System.Windows.Forms.Label();
            this.curCords = new System.Windows.Forms.Label();
            this.updateCurrentPositions = new System.Windows.Forms.Timer(this.components);
            this.btnRemoveBoundaries = new System.Windows.Forms.Button();
            this.cbStronk = new System.Windows.Forms.CheckBox();
            this.lblphealthspeed = new System.Windows.Forms.Label();
            this.nudHealthSpeed = new System.Windows.Forms.NumericUpDown();
            this.setColour = new System.Windows.Forms.ColorDialog();
            this.dbgTxt = new System.Windows.Forms.TextBox();
            this.keyHandler = new System.Windows.Forms.Timer(this.components);
            this.gbReapply = new System.Windows.Forms.GroupBox();
            this.btnReapply = new System.Windows.Forms.Button();
            this.gbStep = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.nudStepHeight = new System.Windows.Forms.NumericUpDown();
            this.cbStepPatch = new System.Windows.Forms.CheckBox();
            this.gbBoundaries = new System.Windows.Forms.GroupBox();
            this.tc = new System.Windows.Forms.TabControl();
            this.tpTeleport = new System.Windows.Forms.TabPage();
            this.label2 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.tpImmortal = new System.Windows.Forms.TabPage();
            this.tpSpeed = new System.Windows.Forms.TabPage();
            this.label3 = new System.Windows.Forms.Label();
            this.nudSpeed = new System.Windows.Forms.NumericUpDown();
            this.cbSpeed = new System.Windows.Forms.CheckBox();
            this.tpMovement = new System.Windows.Forms.TabPage();
            this.label4 = new System.Windows.Forms.Label();
            this.rbNoMovementMod = new System.Windows.Forms.RadioButton();
            this.rbFlight = new System.Windows.Forms.RadioButton();
            this.rbJetpack = new System.Windows.Forms.RadioButton();
            this.tpMisc = new System.Windows.Forms.TabPage();
            this.label5 = new System.Windows.Forms.Label();
            this.tpDebug = new System.Windows.Forms.TabPage();
            ((System.ComponentModel.ISupportInitialize)(this.nudHealthSpeed)).BeginInit();
            this.gbReapply.SuspendLayout();
            this.gbStep.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudStepHeight)).BeginInit();
            this.gbBoundaries.SuspendLayout();
            this.tc.SuspendLayout();
            this.tpTeleport.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.tpImmortal.SuspendLayout();
            this.tpSpeed.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudSpeed)).BeginInit();
            this.tpMovement.SuspendLayout();
            this.tpMisc.SuspendLayout();
            this.tpDebug.SuspendLayout();
            this.SuspendLayout();
            // 
            // savedCords
            // 
            this.savedCords.AutoSize = true;
            this.savedCords.Font = new System.Drawing.Font("Lucida Console", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.savedCords.Location = new System.Drawing.Point(3, 4);
            this.savedCords.Name = "savedCords";
            this.savedCords.Size = new System.Drawing.Size(236, 11);
            this.savedCords.TabIndex = 2;
            this.savedCords.Text = "  Saved: 00.000 | 00.000 | 00.000";
            // 
            // curCords
            // 
            this.curCords.AutoSize = true;
            this.curCords.Font = new System.Drawing.Font("Lucida Console", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.curCords.Location = new System.Drawing.Point(3, 4);
            this.curCords.Name = "curCords";
            this.curCords.Size = new System.Drawing.Size(236, 11);
            this.curCords.TabIndex = 1;
            this.curCords.Text = "Current: 00.000 | 00.000 | 00.000";
            // 
            // updateCurrentPositions
            // 
            this.updateCurrentPositions.Interval = 50;
            this.updateCurrentPositions.Tick += new System.EventHandler(this.updateCurrentPositions_Tick);
            // 
            // btnRemoveBoundaries
            // 
            this.btnRemoveBoundaries.Location = new System.Drawing.Point(6, 17);
            this.btnRemoveBoundaries.Name = "btnRemoveBoundaries";
            this.btnRemoveBoundaries.Size = new System.Drawing.Size(144, 40);
            this.btnRemoveBoundaries.TabIndex = 3;
            this.btnRemoveBoundaries.Text = "Remove boundaries";
            this.btnRemoveBoundaries.UseVisualStyleBackColor = true;
            this.btnRemoveBoundaries.Click += new System.EventHandler(this.btnRemoveBoundaries_Click);
            // 
            // cbStronk
            // 
            this.cbStronk.AutoSize = true;
            this.cbStronk.Location = new System.Drawing.Point(5, 3);
            this.cbStronk.Name = "cbStronk";
            this.cbStronk.Size = new System.Drawing.Size(80, 15);
            this.cbStronk.TabIndex = 2;
            this.cbStronk.Text = "Immortal";
            this.cbStronk.UseVisualStyleBackColor = true;
            this.cbStronk.CheckedChanged += new System.EventHandler(this.cbStronk_CheckedChanged);
            // 
            // lblphealthspeed
            // 
            this.lblphealthspeed.AutoSize = true;
            this.lblphealthspeed.Location = new System.Drawing.Point(3, 21);
            this.lblphealthspeed.Name = "lblphealthspeed";
            this.lblphealthspeed.Size = new System.Drawing.Size(103, 11);
            this.lblphealthspeed.TabIndex = 5;
            this.lblphealthspeed.Text = "Player health:";
            // 
            // nudHealthSpeed
            // 
            this.nudHealthSpeed.Enabled = false;
            this.nudHealthSpeed.Location = new System.Drawing.Point(112, 19);
            this.nudHealthSpeed.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudHealthSpeed.Name = "nudHealthSpeed";
            this.nudHealthSpeed.Size = new System.Drawing.Size(78, 18);
            this.nudHealthSpeed.TabIndex = 4;
            this.nudHealthSpeed.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudHealthSpeed.ValueChanged += new System.EventHandler(this.nudHealthSpeed_ValueChanged);
            // 
            // dbgTxt
            // 
            this.dbgTxt.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.dbgTxt.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.dbgTxt.Location = new System.Drawing.Point(6, 6);
            this.dbgTxt.Multiline = true;
            this.dbgTxt.Name = "dbgTxt";
            this.dbgTxt.Size = new System.Drawing.Size(481, 146);
            this.dbgTxt.TabIndex = 0;
            // 
            // keyHandler
            // 
            this.keyHandler.Interval = 30;
            // 
            // gbReapply
            // 
            this.gbReapply.Controls.Add(this.btnReapply);
            this.gbReapply.Font = new System.Drawing.Font("Lucida Console", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbReapply.Location = new System.Drawing.Point(12, 203);
            this.gbReapply.Name = "gbReapply";
            this.gbReapply.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.gbReapply.Size = new System.Drawing.Size(501, 59);
            this.gbReapply.TabIndex = 5;
            this.gbReapply.TabStop = false;
            this.gbReapply.Text = "Patch";
            // 
            // btnReapply
            // 
            this.btnReapply.Location = new System.Drawing.Point(9, 17);
            this.btnReapply.Name = "btnReapply";
            this.btnReapply.Size = new System.Drawing.Size(482, 30);
            this.btnReapply.TabIndex = 0;
            this.btnReapply.Text = "Re-apply patches";
            this.btnReapply.UseVisualStyleBackColor = true;
            this.btnReapply.Click += new System.EventHandler(this.btnReapply_Click);
            // 
            // gbStep
            // 
            this.gbStep.Controls.Add(this.label1);
            this.gbStep.Controls.Add(this.nudStepHeight);
            this.gbStep.Controls.Add(this.cbStepPatch);
            this.gbStep.Location = new System.Drawing.Point(169, 6);
            this.gbStep.Name = "gbStep";
            this.gbStep.Size = new System.Drawing.Size(157, 67);
            this.gbStep.TabIndex = 7;
            this.gbStep.TabStop = false;
            this.gbStep.Text = "Step";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(54, 11);
            this.label1.TabIndex = 7;
            this.label1.Text = "Height:";
            // 
            // nudStepHeight
            // 
            this.nudStepHeight.Enabled = false;
            this.nudStepHeight.Location = new System.Drawing.Point(66, 39);
            this.nudStepHeight.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudStepHeight.Name = "nudStepHeight";
            this.nudStepHeight.Size = new System.Drawing.Size(78, 18);
            this.nudStepHeight.TabIndex = 6;
            this.nudStepHeight.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudStepHeight.ValueChanged += new System.EventHandler(this.nudStepHeight_ValueChanged);
            // 
            // cbStepPatch
            // 
            this.cbStepPatch.AutoSize = true;
            this.cbStepPatch.Location = new System.Drawing.Point(8, 17);
            this.cbStepPatch.Name = "cbStepPatch";
            this.cbStepPatch.Size = new System.Drawing.Size(94, 15);
            this.cbStepPatch.TabIndex = 0;
            this.cbStepPatch.Text = "Step patch";
            this.cbStepPatch.UseVisualStyleBackColor = true;
            this.cbStepPatch.CheckedChanged += new System.EventHandler(this.cbStepPatch_CheckedChanged);
            // 
            // gbBoundaries
            // 
            this.gbBoundaries.Controls.Add(this.btnRemoveBoundaries);
            this.gbBoundaries.Location = new System.Drawing.Point(6, 6);
            this.gbBoundaries.Name = "gbBoundaries";
            this.gbBoundaries.Size = new System.Drawing.Size(157, 67);
            this.gbBoundaries.TabIndex = 8;
            this.gbBoundaries.TabStop = false;
            this.gbBoundaries.Text = "Boundaries";
            // 
            // tc
            // 
            this.tc.Controls.Add(this.tpTeleport);
            this.tc.Controls.Add(this.tpImmortal);
            this.tc.Controls.Add(this.tpSpeed);
            this.tc.Controls.Add(this.tpMovement);
            this.tc.Controls.Add(this.tpMisc);
            this.tc.Controls.Add(this.tpDebug);
            this.tc.Enabled = false;
            this.tc.Location = new System.Drawing.Point(12, 12);
            this.tc.Name = "tc";
            this.tc.SelectedIndex = 0;
            this.tc.Size = new System.Drawing.Size(501, 185);
            this.tc.TabIndex = 9;
            // 
            // tpTeleport
            // 
            this.tpTeleport.Controls.Add(this.label2);
            this.tpTeleport.Controls.Add(this.panel2);
            this.tpTeleport.Controls.Add(this.panel1);
            this.tpTeleport.Location = new System.Drawing.Point(4, 21);
            this.tpTeleport.Name = "tpTeleport";
            this.tpTeleport.Padding = new System.Windows.Forms.Padding(3);
            this.tpTeleport.Size = new System.Drawing.Size(493, 160);
            this.tpTeleport.TabIndex = 0;
            this.tpTeleport.Text = "Teleport";
            this.tpTeleport.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 59);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(222, 22);
            this.label2.TabIndex = 10;
            this.label2.Text = "Save a position by pressing [I]\r\n Teleport there by pressing [K]\r\n";
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.savedCords);
            this.panel2.Location = new System.Drawing.Point(6, 33);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(481, 21);
            this.panel2.TabIndex = 12;
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.curCords);
            this.panel1.Location = new System.Drawing.Point(6, 6);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(481, 21);
            this.panel1.TabIndex = 10;
            // 
            // tpImmortal
            // 
            this.tpImmortal.Controls.Add(this.lblphealthspeed);
            this.tpImmortal.Controls.Add(this.nudHealthSpeed);
            this.tpImmortal.Controls.Add(this.cbStronk);
            this.tpImmortal.Location = new System.Drawing.Point(4, 21);
            this.tpImmortal.Name = "tpImmortal";
            this.tpImmortal.Size = new System.Drawing.Size(493, 160);
            this.tpImmortal.TabIndex = 4;
            this.tpImmortal.Text = "Godmode";
            this.tpImmortal.UseVisualStyleBackColor = true;
            // 
            // tpSpeed
            // 
            this.tpSpeed.Controls.Add(this.label3);
            this.tpSpeed.Controls.Add(this.nudSpeed);
            this.tpSpeed.Controls.Add(this.cbSpeed);
            this.tpSpeed.Location = new System.Drawing.Point(4, 21);
            this.tpSpeed.Name = "tpSpeed";
            this.tpSpeed.Size = new System.Drawing.Size(493, 160);
            this.tpSpeed.TabIndex = 5;
            this.tpSpeed.Text = "Speed";
            this.tpSpeed.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(3, 21);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(96, 11);
            this.label3.TabIndex = 7;
            this.label3.Text = "Player speed:";
            // 
            // nudSpeed
            // 
            this.nudSpeed.Enabled = false;
            this.nudSpeed.Location = new System.Drawing.Point(112, 19);
            this.nudSpeed.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudSpeed.Name = "nudSpeed";
            this.nudSpeed.Size = new System.Drawing.Size(78, 18);
            this.nudSpeed.TabIndex = 6;
            this.nudSpeed.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudSpeed.ValueChanged += new System.EventHandler(this.nudSpeed_ValueChanged);
            // 
            // cbSpeed
            // 
            this.cbSpeed.AutoSize = true;
            this.cbSpeed.Location = new System.Drawing.Point(5, 3);
            this.cbSpeed.Name = "cbSpeed";
            this.cbSpeed.Size = new System.Drawing.Size(59, 15);
            this.cbSpeed.TabIndex = 3;
            this.cbSpeed.Text = "Speed";
            this.cbSpeed.UseVisualStyleBackColor = true;
            this.cbSpeed.CheckedChanged += new System.EventHandler(this.cbSpeed_CheckedChanged);
            // 
            // tpMovement
            // 
            this.tpMovement.Controls.Add(this.label4);
            this.tpMovement.Controls.Add(this.rbNoMovementMod);
            this.tpMovement.Controls.Add(this.rbFlight);
            this.tpMovement.Controls.Add(this.rbJetpack);
            this.tpMovement.Location = new System.Drawing.Point(4, 21);
            this.tpMovement.Name = "tpMovement";
            this.tpMovement.Padding = new System.Windows.Forms.Padding(3);
            this.tpMovement.Size = new System.Drawing.Size(493, 160);
            this.tpMovement.TabIndex = 1;
            this.tpMovement.Text = "Movement";
            this.tpMovement.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(83, 8);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(404, 77);
            this.label4.TabIndex = 12;
            this.label4.Text = "Normal: no movement mods\r\n\r\nJetpack: Hold space to fly upwards, gravity still app" +
    "lies\r\n\r\nFlight: normal flight, no gravity.\r\n\r\nPress [F1] to switch to normal fli" +
    "ght";
            // 
            // rbNoMovementMod
            // 
            this.rbNoMovementMod.AutoSize = true;
            this.rbNoMovementMod.Checked = true;
            this.rbNoMovementMod.Location = new System.Drawing.Point(8, 8);
            this.rbNoMovementMod.Name = "rbNoMovementMod";
            this.rbNoMovementMod.Size = new System.Drawing.Size(65, 15);
            this.rbNoMovementMod.TabIndex = 11;
            this.rbNoMovementMod.TabStop = true;
            this.rbNoMovementMod.Text = "Normal";
            this.rbNoMovementMod.UseVisualStyleBackColor = true;
            this.rbNoMovementMod.CheckedChanged += new System.EventHandler(this.rbNoMovementMod_CheckedChanged);
            // 
            // rbFlight
            // 
            this.rbFlight.AutoSize = true;
            this.rbFlight.Location = new System.Drawing.Point(8, 50);
            this.rbFlight.Name = "rbFlight";
            this.rbFlight.Size = new System.Drawing.Size(65, 15);
            this.rbFlight.TabIndex = 10;
            this.rbFlight.TabStop = true;
            this.rbFlight.Text = "Flight";
            this.rbFlight.UseVisualStyleBackColor = true;
            // 
            // rbJetpack
            // 
            this.rbJetpack.AutoSize = true;
            this.rbJetpack.Location = new System.Drawing.Point(8, 29);
            this.rbJetpack.Name = "rbJetpack";
            this.rbJetpack.Size = new System.Drawing.Size(72, 15);
            this.rbJetpack.TabIndex = 10;
            this.rbJetpack.TabStop = true;
            this.rbJetpack.Text = "Jetpack";
            this.rbJetpack.UseVisualStyleBackColor = true;
            this.rbJetpack.CheckedChanged += new System.EventHandler(this.rbJetpack_CheckedChanged);
            // 
            // tpMisc
            // 
            this.tpMisc.Controls.Add(this.label5);
            this.tpMisc.Controls.Add(this.gbBoundaries);
            this.tpMisc.Controls.Add(this.gbStep);
            this.tpMisc.Location = new System.Drawing.Point(4, 21);
            this.tpMisc.Name = "tpMisc";
            this.tpMisc.Padding = new System.Windows.Forms.Padding(3);
            this.tpMisc.Size = new System.Drawing.Size(493, 160);
            this.tpMisc.TabIndex = 2;
            this.tpMisc.Text = "Misc";
            this.tpMisc.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 76);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(446, 33);
            this.label5.TabIndex = 10;
            this.label5.Text = "Remove boundaries: Remove the blue walls at the edge of the map\r\n\r\nStep: higher v" +
    "alues allow for the player to climb higher ledges";
            // 
            // tpDebug
            // 
            this.tpDebug.Controls.Add(this.dbgTxt);
            this.tpDebug.Location = new System.Drawing.Point(4, 21);
            this.tpDebug.Name = "tpDebug";
            this.tpDebug.Padding = new System.Windows.Forms.Padding(3);
            this.tpDebug.Size = new System.Drawing.Size(493, 160);
            this.tpDebug.TabIndex = 3;
            this.tpDebug.Text = "Debug";
            this.tpDebug.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 11F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(521, 273);
            this.Controls.Add(this.tc);
            this.Controls.Add(this.gbReapply);
            this.Font = new System.Drawing.Font("Lucida Console", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Form1";
            this.Text = "Teardown diddler";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.nudHealthSpeed)).EndInit();
            this.gbReapply.ResumeLayout(false);
            this.gbStep.ResumeLayout(false);
            this.gbStep.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudStepHeight)).EndInit();
            this.gbBoundaries.ResumeLayout(false);
            this.tc.ResumeLayout(false);
            this.tpTeleport.ResumeLayout(false);
            this.tpTeleport.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.tpImmortal.ResumeLayout(false);
            this.tpImmortal.PerformLayout();
            this.tpSpeed.ResumeLayout(false);
            this.tpSpeed.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudSpeed)).EndInit();
            this.tpMovement.ResumeLayout(false);
            this.tpMovement.PerformLayout();
            this.tpMisc.ResumeLayout(false);
            this.tpMisc.PerformLayout();
            this.tpDebug.ResumeLayout(false);
            this.tpDebug.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label savedCords;
        private System.Windows.Forms.Timer updateCurrentPositions;
        private System.Windows.Forms.ColorDialog setColour;
        private System.Windows.Forms.CheckBox cbStronk;
        private System.Windows.Forms.Button btnRemoveBoundaries;
        private System.Windows.Forms.Timer keyHandler;
        private System.Windows.Forms.Label curCords;
        private System.Windows.Forms.Label lblphealthspeed;
        private System.Windows.Forms.NumericUpDown nudHealthSpeed;
        private System.Windows.Forms.GroupBox gbReapply;
        private System.Windows.Forms.Button btnReapply;
        private System.Windows.Forms.GroupBox gbStep;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown nudStepHeight;
        private System.Windows.Forms.CheckBox cbStepPatch;
        private System.Windows.Forms.TextBox dbgTxt;
        private System.Windows.Forms.GroupBox gbBoundaries;
        private System.Windows.Forms.TabControl tc;
        private System.Windows.Forms.TabPage tpTeleport;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TabPage tpImmortal;
        private System.Windows.Forms.TabPage tpMovement;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.RadioButton rbNoMovementMod;
        private System.Windows.Forms.RadioButton rbFlight;
        private System.Windows.Forms.RadioButton rbJetpack;
        private System.Windows.Forms.TabPage tpMisc;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TabPage tpDebug;
        private System.Windows.Forms.TabPage tpSpeed;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown nudSpeed;
        private System.Windows.Forms.CheckBox cbSpeed;
    }
}

