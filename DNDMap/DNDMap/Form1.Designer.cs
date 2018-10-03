namespace DNDMap
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
            this.mapEditRB = new System.Windows.Forms.RadioButton();
            this.monsterMovementRD = new System.Windows.Forms.RadioButton();
            this.modeGB = new System.Windows.Forms.GroupBox();
            this.obstaclesRD = new System.Windows.Forms.RadioButton();
            this.heightNUD = new System.Windows.Forms.NumericUpDown();
            this.widthNUD = new System.Windows.Forms.NumericUpDown();
            this.mapSizeGB = new System.Windows.Forms.GroupBox();
            this.generateButton = new System.Windows.Forms.Button();
            this.widthLabel = new System.Windows.Forms.Label();
            this.heightLabel = new System.Windows.Forms.Label();
            this.gridTable = new System.Windows.Forms.FlowLayoutPanel();
            this.floorCB = new System.Windows.Forms.ComboBox();
            this.floorTilesLabel = new System.Windows.Forms.Label();
            this.obstaclesCB = new System.Windows.Forms.ComboBox();
            this.obstaclesLabel = new System.Windows.Forms.Label();
            this.editGB = new System.Windows.Forms.GroupBox();
            this.eraseRB = new System.Windows.Forms.RadioButton();
            this.addRB = new System.Windows.Forms.RadioButton();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.modeGB.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.heightNUD)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.widthNUD)).BeginInit();
            this.mapSizeGB.SuspendLayout();
            this.editGB.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.SuspendLayout();
            // 
            // mapEditRB
            // 
            this.mapEditRB.AutoSize = true;
            this.mapEditRB.Checked = true;
            this.mapEditRB.Location = new System.Drawing.Point(6, 19);
            this.mapEditRB.Name = "mapEditRB";
            this.mapEditRB.Size = new System.Drawing.Size(76, 17);
            this.mapEditRB.TabIndex = 0;
            this.mapEditRB.TabStop = true;
            this.mapEditRB.Text = "Map Editor";
            this.mapEditRB.UseVisualStyleBackColor = true;
            // 
            // monsterMovementRD
            // 
            this.monsterMovementRD.AutoSize = true;
            this.monsterMovementRD.Location = new System.Drawing.Point(6, 56);
            this.monsterMovementRD.Name = "monsterMovementRD";
            this.monsterMovementRD.Size = new System.Drawing.Size(116, 17);
            this.monsterMovementRD.TabIndex = 1;
            this.monsterMovementRD.Text = "Monster Movement";
            this.monsterMovementRD.UseVisualStyleBackColor = true;
            // 
            // modeGB
            // 
            this.modeGB.Controls.Add(this.obstaclesRD);
            this.modeGB.Controls.Add(this.mapEditRB);
            this.modeGB.Controls.Add(this.monsterMovementRD);
            this.modeGB.Location = new System.Drawing.Point(724, 31);
            this.modeGB.Name = "modeGB";
            this.modeGB.Size = new System.Drawing.Size(200, 81);
            this.modeGB.TabIndex = 2;
            this.modeGB.TabStop = false;
            this.modeGB.Text = "Mode Box";
            // 
            // obstaclesRD
            // 
            this.obstaclesRD.AutoSize = true;
            this.obstaclesRD.Location = new System.Drawing.Point(5, 35);
            this.obstaclesRD.Margin = new System.Windows.Forms.Padding(2);
            this.obstaclesRD.Name = "obstaclesRD";
            this.obstaclesRD.Size = new System.Drawing.Size(72, 17);
            this.obstaclesRD.TabIndex = 2;
            this.obstaclesRD.TabStop = true;
            this.obstaclesRD.Text = "Obstacles";
            this.obstaclesRD.UseVisualStyleBackColor = true;
            // 
            // heightNUD
            // 
            this.heightNUD.Location = new System.Drawing.Point(74, 19);
            this.heightNUD.Name = "heightNUD";
            this.heightNUD.Size = new System.Drawing.Size(120, 20);
            this.heightNUD.TabIndex = 3;
            // 
            // widthNUD
            // 
            this.widthNUD.Location = new System.Drawing.Point(74, 45);
            this.widthNUD.Name = "widthNUD";
            this.widthNUD.Size = new System.Drawing.Size(120, 20);
            this.widthNUD.TabIndex = 4;
            // 
            // mapSizeGB
            // 
            this.mapSizeGB.Controls.Add(this.generateButton);
            this.mapSizeGB.Controls.Add(this.widthLabel);
            this.mapSizeGB.Controls.Add(this.heightLabel);
            this.mapSizeGB.Controls.Add(this.heightNUD);
            this.mapSizeGB.Controls.Add(this.widthNUD);
            this.mapSizeGB.Location = new System.Drawing.Point(724, 127);
            this.mapSizeGB.Name = "mapSizeGB";
            this.mapSizeGB.Size = new System.Drawing.Size(200, 116);
            this.mapSizeGB.TabIndex = 5;
            this.mapSizeGB.TabStop = false;
            this.mapSizeGB.Text = "Map Size";
            // 
            // generateButton
            // 
            this.generateButton.Location = new System.Drawing.Point(60, 76);
            this.generateButton.Name = "generateButton";
            this.generateButton.Size = new System.Drawing.Size(75, 23);
            this.generateButton.TabIndex = 7;
            this.generateButton.Text = "Generate";
            this.generateButton.UseVisualStyleBackColor = true;
            this.generateButton.Click += new System.EventHandler(this.GenerateButton_Click);
            // 
            // widthLabel
            // 
            this.widthLabel.AutoSize = true;
            this.widthLabel.Location = new System.Drawing.Point(9, 47);
            this.widthLabel.Name = "widthLabel";
            this.widthLabel.Size = new System.Drawing.Size(38, 13);
            this.widthLabel.TabIndex = 6;
            this.widthLabel.Text = "Width:";
            // 
            // heightLabel
            // 
            this.heightLabel.AutoSize = true;
            this.heightLabel.Location = new System.Drawing.Point(9, 21);
            this.heightLabel.Name = "heightLabel";
            this.heightLabel.Size = new System.Drawing.Size(41, 13);
            this.heightLabel.TabIndex = 5;
            this.heightLabel.Text = "Height:";
            // 
            // gridTable
            // 
            this.gridTable.Location = new System.Drawing.Point(6, 6);
            this.gridTable.Name = "gridTable";
            this.gridTable.Size = new System.Drawing.Size(685, 574);
            this.gridTable.TabIndex = 6;
            // 
            // floorCB
            // 
            this.floorCB.FormattingEnabled = true;
            this.floorCB.Location = new System.Drawing.Point(736, 278);
            this.floorCB.Name = "floorCB";
            this.floorCB.Size = new System.Drawing.Size(182, 21);
            this.floorCB.TabIndex = 7;
            // 
            // floorTilesLabel
            // 
            this.floorTilesLabel.AutoSize = true;
            this.floorTilesLabel.Location = new System.Drawing.Point(736, 260);
            this.floorTilesLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.floorTilesLabel.Name = "floorTilesLabel";
            this.floorTilesLabel.Size = new System.Drawing.Size(55, 13);
            this.floorTilesLabel.TabIndex = 8;
            this.floorTilesLabel.Text = "Floor Tiles";
            // 
            // obstaclesCB
            // 
            this.obstaclesCB.FormattingEnabled = true;
            this.obstaclesCB.Location = new System.Drawing.Point(736, 324);
            this.obstaclesCB.Margin = new System.Windows.Forms.Padding(2);
            this.obstaclesCB.Name = "obstaclesCB";
            this.obstaclesCB.Size = new System.Drawing.Size(182, 21);
            this.obstaclesCB.TabIndex = 9;
            // 
            // obstaclesLabel
            // 
            this.obstaclesLabel.AutoSize = true;
            this.obstaclesLabel.Location = new System.Drawing.Point(739, 307);
            this.obstaclesLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.obstaclesLabel.Name = "obstaclesLabel";
            this.obstaclesLabel.Size = new System.Drawing.Size(54, 13);
            this.obstaclesLabel.TabIndex = 10;
            this.obstaclesLabel.Text = "Obstacles";
            // 
            // editGB
            // 
            this.editGB.Controls.Add(this.eraseRB);
            this.editGB.Controls.Add(this.addRB);
            this.editGB.Location = new System.Drawing.Point(724, 425);
            this.editGB.Name = "editGB";
            this.editGB.Size = new System.Drawing.Size(200, 100);
            this.editGB.TabIndex = 11;
            this.editGB.TabStop = false;
            this.editGB.Text = "Edit Box";
            // 
            // eraseRB
            // 
            this.eraseRB.AutoSize = true;
            this.eraseRB.Location = new System.Drawing.Point(7, 44);
            this.eraseRB.Name = "eraseRB";
            this.eraseRB.Size = new System.Drawing.Size(52, 17);
            this.eraseRB.TabIndex = 1;
            this.eraseRB.TabStop = true;
            this.eraseRB.Text = "Erase";
            this.eraseRB.UseVisualStyleBackColor = true;
            // 
            // addRB
            // 
            this.addRB.AutoSize = true;
            this.addRB.Checked = true;
            this.addRB.Location = new System.Drawing.Point(7, 20);
            this.addRB.Name = "addRB";
            this.addRB.Size = new System.Drawing.Size(44, 17);
            this.addRB.TabIndex = 0;
            this.addRB.TabStop = true;
            this.addRB.Text = "Add";
            this.addRB.UseVisualStyleBackColor = true;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(742, 551);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(100, 50);
            this.pictureBox1.TabIndex = 12;
            this.pictureBox1.TabStop = false;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(13, 13);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(705, 612);
            this.tabControl1.TabIndex = 13;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.gridTable);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(697, 586);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "tabPage1";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(697, 586);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "tabPage2";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(936, 655);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.editGB);
            this.Controls.Add(this.obstaclesLabel);
            this.Controls.Add(this.obstaclesCB);
            this.Controls.Add(this.floorTilesLabel);
            this.Controls.Add(this.floorCB);
            this.Controls.Add(this.mapSizeGB);
            this.Controls.Add(this.modeGB);
            this.Name = "Form1";
            this.Text = "Form1";
            this.modeGB.ResumeLayout(false);
            this.modeGB.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.heightNUD)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.widthNUD)).EndInit();
            this.mapSizeGB.ResumeLayout(false);
            this.mapSizeGB.PerformLayout();
            this.editGB.ResumeLayout(false);
            this.editGB.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RadioButton mapEditRB;
        private System.Windows.Forms.RadioButton monsterMovementRD;
        private System.Windows.Forms.GroupBox modeGB;
        private System.Windows.Forms.NumericUpDown heightNUD;
        private System.Windows.Forms.NumericUpDown widthNUD;
        private System.Windows.Forms.GroupBox mapSizeGB;
        private System.Windows.Forms.Label heightLabel;
        private System.Windows.Forms.Button generateButton;
        private System.Windows.Forms.Label widthLabel;
        private System.Windows.Forms.FlowLayoutPanel gridTable;
        private System.Windows.Forms.ComboBox floorCB;
        private System.Windows.Forms.RadioButton obstaclesRD;
        private System.Windows.Forms.Label floorTilesLabel;
        private System.Windows.Forms.ComboBox obstaclesCB;
        private System.Windows.Forms.Label obstaclesLabel;
        private System.Windows.Forms.GroupBox editGB;
        private System.Windows.Forms.RadioButton eraseRB;
        private System.Windows.Forms.RadioButton addRB;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
    }
}

