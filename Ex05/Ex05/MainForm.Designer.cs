namespace Ex05
{
    partial class MainForm
    {
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanelTopRow;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanelGuessRows;

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
            this.flowLayoutPanelTopRow = new System.Windows.Forms.FlowLayoutPanel();
            this.flowLayoutPanelGuessRows = new System.Windows.Forms.FlowLayoutPanel();
            this.SuspendLayout();
            // 
            // flowLayoutPanelTopRow
            // 
            this.flowLayoutPanelTopRow.AutoSize = true;
            this.flowLayoutPanelTopRow.Dock = System.Windows.Forms.DockStyle.Top;
            this.flowLayoutPanelTopRow.Location = new System.Drawing.Point(0, 0);
            this.flowLayoutPanelTopRow.Name = "flowLayoutPanelTopRow";
            this.flowLayoutPanelTopRow.Size = new System.Drawing.Size(422, 0);
            this.flowLayoutPanelTopRow.TabIndex = 0;
            // 
            // flowLayoutPanelGuessRows
            // 
            this.flowLayoutPanelGuessRows.AutoScroll = true;
            this.flowLayoutPanelGuessRows.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanelGuessRows.Location = new System.Drawing.Point(0, 0);
            this.flowLayoutPanelGuessRows.Name = "flowLayoutPanelGuessRows";
            this.flowLayoutPanelGuessRows.Size = new System.Drawing.Size(422, 524);
            this.flowLayoutPanelGuessRows.TabIndex = 1;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(422, 524);
            this.Controls.Add(this.flowLayoutPanelGuessRows);
            this.Controls.Add(this.flowLayoutPanelTopRow);
            this.Name = "MainForm";
            this.Text = "MainForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
    }
}
