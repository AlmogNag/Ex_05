namespace Ex05
{
    partial class NumberOfCancesForm
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
            this.buttonNumberOfChances = new System.Windows.Forms.Button();
            this.buttonStart = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // buttonNumberOfChances
            // 
            this.buttonNumberOfChances.BackColor = System.Drawing.Color.Transparent;
            this.buttonNumberOfChances.Location = new System.Drawing.Point(12, 27);
            this.buttonNumberOfChances.Name = "buttonNumberOfChances";
            this.buttonNumberOfChances.Size = new System.Drawing.Size(284, 23);
            this.buttonNumberOfChances.TabIndex = 0;
            this.buttonNumberOfChances.Text = "Number of chances:";
            this.buttonNumberOfChances.UseVisualStyleBackColor = false;
            this.buttonNumberOfChances.Click += new System.EventHandler(this.buttonGetNumberOfChancesOnClick);
            // 
            // buttonStart
            // 
            this.buttonStart.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.buttonStart.Location = new System.Drawing.Point(221, 102);
            this.buttonStart.Name = "buttonStart";
            this.buttonStart.Size = new System.Drawing.Size(75, 23);
            this.buttonStart.TabIndex = 1;
            this.buttonStart.Text = "start";
            this.buttonStart.UseVisualStyleBackColor = false;
            this.buttonStart.Click += new System.EventHandler(this.buttonStartOnClick);
            // 
            // NumberOfCancesForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(312, 139);
            this.Controls.Add(this.buttonStart);
            this.Controls.Add(this.buttonNumberOfChances);
            this.Enabled = false;
            this.Name = "NumberOfCancesForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Get number of chances: ";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonNumberOfChances;
        private System.Windows.Forms.Button buttonStart;
    }
}