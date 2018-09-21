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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.mapEditRB = new System.Windows.Forms.RadioButton();
            this.monsterMovementRD = new System.Windows.Forms.RadioButton();
            this.modeGB = new System.Windows.Forms.GroupBox();
            this.heightNUD = new System.Windows.Forms.NumericUpDown();
            this.widthNUD = new System.Windows.Forms.NumericUpDown();
            this.mapSizeGB = new System.Windows.Forms.GroupBox();
            this.generateButton = new System.Windows.Forms.Button();
            this.widthLabel = new System.Windows.Forms.Label();
            this.heightLabel = new System.Windows.Forms.Label();
            this.gridTable = new System.Windows.Forms.FlowLayoutPanel();
            this.floorCB = new System.Windows.Forms.ComboBox();
            this.floorTilesLabel = new System.Windows.Forms.Label();
            this.obstaclesRD = new System.Windows.Forms.RadioButton();
            this.obstaclesCB = new System.Windows.Forms.ComboBox();
            this.obstaclesLabel = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.modeGB.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.heightNUD)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.widthNUD)).BeginInit();
            this.mapSizeGB.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // mapEditRB
            // 
            this.mapEditRB.AutoSize = true;
            this.mapEditRB.Checked = true;
            this.mapEditRB.Location = new System.Drawing.Point(9, 29);
            this.mapEditRB.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.mapEditRB.Name = "mapEditRB";
            this.mapEditRB.Size = new System.Drawing.Size(111, 24);
            this.mapEditRB.TabIndex = 0;
            this.mapEditRB.TabStop = true;
            this.mapEditRB.Text = "Map Editor";
            this.mapEditRB.UseVisualStyleBackColor = true;
            // 
            // monsterMovementRD
            // 
            this.monsterMovementRD.AutoSize = true;
            this.monsterMovementRD.Location = new System.Drawing.Point(9, 86);
            this.monsterMovementRD.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.monsterMovementRD.Name = "monsterMovementRD";
            this.monsterMovementRD.Size = new System.Drawing.Size(170, 24);
            this.monsterMovementRD.TabIndex = 1;
            this.monsterMovementRD.Text = "Monster Movement";
            this.monsterMovementRD.UseVisualStyleBackColor = true;
            // 
            // modeGB
            // 
            this.modeGB.Controls.Add(this.obstaclesRD);
            this.modeGB.Controls.Add(this.mapEditRB);
            this.modeGB.Controls.Add(this.monsterMovementRD);
            this.modeGB.Location = new System.Drawing.Point(1086, 18);
            this.modeGB.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.modeGB.Name = "modeGB";
            this.modeGB.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.modeGB.Size = new System.Drawing.Size(300, 154);
            this.modeGB.TabIndex = 2;
            this.modeGB.TabStop = false;
            this.modeGB.Text = "Mode Box";
            // 
            // heightNUD
            // 
            this.heightNUD.Location = new System.Drawing.Point(111, 29);
            this.heightNUD.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.heightNUD.Name = "heightNUD";
            this.heightNUD.Size = new System.Drawing.Size(180, 26);
            this.heightNUD.TabIndex = 3;
            // 
            // widthNUD
            // 
            this.widthNUD.Location = new System.Drawing.Point(111, 69);
            this.widthNUD.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.widthNUD.Name = "widthNUD";
            this.widthNUD.Size = new System.Drawing.Size(180, 26);
            this.widthNUD.TabIndex = 4;
            // 
            // mapSizeGB
            // 
            this.mapSizeGB.Controls.Add(this.generateButton);
            this.mapSizeGB.Controls.Add(this.widthLabel);
            this.mapSizeGB.Controls.Add(this.heightLabel);
            this.mapSizeGB.Controls.Add(this.heightNUD);
            this.mapSizeGB.Controls.Add(this.widthNUD);
            this.mapSizeGB.Location = new System.Drawing.Point(1086, 195);
            this.mapSizeGB.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.mapSizeGB.Name = "mapSizeGB";
            this.mapSizeGB.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.mapSizeGB.Size = new System.Drawing.Size(300, 178);
            this.mapSizeGB.TabIndex = 5;
            this.mapSizeGB.TabStop = false;
            this.mapSizeGB.Text = "Map Size";
            // 
            // generateButton
            // 
            this.generateButton.Location = new System.Drawing.Point(90, 117);
            this.generateButton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.generateButton.Name = "generateButton";
            this.generateButton.Size = new System.Drawing.Size(112, 35);
            this.generateButton.TabIndex = 7;
            this.generateButton.Text = "Generate";
            this.generateButton.UseVisualStyleBackColor = true;
            this.generateButton.Click += new System.EventHandler(this.GenerateButton_Click);
            // 
            // widthLabel
            // 
            this.widthLabel.AutoSize = true;
            this.widthLabel.Location = new System.Drawing.Point(14, 72);
            this.widthLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.widthLabel.Name = "widthLabel";
            this.widthLabel.Size = new System.Drawing.Size(54, 20);
            this.widthLabel.TabIndex = 6;
            this.widthLabel.Text = "Width:";
            // 
            // heightLabel
            // 
            this.heightLabel.AutoSize = true;
            this.heightLabel.Location = new System.Drawing.Point(14, 32);
            this.heightLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.heightLabel.Name = "heightLabel";
            this.heightLabel.Size = new System.Drawing.Size(60, 20);
            this.heightLabel.TabIndex = 5;
            this.heightLabel.Text = "Height:";
            // 
            // gridTable
            // 
            this.gridTable.Location = new System.Drawing.Point(20, 20);
            this.gridTable.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.gridTable.Name = "gridTable";
            this.gridTable.Size = new System.Drawing.Size(1058, 942);
            this.gridTable.TabIndex = 6;
            // 
            // floorCB
            // 
            this.floorCB.FormattingEnabled = true;
            this.floorCB.Location = new System.Drawing.Point(1104, 428);
            this.floorCB.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.floorCB.Name = "floorCB";
            this.floorCB.Size = new System.Drawing.Size(271, 28);
            this.floorCB.TabIndex = 7;
            // 
            // floorTilesLabel
            // 
            this.floorTilesLabel.AutoSize = true;
            this.floorTilesLabel.Location = new System.Drawing.Point(1104, 400);
            this.floorTilesLabel.Name = "floorTilesLabel";
            this.floorTilesLabel.Size = new System.Drawing.Size(81, 20);
            this.floorTilesLabel.TabIndex = 8;
            this.floorTilesLabel.Text = "Floor Tiles";
            // 
            // obstaclesRD
            // 
            this.obstaclesRD.AutoSize = true;
            this.obstaclesRD.Location = new System.Drawing.Point(8, 54);
            this.obstaclesRD.Name = "obstaclesRD";
            this.obstaclesRD.Size = new System.Drawing.Size(105, 24);
            this.obstaclesRD.TabIndex = 2;
            this.obstaclesRD.TabStop = true;
            this.obstaclesRD.Text = "Obstacles";
            this.obstaclesRD.UseVisualStyleBackColor = true;
            // 
            // obstaclesCB
            // 
            this.obstaclesCB.FormattingEnabled = true;
            this.obstaclesCB.Location = new System.Drawing.Point(1104, 498);
            this.obstaclesCB.Name = "obstaclesCB";
            this.obstaclesCB.Size = new System.Drawing.Size(271, 28);
            this.obstaclesCB.TabIndex = 9;
            // 
            // obstaclesLabel
            // 
            this.obstaclesLabel.AutoSize = true;
            this.obstaclesLabel.Location = new System.Drawing.Point(1108, 472);
            this.obstaclesLabel.Name = "obstaclesLabel";
            this.obstaclesLabel.Size = new System.Drawing.Size(80, 20);
            this.obstaclesLabel.TabIndex = 10;
            this.obstaclesLabel.Text = "Obstacles";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(1105, 667);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(100, 50);
            this.pictureBox1.TabIndex = 11;
            this.pictureBox1.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1404, 1008);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.obstaclesLabel);
            this.Controls.Add(this.obstaclesCB);
            this.Controls.Add(this.floorTilesLabel);
            this.Controls.Add(this.floorCB);
            this.Controls.Add(this.gridTable);
            this.Controls.Add(this.mapSizeGB);
            this.Controls.Add(this.modeGB);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Form1";
            this.Text = "Form1";
            this.modeGB.ResumeLayout(false);
            this.modeGB.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.heightNUD)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.widthNUD)).EndInit();
            this.mapSizeGB.ResumeLayout(false);
            this.mapSizeGB.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
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
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

