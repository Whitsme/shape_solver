namespace GUI_Assignment_1
{
    partial class TriangleSolver
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
            this.labelTriangleBase = new System.Windows.Forms.Label();
            this.textBoxTriBase = new System.Windows.Forms.TextBox();
            this.labelTriangleHeight = new System.Windows.Forms.Label();
            this.textBoxTriHeight = new System.Windows.Forms.TextBox();
            this.buttonTriangleReset = new System.Windows.Forms.Button();
            this.textTriangleArea = new System.Windows.Forms.TextBox();
            this.labelTriangleArea = new System.Windows.Forms.Label();
            this.buttonSubmitTriangle = new System.Windows.Forms.Button();
            this.pictureBoxTriangleArea = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxTriangleArea)).BeginInit();
            this.SuspendLayout();
            // 
            // labelTriangleBase
            // 
            this.labelTriangleBase.AutoSize = true;
            this.labelTriangleBase.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelTriangleBase.Location = new System.Drawing.Point(45, 113);
            this.labelTriangleBase.Name = "labelTriangleBase";
            this.labelTriangleBase.Size = new System.Drawing.Size(271, 21);
            this.labelTriangleBase.TabIndex = 4;
            this.labelTriangleBase.Text = "Enter the length of the triangle\'s base:";
            // 
            // textBoxTriBase
            // 
            this.textBoxTriBase.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textBoxTriBase.Location = new System.Drawing.Point(322, 110);
            this.textBoxTriBase.Name = "textBoxTriBase";
            this.textBoxTriBase.Size = new System.Drawing.Size(132, 29);
            this.textBoxTriBase.TabIndex = 3;
            // 
            // labelTriangleHeight
            // 
            this.labelTriangleHeight.AutoSize = true;
            this.labelTriangleHeight.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelTriangleHeight.Location = new System.Drawing.Point(50, 148);
            this.labelTriangleHeight.Name = "labelTriangleHeight";
            this.labelTriangleHeight.Size = new System.Drawing.Size(267, 21);
            this.labelTriangleHeight.TabIndex = 7;
            this.labelTriangleHeight.Text = "                   Enter the triangle\'s height:";
            // 
            // textBoxTriHeight
            // 
            this.textBoxTriHeight.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textBoxTriHeight.Location = new System.Drawing.Point(322, 145);
            this.textBoxTriHeight.Name = "textBoxTriHeight";
            this.textBoxTriHeight.Size = new System.Drawing.Size(132, 29);
            this.textBoxTriHeight.TabIndex = 6;
            // 
            // buttonTriangleReset
            // 
            this.buttonTriangleReset.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.buttonTriangleReset.Location = new System.Drawing.Point(364, 215);
            this.buttonTriangleReset.Name = "buttonTriangleReset";
            this.buttonTriangleReset.Size = new System.Drawing.Size(90, 40);
            this.buttonTriangleReset.TabIndex = 12;
            this.buttonTriangleReset.Text = "Reset";
            this.buttonTriangleReset.UseVisualStyleBackColor = true;
            this.buttonTriangleReset.Click += new System.EventHandler(this.buttonTriangleReset_Click);
            // 
            // textTriangleArea
            // 
            this.textTriangleArea.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textTriangleArea.Location = new System.Drawing.Point(332, 180);
            this.textTriangleArea.Name = "textTriangleArea";
            this.textTriangleArea.ReadOnly = true;
            this.textTriangleArea.Size = new System.Drawing.Size(122, 29);
            this.textTriangleArea.TabIndex = 11;
            // 
            // labelTriangleArea
            // 
            this.labelTriangleArea.AutoSize = true;
            this.labelTriangleArea.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelTriangleArea.Location = new System.Drawing.Point(144, 184);
            this.labelTriangleArea.Name = "labelTriangleArea";
            this.labelTriangleArea.Size = new System.Drawing.Size(0, 21);
            this.labelTriangleArea.TabIndex = 9;
            this.labelTriangleArea.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // buttonSubmitTriangle
            // 
            this.buttonSubmitTriangle.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.buttonSubmitTriangle.Location = new System.Drawing.Point(268, 215);
            this.buttonSubmitTriangle.Name = "buttonSubmitTriangle";
            this.buttonSubmitTriangle.Size = new System.Drawing.Size(90, 40);
            this.buttonSubmitTriangle.TabIndex = 8;
            this.buttonSubmitTriangle.Text = "Submit";
            this.buttonSubmitTriangle.UseVisualStyleBackColor = true;
            this.buttonSubmitTriangle.Click += new System.EventHandler(this.buttonSubmitTriangle_Click);
            // 
            // pictureBoxTriangleArea
            // 
            this.pictureBoxTriangleArea.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.pictureBoxTriangleArea.Location = new System.Drawing.Point(460, 90);
            this.pictureBoxTriangleArea.Name = "pictureBoxTriangleArea";
            this.pictureBoxTriangleArea.Size = new System.Drawing.Size(107, 169);
            this.pictureBoxTriangleArea.TabIndex = 10;
            this.pictureBoxTriangleArea.TabStop = false;
            // 
            // TriangleSolver
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(684, 361);
            this.Controls.Add(this.buttonTriangleReset);
            this.Controls.Add(this.textTriangleArea);
            this.Controls.Add(this.labelTriangleArea);
            this.Controls.Add(this.buttonSubmitTriangle);
            this.Controls.Add(this.pictureBoxTriangleArea);
            this.Controls.Add(this.labelTriangleHeight);
            this.Controls.Add(this.textBoxTriHeight);
            this.Controls.Add(this.labelTriangleBase);
            this.Controls.Add(this.textBoxTriBase);
            this.Name = "TriangleSolver";
            this.Text = "Triangle Solver";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxTriangleArea)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label labelTriangleBase;
        private System.Windows.Forms.TextBox textBoxTriBase;
        private System.Windows.Forms.Label labelTriangleHeight;
        private System.Windows.Forms.TextBox textBoxTriHeight;
        private System.Windows.Forms.Button buttonTriangleReset;
        private System.Windows.Forms.TextBox textTriangleArea;
        private System.Windows.Forms.Label labelTriangleArea;
        private System.Windows.Forms.Button buttonSubmitTriangle;
        private System.Windows.Forms.PictureBox pictureBoxTriangleArea;
    }
}