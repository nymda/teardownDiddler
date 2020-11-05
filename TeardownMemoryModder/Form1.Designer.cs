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
            this.gbPos = new System.Windows.Forms.GroupBox();
            this.savedCords = new System.Windows.Forms.Label();
            this.curCords = new System.Windows.Forms.Label();
            this.updateCurrentPositions = new System.Windows.Forms.Timer(this.components);
            this.gbMisc = new System.Windows.Forms.GroupBox();
            this.lblphealthspeed = new System.Windows.Forms.Label();
            this.nudHealthSpeed = new System.Windows.Forms.NumericUpDown();
            this.btnRemoveBoundaries = new System.Windows.Forms.Button();
            this.cbStronk = new System.Windows.Forms.CheckBox();
            this.cbJetpack = new System.Windows.Forms.CheckBox();
            this.setColour = new System.Windows.Forms.ColorDialog();
            this.gbDebug = new System.Windows.Forms.GroupBox();
            this.lbl_debugInfo = new System.Windows.Forms.Label();
            this.keyHandler = new System.Windows.Forms.Timer(this.components);
            this.gbReapply = new System.Windows.Forms.GroupBox();
            this.btnReapply = new System.Windows.Forms.Button();
            this.gbSpeed = new System.Windows.Forms.GroupBox();
            this.gbStep = new System.Windows.Forms.GroupBox();
            this.cbStepPatch = new System.Windows.Forms.CheckBox();
            this.label1 = new System.Windows.Forms.Label();
            this.nudStepHeight = new System.Windows.Forms.NumericUpDown();
            this.gbPos.SuspendLayout();
            this.gbMisc.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudHealthSpeed)).BeginInit();
            this.gbDebug.SuspendLayout();
            this.gbReapply.SuspendLayout();
            this.gbSpeed.SuspendLayout();
            this.gbStep.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudStepHeight)).BeginInit();
            this.SuspendLayout();
            // 
            // gbPos
            // 
            this.gbPos.Controls.Add(this.savedCords);
            this.gbPos.Controls.Add(this.curCords);
            this.gbPos.Font = new System.Drawing.Font("Lucida Console", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbPos.Location = new System.Drawing.Point(14, 10);
            this.gbPos.Name = "gbPos";
            this.gbPos.Size = new System.Drawing.Size(322, 43);
            this.gbPos.TabIndex = 0;
            this.gbPos.TabStop = false;
            this.gbPos.Text = "Player position (Save [I] Load [K])";
            // 
            // savedCords
            // 
            this.savedCords.AutoSize = true;
            this.savedCords.Font = new System.Drawing.Font("Lucida Console", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.savedCords.Location = new System.Drawing.Point(7, 26);
            this.savedCords.Name = "savedCords";
            this.savedCords.Size = new System.Drawing.Size(236, 11);
            this.savedCords.TabIndex = 2;
            this.savedCords.Text = "  Saved: 00.000 | 00.000 | 00.000";
            // 
            // curCords
            // 
            this.curCords.AutoSize = true;
            this.curCords.Font = new System.Drawing.Font("Lucida Console", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.curCords.Location = new System.Drawing.Point(7, 14);
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
            // gbMisc
            // 
            this.gbMisc.Controls.Add(this.btnRemoveBoundaries);
            this.gbMisc.Controls.Add(this.cbStronk);
            this.gbMisc.Controls.Add(this.cbJetpack);
            this.gbMisc.Font = new System.Drawing.Font("Lucida Console", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbMisc.Location = new System.Drawing.Point(14, 58);
            this.gbMisc.Name = "gbMisc";
            this.gbMisc.Size = new System.Drawing.Size(322, 40);
            this.gbMisc.TabIndex = 1;
            this.gbMisc.TabStop = false;
            this.gbMisc.Text = "Misc";
            // 
            // lblphealthspeed
            // 
            this.lblphealthspeed.AutoSize = true;
            this.lblphealthspeed.Location = new System.Drawing.Point(9, 19);
            this.lblphealthspeed.Name = "lblphealthspeed";
            this.lblphealthspeed.Size = new System.Drawing.Size(159, 11);
            this.lblphealthspeed.TabIndex = 5;
            this.lblphealthspeed.Text = "Player health / speed:";
            // 
            // nudHealthSpeed
            // 
            this.nudHealthSpeed.Enabled = false;
            this.nudHealthSpeed.Location = new System.Drawing.Point(174, 17);
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
            // btnRemoveBoundaries
            // 
            this.btnRemoveBoundaries.Location = new System.Drawing.Point(7, 13);
            this.btnRemoveBoundaries.Name = "btnRemoveBoundaries";
            this.btnRemoveBoundaries.Size = new System.Drawing.Size(144, 19);
            this.btnRemoveBoundaries.TabIndex = 3;
            this.btnRemoveBoundaries.Text = "Remove boundaries";
            this.btnRemoveBoundaries.UseVisualStyleBackColor = true;
            this.btnRemoveBoundaries.Click += new System.EventHandler(this.btnRemoveBoundaries_Click);
            // 
            // cbStronk
            // 
            this.cbStronk.AutoSize = true;
            this.cbStronk.Location = new System.Drawing.Point(238, 16);
            this.cbStronk.Name = "cbStronk";
            this.cbStronk.Size = new System.Drawing.Size(80, 15);
            this.cbStronk.TabIndex = 2;
            this.cbStronk.Text = "Immortal";
            this.cbStronk.UseVisualStyleBackColor = true;
            this.cbStronk.CheckedChanged += new System.EventHandler(this.cbStronk_CheckedChanged);
            // 
            // cbJetpack
            // 
            this.cbJetpack.AutoSize = true;
            this.cbJetpack.Location = new System.Drawing.Point(159, 16);
            this.cbJetpack.Name = "cbJetpack";
            this.cbJetpack.Size = new System.Drawing.Size(73, 15);
            this.cbJetpack.TabIndex = 1;
            this.cbJetpack.Text = "Jetpack";
            this.cbJetpack.UseVisualStyleBackColor = true;
            // 
            // gbDebug
            // 
            this.gbDebug.Controls.Add(this.lbl_debugInfo);
            this.gbDebug.Font = new System.Drawing.Font("Lucida Console", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbDebug.Location = new System.Drawing.Point(14, 204);
            this.gbDebug.Name = "gbDebug";
            this.gbDebug.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.gbDebug.Size = new System.Drawing.Size(322, 65);
            this.gbDebug.TabIndex = 4;
            this.gbDebug.TabStop = false;
            this.gbDebug.Text = "Debug";
            // 
            // lbl_debugInfo
            // 
            this.lbl_debugInfo.AutoSize = true;
            this.lbl_debugInfo.Location = new System.Drawing.Point(7, 14);
            this.lbl_debugInfo.Name = "lbl_debugInfo";
            this.lbl_debugInfo.Size = new System.Drawing.Size(117, 44);
            this.lbl_debugInfo.TabIndex = 3;
            this.lbl_debugInfo.Text = "Entrypoint:\r\nGame instance:\r\nPlayer instance:\r\nScene instance:";
            // 
            // keyHandler
            // 
            this.keyHandler.Interval = 30;
            // 
            // gbReapply
            // 
            this.gbReapply.Controls.Add(this.btnReapply);
            this.gbReapply.Font = new System.Drawing.Font("Lucida Console", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbReapply.Location = new System.Drawing.Point(14, 275);
            this.gbReapply.Name = "gbReapply";
            this.gbReapply.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.gbReapply.Size = new System.Drawing.Size(322, 53);
            this.gbReapply.TabIndex = 5;
            this.gbReapply.TabStop = false;
            this.gbReapply.Text = "Patch";
            // 
            // btnReapply
            // 
            this.btnReapply.Location = new System.Drawing.Point(9, 17);
            this.btnReapply.Name = "btnReapply";
            this.btnReapply.Size = new System.Drawing.Size(307, 30);
            this.btnReapply.TabIndex = 0;
            this.btnReapply.Text = "Reapply patches";
            this.btnReapply.UseVisualStyleBackColor = true;
            this.btnReapply.Click += new System.EventHandler(this.btnReapply_Click);
            // 
            // gbSpeed
            // 
            this.gbSpeed.Controls.Add(this.lblphealthspeed);
            this.gbSpeed.Controls.Add(this.nudHealthSpeed);
            this.gbSpeed.Location = new System.Drawing.Point(14, 104);
            this.gbSpeed.Name = "gbSpeed";
            this.gbSpeed.Size = new System.Drawing.Size(322, 42);
            this.gbSpeed.TabIndex = 6;
            this.gbSpeed.TabStop = false;
            this.gbSpeed.Text = "Speed (Requires immortality)";
            // 
            // gbStep
            // 
            this.gbStep.Controls.Add(this.label1);
            this.gbStep.Controls.Add(this.nudStepHeight);
            this.gbStep.Controls.Add(this.cbStepPatch);
            this.gbStep.Location = new System.Drawing.Point(14, 152);
            this.gbStep.Name = "gbStep";
            this.gbStep.Size = new System.Drawing.Size(322, 46);
            this.gbStep.TabIndex = 7;
            this.gbStep.TabStop = false;
            this.gbStep.Text = "Step";
            // 
            // cbStepPatch
            // 
            this.cbStepPatch.AutoSize = true;
            this.cbStepPatch.Location = new System.Drawing.Point(222, 20);
            this.cbStepPatch.Name = "cbStepPatch";
            this.cbStepPatch.Size = new System.Drawing.Size(94, 15);
            this.cbStepPatch.TabIndex = 0;
            this.cbStepPatch.Text = "Step patch";
            this.cbStepPatch.UseVisualStyleBackColor = true;
            this.cbStepPatch.CheckedChanged += new System.EventHandler(this.cbStepPatch_CheckedChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(54, 11);
            this.label1.TabIndex = 7;
            this.label1.Text = "Height:";
            // 
            // nudStepHeight
            // 
            this.nudStepHeight.Enabled = false;
            this.nudStepHeight.Location = new System.Drawing.Point(69, 19);
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
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 11F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(348, 338);
            this.Controls.Add(this.gbStep);
            this.Controls.Add(this.gbSpeed);
            this.Controls.Add(this.gbReapply);
            this.Controls.Add(this.gbDebug);
            this.Controls.Add(this.gbMisc);
            this.Controls.Add(this.gbPos);
            this.Font = new System.Drawing.Font("Lucida Console", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Form1";
            this.Text = "Teardown diddler";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.gbPos.ResumeLayout(false);
            this.gbPos.PerformLayout();
            this.gbMisc.ResumeLayout(false);
            this.gbMisc.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudHealthSpeed)).EndInit();
            this.gbDebug.ResumeLayout(false);
            this.gbDebug.PerformLayout();
            this.gbReapply.ResumeLayout(false);
            this.gbSpeed.ResumeLayout(false);
            this.gbSpeed.PerformLayout();
            this.gbStep.ResumeLayout(false);
            this.gbStep.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudStepHeight)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbPos;
        private System.Windows.Forms.Label savedCords;
        private System.Windows.Forms.Timer updateCurrentPositions;
        private System.Windows.Forms.GroupBox gbMisc;
        private System.Windows.Forms.ColorDialog setColour;
        private System.Windows.Forms.CheckBox cbJetpack;
        private System.Windows.Forms.CheckBox cbStronk;
        private System.Windows.Forms.Button btnRemoveBoundaries;
        private System.Windows.Forms.GroupBox gbDebug;
        private System.Windows.Forms.Label lbl_debugInfo;
        private System.Windows.Forms.Timer keyHandler;
        private System.Windows.Forms.Label curCords;
        private System.Windows.Forms.Label lblphealthspeed;
        private System.Windows.Forms.NumericUpDown nudHealthSpeed;
        private System.Windows.Forms.GroupBox gbReapply;
        private System.Windows.Forms.Button btnReapply;
        private System.Windows.Forms.GroupBox gbSpeed;
        private System.Windows.Forms.GroupBox gbStep;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown nudStepHeight;
        private System.Windows.Forms.CheckBox cbStepPatch;
    }
}

