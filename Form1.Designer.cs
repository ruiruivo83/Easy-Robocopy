namespace EasyRobocopy
{
    partial class frmMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain));
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.btnGetDestination = new System.Windows.Forms.Button();
            this.txtBoxSource = new System.Windows.Forms.TextBox();
            this.btnGetSource = new System.Windows.Forms.Button();
            this.btnExecuteCommand = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.txtBoxDestination = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Maroon;
            this.label3.Location = new System.Drawing.Point(93, 65);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(438, 32);
            this.label3.TabIndex = 17;
            this.label3.Text = "Attention ce mode vous supprimera tout fichier existant dans le répertoire Destin" +
    "ation. TOUJOURS utiliser des dossier de destination vide.";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(5, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(79, 13);
            this.label1.TabIndex = 11;
            this.label1.Text = "Dossier Source";
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Checked = true;
            this.checkBox1.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBox1.Enabled = false;
            this.checkBox1.Location = new System.Drawing.Point(8, 64);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(84, 17);
            this.checkBox1.TabIndex = 16;
            this.checkBox1.Text = "Copie Mirroir";
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // btnGetDestination
            // 
            this.btnGetDestination.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnGetDestination.BackgroundImage")));
            this.btnGetDestination.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnGetDestination.Location = new System.Drawing.Point(506, 36);
            this.btnGetDestination.Name = "btnGetDestination";
            this.btnGetDestination.Size = new System.Drawing.Size(25, 23);
            this.btnGetDestination.TabIndex = 14;
            this.btnGetDestination.UseVisualStyleBackColor = true;
            this.btnGetDestination.Click += new System.EventHandler(this.btnGetDestination_Click);
            // 
            // txtBoxSource
            // 
            this.txtBoxSource.Location = new System.Drawing.Point(109, 12);
            this.txtBoxSource.Name = "txtBoxSource";
            this.txtBoxSource.Size = new System.Drawing.Size(391, 20);
            this.txtBoxSource.TabIndex = 9;
            // 
            // btnGetSource
            // 
            this.btnGetSource.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnGetSource.BackgroundImage")));
            this.btnGetSource.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnGetSource.Location = new System.Drawing.Point(506, 10);
            this.btnGetSource.Name = "btnGetSource";
            this.btnGetSource.Size = new System.Drawing.Size(25, 23);
            this.btnGetSource.TabIndex = 13;
            this.btnGetSource.UseVisualStyleBackColor = true;
            this.btnGetSource.Click += new System.EventHandler(this.btnGetSource_Click);
            // 
            // btnExecuteCommand
            // 
            this.btnExecuteCommand.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnExecuteCommand.Location = new System.Drawing.Point(403, 118);
            this.btnExecuteCommand.Name = "btnExecuteCommand";
            this.btnExecuteCommand.Size = new System.Drawing.Size(128, 23);
            this.btnExecuteCommand.TabIndex = 15;
            this.btnExecuteCommand.Text = "EXECUTE COMMAND";
            this.btnExecuteCommand.UseVisualStyleBackColor = true;
            this.btnExecuteCommand.Click += new System.EventHandler(this.btnExecuteCommand_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(5, 41);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(98, 13);
            this.label2.TabIndex = 12;
            this.label2.Text = "Dossier Destination";
            // 
            // txtBoxDestination
            // 
            this.txtBoxDestination.Location = new System.Drawing.Point(109, 38);
            this.txtBoxDestination.Name = "txtBoxDestination";
            this.txtBoxDestination.Size = new System.Drawing.Size(391, 20);
            this.txtBoxDestination.TabIndex = 10;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 131);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(54, 13);
            this.label4.TabIndex = 18;
            this.label4.Text = "Rui Ruivo";
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(535, 153);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.btnGetDestination);
            this.Controls.Add(this.txtBoxSource);
            this.Controls.Add(this.btnGetSource);
            this.Controls.Add(this.btnExecuteCommand);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtBoxDestination);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmMain";
            this.Text = "Easy ROBOCOPY V1";
            this.Load += new System.EventHandler(this.frmMain_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.Button btnGetDestination;
        private System.Windows.Forms.TextBox txtBoxSource;
        private System.Windows.Forms.Button btnGetSource;
        private System.Windows.Forms.Button btnExecuteCommand;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtBoxDestination;
        private System.Windows.Forms.Label label4;
    }
}

