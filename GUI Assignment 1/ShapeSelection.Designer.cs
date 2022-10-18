namespace GUI_Assignment_1
{
    partial class SelectShape
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.buttonSquare = new System.Windows.Forms.Button();
            this.buttonTriangle = new System.Windows.Forms.Button();
            this.buttonCircleOrSphere = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // buttonSquare
            // 
            this.buttonSquare.BackColor = System.Drawing.Color.Transparent;
            this.buttonSquare.FlatAppearance.BorderSize = 0;
            this.buttonSquare.Location = new System.Drawing.Point(169, 137);
            this.buttonSquare.Name = "buttonSquare";
            this.buttonSquare.Size = new System.Drawing.Size(116, 116);
            this.buttonSquare.TabIndex = 1;
            this.buttonSquare.Text = "Square Solver";
            this.buttonSquare.UseVisualStyleBackColor = false;
            this.buttonSquare.Click += new System.EventHandler(this.buttonSquare_Click);
            // 
            // buttonTriangle
            // 
            this.buttonTriangle.BackColor = System.Drawing.Color.Transparent;
            this.buttonTriangle.FlatAppearance.BorderSize = 0;
            this.buttonTriangle.Location = new System.Drawing.Point(287, 137);
            this.buttonTriangle.Name = "buttonTriangle";
            this.buttonTriangle.Size = new System.Drawing.Size(116, 116);
            this.buttonTriangle.TabIndex = 2;
            this.buttonTriangle.Text = "Triangle Solver";
            this.buttonTriangle.UseVisualStyleBackColor = false;
            this.buttonTriangle.Click += new System.EventHandler(this.buttonTriangle_Click);
            // 
            // buttonCircleOrSphere
            // 
            this.buttonCircleOrSphere.BackColor = System.Drawing.Color.Transparent;
            this.buttonCircleOrSphere.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.buttonCircleOrSphere.FlatAppearance.BorderSize = 0;
            this.buttonCircleOrSphere.Location = new System.Drawing.Point(405, 137);
            this.buttonCircleOrSphere.Name = "buttonCircleOrSphere";
            this.buttonCircleOrSphere.Size = new System.Drawing.Size(116, 116);
            this.buttonCircleOrSphere.TabIndex = 3;
            this.buttonCircleOrSphere.Text = "Radius Solver";
            this.buttonCircleOrSphere.UseVisualStyleBackColor = false;
            this.buttonCircleOrSphere.Click += new System.EventHandler(this.buttonCircleOrSphere_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(273, 113);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(154, 15);
            this.label1.TabIndex = 4;
            this.label1.Text = "Please select a shape below:";
            // 
            // SelectShape
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(684, 361);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buttonCircleOrSphere);
            this.Controls.Add(this.buttonTriangle);
            this.Controls.Add(this.buttonSquare);
            this.Name = "SelectShape";
            this.Text = "Aaron Whitaker GUI Assignment 1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonSquare;
        private System.Windows.Forms.Button buttonTriangle;
        private System.Windows.Forms.Button buttonCircleOrSphere;
        private System.Windows.Forms.Label label1;
    }
}
