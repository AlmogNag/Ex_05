namespace Ex05
{
    partial class ColorPickerForm
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
            this.buttonBlue = new System.Windows.Forms.Button();
            this.buttonYellow = new System.Windows.Forms.Button();
            this.buttonRed = new System.Windows.Forms.Button();
            this.buttonGreen = new System.Windows.Forms.Button();
            this.buttonFuchsia = new System.Windows.Forms.Button();
            this.buttonOrange = new System.Windows.Forms.Button();
            this.buttonCyan = new System.Windows.Forms.Button();
            this.buttonPurple = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // buttonBlue
            // 
            this.buttonBlue.BackColor = System.Drawing.Color.Blue;
            this.buttonBlue.Location = new System.Drawing.Point(12, 12);
            this.buttonBlue.Name = "buttonBlue";
            this.buttonBlue.Size = new System.Drawing.Size(51, 50);
            this.buttonBlue.TabIndex = 0;
            this.buttonBlue.UseVisualStyleBackColor = false;
            this.buttonBlue.Click += new System.EventHandler(this.buttonBlue_Click);
            // 
            // buttonYellow
            // 
            this.buttonYellow.BackColor = System.Drawing.Color.Yellow;
            this.buttonYellow.Location = new System.Drawing.Point(147, 12);
            this.buttonYellow.Name = "buttonYellow";
            this.buttonYellow.Size = new System.Drawing.Size(49, 50);
            this.buttonYellow.TabIndex = 1;
            this.buttonYellow.UseVisualStyleBackColor = false;
            this.buttonYellow.Click += new System.EventHandler(this.buttonYellow_Click);
            // 
            // buttonRed
            // 
            this.buttonRed.BackColor = System.Drawing.Color.Red;
            this.buttonRed.Location = new System.Drawing.Point(79, 12);
            this.buttonRed.Name = "buttonRed";
            this.buttonRed.Size = new System.Drawing.Size(51, 50);
            this.buttonRed.TabIndex = 2;
            this.buttonRed.UseVisualStyleBackColor = false;
            this.buttonRed.Click += new System.EventHandler(this.buttonRed_Click);
            // 
            // buttonGreen
            // 
            this.buttonGreen.BackColor = System.Drawing.Color.Green;
            this.buttonGreen.Location = new System.Drawing.Point(211, 12);
            this.buttonGreen.Name = "buttonGreen";
            this.buttonGreen.Size = new System.Drawing.Size(51, 50);
            this.buttonGreen.TabIndex = 3;
            this.buttonGreen.UseVisualStyleBackColor = false;
            this.buttonGreen.Click += new System.EventHandler(this.buttonGreen_Click);
            // 
            // buttonFuchsia
            // 
            this.buttonFuchsia.BackColor = System.Drawing.Color.Fuchsia;
            this.buttonFuchsia.Location = new System.Drawing.Point(211, 68);
            this.buttonFuchsia.Name = "buttonFuchsia";
            this.buttonFuchsia.Size = new System.Drawing.Size(51, 50);
            this.buttonFuchsia.TabIndex = 7;
            this.buttonFuchsia.UseVisualStyleBackColor = false;
            this.buttonFuchsia.Click += new System.EventHandler(this.buttonFuchsia_Click);
            // 
            // buttonOrange
            // 
            this.buttonOrange.BackColor = System.Drawing.Color.Orange;
            this.buttonOrange.Location = new System.Drawing.Point(79, 68);
            this.buttonOrange.Name = "buttonOrange";
            this.buttonOrange.Size = new System.Drawing.Size(51, 50);
            this.buttonOrange.TabIndex = 6;
            this.buttonOrange.UseVisualStyleBackColor = false;
            this.buttonOrange.Click += new System.EventHandler(this.buttonOrange_Click);
            // 
            // buttonCyan
            // 
            this.buttonCyan.BackColor = System.Drawing.Color.Cyan;
            this.buttonCyan.Location = new System.Drawing.Point(147, 68);
            this.buttonCyan.Name = "buttonCyan";
            this.buttonCyan.Size = new System.Drawing.Size(49, 50);
            this.buttonCyan.TabIndex = 5;
            this.buttonCyan.UseVisualStyleBackColor = false;
            this.buttonCyan.Click += new System.EventHandler(this.buttonCyan_Click);
            // 
            // buttonPurple
            // 
            this.buttonPurple.BackColor = System.Drawing.Color.Purple;
            this.buttonPurple.Location = new System.Drawing.Point(12, 68);
            this.buttonPurple.Name = "buttonPurple";
            this.buttonPurple.Size = new System.Drawing.Size(51, 50);
            this.buttonPurple.TabIndex = 4;
            this.buttonPurple.UseVisualStyleBackColor = false;
            this.buttonPurple.Click += new System.EventHandler(this.buttonPurple_Click);
            // 
            // ColorPickerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(274, 130);
            this.Controls.Add(this.buttonFuchsia);
            this.Controls.Add(this.buttonOrange);
            this.Controls.Add(this.buttonCyan);
            this.Controls.Add(this.buttonPurple);
            this.Controls.Add(this.buttonGreen);
            this.Controls.Add(this.buttonRed);
            this.Controls.Add(this.buttonYellow);
            this.Controls.Add(this.buttonBlue);
            this.Name = "ColorPickerForm";
            this.Text = "ColorPickerForm";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonBlue;
        private System.Windows.Forms.Button buttonYellow;
        private System.Windows.Forms.Button buttonRed;
        private System.Windows.Forms.Button buttonGreen;
        private System.Windows.Forms.Button buttonFuchsia;
        private System.Windows.Forms.Button buttonOrange;
        private System.Windows.Forms.Button buttonCyan;
        private System.Windows.Forms.Button buttonPurple;
    }
}