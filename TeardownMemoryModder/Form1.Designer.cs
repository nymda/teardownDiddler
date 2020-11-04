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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.savedCords = new System.Windows.Forms.Label();
            this.curCords = new System.Windows.Forms.Label();
            this.updateCurrentPositions = new System.Windows.Forms.Timer(this.components);
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnRemoveBoundaries = new System.Windows.Forms.Button();
            this.cbStronk = new System.Windows.Forms.CheckBox();
            this.cbJetpack = new System.Windows.Forms.CheckBox();
            this.setColour = new System.Windows.Forms.ColorDialog();
            this.gbDebug = new System.Windows.Forms.GroupBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.savedCords);
            this.groupBox1.Controls.Add(this.curCords);
            this.groupBox1.Font = new System.Drawing.Font("Lucida Console", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(14, 10);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(346, 43);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Player position (Save [I] Load [K])";
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
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnRemoveBoundaries);
            this.groupBox2.Controls.Add(this.cbStronk);
            this.groupBox2.Controls.Add(this.cbJetpack);
            this.groupBox2.Font = new System.Drawing.Font("Lucida Console", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(14, 58);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(346, 39);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Misc";
            // 
            // btnRemoveBoundaries
            // 
            this.btnRemoveBoundaries.Location = new System.Drawing.Point(7, 13);
            this.btnRemoveBoundaries.Name = "btnRemoveBoundaries";
            this.btnRemoveBoundaries.Size = new System.Drawing.Size(166, 19);
            this.btnRemoveBoundaries.TabIndex = 3;
            this.btnRemoveBoundaries.Text = "Remove boundaries";
            this.btnRemoveBoundaries.UseVisualStyleBackColor = true;
            this.btnRemoveBoundaries.Click += new System.EventHandler(this.btnRemoveBoundaries_Click);
            // 
            // cbStronk
            // 
            this.cbStronk.AutoSize = true;
            this.cbStronk.Location = new System.Drawing.Point(258, 16);
            this.cbStronk.Name = "cbStronk";
            this.cbStronk.Size = new System.Drawing.Size(80, 15);
            this.cbStronk.TabIndex = 2;
            this.cbStronk.Text = "Immortal";
            this.cbStronk.UseVisualStyleBackColor = true;
            // 
            // cbJetpack
            // 
            this.cbJetpack.AutoSize = true;
            this.cbJetpack.Location = new System.Drawing.Point(179, 16);
            this.cbJetpack.Name = "cbJetpack";
            this.cbJetpack.Size = new System.Drawing.Size(73, 15);
            this.cbJetpack.TabIndex = 1;
            this.cbJetpack.Text = "Jetpack";
            this.cbJetpack.UseVisualStyleBackColor = true;
            // 
            // gbDebug
            // 
            this.gbDebug.Font = new System.Drawing.Font("Lucida Console", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbDebug.Location = new System.Drawing.Point(14, 102);
            this.gbDebug.Name = "gbDebug";
            this.gbDebug.Size = new System.Drawing.Size(346, 336);
            this.gbDebug.TabIndex = 4;
            this.gbDebug.TabStop = false;
            this.gbDebug.Text = "Debug";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 11F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(373, 448);
            this.Controls.Add(this.gbDebug);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Lucida Console", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Form1";
            this.Text = "Teardown diddler";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label savedCords;
        private System.Windows.Forms.Label curCords;
        private System.Windows.Forms.Timer updateCurrentPositions;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ColorDialog setColour;
        private System.Windows.Forms.CheckBox cbJetpack;
        private System.Windows.Forms.CheckBox cbStronk;
        private System.Windows.Forms.Button btnRemoveBoundaries;
        private System.Windows.Forms.GroupBox gbDebug;
    }
}

