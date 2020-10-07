namespace WindowsFormsApptest1
{
    partial class MainForm
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
            this.startGameButton = new System.Windows.Forms.Button();
            this.gameBoard = new System.Windows.Forms.Panel();
            this.btn3_3 = new System.Windows.Forms.Button();
            this.btn3_2 = new System.Windows.Forms.Button();
            this.btn3_1 = new System.Windows.Forms.Button();
            this.btn2_3 = new System.Windows.Forms.Button();
            this.btn2_2 = new System.Windows.Forms.Button();
            this.btn2_1 = new System.Windows.Forms.Button();
            this.btn1_3 = new System.Windows.Forms.Button();
            this.btn1_2 = new System.Windows.Forms.Button();
            this.btn1_1 = new System.Windows.Forms.Button();
            this.ProgressLabel = new System.Windows.Forms.Label();
            this.XwinLabel = new System.Windows.Forms.Label();
            this.OwinLabel = new System.Windows.Forms.Label();
            this.DrawLabel = new System.Windows.Forms.Label();
            this.SaveFile = new System.Windows.Forms.Button();
            this.History = new System.Windows.Forms.Button();
            this.gameBoard.SuspendLayout();
            this.SuspendLayout();
            // 
            // startGameButton
            // 
            this.startGameButton.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.startGameButton.Location = new System.Drawing.Point(316, 27);
            this.startGameButton.Name = "startGameButton";
            this.startGameButton.Size = new System.Drawing.Size(95, 34);
            this.startGameButton.TabIndex = 0;
            this.startGameButton.Text = "New Game";
            this.startGameButton.UseVisualStyleBackColor = false;
            this.startGameButton.Click += new System.EventHandler(this.startGameButton_Click);
            // 
            // gameBoard
            // 
            this.gameBoard.Controls.Add(this.btn3_3);
            this.gameBoard.Controls.Add(this.btn3_2);
            this.gameBoard.Controls.Add(this.btn3_1);
            this.gameBoard.Controls.Add(this.btn2_3);
            this.gameBoard.Controls.Add(this.btn2_2);
            this.gameBoard.Controls.Add(this.btn2_1);
            this.gameBoard.Controls.Add(this.btn1_3);
            this.gameBoard.Controls.Add(this.btn1_2);
            this.gameBoard.Controls.Add(this.btn1_1);
            this.gameBoard.Location = new System.Drawing.Point(225, 81);
            this.gameBoard.Name = "gameBoard";
            this.gameBoard.Size = new System.Drawing.Size(272, 262);
            this.gameBoard.TabIndex = 1;
            // 
            // btn3_3
            // 
            this.btn3_3.Location = new System.Drawing.Point(189, 182);
            this.btn3_3.Name = "btn3_3";
            this.btn3_3.Size = new System.Drawing.Size(80, 80);
            this.btn3_3.TabIndex = 8;
            this.btn3_3.Text = " ";
            this.btn3_3.UseVisualStyleBackColor = true;
            this.btn3_3.Click += new System.EventHandler(this.btn3_3_Click);
            // 
            // btn3_2
            // 
            this.btn3_2.Location = new System.Drawing.Point(99, 182);
            this.btn3_2.Name = "btn3_2";
            this.btn3_2.Size = new System.Drawing.Size(80, 80);
            this.btn3_2.TabIndex = 7;
            this.btn3_2.Text = " ";
            this.btn3_2.UseVisualStyleBackColor = true;
            this.btn3_2.Click += new System.EventHandler(this.btn3_2_Click);
            // 
            // btn3_1
            // 
            this.btn3_1.Location = new System.Drawing.Point(13, 182);
            this.btn3_1.Name = "btn3_1";
            this.btn3_1.Size = new System.Drawing.Size(80, 80);
            this.btn3_1.TabIndex = 6;
            this.btn3_1.Text = " ";
            this.btn3_1.UseVisualStyleBackColor = true;
            this.btn3_1.Click += new System.EventHandler(this.btn3_1_Click);
            // 
            // btn2_3
            // 
            this.btn2_3.Location = new System.Drawing.Point(192, 91);
            this.btn2_3.Name = "btn2_3";
            this.btn2_3.Size = new System.Drawing.Size(80, 80);
            this.btn2_3.TabIndex = 5;
            this.btn2_3.Text = " ";
            this.btn2_3.UseVisualStyleBackColor = true;
            this.btn2_3.Click += new System.EventHandler(this.btn2_3_Click);
            // 
            // btn2_2
            // 
            this.btn2_2.Location = new System.Drawing.Point(99, 91);
            this.btn2_2.Name = "btn2_2";
            this.btn2_2.Size = new System.Drawing.Size(80, 80);
            this.btn2_2.TabIndex = 4;
            this.btn2_2.Text = " ";
            this.btn2_2.UseVisualStyleBackColor = true;
            this.btn2_2.Click += new System.EventHandler(this.btn2_2_Click);
            // 
            // btn2_1
            // 
            this.btn2_1.Location = new System.Drawing.Point(13, 91);
            this.btn2_1.Name = "btn2_1";
            this.btn2_1.Size = new System.Drawing.Size(80, 80);
            this.btn2_1.TabIndex = 3;
            this.btn2_1.Text = " ";
            this.btn2_1.UseVisualStyleBackColor = true;
            this.btn2_1.Click += new System.EventHandler(this.btn2_1_Click);
            // 
            // btn1_3
            // 
            this.btn1_3.Location = new System.Drawing.Point(192, 3);
            this.btn1_3.Name = "btn1_3";
            this.btn1_3.Size = new System.Drawing.Size(80, 80);
            this.btn1_3.TabIndex = 2;
            this.btn1_3.Text = " ";
            this.btn1_3.UseVisualStyleBackColor = true;
            this.btn1_3.Click += new System.EventHandler(this.btn1_3_Click);
            // 
            // btn1_2
            // 
            this.btn1_2.Location = new System.Drawing.Point(99, 3);
            this.btn1_2.Name = "btn1_2";
            this.btn1_2.Size = new System.Drawing.Size(80, 80);
            this.btn1_2.TabIndex = 1;
            this.btn1_2.Text = " ";
            this.btn1_2.UseVisualStyleBackColor = true;
            this.btn1_2.Click += new System.EventHandler(this.btn1_2_Click);
            // 
            // btn1_1
            // 
            this.btn1_1.AccessibleName = "btn1_1";
            this.btn1_1.Location = new System.Drawing.Point(13, 3);
            this.btn1_1.Name = "btn1_1";
            this.btn1_1.Size = new System.Drawing.Size(80, 80);
            this.btn1_1.TabIndex = 0;
            this.btn1_1.Text = " ";
            this.btn1_1.UseVisualStyleBackColor = true;
            this.btn1_1.Click += new System.EventHandler(this.btn1_1_Click);
            // 
            // ProgressLabel
            // 
            this.ProgressLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ProgressLabel.Font = new System.Drawing.Font("Times New Roman", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ProgressLabel.Location = new System.Drawing.Point(225, 362);
            this.ProgressLabel.Name = "ProgressLabel";
            this.ProgressLabel.Size = new System.Drawing.Size(272, 65);
            this.ProgressLabel.TabIndex = 2;
            this.ProgressLabel.Text = "Start the game :)";
            this.ProgressLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // XwinLabel
            // 
            this.XwinLabel.Location = new System.Drawing.Point(560, 124);
            this.XwinLabel.Name = "XwinLabel";
            this.XwinLabel.Size = new System.Drawing.Size(138, 40);
            this.XwinLabel.TabIndex = 3;
            this.XwinLabel.Text = "X wins = ";
            // 
            // OwinLabel
            // 
            this.OwinLabel.Location = new System.Drawing.Point(560, 172);
            this.OwinLabel.Name = "OwinLabel";
            this.OwinLabel.Size = new System.Drawing.Size(138, 40);
            this.OwinLabel.TabIndex = 4;
            this.OwinLabel.Text = "O wins = ";
            // 
            // DrawLabel
            // 
            this.DrawLabel.Location = new System.Drawing.Point(560, 297);
            this.DrawLabel.Name = "DrawLabel";
            this.DrawLabel.Size = new System.Drawing.Size(138, 40);
            this.DrawLabel.TabIndex = 5;
            this.DrawLabel.Text = "Draws = ";
            // 
            // SaveFile
            // 
            this.SaveFile.Location = new System.Drawing.Point(563, 314);
            this.SaveFile.Name = "SaveFile";
            this.SaveFile.Size = new System.Drawing.Size(125, 29);
            this.SaveFile.TabIndex = 6;
            this.SaveFile.Text = "Save to file";
            this.SaveFile.UseVisualStyleBackColor = true;
            this.SaveFile.Click += new System.EventHandler(this.SaveFile_Click);
            // 
            // History
            // 
            this.History.Location = new System.Drawing.Point(563, 349);
            this.History.Name = "History";
            this.History.Size = new System.Drawing.Size(125, 31);
            this.History.TabIndex = 7;
            this.History.Text = "Show history";
            this.History.UseVisualStyleBackColor = true;
            this.History.Click += new System.EventHandler(this.History_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.History);
            this.Controls.Add(this.SaveFile);
            this.Controls.Add(this.DrawLabel);
            this.Controls.Add(this.OwinLabel);
            this.Controls.Add(this.XwinLabel);
            this.Controls.Add(this.ProgressLabel);
            this.Controls.Add(this.gameBoard);
            this.Controls.Add(this.startGameButton);
            this.Name = "Form1";
            this.Text = "Tic-Tac-Toe";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.gameBoard.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button startGameButton;
        private System.Windows.Forms.Panel gameBoard;
        private System.Windows.Forms.Button btn1_2;
        private System.Windows.Forms.Button btn1_1;
        private System.Windows.Forms.Button btn3_3;
        private System.Windows.Forms.Button btn3_2;
        private System.Windows.Forms.Button btn3_1;
        private System.Windows.Forms.Button btn2_3;
        private System.Windows.Forms.Button btn2_2;
        private System.Windows.Forms.Button btn2_1;
        private System.Windows.Forms.Button btn1_3;
        private System.Windows.Forms.Label ProgressLabel;
        private System.Windows.Forms.Label XwinLabel;
        private System.Windows.Forms.Label OwinLabel;
        private System.Windows.Forms.Label DrawLabel;
        private System.Windows.Forms.Button SaveFile;
        private System.Windows.Forms.Button History;
    }
}

