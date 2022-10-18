namespace GUI_Assignment_1
{
    partial class SquareSolver
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
            this.textBoxSquareSide = new System.Windows.Forms.TextBox();
            this.buttonSubmitSquare = new System.Windows.Forms.Button();
            this.pictureBoxSquareArea = new System.Windows.Forms.PictureBox();
            this.labelSquareSide = new System.Windows.Forms.Label();
            this.textBoxArea = new System.Windows.Forms.TextBox();
            this.labelArea = new System.Windows.Forms.Label();
            this.buttonSquareReset = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxSquareArea)).BeginInit();
            this.SuspendLayout();
            // 
            // textBoxSquareSide
            // 
            this.textBoxSquareSide.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textBoxSquareSide.Location = new System.Drawing.Point(332, 110);
            this.textBoxSquareSide.Name = "textBoxSquareSide";
            this.textBoxSquareSide.Size = new System.Drawing.Size(122, 29);
            this.textBoxSquareSide.TabIndex = 0;
            // 
            // buttonSubmitSquare
            // 
            this.buttonSubmitSquare.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.buttonSubmitSquare.Location = new System.Drawing.Point(268, 180);
            this.buttonSubmitSquare.Name = "buttonSubmitSquare";
            this.buttonSubmitSquare.Size = new System.Drawing.Size(90, 40);
            this.buttonSubmitSquare.TabIndex = 2;
            this.buttonSubmitSquare.Text = "Submit";
            this.buttonSubmitSquare.UseVisualStyleBackColor = true;
            this.buttonSubmitSquare.Click += new System.EventHandler(this.buttonSubmitSquare_Click);
            // 
            // pictureBoxSquareArea
            // 
            this.pictureBoxSquareArea.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.pictureBoxSquareArea.Location = new System.Drawing.Point(460, 90);
            this.pictureBoxSquareArea.Name = "pictureBoxSquareArea";
            this.pictureBoxSquareArea.Size = new System.Drawing.Size(107, 169);
            this.pictureBoxSquareArea.TabIndex = 5;
            this.pictureBoxSquareArea.TabStop = false;
            // 
            // labelSquareSide
            // 
            this.labelSquareSide.AutoSize = true;
            this.labelSquareSide.BackColor = System.Drawing.Color.Transparent;
            this.labelSquareSide.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelSquareSide.Location = new System.Drawing.Point(65, 113);
            this.labelSquareSide.Name = "labelSquareSide";
            this.labelSquareSide.Size = new System.Drawing.Size(261, 21);
            this.labelSquareSide.TabIndex = 1;
            this.labelSquareSide.Text = "Enter the length of the square\'s side:";
            // 
            // textBoxArea
            // 
            this.textBoxArea.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textBoxArea.Location = new System.Drawing.Point(332, 145);
            this.textBoxArea.Name = "textBoxArea";
            this.textBoxArea.ReadOnly = true;
            this.textBoxArea.Size = new System.Drawing.Size(122, 29);
            this.textBoxArea.TabIndex = 6;
            // 
            // labelArea
            // 
            this.labelArea.AutoSize = true;
            this.labelArea.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelArea.Location = new System.Drawing.Point(144, 148);
            this.labelArea.Name = "labelArea";
            this.labelArea.Size = new System.Drawing.Size(0, 21);
            this.labelArea.TabIndex = 3;
            this.labelArea.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // buttonSquareReset
            // 
            this.buttonSquareReset.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.buttonSquareReset.Location = new System.Drawing.Point(364, 180);
            this.buttonSquareReset.Name = "buttonSquareReset";
            this.buttonSquareReset.Size = new System.Drawing.Size(90, 40);
            this.buttonSquareReset.TabIndex = 7;
            this.buttonSquareReset.Text = "Reset";
            this.buttonSquareReset.UseVisualStyleBackColor = true;
            this.buttonSquareReset.Click += new System.EventHandler(this.buttonSquareReset_Click);
            // 
            // SquareSolver
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(684, 361);
            this.Controls.Add(this.buttonSquareReset);
            this.Controls.Add(this.textBoxArea);
            this.Controls.Add(this.labelArea);
            this.Controls.Add(this.buttonSubmitSquare);
            this.Controls.Add(this.labelSquareSide);
            this.Controls.Add(this.textBoxSquareSide);
            this.Controls.Add(this.pictureBoxSquareArea);
            this.Name = "SquareSolver";
            this.Text = "Square Solver";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxSquareArea)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxSquareSide;
        private System.Windows.Forms.Button buttonSubmitSquare;
        private System.Windows.Forms.PictureBox pictureBoxSquareArea;
        private System.Windows.Forms.Label labelSquareSide;
        private System.Windows.Forms.TextBox textBoxArea;
        private System.Windows.Forms.Label labelArea;
        private System.Windows.Forms.Button buttonSquareReset;
    }
}