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
            this.btnLoadPos = new System.Windows.Forms.Button();
            this.btnSavePos = new System.Windows.Forms.Button();
            this.sPosZ = new System.Windows.Forms.Label();
            this.sPosY = new System.Windows.Forms.Label();
            this.sPosX = new System.Windows.Forms.Label();
            this.cPosZ = new System.Windows.Forms.Label();
            this.cPosY = new System.Windows.Forms.Label();
            this.cPosX = new System.Windows.Forms.Label();
            this.updateCurrentPositions = new System.Windows.Forms.Timer(this.components);
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.cbJetpack = new System.Windows.Forms.CheckBox();
            this.setColour = new System.Windows.Forms.ColorDialog();
            this.cbStronk = new System.Windows.Forms.CheckBox();
            this.btnRemoveBoundaries = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnLoadPos);
            this.groupBox1.Controls.Add(this.btnSavePos);
            this.groupBox1.Controls.Add(this.sPosZ);
            this.groupBox1.Controls.Add(this.sPosY);
            this.groupBox1.Controls.Add(this.sPosX);
            this.groupBox1.Controls.Add(this.cPosZ);
            this.groupBox1.Controls.Add(this.cPosY);
            this.groupBox1.Controls.Add(this.cPosX);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(346, 120);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Player position";
            // 
            // btnLoadPos
            // 
            this.btnLoadPos.Location = new System.Drawing.Point(243, 45);
            this.btnLoadPos.Name = "btnLoadPos";
            this.btnLoadPos.Size = new System.Drawing.Size(97, 23);
            this.btnLoadPos.TabIndex = 7;
            this.btnLoadPos.Text = "Load position (K)";
            this.btnLoadPos.UseVisualStyleBackColor = true;
            this.btnLoadPos.Click += new System.EventHandler(this.btnLoadPos_Click);
            // 
            // btnSavePos
            // 
            this.btnSavePos.Location = new System.Drawing.Point(243, 16);
            this.btnSavePos.Name = "btnSavePos";
            this.btnSavePos.Size = new System.Drawing.Size(97, 23);
            this.btnSavePos.TabIndex = 1;
            this.btnSavePos.Text = "Save position (I)";
            this.btnSavePos.UseVisualStyleBackColor = true;
            this.btnSavePos.Click += new System.EventHandler(this.btnSavePos_Click);
            // 
            // sPosZ
            // 
            this.sPosZ.AutoSize = true;
            this.sPosZ.Font = new System.Drawing.Font("Lucida Console", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sPosZ.Location = new System.Drawing.Point(6, 100);
            this.sPosZ.Name = "sPosZ";
            this.sPosZ.Size = new System.Drawing.Size(96, 11);
            this.sPosZ.TabIndex = 6;
            this.sPosZ.Text = "Saved Z: 0.00";
            // 
            // sPosY
            // 
            this.sPosY.AutoSize = true;
            this.sPosY.Font = new System.Drawing.Font("Lucida Console", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sPosY.Location = new System.Drawing.Point(6, 85);
            this.sPosY.Name = "sPosY";
            this.sPosY.Size = new System.Drawing.Size(96, 11);
            this.sPosY.TabIndex = 5;
            this.sPosY.Text = "Saved Y: 0.00";
            // 
            // sPosX
            // 
            this.sPosX.AutoSize = true;
            this.sPosX.Font = new System.Drawing.Font("Lucida Console", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sPosX.Location = new System.Drawing.Point(6, 70);
            this.sPosX.Name = "sPosX";
            this.sPosX.Size = new System.Drawing.Size(96, 11);
            this.sPosX.TabIndex = 4;
            this.sPosX.Text = "Saved X: 0.00";
            // 
            // cPosZ
            // 
            this.cPosZ.AutoSize = true;
            this.cPosZ.Font = new System.Drawing.Font("Lucida Console", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cPosZ.Location = new System.Drawing.Point(6, 46);
            this.cPosZ.Name = "cPosZ";
            this.cPosZ.Size = new System.Drawing.Size(110, 11);
            this.cPosZ.TabIndex = 3;
            this.cPosZ.Text = "Current Z: 0.00";
            // 
            // cPosY
            // 
            this.cPosY.AutoSize = true;
            this.cPosY.Font = new System.Drawing.Font("Lucida Console", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cPosY.Location = new System.Drawing.Point(6, 31);
            this.cPosY.Name = "cPosY";
            this.cPosY.Size = new System.Drawing.Size(110, 11);
            this.cPosY.TabIndex = 2;
            this.cPosY.Text = "Current Y: 0.00";
            // 
            // cPosX
            // 
            this.cPosX.AutoSize = true;
            this.cPosX.Font = new System.Drawing.Font("Lucida Console", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cPosX.Location = new System.Drawing.Point(6, 16);
            this.cPosX.Name = "cPosX";
            this.cPosX.Size = new System.Drawing.Size(110, 11);
            this.cPosX.TabIndex = 1;
            this.cPosX.Text = "Current X: 0.00";
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
            this.groupBox2.Location = new System.Drawing.Point(12, 138);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(346, 46);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Misc";
            // 
            // cbJetpack
            // 
            this.cbJetpack.AutoSize = true;
            this.cbJetpack.Location = new System.Drawing.Point(130, 19);
            this.cbJetpack.Name = "cbJetpack";
            this.cbJetpack.Size = new System.Drawing.Size(64, 17);
            this.cbJetpack.TabIndex = 1;
            this.cbJetpack.Text = "Jetpack";
            this.cbJetpack.UseVisualStyleBackColor = true;
            // 
            // cbStronk
            // 
            this.cbStronk.AutoSize = true;
            this.cbStronk.Location = new System.Drawing.Point(200, 19);
            this.cbStronk.Name = "cbStronk";
            this.cbStronk.Size = new System.Drawing.Size(57, 17);
            this.cbStronk.TabIndex = 2;
            this.cbStronk.Text = "Stronk";
            this.cbStronk.UseVisualStyleBackColor = true;
            // 
            // btnRemoveBoundaries
            // 
            this.btnRemoveBoundaries.Location = new System.Drawing.Point(6, 15);
            this.btnRemoveBoundaries.Name = "btnRemoveBoundaries";
            this.btnRemoveBoundaries.Size = new System.Drawing.Size(110, 23);
            this.btnRemoveBoundaries.TabIndex = 3;
            this.btnRemoveBoundaries.Text = "Remove boundaries";
            this.btnRemoveBoundaries.UseVisualStyleBackColor = true;
            this.btnRemoveBoundaries.Click += new System.EventHandler(this.btnRemoveBoundaries_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(369, 189);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
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
        private System.Windows.Forms.Button btnLoadPos;
        private System.Windows.Forms.Button btnSavePos;
        private System.Windows.Forms.Label sPosZ;
        private System.Windows.Forms.Label sPosY;
        private System.Windows.Forms.Label sPosX;
        private System.Windows.Forms.Label cPosZ;
        private System.Windows.Forms.Label cPosY;
        private System.Windows.Forms.Label cPosX;
        private System.Windows.Forms.Timer updateCurrentPositions;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ColorDialog setColour;
        private System.Windows.Forms.CheckBox cbJetpack;
        private System.Windows.Forms.CheckBox cbStronk;
        private System.Windows.Forms.Button btnRemoveBoundaries;
    }
}

