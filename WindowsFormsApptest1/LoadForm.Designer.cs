namespace WindowsFormsApptest1
{
    partial class LoadForm
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
            this.chooseFile = new System.Windows.Forms.ListBox();
            this.list1 = new System.Windows.Forms.ListView();
            this.SuspendLayout();
            // 
            // chooseFile
            // 
            this.chooseFile.FormattingEnabled = true;
            this.chooseFile.Location = new System.Drawing.Point(12, 3);
            this.chooseFile.Name = "chooseFile";
            this.chooseFile.Size = new System.Drawing.Size(120, 134);
            this.chooseFile.TabIndex = 0;
            this.chooseFile.SelectedIndexChanged += new System.EventHandler(this.chooseFile_SelectedIndexChanged);
            // 
            // list1
            // 
            this.list1.AutoArrange = false;
            this.list1.FullRowSelect = true;
            this.list1.GridLines = true;
            this.list1.HideSelection = false;
            this.list1.LabelWrap = false;
            this.list1.Location = new System.Drawing.Point(157, 3);
            this.list1.Name = "list1";
            this.list1.Size = new System.Drawing.Size(331, 140);
            this.list1.TabIndex = 1;
            this.list1.UseCompatibleStateImageBehavior = false;
            this.list1.View = System.Windows.Forms.View.List;
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(546, 180);
            this.Controls.Add(this.list1);
            this.Controls.Add(this.chooseFile);
            this.Name = "Form3";
            this.Text = "Form3";
            this.Load += new System.EventHandler(this.Form3_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox chooseFile;
        private System.Windows.Forms.ListView list1;
    }
}