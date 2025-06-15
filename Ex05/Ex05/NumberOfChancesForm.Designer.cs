namespace Ex05
{
    partial class NumberOfChancesForm
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
            this.buttonNumberOfChances.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonNumberOfChances.BackColor = System.Drawing.Color.Transparent;
            this.buttonNumberOfChances.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.buttonNumberOfChances.Location = new System.Drawing.Point(12, 12);
            this.buttonNumberOfChances.Name = "buttonNumberOfChances";
            this.buttonNumberOfChances.Size = new System.Drawing.Size(387, 53);
            this.buttonNumberOfChances.TabIndex = 0;
            this.buttonNumberOfChances.Text = "Number of chances:";
            this.buttonNumberOfChances.UseVisualStyleBackColor = false;
            this.buttonNumberOfChances.Click += new System.EventHandler(this.buttonGetNumberOfChancesOnClick);
            // 
            // buttonStart
            // 
            this.buttonStart.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonStart.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.buttonStart.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.buttonStart.Location = new System.Drawing.Point(309, 90);
            this.buttonStart.Name = "buttonStart";
            this.buttonStart.Size = new System.Drawing.Size(90, 35);
            this.buttonStart.TabIndex = 1;
            this.buttonStart.Text = "start";
            this.buttonStart.UseVisualStyleBackColor = false;
            this.buttonStart.Click += new System.EventHandler(this.buttonStartOnClick);
            // 
            // NumberOfChancesForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(415, 139);
            this.Controls.Add(this.buttonStart);
            this.Controls.Add(this.buttonNumberOfChances);
            this.Name = "NumberOfChancesForm";
            this.Text = "Get number of chances: ";
            this.Load += new System.EventHandler(this.NumberOfChancesForm_Load);
            this.Resize += new System.EventHandler(this.NumberOfChancesForm_Resize);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonNumberOfChances;
        private System.Windows.Forms.Button buttonStart;
    }
}